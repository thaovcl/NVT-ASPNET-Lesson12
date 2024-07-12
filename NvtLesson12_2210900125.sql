SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nvt_SACH](
	[Nvt_MaSach] [nchar](10) NOT NULL,
	[Nvt_TenSach] [nvarchar](50) NULL,
	[Nvt_SoTrang] [int] NULL,
	[Nvt_NamXB] [int] NULL,
	[Nvt_MaTG] [nchar](10) NULL,
	[Nvt_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Nvt_SACH] PRIMARY KEY CLUSTERED 
(
	[Nvt_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nvt_TACGIA]    Script Date: 7/12/2024 9:19:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nvt_TACGIA](
	[Nvt_MaTG] [nchar](10) NOT NULL,
	[Nvt_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nvt_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Nvt_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Nvt_SACH] ([Nvt_MaSach], [Nvt_TenSach], [Nvt_SoTrang], [Nvt_NamXB], [Nvt_MaTG], [Nvt_TrangThai]) VALUES (N'S1        ', N'Ngữ Văn', 200, 2023, N'T1        ', 1)
INSERT [dbo].[Nvt_SACH] ([Nvt_MaSach], [Nvt_TenSach], [Nvt_SoTrang], [Nvt_NamXB], [Nvt_MaTG], [Nvt_TrangThai]) VALUES (N'S2        ', N'Toán', 150, 2022, N'T2        ', 0)
INSERT [dbo].[Nvt_TACGIA] ([Nvt_MaTG], [Nvt_TenTG]) VALUES (N'T1        ', N'Nguyễn Văn Thạo')
INSERT [dbo].[Nvt_TACGIA] ([Nvt_MaTG], [Nvt_TenTG]) VALUES (N'T2        ', N'Nguyễn Văn Thạo')
ALTER TABLE [dbo].[Nvt_SACH]  WITH CHECK ADD  CONSTRAINT [FK_Nvt_SACH_Nvt_TACGIA] FOREIGN KEY([Nvt_MaTG])
REFERENCES [dbo].[Nvt_TACGIA] ([Nvt_MaTG])
GO
ALTER TABLE [dbo].[Nvt_SACH] CHECK CONSTRAINT [FK_Nvt_SACH_Nvt_TACGIA]
