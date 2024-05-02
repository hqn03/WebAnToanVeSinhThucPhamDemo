﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json.Serialization;
using WebAnToanVeSinhThucPhamDemo.Models;

namespace WebAnToanVeSinhThucPhamDemo.Controllers
{
    public class BaoCaoViPhamController : Controller
    {
        private readonly QlattpContext _context;
        private readonly IWebHostEnvironment _webHost;

        private int _currentPage = 1;
        private int _maxRowPerPage = 6;
        private int _totalPage = 0;
        private Models.ViolationReportViewModel _viewModel = new Models.ViolationReportViewModel();

        public BaoCaoViPhamController(QlattpContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
        }

        public ActionResult Index()
        {
            return View(GetViewModel(""));
        }

        [HttpGet]
        public JsonResult Search(int page = 1, string value = "")
        {
            Log("Seach");
            _currentPage = page;
            Log("" + _currentPage);
            return Json(GetViewModel(value));
        }
        //public ActionResult Search(int page = 1, string value = "")
        //{
        //    //switch (pageAction)
        //    //{
        //    //    case "Next":
        //    //        _currentPage++;
        //    //        Log("Next");
        //    //        break;
        //    //    case "Back":
        //    //        _currentPage--;
        //    //        Log("Back");
        //    //        break;
        //    //}
        //    //_currentPage = Math.Clamp(_currentPage, 1, _totalPage + 1);
        //    _currentPage = page;
        //    Log("" + _currentPage);
        //    return View("Index", GetViewModel(value));
        //}

        [HttpPost]
        public ActionResult Index([Bind("HoTen,SDT,CCCD,IDCoSo")] ViolationReportViewModel baoCaoViPham, List<IFormFile> uploadFiles)
        {
            if (uploadFiles.Count == 0)
            {
                ModelState.AddModelError("uploadFiles", "Chọn hình ảnh minh chứng");
            }

            if (!ModelState.IsValid)
            {
                //var Errors = ModelState.Keys.Where(i => ModelState[i].Errors.Count > 0).Select(k => new KeyValuePair<string, string>(k, ModelState[k].Errors.First().ErrorMessage));
                //foreach (var item in Errors)
                //{
                //    Log(item.Value);
                //}
                TempData["AlertMessage"] = "Lỗi";
                return View(GetViewModel(""));
            }

            Models.ViolationReportViewModel viewModel = new Models.ViolationReportViewModel();
            int imageCount = 0;
            for (int i = 0; i < uploadFiles.Count; i++)
            {
                var file = uploadFiles[i];
                baoCaoViPham.HinhAnhMinhChung += imageCount != 0 ? "," + file.FileName : file.FileName;
                imageCount++;
            }

            Log($"{baoCaoViPham.HoTen} | {baoCaoViPham.SDT} | {baoCaoViPham.CCCD} | {baoCaoViPham.HinhAnhMinhChung} | {baoCaoViPham.IDCoSo}");

            var hoTenParam = new SqlParameter("@HoTen", baoCaoViPham.HoTen);
            var sdtParam = new SqlParameter("@SDT", baoCaoViPham.SDT);
            var cccdParam = new SqlParameter("@CCCD", baoCaoViPham.CCCD);
            var ngayBaoCaoParam = new SqlParameter("@NgayBaoCao", DateTime.Now);
            var hinhAnhMinhChungParam = new SqlParameter("@HinhAnhMinhChung", baoCaoViPham.HinhAnhMinhChung);
            var idCoSoParam = new SqlParameter("@IDCoSo", baoCaoViPham.IDCoSo);
            var newIdParam = new SqlParameter
            {
                ParameterName = "@NewId",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            _context.Database.ExecuteSqlRaw("Execute pr_TaoBaoCaoViPham @HoTen, @SDT, @CCCD, @NgayBaoCao, @HinhAnhMinhChung, @IDCoSo, @NewId out",
                                    hoTenParam, sdtParam, cccdParam, ngayBaoCaoParam, hinhAnhMinhChungParam, idCoSoParam, newIdParam);

            int id = (int)newIdParam.Value;
            string uploadFolder = Path.Combine(_webHost.WebRootPath, "BaoCaoViPham", id.ToString());
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
            foreach (IFormFile file in uploadFiles)
            {
                SaveImage(file, uploadFolder);
            }

            TempData["AlertMessage"] = "Gửi thành công";
            return RedirectToAction("Index");
        }

        private ViolationReportViewModel GetViewModel(string searchValue, bool isSearching = true)
        {
            if (isSearching)
            {
                _viewModel.CoSoes = _context.CoSos.ToList();

                if (!searchValue.ToLower().Equals(""))
                {
                    _viewModel.CoSoes = _viewModel.CoSoes.Where(s => s.TenCoSo.ToLower().Contains(searchValue.ToLower())).ToList();
                }

                _totalPage = _viewModel.CoSoes.Count;
            }

            _viewModel.CoSoes = _viewModel.CoSoes.OrderBy(c => c.IdchuCoSo).Skip((_currentPage - 1) * _maxRowPerPage).Take(_maxRowPerPage).ToList();
            _viewModel.CurrentPage = _currentPage;
            _viewModel.TotalPage = ((_totalPage - 1) / _maxRowPerPage) + 1;
            return _viewModel;
        }

        private void SaveImage(IFormFile file, string path)
        {
            string fileName = Path.GetFileName(file.FileName);
            string fileSavePath = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(fileSavePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
        }

        private void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
