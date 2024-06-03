﻿using Microsoft.AspNetCore.Mvc;
using WebAnToanVeSinhThucPhamDemo.Models.Blog;

namespace WebAnToanVeSinhThucPhamDemo.Components
{
    [ViewComponent]
    public class CategorySidebar : ViewComponent
    {
        public class CategorySidebarData
        {
            public List<DanhMuc> Categories { get; set; }
            public int level { get; set; }

            public string categoryslug { get; set; }

        }

        public IViewComponentResult Invoke(CategorySidebarData data)
        {
            return View(data);
        }

    }
}
