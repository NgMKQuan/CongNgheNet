USE [QuanLyBenhVien]
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BacSi](
	[MaBS] [nvarchar](50) NOT NULL,
	[TenBS] [nvarchar](200) NULL,
	[ChuyenKhoa] [nvarchar](100) NULL,
	[NgayVaoLam] [datetime] NULL,
 CONSTRAINT [PK_BacSi] PRIMARY KEY CLUSTERED 
(
	[MaBS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [nvarchar](50) NOT NULL,
	[TenBN] [nvarchar](200) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SDT] [nvarchar](50) NULL,
	[TinhTrangSK] [nvarchar](255) NULL,
	[NgayNhapVien] [datetime] NULL,
	[NgayXuatVien] [datetime] NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDonThuoc]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDonThuoc](
	[MaDT] [nvarchar](50) NOT NULL,
	[MaThuoc] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTDonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDT] [nvarchar](50) NOT NULL,
	[MaBS] [nvarchar](50) NULL,
	[MaBN] [nvarchar](50) NULL,
	[SoPhong] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_DonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaBN] [nvarchar](50) NULL,
	[MaDT] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [decimal](18, 4) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaND] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBenh]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBenh](
	[SoPhong] [nvarchar](50) NOT NULL,
	[SoGiuong] [int] NULL,
	[SoGiuongTrong] [int] NULL,
 CONSTRAINT [PK_PhongBenh] PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/16/2023 10:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [nvarchar](50) NOT NULL,
	[TenThuoc] [nvarchar](200) NULL,
	[SoLuong] [int] NULL,
	[GiaThuoc] [decimal](18, 4) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BacSi] ([MaBS], [TenBS], [ChuyenKhoa], [NgayVaoLam]) VALUES (N'BS001', N'Tuấn Trần', N'Y Học Cổ Truyền', CAST(N'2023-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[BacSi] ([MaBS], [TenBS], [ChuyenKhoa], [NgayVaoLam]) VALUES (N'BS002', N'Trọng Tấn', N'Y Học Cổ Truyền', CAST(N'2023-11-05T00:00:00.000' AS DateTime))
INSERT [dbo].[BacSi] ([MaBS], [TenBS], [ChuyenKhoa], [NgayVaoLam]) VALUES (N'BS003', N'Mai Lan', N'Lâm Sàng', CAST(N'2023-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[BacSi] ([MaBS], [TenBS], [ChuyenKhoa], [NgayVaoLam]) VALUES (N'BS004', N'Quốc Trung', N'Ngoại Khoa', CAST(N'2023-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[BacSi] ([MaBS], [TenBS], [ChuyenKhoa], [NgayVaoLam]) VALUES (N'BS005', N'Hải Tú', N'Ngoại Khoa', CAST(N'2023-11-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TinhTrangSK], [NgayNhapVien], [NgayXuatVien]) VALUES (N'BN001', N'Lan Hương', 0, CAST(N'2023-11-10T00:00:00.000' AS DateTime), N'Hà Nội', N'0979777999', N'', CAST(N'2023-11-10T00:00:00.000' AS DateTime), CAST(N'2023-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TinhTrangSK], [NgayNhapVien], [NgayXuatVien]) VALUES (N'BN002', N'Trúc Quỳnh', 0, CAST(N'2023-11-10T00:00:00.000' AS DateTime), N'HCM', N'0979777999', N'', CAST(N'2023-11-10T00:00:00.000' AS DateTime), CAST(N'2023-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TinhTrangSK], [NgayNhapVien], [NgayXuatVien]) VALUES (N'BN003', N'Trọng Đạt', 1, CAST(N'2023-11-05T00:00:00.000' AS DateTime), N'Hà Nội', N'0979777992', N'Tốt', CAST(N'2023-11-10T00:00:00.000' AS DateTime), CAST(N'2023-11-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[CTDonThuoc] ([MaDT], [MaThuoc], [SoLuong]) VALUES (N'DT001', N'T001', 2)
INSERT [dbo].[CTDonThuoc] ([MaDT], [MaThuoc], [SoLuong]) VALUES (N'DT001', N'T002', 1)
INSERT [dbo].[CTDonThuoc] ([MaDT], [MaThuoc], [SoLuong]) VALUES (N'DT002', N'T001', 2)
INSERT [dbo].[CTDonThuoc] ([MaDT], [MaThuoc], [SoLuong]) VALUES (N'DT003', N'T002', 1)
INSERT [dbo].[CTDonThuoc] ([MaDT], [MaThuoc], [SoLuong]) VALUES (N'DT003', N'T003', 1)
GO
INSERT [dbo].[DonThuoc] ([MaDT], [MaBS], [MaBN], [SoPhong], [NgayLap]) VALUES (N'DT001', N'BS001', N'BN001', N'P001', CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[DonThuoc] ([MaDT], [MaBS], [MaBN], [SoPhong], [NgayLap]) VALUES (N'DT002', N'BS001', N'BN001', N'P001', CAST(N'2023-11-15T00:00:00.000' AS DateTime))
INSERT [dbo].[DonThuoc] ([MaDT], [MaBS], [MaBN], [SoPhong], [NgayLap]) VALUES (N'DT003', N'BS002', N'BN002', N'P001', CAST(N'2023-11-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaBN], [MaDT], [NgayLap], [TongTien]) VALUES (N'HD001', N'BN001', N'DT001', CAST(N'2023-11-10T00:00:00.000' AS DateTime), CAST(350000.0000 AS Decimal(18, 4)))
GO
INSERT [dbo].[NguoiDung] ([MaND], [MatKhau], [Quyen]) VALUES (N'admin', N'123', N'ADMIN')
INSERT [dbo].[NguoiDung] ([MaND], [MatKhau], [Quyen]) VALUES (N'user', N'123', N'USER')
GO
INSERT [dbo].[PhongBenh] ([SoPhong], [SoGiuong], [SoGiuongTrong]) VALUES (N'P001', 10, 10)
INSERT [dbo].[PhongBenh] ([SoPhong], [SoGiuong], [SoGiuongTrong]) VALUES (N'P002', 10, 10)
INSERT [dbo].[PhongBenh] ([SoPhong], [SoGiuong], [SoGiuongTrong]) VALUES (N'P003', 3, 3)
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [GiaThuoc]) VALUES (N'T001', N'Giảm đau', 1, CAST(10000.0000 AS Decimal(18, 4)))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [GiaThuoc]) VALUES (N'T002', N'Sốt', 5, CAST(10000.0000 AS Decimal(18, 4)))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [GiaThuoc]) VALUES (N'T003', N'Ho', 6, CAST(10000.0000 AS Decimal(18, 4)))
GO
ALTER TABLE [dbo].[CTDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_CTDonThuoc_DonThuoc] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DonThuoc] ([MaDT])
GO
ALTER TABLE [dbo].[CTDonThuoc] CHECK CONSTRAINT [FK_CTDonThuoc_DonThuoc]
GO
ALTER TABLE [dbo].[CTDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_CTDonThuoc_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[CTDonThuoc] CHECK CONSTRAINT [FK_CTDonThuoc_Thuoc]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_BacSi] FOREIGN KEY([MaBS])
REFERENCES [dbo].[BacSi] ([MaBS])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_BacSi]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_BenhNhan]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_PhongBenh] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[PhongBenh] ([SoPhong])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_PhongBenh]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DonThuoc] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DonThuoc] ([MaDT])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DonThuoc]
GO
