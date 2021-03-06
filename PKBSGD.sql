USE [PKBSGD]
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 1/3/2021 5:22:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[MaBenhNhan] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[NamSinh] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[CMND] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CACHDUNG]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CACHDUNG](
	[MaLoaiCachDung] [nvarchar](5) NOT NULL,
	[TenLoaiCachDung] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiCachDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_DSKB]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DSKB](
	[MaCTDSKB] [nvarchar](10) NOT NULL,
	[MaDSKB] [nvarchar](10) NULL,
	[MaBenhNhan] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDSKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHSACHKHAMBENH]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHSACHKHAMBENH](
	[MaDSKB] [nvarchar](10) NOT NULL,
	[NgayKhamBenh] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDSKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONTHUOC]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONTHUOC](
	[MaDT] [nvarchar](10) NOT NULL,
	[MaPK] [nvarchar](10) NULL,
	[MaLoaiThuoc] [nvarchar](5) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaPK] [nvarchar](10) NULL,
	[TienKham] [int] NULL,
	[TienThuoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIBENH]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIBENH](
	[MaLoaiBenh] [nvarchar](5) NOT NULL,
	[TenLoaiBenh] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDONVI]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDONVI](
	[MaLoaiDonVi] [nvarchar](5) NOT NULL,
	[TenLoaiDonVi] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAITHUOC]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITHUOC](
	[MaLoaiThuoc] [nvarchar](5) NOT NULL,
	[TenLoaiThuoc] [nvarchar](30) NULL,
	[MaLoaiDonVi] [nvarchar](5) NULL,
	[MaLoaiCachDung] [nvarchar](5) NULL,
	[DonGia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUKHAM]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUKHAM](
	[MaPK] [nvarchar](10) NOT NULL,
	[MaCTDSKB] [nvarchar](10) NULL,
	[TrieuChung] [nvarchar](50) NULL,
	[MaLoaiBenh] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenTaiKhoan] [nvarchar](30) NOT NULL,
	[TenHienThi] [nvarchar](30) NULL,
	[ChucVu] [nvarchar](20) NULL,
	[Quyen] [int] NULL,
	[MatKhau] [nvarchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 1/3/2021 5:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaThamSo] [nvarchar](5) NOT NULL,
	[TenThamSo] [nvarchar](30) NULL,
	[TriGiaThamSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [SoDienThoai], [CMND]) VALUES (N'BN0000001', N'Nguyễn Văn An', N'Nam', 1999, N'Phú Yên', N'034567895', N'2215689785')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [SoDienThoai], [CMND]) VALUES (N'BN0000002', N'Nguyễn Thị Tú Minh', N'Nữ', 1998, N'Hồ Chí Minh', N'034567777', N'2215689555')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [SoDienThoai], [CMND]) VALUES (N'BN0000003', N'Tran Van Nam', N'Nam', 1970, N'Can Tho', N'0903862104', N'026011104')
GO
INSERT [dbo].[CACHDUNG] ([MaLoaiCachDung], [TenLoaiCachDung]) VALUES (N'CD01', N'1-Uống sau khi ăn')
INSERT [dbo].[CACHDUNG] ([MaLoaiCachDung], [TenLoaiCachDung]) VALUES (N'CD02', N'2-Nhai')
INSERT [dbo].[CACHDUNG] ([MaLoaiCachDung], [TenLoaiCachDung]) VALUES (N'CD03', N'3-Pha với nước')
INSERT [dbo].[CACHDUNG] ([MaLoaiCachDung], [TenLoaiCachDung]) VALUES (N'CD04', N'4-Thoa đắp ngoài da')
GO
INSERT [dbo].[CT_DSKB] ([MaCTDSKB], [MaDSKB], [MaBenhNhan]) VALUES (N'CT0000001', N'DS20190605', N'BN0000001')
INSERT [dbo].[CT_DSKB] ([MaCTDSKB], [MaDSKB], [MaBenhNhan]) VALUES (N'CT0000002', N'DS20190625', N'BN0000001')
INSERT [dbo].[CT_DSKB] ([MaCTDSKB], [MaDSKB], [MaBenhNhan]) VALUES (N'CT0000003', N'DS20190625', N'BN0000002')
INSERT [dbo].[CT_DSKB] ([MaCTDSKB], [MaDSKB], [MaBenhNhan]) VALUES (N'CT0000004', N'DS20210102', N'BN0000001')
GO
INSERT [dbo].[DANHSACHKHAMBENH] ([MaDSKB], [NgayKhamBenh]) VALUES (N'DS20190605', CAST(N'2019-06-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[DANHSACHKHAMBENH] ([MaDSKB], [NgayKhamBenh]) VALUES (N'DS20190625', CAST(N'2019-06-25T00:00:00' AS SmallDateTime))
INSERT [dbo].[DANHSACHKHAMBENH] ([MaDSKB], [NgayKhamBenh]) VALUES (N'DS20210102', CAST(N'2021-01-02T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000001', N'PK0000001', N'LT17', 5)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000002', N'PK0000001', N'LT18', 10)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000003', N'PK0000002', N'LT23', 3)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000005', N'PK0000002', N'LT18', 3)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000008', N'PK0000002', N'LT07', 3)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000009', N'PK0000003', N'LT23', 2)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000011', N'PK0000003', N'LT08', 2)
INSERT [dbo].[DONTHUOC] ([MaDT], [MaPK], [MaLoaiThuoc], [SoLuong]) VALUES (N'DT00000012', N'PK0000004', N'LT01', 1)
GO
INSERT [dbo].[HOADON] ([MaHoaDon], [MaPK], [TienKham], [TienThuoc]) VALUES (N'HD00000001', N'PK0000001', 30000, 25000)
INSERT [dbo].[HOADON] ([MaHoaDon], [MaPK], [TienKham], [TienThuoc]) VALUES (N'HD00000002', N'PK0000002', 30000, 13500)
INSERT [dbo].[HOADON] ([MaHoaDon], [MaPK], [TienKham], [TienThuoc]) VALUES (N'HD00000003', N'PK0000003', 30000, 6000)
INSERT [dbo].[HOADON] ([MaHoaDon], [MaPK], [TienKham], [TienThuoc]) VALUES (N'HD00000004', N'PK0000004', 30000, 2000)
GO
INSERT [dbo].[LOAIBENH] ([MaLoaiBenh], [TenLoaiBenh]) VALUES (N'LB01', N'Ho')
INSERT [dbo].[LOAIBENH] ([MaLoaiBenh], [TenLoaiBenh]) VALUES (N'LB02', N'Viêm họng')
INSERT [dbo].[LOAIBENH] ([MaLoaiBenh], [TenLoaiBenh]) VALUES (N'LB03', N'Cảm')
INSERT [dbo].[LOAIBENH] ([MaLoaiBenh], [TenLoaiBenh]) VALUES (N'LB04', N'Sốt')
INSERT [dbo].[LOAIBENH] ([MaLoaiBenh], [TenLoaiBenh]) VALUES (N'LB05', N'Nhức đầu')
GO
INSERT [dbo].[LOAIDONVI] ([MaLoaiDonVi], [TenLoaiDonVi]) VALUES (N'DV01', N'viên')
INSERT [dbo].[LOAIDONVI] ([MaLoaiDonVi], [TenLoaiDonVi]) VALUES (N'DV02', N'chai')
GO
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT01', N'Paracetamon', N'DV01', N'CD01', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT02', N'TataMon', N'DV01', N'CD02', 3000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT03', N'Citeron', N'DV02', N'CD01', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT04', N'Pastra', N'DV02', N'CD03', 1000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT05', N'Halothane', N'DV02', N'CD01', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT06', N'Isoflurane', N'DV01', N'CD02', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT07', N'Propofol', N'DV01', N'CD03', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT08', N'Codeine', N'DV01', N'CD01', 1000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT09', N'Fentanyl', N'DV02', N'CD03', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT10', N'Morphine', N'DV02', N'CD04', 1000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT11', N'Methadone', N'DV01', N'CD02', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT12', N'Amitriptyline', N'DV01', N'CD03', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT13', N'Cyclizine', N'DV01', N'CD02', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT14', N'Dexamethasone', N'DV02', N'CD01', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT15', N'Diazepam', N'DV02', N'CD03', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT16', N'Fluoxetine', N'DV01', N'CD03', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT17', N'Docusate sodium', N'DV02', N'CD02', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT18', N'Haloperidol', N'DV01', N'CD01', 1000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT19', N'Hyoscine butylbromide', N'DV01', N'CD03', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT20', N'Lactulose', N'DV02', N'CD01', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT21', N'Loperamide', N'DV01', N'CD03', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT22', N'Metoclopramide', N'DV02', N'CD01', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT23', N'Prednisolone', N'DV01', N'CD03', 2000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT24', N'Loratadin', N'DV02', N'CD01', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT25', N'Acetylcysteine', N'DV01', N'CD01', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT26', N'Naloxone', N'DV01', N'CD02', 1000)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT27', N'Succimer', N'DV02', N'CD01', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT28', N'Diazepam', N'DV01', N'CD02', 2500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT29', N'Midazolam', N'DV02', N'CD04', 1500)
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc], [MaLoaiDonVi], [MaLoaiCachDung], [DonGia]) VALUES (N'LT30', N'Amoxicillin', N'DV01', N'CD03', 3500)
GO
INSERT [dbo].[PHIEUKHAM] ([MaPK], [MaCTDSKB], [TrieuChung], [MaLoaiBenh]) VALUES (N'PK0000001', N'CT0000001', N'Ho dai dẳng', N'LB01')
INSERT [dbo].[PHIEUKHAM] ([MaPK], [MaCTDSKB], [TrieuChung], [MaLoaiBenh]) VALUES (N'PK0000002', N'CT0000002', N'Ho dữ dội', N'LB01')
INSERT [dbo].[PHIEUKHAM] ([MaPK], [MaCTDSKB], [TrieuChung], [MaLoaiBenh]) VALUES (N'PK0000003', N'CT0000003', N'Đau rát họng', N'LB02')
INSERT [dbo].[PHIEUKHAM] ([MaPK], [MaCTDSKB], [TrieuChung], [MaLoaiBenh]) VALUES (N'PK0000004', N'CT0000004', N'Ho', N'LB01')
GO
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [TenHienThi], [ChucVu], [Quyen], [MatKhau]) VALUES (N'admin', N'TTTL', N'Quản trị viên', 123456, N'ac0e7d037817094e9e0b4441f9bae3209d67b02fa484917065f71b16109a1a78')
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [TenHienThi], [ChucVu], [Quyen], [MatKhau]) VALUES (N'tk1', N'Nguyễn Thị Thu Hằng', N'Tiếp tân', 2, N'806421f5ee60d9cc4f8cdcc54b14ce06735cb96efe8d776ef461b92b6dc5c52c')
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [TenHienThi], [ChucVu], [Quyen], [MatKhau]) VALUES (N'tk2', N'Nguyễn Tư Bắc', N'Bác sĩ', 34, N'ffeb398ebf567c834532641d810cdf873e1f52849ed4890fc58126f5b0533b5a')
INSERT [dbo].[TAIKHOAN] ([TenTaiKhoan], [TenHienThi], [ChucVu], [Quyen], [MatKhau]) VALUES (N'tk3', N'Lê Thị Diễm', N'Thu Ngân', 56, N'5459ea3db38df4375d145c164fcd30ffd2504ab4edec9d989e10cb1cbcdbaf1e')
GO
INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [TriGiaThamSo]) VALUES (N'TS01', N'SoBenhNhanToiDa', 2)
INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [TriGiaThamSo]) VALUES (N'TS02', N'TienKham', 30000)
GO
ALTER TABLE [dbo].[CT_DSKB]  WITH CHECK ADD FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BENHNHAN] ([MaBenhNhan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_DSKB]  WITH CHECK ADD FOREIGN KEY([MaDSKB])
REFERENCES [dbo].[DANHSACHKHAMBENH] ([MaDSKB])
GO
ALTER TABLE [dbo].[DONTHUOC]  WITH CHECK ADD FOREIGN KEY([MaLoaiThuoc])
REFERENCES [dbo].[LOAITHUOC] ([MaLoaiThuoc])
GO
ALTER TABLE [dbo].[DONTHUOC]  WITH CHECK ADD FOREIGN KEY([MaPK])
REFERENCES [dbo].[PHIEUKHAM] ([MaPK])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaPK])
REFERENCES [dbo].[PHIEUKHAM] ([MaPK])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LOAITHUOC]  WITH CHECK ADD FOREIGN KEY([MaLoaiDonVi])
REFERENCES [dbo].[LOAIDONVI] ([MaLoaiDonVi])
GO
ALTER TABLE [dbo].[LOAITHUOC]  WITH CHECK ADD FOREIGN KEY([MaLoaiCachDung])
REFERENCES [dbo].[CACHDUNG] ([MaLoaiCachDung])
GO
ALTER TABLE [dbo].[PHIEUKHAM]  WITH CHECK ADD FOREIGN KEY([MaCTDSKB])
REFERENCES [dbo].[CT_DSKB] ([MaCTDSKB])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUKHAM]  WITH CHECK ADD FOREIGN KEY([MaLoaiBenh])
REFERENCES [dbo].[LOAIBENH] ([MaLoaiBenh])
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoDoanhThu]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[BaoCaoDoanhThu] --exec BaoCaoDoanhThu @thang='6', @nam='2019'
@thang int,
@nam int
as
begin
select CAST(day(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar)+'/'+CAST(month(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar)+'/'+CAST(year(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar) as Ngay,
	count(PHIEUKHAM.MaPK) as SoBenhNhan,
	sum(TienKham)+sum(TienThuoc) as DoanhThu
from CT_DSKB 
inner join PHIEUKHAM on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
inner join HOADON on HOADON.MaPK=PHIEUKHAM.MaPK
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
where Month(NgayKhamBenh)=@thang and year(NgayKhamBenh)=@nam
group by DANHSACHKHAMBENH.NgayKhamBenh
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachKhamBenh]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDanhSachKhamBenh] 
@ngayKhamBenh smalldatetime
as
begin
select BENHNHAN.MaBenhNhan,HoTen,GioiTinh,NamSinh,DiaChi, SoDienThoai,CMND 
from BENHNHAN inner join CT_DSKB on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
where DANHSACHKHAMBENH.NgayKhamBenh=@ngayKhamBenh
end
GO
/****** Object:  StoredProcedure [dbo].[GetThongTinVeThuoc]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GetThongTinVeThuoc] --exec GetThongTinVeThuoc
as
begin
select MaLoaiThuoc,TenLoaiThuoc, TenLoaiDonVi, TenLoaiCachDung, DonGia 
from LOAITHUOC inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
end
GO
/****** Object:  StoredProcedure [dbo].[KiemTraBenhNhanCoTrongDanhSach]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[KiemTraBenhNhanCoTrongDanhSach] --exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='BN0000001', @maDSKB='DS20190605'
@maBenhNhan nvarchar(10),
@maDSKB nvarchar(10)
as
begin
select MaCTDSKB from CT_DSKB
where MaBenhNhan=@maBenhNhan and MaDSKB=@maDSKB
end
GO
/****** Object:  StoredProcedure [dbo].[LayThongTinDonThuoc]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[LayThongTinDonThuoc] --exec LayThongTinDonThuoc @MaPK='PK0000002'
@MaPK nvarchar(10)
as
begin
select TenLoaiThuoc, SoLuong, TenLoaiDonVi, TenLoaiCachDung
from DONTHUOC inner join LOAITHUOC on DONTHUOC.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaPK=@MaPK
end
GO
/****** Object:  StoredProcedure [dbo].[LayThongTinHoaDon]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--drop proc LayThongTinHoaDon
create procedure [dbo].[LayThongTinHoaDon] --exec LayThongTinHoaDon @MaPK='PK0000013'
@MaPK nvarchar(10)
as
begin
select PHIEUKHAM.MaPK, BENHNHAN.MaBenhNhan, HoTen, MaHoaDon, TienKham, TienThuoc, MaDSKB
from PHIEUKHAM inner join CT_DSKB on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
inner join BENHNHAN on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join HOADON on HOADON.MaPK= PHIEUKHAM.MaPK
where PHIEUKHAM.MaPK like @MaPK
end
GO
/****** Object:  StoredProcedure [dbo].[LayThongTinTienThuoc]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[LayThongTinTienThuoc] --exec LayThongTinTienThuoc @MaPK='PK0000002'
@MaPK nvarchar(10)
as
begin
select TenLoaiThuoc, SoLuong, TenLoaiDonVi, DonGia*SoLuong as ThanhTien
from DONTHUOC inner join LOAITHUOC on DONTHUOC.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaPK=@MaPK
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSuDungThuoc]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop proc BaoCaoDoanhThu

create procedure [dbo].[ThongKeSuDungThuoc] --exec ThongKeSuDungThuoc @thang='6', @nam='2019'
@thang int,
@nam int
as
begin
select A.MaLoaiThuoc, TenLoaiThuoc, TenLoaiDonVi, A.SoLuongBan, A.SoLanDung
from
(
	select DONTHUOC.MaLoaiThuoc, sum(SoLuong) as SoLuongBan, count(DONTHUOC.MaPK) as SoLanDung
	from DONTHUOC inner join PHIEUKHAM on DONTHUOC.MaPK=PHIEUKHAM.MaPK
	inner join CT_DSKB on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
	inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
	where month(NgayKhamBenh)=@thang and year(NgayKhamBenh)=@nam
	group by DONTHUOC.MaLoaiThuoc
)A inner join LOAITHUOC on A.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
end
GO
/****** Object:  StoredProcedure [dbo].[TimBenhNhan]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[TimBenhNhan] --exec TimBenhNhan @maBN='', @hoTen='', @cmnd='', @gioiTinh='', @namSinh='1999', @sdt='', @diaChi=''
@maBN nvarchar(10), 
@hoTen nvarchar(30), 
@cmnd nvarchar(20), 
@gioiTinh nvarchar(4), 
@namSinh nvarchar(4), 
@sdt nvarchar(20), 
@diaChi nvarchar(50)
as
begin
select * from BENHNHAN 
where
MaBenhNhan like '%'+@maBN +'%' and
HoTen like '%'+@hoTen +'%' and
CMND like '%'+@cmnd +'%' and
GioiTinh like '%'+@gioiTinh +'%' and
NamSinh like '%'+@namSinh +'%' and
SoDienThoai like '%'+@sdt +'%' and
DiaChi like '%'+@diaChi +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemThuoc]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[TimKiemThuoc] --exec TimKiemThuoc @maLoaiThuoc='', @tenLoaiThuoc='', @tenLoaiDonVi='', @tenLoaiCachDung='', @donGia=''
@maLoaiThuoc nvarchar(5),
@tenLoaiThuoc nvarchar(30),
@tenLoaiDonVi nvarchar(10),
@tenLoaiCachDung nvarchar(30),
@donGia nvarchar(20)
as
begin
select MaLoaiThuoc,TenLoaiThuoc, TenLoaiDonVi, TenLoaiCachDung, DonGia 
from LOAITHUOC inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaLoaiThuoc like @maLoaiThuoc+'%' 
and TenLoaiThuoc like @tenLoaiThuoc+'%'
and TenLoaiDonVi like @tenLoaiDonVi+'%'
and TenLoaiCachDung like @tenLoaiCachDung+'%'
and DonGia like @donGia+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[TraCuuDanhSachBenhNhanKhamBenh]    Script Date: 1/3/2021 5:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--exec TraCuuDanhSachBenhNhanKhamBenh @maPK='',@maBenhNhan='', @tenBenhNhan=N'Nguyễn Thị', @MaDSKB_NgayKham='', @cmnd='', @sdt=''
--drop proc TraCuuDanhSachBenhNhanKhamBenh
create procedure [dbo].[TraCuuDanhSachBenhNhanKhamBenh] 
@maPK nvarchar(10),
@maBenhNhan nvarchar(10),
@tenBenhNhan nvarchar(30),
@MaDSKB_NgayKham nvarchar(10),
@cmnd nvarchar(20),
@sdt nvarchar(20)
as
begin
select top 50 MaPK, BENHNHAN.MaBenhNhan, HoTen,NgayKhamBenh, TenLoaiBenh, TrieuChung 
from BENHNHAN inner join CT_DSKB on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
inner join PHIEUKHAM on PHIEUKHAM.MaCTDSKB=CT_DSKB.MaCTDSKB
inner join LOAIBENH on LOAIBENH.MaLoaiBenh= PHIEUKHAM.MaLoaiBenh
where MaPK like @maPK+'%' 
and BENHNHAN.MaBenhNhan like '%'+@maBenhNhan+'%'
and HoTen like '%'+@tenBenhNhan+'%'
and CT_DSKB.MaDSKB like '%'+@MaDSKB_NgayKham+'%'
and BENHNHAN.CMND like @cmnd+'%'
and BENHNHAN.SoDienThoai like @sdt+'%'
end
GO
