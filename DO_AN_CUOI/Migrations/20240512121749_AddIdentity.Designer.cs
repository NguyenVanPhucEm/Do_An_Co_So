﻿// <auto-generated />
using System;
using DO_AN_CUOI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DO_AN_CUOI.Migrations
{
    [DbContext(typeof(DoAnContext))]
    [Migration("20240512121749_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DO_AN_CUOI.Models.Danhgia", b =>
                {
                    b.Property<int>("Makh")
                        .HasColumnType("int")
                        .HasColumnName("MAKH");

                    b.Property<int>("Matour")
                        .HasColumnType("int")
                        .HasColumnName("MATOUR");

                    b.Property<string>("Noidungdanhgia")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("NOIDUNGDANHGIA");

                    b.Property<int?>("Sosao")
                        .HasColumnType("int")
                        .HasColumnName("SOSAO");

                    b.Property<DateTime?>("Thoigiandanhgia")
                        .HasColumnType("datetime")
                        .HasColumnName("THOIGIANDANHGIA");

                    b.HasKey("Makh", "Matour");

                    b.HasIndex(new[] { "Makh" }, "ASSOCIATION_16_FK");

                    b.HasIndex(new[] { "Matour" }, "ASSOCIATION_17_FK");

                    b.ToTable("DANHGIA", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Diemden", b =>
                {
                    b.Property<int>("Madd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MADD");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Madd"));

                    b.Property<string>("Dc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DC");

                    b.Property<string>("Tendd")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENDD");

                    b.Property<string>("Thongtindiemden")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("THONGTINDIEMDEN");

                    b.HasKey("Madd");

                    b.ToTable("DIEMDEN", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Diemkhoihanh", b =>
                {
                    b.Property<int>("Madkh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MADKH");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Madkh"));

                    b.Property<string>("Dc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DC");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("SDT")
                        .IsFixedLength();

                    b.Property<string>("Tendkh")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENDKH");

                    b.HasKey("Madkh");

                    b.ToTable("DIEMKHOIHANH", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Hinhanh", b =>
                {
                    b.Property<int>("Mah")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAH");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mah"));

                    b.Property<int>("Madd")
                        .HasColumnType("int")
                        .HasColumnName("MADD");

                    b.Property<string>("UrlHa")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("URL_HA");

                    b.HasKey("Mah");

                    b.HasIndex(new[] { "Madd" }, "GHEP_FK");

                    b.ToTable("HINHANH", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khachhang", b =>
                {
                    b.Property<int>("Makh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAKH");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Makh"));

                    b.Property<string>("Dc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DC");

                    b.Property<string>("Sdt")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("SDT")
                        .IsFixedLength();

                    b.Property<int?>("Sotourdadat")
                        .HasColumnType("int")
                        .HasColumnName("SOTOURDADAT");

                    b.Property<string>("Tenkh")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENKH");

                    b.HasKey("Makh");

                    b.ToTable("KHACHHANG", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khachsan", b =>
                {
                    b.Property<int>("Maks")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAKS");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Maks"));

                    b.Property<string>("Dc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DC");

                    b.Property<string>("Tenks")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENKS");

                    b.HasKey("Maks");

                    b.ToTable("KHACHSAN", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khuyenmai", b =>
                {
                    b.Property<int>("Makm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAKM");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Makm"));

                    b.Property<string>("Dk")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DK");

                    b.Property<double?>("Phantramkm")
                        .HasColumnType("float")
                        .HasColumnName("PHANTRAMKM");

                    b.Property<string>("Tenkm")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENKM");

                    b.HasKey("Makm");

                    b.ToTable("KHUYENMAI", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Lichtrinh", b =>
                {
                    b.Property<int>("Malt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MALT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Malt"));

                    b.Property<int>("Madd")
                        .HasColumnType("int")
                        .HasColumnName("MADD");

                    b.Property<int>("Maks")
                        .HasColumnType("int")
                        .HasColumnName("MAKS");

                    b.Property<int>("Matour")
                        .HasColumnType("int")
                        .HasColumnName("MATOUR");

                    b.Property<string>("Thongtinchitiet")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("THONGTINCHITIET");

                    b.HasKey("Malt");

                    b.HasIndex(new[] { "Matour" }, "ASSOCIATION_13_FK");

                    b.HasIndex(new[] { "Madd" }, "ASSOCIATION_14_FK");

                    b.HasIndex(new[] { "Maks" }, "ASSOCIATION_15_FK");

                    b.ToTable("LICHTRINH", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Loaitour", b =>
                {
                    b.Property<int>("Maloai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MALOAI");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Maloai"));

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENLOAI");

                    b.HasKey("Maloai");

                    b.ToTable("LOAITOUR", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Nhanvien", b =>
                {
                    b.Property<int>("Manv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MANV");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Manv"));

                    b.Property<string>("Dc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DC");

                    b.Property<string>("Gioitinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("GIOITINH");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYSINH");

                    b.Property<string>("Sdt")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("SDT")
                        .IsFixedLength();

                    b.Property<string>("Tennv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENNV");

                    b.HasKey("Manv");

                    b.ToTable("NHANVIEN", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Phieudattour", b =>
                {
                    b.Property<int>("Mapdt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAPDT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mapdt"));

                    b.Property<string>("Dvt")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DVT");

                    b.Property<int>("Makh")
                        .HasColumnType("int")
                        .HasColumnName("MAKH");

                    b.Property<int>("Makm")
                        .HasColumnType("int")
                        .HasColumnName("MAKM");

                    b.Property<int>("Manv")
                        .HasColumnType("int")
                        .HasColumnName("MANV");

                    b.Property<int>("Matour")
                        .HasColumnType("int")
                        .HasColumnName("MATOUR");

                    b.Property<DateTime?>("Ngaydat")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYDAT");

                    b.Property<int?>("Song")
                        .HasColumnType("int")
                        .HasColumnName("SONG");

                    b.Property<int?>("Tongtien")
                        .HasColumnType("int")
                        .HasColumnName("TONGTIEN");

                    b.HasKey("Mapdt");

                    b.HasIndex(new[] { "Makm" }, "AP_DUNG_FK");

                    b.HasIndex(new[] { "Makh" }, "DAT_FK");

                    b.HasIndex(new[] { "Manv" }, "KY_DUYET_FK");

                    b.HasIndex(new[] { "Matour" }, "LAP_FK");

                    b.ToTable("PHIEUDATTOUR", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Phuongtiendc", b =>
                {
                    b.Property<int>("Mapt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MAPT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mapt"));

                    b.Property<string>("Tenpt")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENPT");

                    b.HasKey("Mapt");

                    b.ToTable("PHUONGTIENDC", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Tour", b =>
                {
                    b.Property<int>("Matour")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MATOUR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Matour"));

                    b.Property<string>("AnhAiien")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .HasColumnName("ANH_AIIEN")
                        .IsFixedLength();

                    b.Property<string>("Dvt")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("DVT");

                    b.Property<int?>("Gia")
                        .HasColumnType("int")
                        .HasColumnName("GIA");

                    b.Property<int>("Madkh")
                        .HasColumnType("int")
                        .HasColumnName("MADKH");

                    b.Property<int>("Maloai")
                        .HasColumnType("int")
                        .HasColumnName("MALOAI");

                    b.Property<int>("Manv")
                        .HasColumnType("int")
                        .HasColumnName("MANV");

                    b.Property<int>("Mapt")
                        .HasColumnType("int")
                        .HasColumnName("MAPT");

                    b.Property<DateTime>("Ngaykh")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYKH");

                    b.Property<DateTime?>("Ngaykt")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYKT");

                    b.Property<int?>("Sochodadat")
                        .HasColumnType("int")
                        .HasColumnName("SOCHODADAT");

                    b.Property<int?>("Sodem")
                        .HasColumnType("int")
                        .HasColumnName("SODEM");

                    b.Property<int?>("Soluongtoida")
                        .HasColumnType("int")
                        .HasColumnName("SOLUONGTOIDA");

                    b.Property<int?>("Songay")
                        .HasColumnType("int")
                        .HasColumnName("SONGAY");

                    b.Property<string>("Tentour")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TENTOUR");

                    b.HasKey("Matour");

                    b.HasIndex(new[] { "Madkh" }, "BAT_DAU_FK");

                    b.HasIndex(new[] { "Mapt" }, "DI_CHUYEN_FK");

                    b.HasIndex(new[] { "Manv" }, "HUONG_DAN_FK");

                    b.HasIndex(new[] { "Maloai" }, "THUOC_FK");

                    b.ToTable("TOUR", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Danhgia", b =>
                {
                    b.HasOne("DO_AN_CUOI.Models.Khachhang", "MakhNavigation")
                        .WithMany("Danhgia")
                        .HasForeignKey("Makh")
                        .IsRequired()
                        .HasConstraintName("FK_DANHGIA_ASSOCIATI_KHACHHAN");

                    b.HasOne("DO_AN_CUOI.Models.Tour", "MatourNavigation")
                        .WithMany("Danhgia")
                        .HasForeignKey("Matour")
                        .IsRequired()
                        .HasConstraintName("FK_DANHGIA_ASSOCIATI_TOUR");

                    b.Navigation("MakhNavigation");

                    b.Navigation("MatourNavigation");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Hinhanh", b =>
                {
                    b.HasOne("DO_AN_CUOI.Models.Diemden", "MaddNavigation")
                        .WithMany("Hinhanhs")
                        .HasForeignKey("Madd")
                        .IsRequired()
                        .HasConstraintName("FK_HINHANH_GHEP_DIEMDEN");

                    b.Navigation("MaddNavigation");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Lichtrinh", b =>
                {
                    b.HasOne("DO_AN_CUOI.Models.Diemden", "MaddNavigation")
                        .WithMany("Lichtrinhs")
                        .HasForeignKey("Madd")
                        .IsRequired()
                        .HasConstraintName("FK_LICHTRIN_ASSOCIATI_DIEMDEN");

                    b.HasOne("DO_AN_CUOI.Models.Khachsan", "MaksNavigation")
                        .WithMany("Lichtrinhs")
                        .HasForeignKey("Maks")
                        .IsRequired()
                        .HasConstraintName("FK_LICHTRIN_ASSOCIATI_KHACHSAN");

                    b.HasOne("DO_AN_CUOI.Models.Tour", "MatourNavigation")
                        .WithMany("Lichtrinhs")
                        .HasForeignKey("Matour")
                        .IsRequired()
                        .HasConstraintName("FK_LICHTRIN_ASSOCIATI_TOUR");

                    b.Navigation("MaddNavigation");

                    b.Navigation("MaksNavigation");

                    b.Navigation("MatourNavigation");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Phieudattour", b =>
                {
                    b.HasOne("DO_AN_CUOI.Models.Khachhang", "MakhNavigation")
                        .WithMany("Phieudattours")
                        .HasForeignKey("Makh")
                        .IsRequired()
                        .HasConstraintName("FK_PHIEUDAT_DAT_KHACHHAN");

                    b.HasOne("DO_AN_CUOI.Models.Khuyenmai", "MakmNavigation")
                        .WithMany("Phieudattours")
                        .HasForeignKey("Makm")
                        .IsRequired()
                        .HasConstraintName("FK_PHIEUDAT_AP_DUNG_KHUYENMA");

                    b.HasOne("DO_AN_CUOI.Models.Nhanvien", "ManvNavigation")
                        .WithMany("Phieudattours")
                        .HasForeignKey("Manv")
                        .IsRequired()
                        .HasConstraintName("FK_PHIEUDAT_KY_DUYET_NHANVIEN");

                    b.HasOne("DO_AN_CUOI.Models.Tour", "MatourNavigation")
                        .WithMany("Phieudattours")
                        .HasForeignKey("Matour")
                        .IsRequired()
                        .HasConstraintName("FK_PHIEUDAT_LAP_TOUR");

                    b.Navigation("MakhNavigation");

                    b.Navigation("MakmNavigation");

                    b.Navigation("ManvNavigation");

                    b.Navigation("MatourNavigation");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Tour", b =>
                {
                    b.HasOne("DO_AN_CUOI.Models.Diemkhoihanh", "MadkhNavigation")
                        .WithMany("Tours")
                        .HasForeignKey("Madkh")
                        .IsRequired()
                        .HasConstraintName("FK_TOUR_BAT_DAU_DIEMKHOI");

                    b.HasOne("DO_AN_CUOI.Models.Loaitour", "MaloaiNavigation")
                        .WithMany("Tours")
                        .HasForeignKey("Maloai")
                        .IsRequired()
                        .HasConstraintName("FK_TOUR_THUOC_LOAITOUR");

                    b.HasOne("DO_AN_CUOI.Models.Nhanvien", "ManvNavigation")
                        .WithMany("Tours")
                        .HasForeignKey("Manv")
                        .IsRequired()
                        .HasConstraintName("FK_TOUR_HUONG_DAN_NHANVIEN");

                    b.HasOne("DO_AN_CUOI.Models.Phuongtiendc", "MaptNavigation")
                        .WithMany("Tours")
                        .HasForeignKey("Mapt")
                        .IsRequired()
                        .HasConstraintName("FK_TOUR_DI_CHUYEN_PHUONGTI");

                    b.Navigation("MadkhNavigation");

                    b.Navigation("MaloaiNavigation");

                    b.Navigation("ManvNavigation");

                    b.Navigation("MaptNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Diemden", b =>
                {
                    b.Navigation("Hinhanhs");

                    b.Navigation("Lichtrinhs");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Diemkhoihanh", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khachhang", b =>
                {
                    b.Navigation("Danhgia");

                    b.Navigation("Phieudattours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khachsan", b =>
                {
                    b.Navigation("Lichtrinhs");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Khuyenmai", b =>
                {
                    b.Navigation("Phieudattours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Loaitour", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Nhanvien", b =>
                {
                    b.Navigation("Phieudattours");

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Phuongtiendc", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("DO_AN_CUOI.Models.Tour", b =>
                {
                    b.Navigation("Danhgia");

                    b.Navigation("Lichtrinhs");

                    b.Navigation("Phieudattours");
                });
#pragma warning restore 612, 618
        }
    }
}
