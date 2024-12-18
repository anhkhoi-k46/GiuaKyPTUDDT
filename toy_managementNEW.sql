USE [Toy_management]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/28/2024 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [int] NOT NULL,
	[IDDoChoi] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiamGia] [float] NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoChoi]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoChoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDoChoi] [nvarchar](1000) NOT NULL,
	[NhomMatHang] [int] NOT NULL,
	[NhaCC] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NOT NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[PhanLoai] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_DoChoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoChoiTheoNCC]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoChoiTheoNCC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaDoChoi] [int] NOT NULL,
 CONSTRAINT [PK_DoChoiTheoNCC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangDoChoi]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangDoChoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDNhaCC] [int] NOT NULL,
	[TenHang] [nvarchar](1000) NOT NULL,
	[XuatXu] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_HangDoChoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KhachHangID] [int] NOT NULL,
	[NhanVienID] [int] NOT NULL,
	[MaHang] [int] NOT NULL,
	[TongTien] [float] NOT NULL,
	[GiamGia] [float] NULL,
	[NgayLapHD] [smalldatetime] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](1000) NOT NULL,
	[SDT] [int] NULL,
	[DiaChi] [nvarchar](1000) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](1000) NOT NULL,
	[DiaChi] [nvarchar](1000) NOT NULL,
	[SDT] [nvarchar](500) NOT NULL,
	[Email] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDTaiKhoan] [int] NOT NULL,
	[HoTen] [nvarchar](1000) NOT NULL,
	[SDT] [nchar](100) NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[NgaySinh] [smalldatetime] NULL,
	[NgayVaoLam] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomMatHang]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomMatHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDDoChoi] [int] NOT NULL,
	[LoaiDoChoi] [nvarchar](1000) NOT NULL,
	[GhiChu] [nvarchar](1000) NULL,
 CONSTRAINT [PK_NhomMatHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/28/2024 3:00:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [nvarchar](1000) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[LoaiTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([ID], [IDHoaDon], [IDDoChoi], [DonGia], [SoLuong], [GiamGia], [ThanhTien]) VALUES (1, 9, 1, 199999, 1, NULL, 199999)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[DoChoi] ON 

INSERT [dbo].[DoChoi] ([ID], [TenDoChoi], [NhomMatHang], [NhaCC], [SoLuong], [Gia], [GhiChu], [PhanLoai]) VALUES (1, N'Lego', 1, 1, 10, 10000, NULL, N'1')
INSERT [dbo].[DoChoi] ([ID], [TenDoChoi], [NhomMatHang], [NhaCC], [SoLuong], [Gia], [GhiChu], [PhanLoai]) VALUES (2, N'BupBe', 2, 2, 10, 20000, NULL, N'2')
INSERT [dbo].[DoChoi] ([ID], [TenDoChoi], [NhomMatHang], [NhaCC], [SoLuong], [Gia], [GhiChu], [PhanLoai]) VALUES (5, N'test', 1, 1, 10, 199999, N'test nha may ni', N'1')
SET IDENTITY_INSERT [dbo].[DoChoi] OFF
GO
SET IDENTITY_INSERT [dbo].[HangDoChoi] ON 

INSERT [dbo].[HangDoChoi] ([ID], [IDNhaCC], [TenHang], [XuatXu]) VALUES (1, 1, N'Lego', N'TrungQuoc')
INSERT [dbo].[HangDoChoi] ([ID], [IDNhaCC], [TenHang], [XuatXu]) VALUES (2, 1, N'Lego', N'ThuySi')
INSERT [dbo].[HangDoChoi] ([ID], [IDNhaCC], [TenHang], [XuatXu]) VALUES (3, 2, N'BupBe', N'VietNam')
SET IDENTITY_INSERT [dbo].[HangDoChoi] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (9, 1, 4, 1, 199999, NULL, CAST(N'2024-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (28, 1, 4, 1, 10000, NULL, CAST(N'2024-11-28T00:50:00' AS SmallDateTime), 1)
INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (29, 1, 4, 1, 60000, NULL, CAST(N'2024-11-28T08:57:00' AS SmallDateTime), 2)
INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (30, 1, 4, 2, 60000, NULL, CAST(N'2024-11-28T08:57:00' AS SmallDateTime), 2)
INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (31, 1, 7, 1, 60000, NULL, CAST(N'2024-11-28T09:02:00' AS SmallDateTime), 4)
INSERT [dbo].[HoaDon] ([ID], [KhachHangID], [NhanVienID], [MaHang], [TongTien], [GiamGia], [NgayLapHD], [SoLuong]) VALUES (32, 1, 7, 2, 60000, NULL, CAST(N'2024-11-28T09:02:00' AS SmallDateTime), 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT], [DiaChi]) VALUES (1, N'NguyenLeMinhTri', 91111111, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT], [DiaChi]) VALUES (2, N'NhuYLe', 911202020, NULL)
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT], [DiaChi]) VALUES (3, N'HuynhTanPhat', 911717171, N'91ALacDuong')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCC] ON 

INSERT [dbo].[NhaCC] ([ID], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (1, N'MyKingDom', N'87HungVuong', N'0988121212', N'mkd@gmail.com')
INSERT [dbo].[NhaCC] ([ID], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (2, N'MeVaBe', N'81ATranPhu', N'0823111111', N'mvb@gmail.com')
INSERT [dbo].[NhaCC] ([ID], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (3, N'ConCung', N'12ADongTam', N'0911828282', N'concung@gmail.com')
INSERT [dbo].[NhaCC] ([ID], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (4, N'hehehe', N'12asdd', N'09999999', N'adl@gmail.com')
SET IDENTITY_INSERT [dbo].[NhaCC] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [IDTaiKhoan], [HoTen], [SDT], [GioiTinh], [NgaySinh], [NgayVaoLam]) VALUES (4, 1, N'NhamVinhThuy', N'0988465057                                                                                          ', 1, CAST(N'2004-06-09T00:00:00' AS SmallDateTime), CAST(N'2024-01-01T00:00:00' AS SmallDateTime))
INSERT [dbo].[NhanVien] ([ID], [IDTaiKhoan], [HoTen], [SDT], [GioiTinh], [NgaySinh], [NgayVaoLam]) VALUES (6, 2, N'HoNgocQuynhTram', N'0101010101                                                                                          ', 0, CAST(N'2004-01-12T00:00:00' AS SmallDateTime), CAST(N'2024-01-01T00:00:00' AS SmallDateTime))
INSERT [dbo].[NhanVien] ([ID], [IDTaiKhoan], [HoTen], [SDT], [GioiTinh], [NgaySinh], [NgayVaoLam]) VALUES (7, 3, N'TranAnhKhoi', N'0101010202                                                                                          ', 1, CAST(N'2004-05-01T00:00:00' AS SmallDateTime), CAST(N'2024-01-01T00:00:00' AS SmallDateTime))
INSERT [dbo].[NhanVien] ([ID], [IDTaiKhoan], [HoTen], [SDT], [GioiTinh], [NgaySinh], [NgayVaoLam]) VALUES (12, 4, N'ThuThanh', N'1100123456                                                                                          ', 0, CAST(N'2004-01-06T00:00:00' AS SmallDateTime), CAST(N'2024-01-01T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NhomMatHang] ON 

INSERT [dbo].[NhomMatHang] ([ID], [IDDoChoi], [LoaiDoChoi], [GhiChu]) VALUES (1, 1, N'Lego', NULL)
INSERT [dbo].[NhomMatHang] ([ID], [IDDoChoi], [LoaiDoChoi], [GhiChu]) VALUES (2, 2, N'DoChoiConGai', NULL)
INSERT [dbo].[NhomMatHang] ([ID], [IDDoChoi], [LoaiDoChoi], [GhiChu]) VALUES (3, 3, N'DoChoiConTrai', N'123')
SET IDENTITY_INSERT [dbo].[NhomMatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [LoaiTaiKhoan]) VALUES (1, N'vthuy', N'123', 1)
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [LoaiTaiKhoan]) VALUES (2, N'tram', N'123', 1)
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [LoaiTaiKhoan]) VALUES (3, N'khoi', N'123', 0)
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [LoaiTaiKhoan]) VALUES (4, N'thanh', N'123', 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_DoChoi] FOREIGN KEY([IDDoChoi])
REFERENCES [dbo].[DoChoi] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_DoChoi]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon1] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon1]
GO
ALTER TABLE [dbo].[DoChoi]  WITH CHECK ADD  CONSTRAINT [FK_DoChoi_NhaCC] FOREIGN KEY([NhaCC])
REFERENCES [dbo].[NhaCC] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoChoi] CHECK CONSTRAINT [FK_DoChoi_NhaCC]
GO
ALTER TABLE [dbo].[DoChoi]  WITH CHECK ADD  CONSTRAINT [FK_DoChoi_NhomMatHang] FOREIGN KEY([NhomMatHang])
REFERENCES [dbo].[NhomMatHang] ([ID])
GO
ALTER TABLE [dbo].[DoChoi] CHECK CONSTRAINT [FK_DoChoi_NhomMatHang]
GO
ALTER TABLE [dbo].[DoChoiTheoNCC]  WITH CHECK ADD  CONSTRAINT [FK_DoChoiTheoNCC_DoChoi] FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([ID])
GO
ALTER TABLE [dbo].[DoChoiTheoNCC] CHECK CONSTRAINT [FK_DoChoiTheoNCC_DoChoi]
GO
ALTER TABLE [dbo].[DoChoiTheoNCC]  WITH CHECK ADD  CONSTRAINT [FK_DoChoiTheoNCC_NhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoChoiTheoNCC] CHECK CONSTRAINT [FK_DoChoiTheoNCC_NhaCC]
GO
ALTER TABLE [dbo].[HangDoChoi]  WITH CHECK ADD  CONSTRAINT [FK_HangDoChoi_NhaCC] FOREIGN KEY([IDNhaCC])
REFERENCES [dbo].[NhaCC] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangDoChoi] CHECK CONSTRAINT [FK_HangDoChoi_NhaCC]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DoChoi] FOREIGN KEY([MaHang])
REFERENCES [dbo].[DoChoi] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DoChoi]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KhachHang] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([IDTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
