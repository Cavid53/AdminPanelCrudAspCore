USE [AdminPanelDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RepeatDescriptions]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepeatDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_RepeatDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[IconField] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[Image] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Welcomes]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Welcomes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Welcomes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhatWeDos]    Script Date: 08/26/2019 09:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhatWeDos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_WhatWeDos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190823145026_CreateSliderTable', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190824075717_CreateRepeatDescriptionTable', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190824094056_CreateWelcomeTable', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190824102031_CreateWhatWeDoTable', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190826115248_CreateServiceTable', N'2.1.11-servicing-32099')
SET IDENTITY_INSERT [dbo].[RepeatDescriptions] ON 

INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (1, N'WELCOME TO THE WORLD OF POLO', N'Create amam ipsum dolor sit amet, Beautiful nature, and rare feathers!')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (2, N'WHAT WE DO', N'Create amam ipsum dolor sit amet, Beautiful nature, and rare feathers!')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (3, N'RECENT WORK', N' Lorem ipsum dolor sit amet, coper suscipit lobortis nisl ut aliquip ex ea commodo consequat.
                        Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel
                        illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto.')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (4, N'SERVICES', N' Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (5, N'OUR BLOG', N'The most happiest time of the day!. Morbi sagittis, sem quis lacinia faucibus, orci ipsum
                        gravida tortor, vel interdum mi sapien ut justo. Nulla varius consequat magna, id molestie
                        ipsum volutpat quis. A true story, that never been told!. Fusce id mi diam, non ornare orci.
                        Pellentesque ipsum erat, facilisis ut venenatis eu, sodales vel dolor.')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (6, N'CLIENTS', N'Our awesome clients we''ve had the pleasure to work with!')
INSERT [dbo].[RepeatDescriptions] ([Id], [Title], [Description]) VALUES (7, N'MEET OUR TEAM', N' Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum
                        porttitor cursumus.')
SET IDENTITY_INSERT [dbo].[RepeatDescriptions] OFF
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Title], [Description], [IconField]) VALUES (1, N'
Powerful template', N'Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.', N'fa fa-desktop')
INSERT [dbo].[Services] ([Id], [Title], [Description], [IconField]) VALUES (3, N'
Powerful template', N'Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.', N'fa fa-plug')
INSERT [dbo].[Services] ([Id], [Title], [Description], [IconField]) VALUES (6, N'About', N'Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.', N'fa fa-cloud')
INSERT [dbo].[Services] ([Id], [Title], [Description], [IconField]) VALUES (7, N'Blog', N'Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.', N'far fa-lightbulb')
INSERT [dbo].[Services] ([Id], [Title], [Description], [IconField]) VALUES (8, N'Powerful template', N'Lorem ipsum dolor sit amet, consecte adipiscing elit. Suspendisse condimentum porttitor cursumus.', N'fa fa-cloud')
SET IDENTITY_INSERT [dbo].[Services] OFF
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Title], [Description], [Image]) VALUES (1, N'WELCOME TO THE WORLD OF POLO', N'     Say hello to the smartest and most flexible bootstrap template. Polo is an powerful template
                        that can build any type of websites, and quite possibly the only one you will ever need.', N'slidernew3.jpg')
INSERT [dbo].[Sliders] ([Id], [Title], [Description], [Image]) VALUES (2, N'200+ Laytout Demos', N' POLO is packed with 200+ pre-made layouts that allow you to quickly jumpstart your project.
                        Completely customizable for creating your own designs.', N'slidernew4.jpg')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
SET IDENTITY_INSERT [dbo].[Welcomes] ON 

INSERT [dbo].[Welcomes] ([Id], [Image]) VALUES (1, N'welcome.jpg')
SET IDENTITY_INSERT [dbo].[Welcomes] OFF
SET IDENTITY_INSERT [dbo].[WhatWeDos] ON 

INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (1, N'Modern Design', N' Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (2, N'Loaded with Features', N'Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (3, N'Completely Customizable', N'Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (4, N'100% Responsive Layout', N'Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (5, N'Clean Modern Code', N'Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
INSERT [dbo].[WhatWeDos] ([Id], [Title], [Description]) VALUES (6, N'Free Updates & Support', N'Lorem ipsum dolor sit amet, blandit vel sapien vitae,condimentum ultricies magna et. Quisque
                        euismod orci ut et lobortis aliquam.')
SET IDENTITY_INSERT [dbo].[WhatWeDos] OFF
