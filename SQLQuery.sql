USE [master]
GO
/****** Object:  Database [ProductDB]    Script Date: 29/09/2021 8:45:49 am ******/
CREATE DATABASE [ProductDB]
 
GO
USE [ProductDB]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 29/09/2021 8:45:50 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](70) NULL,
 CONSTRAINT [PK__ProductC__19093A2B79ED18E1] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 29/09/2021 8:45:50 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](70) NULL,
	[CategoryID] [bigint] NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[Picture] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__Products__B40CC6EDE19F7C0F] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] ON 
GO
INSERT [dbo].[ProductCategories] ([CategoryID], [CategoryName]) VALUES (1, N'Electronics')
GO
INSERT [dbo].[ProductCategories] ([CategoryID], [CategoryName]) VALUES (2, N'Sport equipment')
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitPrice], [Picture]) VALUES (1, N'Rdtv', 1, CAST(100.00 AS Decimal(18, 2)), N'a')
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitPrice], [Picture]) VALUES (2, N'Sochet ball', 2, CAST(200.00 AS Decimal(18, 2)), N'v')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [Fkey1] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[ProductCategories] ([CategoryID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [Fkey1]
GO
USE [master]
GO
ALTER DATABASE [ProductDB] SET  READ_WRITE 
GO
