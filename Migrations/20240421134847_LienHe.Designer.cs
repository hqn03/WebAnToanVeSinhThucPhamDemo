﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAnToanVeSinhThucPhamDemo.Models;

#nullable disable

namespace WebAnToanVeSinhThucPhamDemo.Migrations
{
    [DbContext(typeof(QlattpContext))]
    [Migration("20240421134847_LienHe")]
    partial class LienHe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BanCongBoSp", b =>
                {
                    b.Property<int>("IdbanCongBoSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDBanCongBoSP");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdbanCongBoSp"));

                    b.Property<string>("CachDongGoiBaoBi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CachDongGoi_BaoBi");

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("MauNhanSp")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("MauNhanSP");

                    b.Property<DateOnly?>("NgayCongBo")
                        .HasColumnType("date");

                    b.Property<string>("TenDiaChiSx")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ten_DiaChiSX");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhPhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("ThoiHanSuDung")
                        .HasColumnType("date");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdbanCongBoSp")
                        .HasName("PK__BanCongB__57824418B2AEB7B3");

                    b.HasIndex("IdcoSo");

                    b.ToTable("BanCongBoSP", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BaoCaoViPham", b =>
                {
                    b.Property<long>("IdbaoCao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("IDBaoCao");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdbaoCao"));

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<DateOnly?>("NgayBaoCao")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("SDT");

                    b.HasKey("IdbaoCao")
                        .HasName("PK__BaoCaoVi__BC216EF0A853FDD6");

                    b.HasIndex("IdcoSo");

                    b.ToTable("BaoCaoViPham", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CanBo", b =>
                {
                    b.Property<int>("IdcanBo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCanBo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdcanBo"));

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdchucVu")
                        .HasColumnType("int")
                        .HasColumnName("IDChucVu");

                    b.Property<string>("MatKhau")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("IdcanBo")
                        .HasName("PK__CanBo__D8C385AC7420D539");

                    b.HasIndex("IdchucVu");

                    b.ToTable("CanBo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietDoanThanhTra", b =>
                {
                    b.Property<int>("IdkeHoach")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    b.Property<int>("IdcanBo")
                        .HasColumnType("int")
                        .HasColumnName("IDCanBo");

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdkeHoach", "IdcanBo")
                        .HasName("PK__ChiTietD__4EE32992008214FC");

                    b.HasIndex("IdcanBo");

                    b.ToTable("ChiTietDoanThanhTra", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietKetQua", b =>
                {
                    b.Property<int>("IdkeHoachCoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoachCoSo");

                    b.Property<int>("IdmucKt")
                        .HasColumnType("int")
                        .HasColumnName("IDMucKT");

                    b.Property<bool?>("Dat")
                        .HasColumnType("bit");

                    b.HasKey("IdkeHoachCoSo", "IdmucKt")
                        .HasName("PK__ChiTietK__E62BAC593B114B18");

                    b.HasIndex("IdmucKt");

                    b.ToTable("ChiTietKetQua", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChuCoSo", b =>
                {
                    b.Property<int>("IdchuCoSo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDChuCoSo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdchuCoSo"));

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("SDT");

                    b.HasKey("IdchuCoSo")
                        .HasName("PK__ChuCoSo__00A8457314C153D6");

                    b.ToTable("ChuCoSo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChucVu", b =>
                {
                    b.Property<int>("IdchucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDChucVu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdchucVu"));

                    b.Property<string>("TenChucVu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdchucVu")
                        .HasName("PK__ChucVu__70FCCF652716418C");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.Property<int>("IdcoSo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdcoSo"));

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdchuCoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDChuCoSo");

                    b.Property<string>("LoaiHinhKinhDoanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayCapCnattp")
                        .HasColumnType("date")
                        .HasColumnName("NgayCapCNATTP");

                    b.Property<DateOnly?>("NgayCapGiayPhepKd")
                        .HasColumnType("date")
                        .HasColumnName("NgayCapGiayPhepKD");

                    b.Property<DateOnly?>("NgayHetHanCnattp")
                        .HasColumnType("date")
                        .HasColumnName("NgayHetHanCNATTP");

                    b.Property<string>("SoGiayPhepKd")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("SoGiayPhepKD");

                    b.Property<string>("TenCoSo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdcoSo")
                        .HasName("PK__CoSo__344441C5716816E6");

                    b.HasIndex("IdchuCoSo");

                    b.ToTable("CoSo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.Contact.LienHe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LienHe");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.HoSoCapGiayChungNhan", b =>
                {
                    b.Property<int>("IdgiayChungNhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDGiayChungNhan");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdgiayChungNhan"));

                    b.Property<string>("HinhAnhMinhChung")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("LoaiThucPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayDangKy")
                        .HasColumnType("date");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdgiayChungNhan")
                        .HasName("PK__HoSoCapG__729C7BB617160CD8");

                    b.HasIndex("IdcoSo");

                    b.ToTable("HoSoCapGiayChungNhan", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", b =>
                {
                    b.Property<int>("IdkeHoach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdkeHoach"));

                    b.Property<int?>("DoanSo")
                        .HasColumnType("int");

                    b.Property<string>("Loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ThoiGianBatDau")
                        .HasColumnType("datetime");

                    b.HasKey("IdkeHoach")
                        .HasName("PK__KeHoach__936F11C8A85196CC");

                    b.ToTable("KeHoach", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.Property<int>("IdkeHoachCoSo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoachCoSo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdkeHoachCoSo"));

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<int?>("IdkeHoach")
                        .HasColumnType("int")
                        .HasColumnName("IDKeHoach");

                    b.Property<string>("KetLuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhacPhuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayTao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ThoiGianKiemTra")
                        .HasColumnType("datetime");

                    b.Property<string>("YkienChuCoSo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("YKienChuCoSo");

                    b.HasKey("IdkeHoachCoSo")
                        .HasName("PK__KeHoach___146E827EF1EC716F");

                    b.HasIndex("IdcoSo");

                    b.HasIndex("IdkeHoach");

                    b.ToTable("KeHoach_CoSo", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", b =>
                {
                    b.Property<int>("IdmucKt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDMucKT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdmucKt"));

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdmucKt")
                        .HasName("PK__MucKiemT__2452E27ECB438FBA");

                    b.ToTable("MucKiemTra", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ThongBaoThayDoi", b =>
                {
                    b.Property<int>("IdthongBao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDThongBao");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdthongBao"));

                    b.Property<string>("DiaChiMoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdchuCoSoMoi")
                        .HasColumnType("int")
                        .HasColumnName("IDChuCoSoMoi");

                    b.Property<int?>("IdcoSo")
                        .HasColumnType("int")
                        .HasColumnName("IDCoSo");

                    b.Property<string>("TenCoSoMoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdthongBao")
                        .HasName("PK__ThongBao__3EBBFAAEC5198DAB");

                    b.HasIndex("IdchuCoSoMoi");

                    b.HasIndex("IdcoSo");

                    b.ToTable("ThongBaoThayDoi", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.TinTuc", b =>
                {
                    b.Property<int>("IdtinTuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDTinTuc");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdtinTuc"));

                    b.Property<int?>("IdcanBo")
                        .HasColumnType("int")
                        .HasColumnName("IDCanBo");

                    b.Property<DateOnly?>("NgayDang")
                        .HasColumnType("date");

                    b.Property<string>("NoiDung")
                        .HasColumnType("text");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdtinTuc")
                        .HasName("PK__TinTuc__74C0F8F80B49A437");

                    b.HasIndex("IdcanBo");

                    b.ToTable("TinTuc", (string)null);
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BanCongBoSp", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("BanCongBoSps")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__BanCongBo__IDCoS__440B1D61");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.BaoCaoViPham", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("BaoCaoViPhams")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__BaoCaoViP__IDCoS__4AB81AF0");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CanBo", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.ChucVu", "IdchucVuNavigation")
                        .WithMany("CanBos")
                        .HasForeignKey("IdchucVu")
                        .HasConstraintName("FK__CanBo__IDChucVu__398D8EEE");

                    b.Navigation("IdchucVuNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietDoanThanhTra", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CanBo", "IdcanBoNavigation")
                        .WithMany("ChiTietDoanThanhTras")
                        .HasForeignKey("IdcanBo")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietDo__IDCan__534D60F1");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", "IdkeHoachNavigation")
                        .WithMany("ChiTietDoanThanhTras")
                        .HasForeignKey("IdkeHoach")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietDo__IDKeH__52593CB8");

                    b.Navigation("IdcanBoNavigation");

                    b.Navigation("IdkeHoachNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChiTietKetQua", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", "IdkeHoachCoSoNavigation")
                        .WithMany("ChiTietKetQuas")
                        .HasForeignKey("IdkeHoachCoSo")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietKe__IDKeH__5BE2A6F2");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", "IdmucKtNavigation")
                        .WithMany("ChiTietKetQuas")
                        .HasForeignKey("IdmucKt")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietKe__IDMuc__5CD6CB2B");

                    b.Navigation("IdkeHoachCoSoNavigation");

                    b.Navigation("IdmucKtNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.ChuCoSo", "IdchuCoSoNavigation")
                        .WithMany("CoSos")
                        .HasForeignKey("IdchuCoSo")
                        .HasConstraintName("FK__CoSo__IDChuCoSo__3E52440B");

                    b.Navigation("IdchuCoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.HoSoCapGiayChungNhan", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("HoSoCapGiayChungNhans")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__HoSoCapGi__IDCoS__412EB0B6");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("KeHoachCoSos")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__KeHoach_C__IDCoS__571DF1D5");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", "IdkeHoachNavigation")
                        .WithMany("KeHoachCoSos")
                        .HasForeignKey("IdkeHoach")
                        .HasConstraintName("FK__KeHoach_C__IDKeH__5629CD9C");

                    b.Navigation("IdcoSoNavigation");

                    b.Navigation("IdkeHoachNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ThongBaoThayDoi", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.ChuCoSo", "IdchuCoSoMoiNavigation")
                        .WithMany("ThongBaoThayDois")
                        .HasForeignKey("IdchuCoSoMoi")
                        .HasConstraintName("FK__ThongBaoT__IDChu__47DBAE45");

                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CoSo", "IdcoSoNavigation")
                        .WithMany("ThongBaoThayDois")
                        .HasForeignKey("IdcoSo")
                        .HasConstraintName("FK__ThongBaoT__IDCoS__46E78A0C");

                    b.Navigation("IdchuCoSoMoiNavigation");

                    b.Navigation("IdcoSoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.TinTuc", b =>
                {
                    b.HasOne("WebAnToanVeSinhThucPhamDemo.Models.CanBo", "IdcanBoNavigation")
                        .WithMany("TinTucs")
                        .HasForeignKey("IdcanBo")
                        .HasConstraintName("FK__TinTuc__IDCanBo__4D94879B");

                    b.Navigation("IdcanBoNavigation");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CanBo", b =>
                {
                    b.Navigation("ChiTietDoanThanhTras");

                    b.Navigation("TinTucs");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChuCoSo", b =>
                {
                    b.Navigation("CoSos");

                    b.Navigation("ThongBaoThayDois");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.ChucVu", b =>
                {
                    b.Navigation("CanBos");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.CoSo", b =>
                {
                    b.Navigation("BanCongBoSps");

                    b.Navigation("BaoCaoViPhams");

                    b.Navigation("HoSoCapGiayChungNhans");

                    b.Navigation("KeHoachCoSos");

                    b.Navigation("ThongBaoThayDois");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoach", b =>
                {
                    b.Navigation("ChiTietDoanThanhTras");

                    b.Navigation("KeHoachCoSos");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.KeHoachCoSo", b =>
                {
                    b.Navigation("ChiTietKetQuas");
                });

            modelBuilder.Entity("WebAnToanVeSinhThucPhamDemo.Models.MucKiemTra", b =>
                {
                    b.Navigation("ChiTietKetQuas");
                });
#pragma warning restore 612, 618
        }
    }
}