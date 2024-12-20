USE [FreshfarmMart-DB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11-12-24 13:24:49 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTbl](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ContactPerson] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminTbl] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartTbl](
	[CartID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CartTbl] PRIMARY KEY CLUSTERED 
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTbl](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[MainCategoryID] [bigint] NOT NULL,
	[PurchaseLimitInQty] [int] NOT NULL,
 CONSTRAINT [PK_CategoryTbl] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CityTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTbl](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[StateID] [bigint] NOT NULL,
	[CityName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CityTbl] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComplaintRefundTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComplaintRefundTbl](
	[ComplaintRefundID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderComplaintSolutionID] [bigint] NOT NULL,
	[RefundAmount] [decimal](18, 2) NOT NULL,
	[ReundDate] [datetime2](7) NOT NULL,
	[PaymentMode] [int] NOT NULL,
 CONSTRAINT [PK_ComplaintRefundTbl] PRIMARY KEY CLUSTERED 
(
	[ComplaintRefundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CountryTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryTbl](
	[CountryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CountryTbl] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DispatchAgencyTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DispatchAgencyTbl](
	[DispatchAgencyID] [bigint] IDENTITY(1,1) NOT NULL,
	[AgencyName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[ContactPerson] [nvarchar](max) NULL,
 CONSTRAINT [PK_DispatchAgencyTbl] PRIMARY KEY CLUSTERED 
(
	[DispatchAgencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FarmerTermsConditionTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FarmerTermsConditionTbl](
	[TraderFarmerTermsConditionID] [bigint] IDENTITY(1,1) NOT NULL,
	[TermsConditionTitle] [nvarchar](max) NULL,
	[TermsConditionDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_FarmerTermsConditionTbl] PRIMARY KEY CLUSTERED 
(
	[TraderFarmerTermsConditionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainCategoryTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainCategoryTbl](
	[MainCategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[MainCategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_MainCategoryTbl] PRIMARY KEY CLUSTERED 
(
	[MainCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDispatchTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDispatchTbl](
	[OrderDispatchID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderID] [bigint] NOT NULL,
	[DispatchAgencyID] [bigint] NOT NULL,
	[DocketNo] [nvarchar](max) NULL,
	[DispatchDate] [datetime2](7) NOT NULL,
	[ExpectedReachDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderDispatchTbl] PRIMARY KEY CLUSTERED 
(
	[OrderDispatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDiscountTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDiscountTbl](
	[ProductDiscountID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[DiscountName] [nvarchar](max) NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
	[IsPercentile] [bit] NOT NULL,
 CONSTRAINT [PK_ProductDiscountTbl] PRIMARY KEY CLUSTERED 
(
	[ProductDiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPhotoTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPhotoTbl](
	[ProudctPhotoID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[PhotoPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductPhotoTbl] PRIMARY KEY CLUSTERED 
(
	[ProudctPhotoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductReviewTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductReviewTbl](
	[ProductReviewID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[ReviewDesc] [nvarchar](max) NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_ProductReviewTbl] PRIMARY KEY CLUSTERED 
(
	[ProductReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[ProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[ProductDesc] [nvarchar](max) NULL,
	[CategoryID] [bigint] NOT NULL,
	[UnitID] [bigint] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[MainPhotoPath] [nvarchar](max) NULL,
	[TraderFarmerID] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductTbl] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateTbl](
	[StateID] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
	[CountryID] [bigint] NOT NULL,
 CONSTRAINT [PK_StateTbl] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraderFarmerTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraderFarmerTbl](
	[TraderFarmerID] [bigint] IDENTITY(1,1) NOT NULL,
	[TradeName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[PinCode] [nvarchar](max) NULL,
	[CityID] [bigint] NOT NULL,
	[Password] [nvarchar](max) NULL,
	[RegistrationDate] [datetime2](7) NOT NULL,
	[ActiveFlag] [bit] NOT NULL,
	[ContactPerson] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_TraderFarmerTbl] PRIMARY KEY CLUSTERED 
(
	[TraderFarmerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitTbl](
	[UnitID] [bigint] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](max) NULL,
	[QtyPerUnit] [int] NOT NULL,
 CONSTRAINT [PK_UnitTbl] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOrderComplaintSolutionTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOrderComplaintSolutionTbl](
	[UserOrderComplaintSolutionID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderComplaintID] [bigint] NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
	[SolutionDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserOrderComplaintSolutionTbl] PRIMARY KEY CLUSTERED 
(
	[UserOrderComplaintSolutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOrderComplaintTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOrderComplaintTbl](
	[UserOrderComplaintID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderID] [bigint] NOT NULL,
	[ComplaintDate] [datetime2](7) NOT NULL,
	[ComplaintDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserOrderComplaintTbl] PRIMARY KEY CLUSTERED 
(
	[UserOrderComplaintID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOrderDetTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOrderDetTbl](
	[UserOrderDetID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[DiscountName] [nvarchar](max) NULL,
	[DiscountApplied] [decimal](18, 2) NOT NULL,
	[IsPercentile] [bit] NOT NULL,
	[ActualDiscountAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_UserOrderDetTbl] PRIMARY KEY CLUSTERED 
(
	[UserOrderDetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOrderPaymentTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOrderPaymentTbl](
	[UserOrderPaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserOrderID] [bigint] NOT NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[PaymentMode] [int] NOT NULL,
 CONSTRAINT [PK_UserOrderPaymentTbl] PRIMARY KEY CLUSTERED 
(
	[UserOrderPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOrderTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOrderTbl](
	[UserOrderID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[IsPaid] [bit] NOT NULL,
 CONSTRAINT [PK_UserOrderTbl] PRIMARY KEY CLUSTERED 
(
	[UserOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Gender] [int] NOT NULL,
	[CityID] [bigint] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[PinCode] [nvarchar](max) NULL,
	[Occupation] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTermsConditionTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTermsConditionTbl](
	[UserTermsConditionID] [bigint] IDENTITY(1,1) NOT NULL,
	[TermsConditionTitle] [nvarchar](max) NULL,
	[TermsConditionDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTermsConditionTbl] PRIMARY KEY CLUSTERED 
(
	[UserTermsConditionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WishListTbl]    Script Date: 11-12-24 13:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WishListTbl](
	[WishListID] [bigint] IDENTITY(1,1) NOT NULL,
	[WishListDate] [datetime2](7) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[AddedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_WishListTbl] PRIMARY KEY CLUSTERED 
(
	[WishListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241001160201_Init', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241002071955_Giodata', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241004063636_Initi', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241005054838_upt', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241008110801_ffaar', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241009084133_fr', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011171159_InitialCreate', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241018100958_TraderFarmerID', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241018101706_farmFK', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241018112253_FKadd', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241113091155_initii', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241114135416_new', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241114140048_Addtable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241115092813_newone', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241115093605_init', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241121084550_fkadd', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241121100721_newup', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241125095133_addUserfkwishlist', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241127070912_removefkfarmer', N'8.0.8')
GO
SET IDENTITY_INSERT [dbo].[AdminTbl] ON 

INSERT [dbo].[AdminTbl] ([AdminId], [FirstName], [LastName], [EmailID], [MobileNo], [Password], [Address], [ContactPerson]) VALUES (1, N'Pravin', N'Chavan', N'pravinchavan@gmail.com', N'9765972392', N'1234', N'Nigdi,Pune', N'Rohini Chavan')
INSERT [dbo].[AdminTbl] ([AdminId], [FirstName], [LastName], [EmailID], [MobileNo], [Password], [Address], [ContactPerson]) VALUES (2, N'Rahul', N'Chougale', N'rahul@gmail.com', N'9765672392', N'abcd', N'Hadpasar,Pune', N'Minal')
SET IDENTITY_INSERT [dbo].[AdminTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CartTbl] ON 

INSERT [dbo].[CartTbl] ([CartID], [UserID], [ProductID], [Qty], [Price]) VALUES (10028, 2, 2, 1, CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[CartTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryTbl] ON 

INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (1, N'Fruiting Vegetables', 1, 200)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (2, N'Leafy Vegetables', 1, 300)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (3, N'Root Vegetables', 1, 500)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (4, N'Bulb Vegetables', 1, 400)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (5, N'Citrus Fruits', 2, 200)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (6, N'Tropical Fruits', 2, 300)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (7, N'Cereal Grains', 3, 400)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (8, N'Millets', 3, 500)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (9, N'Milk', 4, 300)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (10, N'Cheese', 4, 400)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (11, N'Ghee', 4, 600)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (12, N'Poultry', 5, 600)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (13, N'Eggs', 5, 400)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (14, N'Ground Spices', 6, 300)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (15, N'Fresh Herbs', 6, 400)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (16, N'Almonds', 7, 200)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (17, N'Fresh Flowers', 8, 200)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (18, N'Raw Honey', 9, 500)
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName], [MainCategoryID], [PurchaseLimitInQty]) VALUES (19, N'Fresh Fruit Juices', 10, 400)
SET IDENTITY_INSERT [dbo].[CategoryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CityTbl] ON 

INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (1, 1, N'Pune')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (2, 2, N'Seattle')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (3, 3, N'San Jose')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (4, 5, N'Krimml')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (5, 6, N'Rome')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (6, 4, N'Jodhpur ')
INSERT [dbo].[CityTbl] ([CityID], [StateID], [CityName]) VALUES (7, 1, N'Mumbai ')
SET IDENTITY_INSERT [dbo].[CityTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CountryTbl] ON 

INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (1, N'India')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (2, N'USA')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (3, N'Austria')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (4, N'Italy')
SET IDENTITY_INSERT [dbo].[CountryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[DispatchAgencyTbl] ON 

INSERT [dbo].[DispatchAgencyTbl] ([DispatchAgencyID], [AgencyName], [Address], [EmailID], [MobileNo], [ContactPerson]) VALUES (1, N'GreenLine Logistics', N'Nigdi,pune', N'info@logistics.com', N'7799668855', N'Minal')
INSERT [dbo].[DispatchAgencyTbl] ([DispatchAgencyID], [AgencyName], [Address], [EmailID], [MobileNo], [ContactPerson]) VALUES (2, N'AgriMove Dispatchers', N'Andheri,Mumbai', N'dispatch@agrimove.com', N'9966448822', N'Radhika')
INSERT [dbo].[DispatchAgencyTbl] ([DispatchAgencyID], [AgencyName], [Address], [EmailID], [MobileNo], [ContactPerson]) VALUES (3, N'FreshCart Logistics', N'Navi Mumbai', N'contact@freshcart.com', N'8894564466', N'Sanika')
INSERT [dbo].[DispatchAgencyTbl] ([DispatchAgencyID], [AgencyName], [Address], [EmailID], [MobileNo], [ContactPerson]) VALUES (4, N'Harvest Flow Dispatch', N'Akurdi,Pune', N'sales@harvestflow.com', N'9596989493', N'Priya')
SET IDENTITY_INSERT [dbo].[DispatchAgencyTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[FarmerTermsConditionTbl] ON 

INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (1, N' Quality Assurance', N'All products sold are subject to a strict quality control check before being shipped to ensure freshness.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (2, N'	Payment Terms', N'Payments must be made at the time of order confirmation via accepted payment methods (e.g., credit card, net banking).')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (3, N'	Delivery Policy', N'Orders will be delivered within 3-5 business days. Delivery charges may vary based on location and order size.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (4, N'Return and Refund Policy', N'	Returns are accepted within 7 days if the product is damaged or not as described. Refunds will be processed within 14 days.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (5, N'Cancellation Policy', N'	Orders can be canceled within 24 hours of placing the order. A full refund will be processed for such cancellations.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (6, N'	Pricing and Availability', N'Prices are subject to change without prior notice. Products are offered based on availability.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (7, N'Privacy and Data Protection', N'Customer information will be stored securely and not shared with third parties, except as required for order fulfillment.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (8, N'	Liability Limitations', N'	Fresh Farm Mart is not responsible for any damages or losses resulting from delays, incorrect deliveries, or product availability.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (9, N'User Responsibilities', N'Users must ensure the accuracy of their personal and delivery details to avoid issues with their order.')
INSERT [dbo].[FarmerTermsConditionTbl] ([TraderFarmerTermsConditionID], [TermsConditionTitle], [TermsConditionDesc]) VALUES (10, N'	Changes to Terms and Conditions', N'Fresh Farm Mart reserves the right to update these terms at any time. Changes will be communicated to customers.')
SET IDENTITY_INSERT [dbo].[FarmerTermsConditionTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[MainCategoryTbl] ON 

INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (1, N'Vegetables')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (2, N'Fruits')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (3, N'Grains & Cereals')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (4, N'Dairy Products')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (5, N'Poultry & Meat')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (6, N'Spices & Herbs')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (7, N' Nuts & Dry Fruits')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (8, N'Flowers')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (9, N'Honey & Bee Products')
INSERT [dbo].[MainCategoryTbl] ([MainCategoryID], [MainCategoryName]) VALUES (10, N'Beverages')
SET IDENTITY_INSERT [dbo].[MainCategoryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDispatchTbl] ON 

INSERT [dbo].[OrderDispatchTbl] ([OrderDispatchID], [UserOrderID], [DispatchAgencyID], [DocketNo], [DispatchDate], [ExpectedReachDate]) VALUES (2, 13, 1, N'CT202', CAST(N'2024-11-27T14:16:00.0000000' AS DateTime2), CAST(N'2024-11-30T21:16:00.0000000' AS DateTime2))
INSERT [dbo].[OrderDispatchTbl] ([OrderDispatchID], [UserOrderID], [DispatchAgencyID], [DocketNo], [DispatchDate], [ExpectedReachDate]) VALUES (3, 18, 3, N'Ct203', CAST(N'2024-12-01T13:32:00.0000000' AS DateTime2), CAST(N'2024-12-02T13:32:00.0000000' AS DateTime2))
INSERT [dbo].[OrderDispatchTbl] ([OrderDispatchID], [UserOrderID], [DispatchAgencyID], [DocketNo], [DispatchDate], [ExpectedReachDate]) VALUES (4, 20, 1, N'Ct2023', CAST(N'2024-12-01T21:01:00.0000000' AS DateTime2), CAST(N'2024-12-10T12:02:00.0000000' AS DateTime2))
INSERT [dbo].[OrderDispatchTbl] ([OrderDispatchID], [UserOrderID], [DispatchAgencyID], [DocketNo], [DispatchDate], [ExpectedReachDate]) VALUES (5, 21, 3, N'cT404', CAST(N'2024-12-02T10:30:00.0000000' AS DateTime2), CAST(N'2024-12-18T10:30:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[OrderDispatchTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDiscountTbl] ON 

INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (1, 2, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (2, 10002, N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (3, 10003, N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (4, 10004, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (5, 2, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (6, 10005, N'24-Hour Deal', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (7, 2, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (8, 10006, N'Holiday Sale', CAST(0.15 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (9, 10007, N'Holiday Sale', CAST(0.10 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10, 10008, N'Holiday Sale', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (11, 10009, N'First-Time Buyer Discount', CAST(0.10 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (12, 2, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10012, 10010, N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10013, 10010, N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10014, 10004, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10015, 10006, N'Holiday Sale', CAST(0.15 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10016, 10011, N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10017, 10012, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10018, 10013, N'Holiday Sale', CAST(0.10 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10019, 10014, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10020, 10015, N'Today Only Offer', CAST(0.25 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10021, 10016, N'Today Only Offer', CAST(0.20 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10022, 10017, N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10023, 2, N'First-Time Buyer Discount', CAST(10.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10024, 10002, N'Limited Time Offer', CAST(25.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10025, 2, N'First-Time Buyer Discount', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10026, 10002, N'Limited Time Offer', CAST(25.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10027, 10003, N'Limited Time Offer', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10028, 10004, N'First-Time Buyer Discount', CAST(10.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10029, 10005, N'24-Hour Deal', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10030, 10006, N'Holiday Sale', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10031, 10007, N'Holiday Sale', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10032, 10008, N'Holiday Sale', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10033, 10009, N'First-Time Buyer Discount', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10034, 10010, N'Limited Time Offer', CAST(25.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10035, 10011, N'Limited Time Offer', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10036, 10012, N'First-Time Buyer Discount', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10037, 10013, N'Holiday Sale', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10038, 10014, N'First-Time Buyer Discount', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10039, 10015, N'Today Only Offer', CAST(10.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10040, 10016, N'Today Only Offer', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10041, 10017, N'Limited Time Offer', CAST(15.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10042, 10017, N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10043, 2, N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10044, 10018, N'First-Time Buyer Discount', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10045, 10018, N'First-Time Buyer Discount', CAST(20.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10046, 10019, N'Holiday Sale', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProductDiscountTbl] ([ProductDiscountID], [ProductID], [DiscountName], [DiscountAmount], [IsPercentile]) VALUES (10047, 10018, N'First-Time Buyer Discount', CAST(20.00 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[ProductDiscountTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductPhotoTbl] ON 

INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (2, 2, N'\ProductPhotos\Bell Peppersss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (3, 10004, N'\ProductPhotos\pngtree-tomato-fruit-and-vegetable-png-image_11559795.png')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (5, 10008, N'\ProductPhotos\spinach.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (6, 10003, N'\ProductPhotos\Milkkk.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (8, 2, N'\ProductPhotos\Bell Pepperss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (9, 10002, N'\ProductPhotos\orangeeeee.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (11, 10002, N'\ProductPhotos\orange.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (14, 2, N'\ProductPhotos\Bell Peppers.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (15, 10002, N'\ProductPhotos\Oranges.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (16, 10003, N'\ProductPhotos\milkk.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (17, 10003, N'\ProductPhotos\milllkk.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (18, 10004, N'\ProductPhotos\Tomatooo.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (20, 10004, N'\ProductPhotos\Tomato.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (22, 10005, N'\ProductPhotos\onionsss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (23, 10005, N'\ProductPhotos\onionss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (24, 10006, N'\ProductPhotos\GoatMilkkkk.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (26, 10006, N'\ProductPhotos\GoatMilkkkkk.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (27, 10007, N'\ProductPhotos\Chickenn.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (28, 10007, N'\ProductPhotos\Chickennn.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (29, 10007, N'\ProductPhotos\Chickennnn.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (30, 10008, N'\ProductPhotos\Spinachhhhhh.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (31, 10008, N'\ProductPhotos\spinachh.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (32, 10009, N'\ProductPhotos\Eggsss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (33, 10009, N'\ProductPhotos\Eggssss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (34, 10009, N'\ProductPhotos\Eggsssss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (35, 10010, N'\ProductPhotos\Garlicccc.webp')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (36, 10010, N'\ProductPhotos\Garliccc.webp')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (38, 10011, N'\ProductPhotos\Almondss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (39, 10011, N'\ProductPhotos\Almondsss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (40, 10011, N'\ProductPhotos\Almondssss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (41, 10012, N'\ProductPhotos\Turmericc.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (42, 10012, N'\ProductPhotos\Turmericcc.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (43, 10012, N'\ProductPhotos\Turmericccc.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (44, 10013, N'\ProductPhotos\Rosess.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (47, 10013, N'\ProductPhotos\Rosesss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (48, 10013, N'\ProductPhotos\Rosessss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (49, 10014, N'\ProductPhotos\Potatoess.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (50, 10014, N'\ProductPhotos\Potatoesss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (51, 10014, N'\ProductPhotos\Potatoessss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (52, 10015, N'\ProductPhotos\Carrotss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (53, 10015, N'\ProductPhotos\Carrotsss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (56, 10015, N'\ProductPhotos\Carrotssss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (58, 10016, N'\ProductPhotos\RawHoneyy.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (59, 10016, N'\ProductPhotos\RawHoneyyy.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (60, 10017, N'\ProductPhotos\Sorghum.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (61, 10017, N'\ProductPhotos\Sorghummmm.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (62, 10017, N'\ProductPhotos\Sorghummmmm.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (64, 10019, N'\ProductPhotos\corennn.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (66, 10019, N'\ProductPhotos\download.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (67, 10019, N'\ProductPhotos\Corn.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (69, 10018, N'\ProductPhotos\Pickelsss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (70, 10018, N'\ProductPhotos\Pickelssss.jpg')
INSERT [dbo].[ProductPhotoTbl] ([ProudctPhotoID], [ProductID], [PhotoPath]) VALUES (75, 10019, N'\ProductPhotos\download.jpg')
SET IDENTITY_INSERT [dbo].[ProductPhotoTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductReviewTbl] ON 

INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (1, 2, 2, N'Good Test and fresh', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (2, 2, 1, N'Very very Fresh', 1)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (3, 10004, 2, N'Very very fresh', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (4, 10004, 2, N'Very very fresh', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (5, 10008, 2, N'Fresh quality', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (6, 10010, 2, N'Very good Quality ', 1)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10003, 10012, 2, N'Very good Quality ', 1)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10004, 10006, 2, N'Fresh quality', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10005, 10002, 2, N'very fresh and good Quality', 1)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10006, 10002, 3, N'Good and fresh ', 1)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10007, 10019, 4, N'Very Sweet and fresh', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10008, 10005, 4, N'Good Quality', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10009, 10003, 4, N'Fresh Milk', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10010, 10009, 4, N'very good Quality', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10011, 10010, 4, N'fresh', 2)
INSERT [dbo].[ProductReviewTbl] ([ProductReviewID], [ProductID], [UserID], [ReviewDesc], [Rating]) VALUES (10012, 10002, 5, N'vary fresh', 2)
SET IDENTITY_INSERT [dbo].[ProductReviewTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTbl] ON 

INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (2, N'Bell Peppers', N'Good Quality', 1, 1, 500, CAST(40.00 AS Decimal(18, 2)), N'\ProductPhotos\Peppers.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10002, N'Oranges', N'Fresh and Good Quality', 5, 1, 3000, CAST(200.00 AS Decimal(18, 2)), N'\ProductPhotos\Oranges.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10003, N'Cow Milk', N'Good for Health', 9, 2, 500, CAST(50.00 AS Decimal(18, 2)), N'\ProductPhotos\Milk.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10004, N'Tomato', N'fresh', 1, 1, 500, CAST(40.00 AS Decimal(18, 2)), N'\ProductPhotos\Tomato.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10005, N'Onions', N'Onions are rich in B vitamins, including folate and vitamin B6', 4, 1, 600, CAST(80.00 AS Decimal(18, 2)), N'\ProductPhotos\Onions.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10006, N'Goat Milk', N'Good for health', 9, 2, 800, CAST(30.00 AS Decimal(18, 2)), N'\ProductPhotos\GoatMilkk.jpg', 2)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10007, N'Chicken', N'Fresh and good Quality', 12, 1, 8500, CAST(100.00 AS Decimal(18, 2)), N'\ProductPhotos\Chicken.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10008, N'Spinach', N'Vitamins A, C, K and folate, which are crucial for healthy vision, immunity, bone health and cell growth', 2, 1, 900, CAST(20.00 AS Decimal(18, 2)), N'\ProductPhotos\Leafy Greens.jpg', 2)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10009, N'Chicken Eggs', N'Good source of protein, vitamins, minerals, and other nutrients', 13, 4, 10000, CAST(30.00 AS Decimal(18, 2)), N'\ProductPhotos\Eggs.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10010, N'Garlic', N'Garlic is the small, white, round bulb of a plant that is related to the onion plant.', 4, 1, 5000, CAST(50.00 AS Decimal(18, 2)), N'\ProductPhotos\Garlic.jpg', 2)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10011, N'Almonds', N'Good for health ', 16, 1, 10000, CAST(300.00 AS Decimal(18, 2)), N'\ProductPhotos\Almonds.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10012, N'Turmeric', N'Turmeric is a product of Curcuma longa', 14, 1, 5000, CAST(20.00 AS Decimal(18, 2)), N'\ProductPhotos\Turmeric.jpg', 1)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10013, N'Roses', N'Their stems are usually prickly and their glossy, green leaves have toothed edges', 17, 4, 1000, CAST(10.00 AS Decimal(18, 2)), N'\ProductPhotos\Roses.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10014, N'Potatoes', N'They''re rich in vitamin C, which is an antioxidant.', 3, 1, 7000, CAST(30.00 AS Decimal(18, 2)), N'\ProductPhotos\Potatoes.jpg', 2)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10015, N'Carrots', N'The fiber in carrots can help keep blood sugar levels under control.', 3, 1, 10000, CAST(40.00 AS Decimal(18, 2)), N'\ProductPhotos\Carrots.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10016, N'Honey', N'relieving coughs, wound healing, treating diarrhea, and more', 18, 1, 2000, CAST(100.00 AS Decimal(18, 2)), N'\ProductPhotos\RawHoney.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10017, N'Sorghum', N'It is high in carbohydrates, with 10 percent protein and 3.4 percent fat, and contains calcium and small amounts of iron, vitamin B1, and niacin.', 8, 1, 20000, CAST(40.00 AS Decimal(18, 2)), N'\ProductPhotos\Sorghumm.jpg', 3)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10018, N'Pickels', N'dfdfdgdg', 14, 1, 100, CAST(500.00 AS Decimal(18, 2)), N'\ProductPhotos\Pickelsss.jpg', 10011)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [ProductDesc], [CategoryID], [UnitID], [Qty], [Price], [MainPhotoPath], [TraderFarmerID]) VALUES (10019, N'Sweet Corn', N'Good for health', 7, 1, 300, CAST(80.00 AS Decimal(18, 2)), N'\ProductPhotos\Corn.jpg', 16)
SET IDENTITY_INSERT [dbo].[ProductTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[StateTbl] ON 

INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (1, N'Maharashtra', 1)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (2, N'Washington', 2)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (3, N'California', 2)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (4, N'Rajasthan', 1)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (5, N'Salzburg', 3)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (6, N'Lazio', 4)
SET IDENTITY_INSERT [dbo].[StateTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[TraderFarmerTbl] ON 

INSERT [dbo].[TraderFarmerTbl] ([TraderFarmerID], [TradeName], [Address], [PinCode], [CityID], [Password], [RegistrationDate], [ActiveFlag], [ContactPerson], [EmailID], [MobileNo]) VALUES (1, NULL, N'Kolhapur', N'416209', 1, N'acbd', CAST(N'2024-11-27T12:39:09.5855259' AS DateTime2), 1, N'Minal', N'rahul@gmail.com', N'9874587658')
INSERT [dbo].[TraderFarmerTbl] ([TraderFarmerID], [TradeName], [Address], [PinCode], [CityID], [Password], [RegistrationDate], [ActiveFlag], [ContactPerson], [EmailID], [MobileNo]) VALUES (2, N'Minal Chougale', N'Nigdi,Pune', N'417809', 2, N'abcd', CAST(N'2024-10-20T00:00:00.0000000' AS DateTime2), 1, N'Rohini', N'pravin@gmail.com', N'9765972392')
INSERT [dbo].[TraderFarmerTbl] ([TraderFarmerID], [TradeName], [Address], [PinCode], [CityID], [Password], [RegistrationDate], [ActiveFlag], [ContactPerson], [EmailID], [MobileNo]) VALUES (3, N'Karan', N'Akurdi,Pune', N'417806', 3, N'aacc', CAST(N'2024-10-21T00:00:00.0000000' AS DateTime2), 1, N'Priya', N'karan@gmail.com', N'9988774455')
INSERT [dbo].[TraderFarmerTbl] ([TraderFarmerID], [TradeName], [Address], [PinCode], [CityID], [Password], [RegistrationDate], [ActiveFlag], [ContactPerson], [EmailID], [MobileNo]) VALUES (16, N'Minal Chougale', N'Pune', N'416209', 1, N'abcd', CAST(N'2022-02-12T00:00:00.0000000' AS DateTime2), 0, N'Rahul Chougale', N'minal@gmail.com', N'9765672392')
INSERT [dbo].[TraderFarmerTbl] ([TraderFarmerID], [TradeName], [Address], [PinCode], [CityID], [Password], [RegistrationDate], [ActiveFlag], [ContactPerson], [EmailID], [MobileNo]) VALUES (10011, N'Radhika Chougale', N'Kolhapur', N'416209', 1, N'abcd', CAST(N'2024-11-30T13:07:00.0000000' AS DateTime2), 0, N'Rohini', N'radhika@gmail.com', N'8329006775')
SET IDENTITY_INSERT [dbo].[TraderFarmerTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UnitTbl] ON 

INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (1, N'Kilogram', 1)
INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (2, N'Liter', 1)
INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (3, N'gram', 1)
INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (4, N'Dozen', 1)
INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (5, N'Head', 1)
INSERT [dbo].[UnitTbl] ([UnitID], [UnitName], [QtyPerUnit]) VALUES (6, N'Cob', 1)
SET IDENTITY_INSERT [dbo].[UnitTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserOrderDetTbl] ON 

INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (1, 13, 2, 3, CAST(40.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.60 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (2, 13, 10002, 3, CAST(200.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1, CAST(0.90 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (3, 13, 10007, 1, CAST(100.00 AS Decimal(18, 2)), N'Holiday Sale', CAST(0.10 AS Decimal(18, 2)), 1, CAST(0.10 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (4, 13, 10014, 1, CAST(30.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (5, 13, 10003, 2, CAST(50.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (6, 13, 10009, 1, CAST(30.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.10 AS Decimal(18, 2)), 1, CAST(0.10 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (7, 13, 10015, 1, CAST(40.00 AS Decimal(18, 2)), N'Today Only Offer', CAST(0.25 AS Decimal(18, 2)), 1, CAST(0.25 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (8, 14, 10006, 1, CAST(30.00 AS Decimal(18, 2)), N'Holiday Sale', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (9, 15, 2, 1, CAST(40.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (10, 15, 10004, 1, CAST(40.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (11, 15, 10005, 1, CAST(80.00 AS Decimal(18, 2)), N'24-Hour Deal', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (12, 16, 10002, 1, CAST(200.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (13, 17, 10008, 1, CAST(20.00 AS Decimal(18, 2)), N'Holiday Sale', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (14, 17, 10004, 1, CAST(40.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (15, 18, 10008, 1, CAST(20.00 AS Decimal(18, 2)), N'Holiday Sale', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (16, 18, 10012, 1, CAST(20.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (17, 19, 10002, 1, CAST(200.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (18, 19, 10005, 1, CAST(80.00 AS Decimal(18, 2)), N'24-Hour Deal', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (19, 19, 10011, 1, CAST(300.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (20, 19, 10009, 1, CAST(30.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.10 AS Decimal(18, 2)), 1, CAST(0.10 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (21, 20, 10002, 1, CAST(200.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (22, 20, 10003, 2, CAST(50.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (23, 20, 10005, 1, CAST(80.00 AS Decimal(18, 2)), N'24-Hour Deal', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (24, 20, 10006, 1, CAST(30.00 AS Decimal(18, 2)), N'Holiday Sale', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (25, 21, 10003, 1, CAST(50.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.15 AS Decimal(18, 2)), 1, CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (26, 21, 10002, 1, CAST(200.00 AS Decimal(18, 2)), N'Limited Time Offer', CAST(0.30 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)))
INSERT [dbo].[UserOrderDetTbl] ([UserOrderDetID], [UserOrderID], [ProductID], [Qty], [Price], [DiscountName], [DiscountApplied], [IsPercentile], [ActualDiscountAmount]) VALUES (27, 21, 10004, 1, CAST(40.00 AS Decimal(18, 2)), N'First-Time Buyer Discount', CAST(0.20 AS Decimal(18, 2)), 1, CAST(0.20 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[UserOrderDetTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserOrderPaymentTbl] ON 

INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (1, 13, CAST(N'2024-11-27T14:08:39.7126671' AS DateTime2), CAST(1017.55 AS Decimal(18, 2)), 2)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (2, 14, CAST(N'2024-11-27T14:19:54.3470953' AS DateTime2), CAST(29.85 AS Decimal(18, 2)), 1)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (3, 15, CAST(N'2024-11-27T14:33:24.9675600' AS DateTime2), CAST(159.40 AS Decimal(18, 2)), 4)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (4, 16, CAST(N'2024-11-27T14:48:18.4193805' AS DateTime2), CAST(199.70 AS Decimal(18, 2)), 1)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (5, 17, CAST(N'2024-11-27T14:57:58.5322687' AS DateTime2), CAST(59.60 AS Decimal(18, 2)), 1)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (6, 18, CAST(N'2024-11-30T13:29:13.6477065' AS DateTime2), CAST(39.60 AS Decimal(18, 2)), 3)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (7, 19, CAST(N'2024-11-30T18:45:19.2425155' AS DateTime2), CAST(609.25 AS Decimal(18, 2)), 1)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (8, 20, CAST(N'2024-12-01T15:16:56.8867048' AS DateTime2), CAST(409.05 AS Decimal(18, 2)), 2)
INSERT [dbo].[UserOrderPaymentTbl] ([UserOrderPaymentID], [UserOrderID], [PaymentDate], [Amount], [PaymentMode]) VALUES (9, 21, CAST(N'2024-12-02T10:28:07.7515794' AS DateTime2), CAST(289.35 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[UserOrderPaymentTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserOrderTbl] ON 

INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (13, 2, CAST(N'2024-11-27T14:08:39.7112968' AS DateTime2), 1)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (14, 2, CAST(N'2024-11-27T14:19:54.3463905' AS DateTime2), 0)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (15, 2, CAST(N'2024-11-27T14:33:24.9661281' AS DateTime2), 1)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (16, 2, CAST(N'2024-11-27T14:48:18.4177966' AS DateTime2), 0)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (17, 2, CAST(N'2024-11-27T14:57:58.5311795' AS DateTime2), 0)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (18, 3, CAST(N'2024-11-30T13:29:13.6461537' AS DateTime2), 1)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (19, 4, CAST(N'2024-11-30T18:45:19.2418684' AS DateTime2), 0)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (20, 4, CAST(N'2024-12-01T15:16:56.8854691' AS DateTime2), 1)
INSERT [dbo].[UserOrderTbl] ([UserOrderID], [UserID], [OrderDate], [IsPaid]) VALUES (21, 5, CAST(N'2024-12-02T10:28:07.7507776' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[UserOrderTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Gender], [CityID], [Address], [PinCode], [Occupation], [EmailId], [Password]) VALUES (1, N'Sangita', N'Chougale', 0, 1, N'Kolhapur', N'416209', N'BCom', N'sanita@gmail.com', N'222111')
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Gender], [CityID], [Address], [PinCode], [Occupation], [EmailId], [Password]) VALUES (2, N'Sonali', N'Patil', 0, 7, N'Andheri east,Mumbai', N'415206', N'MCA', N'sonali@gmail.com', N'abcd')
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Gender], [CityID], [Address], [PinCode], [Occupation], [EmailId], [Password]) VALUES (3, N'Komal', N'Patil', 0, 5, N'Mumbai', N'416302', N'BE', N'komal@gmail.com', N'abcd')
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Gender], [CityID], [Address], [PinCode], [Occupation], [EmailId], [Password]) VALUES (4, N'pravin', N'Chavan', 0, 1, N'Kolhapur', N'415302', N'BE', N'pravin123@gmail.com', N'1234')
INSERT [dbo].[Users] ([UserID], [FirstName], [LastName], [Gender], [CityID], [Address], [PinCode], [Occupation], [EmailId], [Password]) VALUES (5, N'Vaishnavi', N'Tamane', 2, 1, N'Pune', N'415206', N'BCA', N'vaishnavi@gmail.com', N'abcd')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[WishListTbl] ON 

INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (18, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 10002, CAST(N'2024-11-25T15:25:32.3175649' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (19, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 2, CAST(N'2024-11-25T16:33:25.9249328' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (20, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 10007, CAST(N'2024-11-25T16:35:30.8809520' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (21, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 10010, CAST(N'2024-11-25T16:39:17.2265454' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (23, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 10005, CAST(N'2024-11-25T16:51:11.8305517' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (24, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 10003, CAST(N'2024-11-25T20:35:07.0260823' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (25, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 3, 10002, CAST(N'2024-11-30T13:27:18.5896659' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (26, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 4, 10005, CAST(N'2024-12-01T15:16:15.5804774' AS DateTime2))
INSERT [dbo].[WishListTbl] ([WishListID], [WishListDate], [UserID], [ProductID], [AddedDate]) VALUES (27, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 5, 10005, CAST(N'2024-12-02T10:26:48.1579987' AS DateTime2))
SET IDENTITY_INSERT [dbo].[WishListTbl] OFF
GO
/****** Object:  Index [IX_CartTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_CartTbl_ProductID] ON [dbo].[CartTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartTbl_UserID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_CartTbl_UserID] ON [dbo].[CartTbl]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CategoryTbl_MainCategoryID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_CategoryTbl_MainCategoryID] ON [dbo].[CategoryTbl]
(
	[MainCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CityTbl_StateID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_CityTbl_StateID] ON [dbo].[CityTbl]
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ComplaintRefundTbl_UserOrderComplaintSolutionID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ComplaintRefundTbl_UserOrderComplaintSolutionID] ON [dbo].[ComplaintRefundTbl]
(
	[UserOrderComplaintSolutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDispatchTbl_DispatchAgencyID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDispatchTbl_DispatchAgencyID] ON [dbo].[OrderDispatchTbl]
(
	[DispatchAgencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDispatchTbl_UserOrderID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDispatchTbl_UserOrderID] ON [dbo].[OrderDispatchTbl]
(
	[UserOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductDiscountTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductDiscountTbl_ProductID] ON [dbo].[ProductDiscountTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductPhotoTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductPhotoTbl_ProductID] ON [dbo].[ProductPhotoTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductReviewTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductReviewTbl_ProductID] ON [dbo].[ProductReviewTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductReviewTbl_UserID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductReviewTbl_UserID] ON [dbo].[ProductReviewTbl]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductTbl_CategoryID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductTbl_CategoryID] ON [dbo].[ProductTbl]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductTbl_TraderFarmerID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductTbl_TraderFarmerID] ON [dbo].[ProductTbl]
(
	[TraderFarmerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductTbl_UnitID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_ProductTbl_UnitID] ON [dbo].[ProductTbl]
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StateTbl_CountryID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_StateTbl_CountryID] ON [dbo].[StateTbl]
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TraderFarmerTbl_CityID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_TraderFarmerTbl_CityID] ON [dbo].[TraderFarmerTbl]
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderComplaintSolutionTbl_UserOrderComplaintID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderComplaintSolutionTbl_UserOrderComplaintID] ON [dbo].[UserOrderComplaintSolutionTbl]
(
	[UserOrderComplaintID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderComplaintTbl_UserOrderID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderComplaintTbl_UserOrderID] ON [dbo].[UserOrderComplaintTbl]
(
	[UserOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderDetTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderDetTbl_ProductID] ON [dbo].[UserOrderDetTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderDetTbl_UserOrderID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderDetTbl_UserOrderID] ON [dbo].[UserOrderDetTbl]
(
	[UserOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderPaymentTbl_UserOrderID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderPaymentTbl_UserOrderID] ON [dbo].[UserOrderPaymentTbl]
(
	[UserOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserOrderTbl_UserID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_UserOrderTbl_UserID] ON [dbo].[UserOrderTbl]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_CityID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_Users_CityID] ON [dbo].[Users]
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_WishListTbl_ProductID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_WishListTbl_ProductID] ON [dbo].[WishListTbl]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_WishListTbl_UserID]    Script Date: 11-12-24 13:24:49 ******/
CREATE NONCLUSTERED INDEX [IX_WishListTbl_UserID] ON [dbo].[WishListTbl]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductTbl] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [TraderFarmerID]
GO
ALTER TABLE [dbo].[CartTbl]  WITH CHECK ADD  CONSTRAINT [FK_CartTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[CartTbl] CHECK CONSTRAINT [FK_CartTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[CartTbl]  WITH CHECK ADD  CONSTRAINT [FK_CartTbl_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[CartTbl] CHECK CONSTRAINT [FK_CartTbl_Users_UserID]
GO
ALTER TABLE [dbo].[CategoryTbl]  WITH CHECK ADD  CONSTRAINT [FK_CategoryTbl_MainCategoryTbl_MainCategoryID] FOREIGN KEY([MainCategoryID])
REFERENCES [dbo].[MainCategoryTbl] ([MainCategoryID])
GO
ALTER TABLE [dbo].[CategoryTbl] CHECK CONSTRAINT [FK_CategoryTbl_MainCategoryTbl_MainCategoryID]
GO
ALTER TABLE [dbo].[CityTbl]  WITH CHECK ADD  CONSTRAINT [FK_CityTbl_StateTbl_StateID] FOREIGN KEY([StateID])
REFERENCES [dbo].[StateTbl] ([StateID])
GO
ALTER TABLE [dbo].[CityTbl] CHECK CONSTRAINT [FK_CityTbl_StateTbl_StateID]
GO
ALTER TABLE [dbo].[ComplaintRefundTbl]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintRefundTbl_UserOrderComplaintSolutionTbl_UserOrderComplaintSolutionID] FOREIGN KEY([UserOrderComplaintSolutionID])
REFERENCES [dbo].[UserOrderComplaintSolutionTbl] ([UserOrderComplaintSolutionID])
GO
ALTER TABLE [dbo].[ComplaintRefundTbl] CHECK CONSTRAINT [FK_ComplaintRefundTbl_UserOrderComplaintSolutionTbl_UserOrderComplaintSolutionID]
GO
ALTER TABLE [dbo].[OrderDispatchTbl]  WITH CHECK ADD  CONSTRAINT [FK_OrderDispatchTbl_DispatchAgencyTbl_DispatchAgencyID] FOREIGN KEY([DispatchAgencyID])
REFERENCES [dbo].[DispatchAgencyTbl] ([DispatchAgencyID])
GO
ALTER TABLE [dbo].[OrderDispatchTbl] CHECK CONSTRAINT [FK_OrderDispatchTbl_DispatchAgencyTbl_DispatchAgencyID]
GO
ALTER TABLE [dbo].[OrderDispatchTbl]  WITH CHECK ADD  CONSTRAINT [FK_OrderDispatchTbl_UserOrderTbl_UserOrderID] FOREIGN KEY([UserOrderID])
REFERENCES [dbo].[UserOrderTbl] ([UserOrderID])
GO
ALTER TABLE [dbo].[OrderDispatchTbl] CHECK CONSTRAINT [FK_OrderDispatchTbl_UserOrderTbl_UserOrderID]
GO
ALTER TABLE [dbo].[ProductDiscountTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductDiscountTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[ProductDiscountTbl] CHECK CONSTRAINT [FK_ProductDiscountTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[ProductPhotoTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductPhotoTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[ProductPhotoTbl] CHECK CONSTRAINT [FK_ProductPhotoTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[ProductReviewTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductReviewTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[ProductReviewTbl] CHECK CONSTRAINT [FK_ProductReviewTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[ProductReviewTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductReviewTbl_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ProductReviewTbl] CHECK CONSTRAINT [FK_ProductReviewTbl_Users_UserID]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_CategoryTbl_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CategoryTbl] ([CategoryID])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_CategoryTbl_CategoryID]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_TraderFarmerTbl_TraderFarmerID] FOREIGN KEY([TraderFarmerID])
REFERENCES [dbo].[TraderFarmerTbl] ([TraderFarmerID])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_TraderFarmerTbl_TraderFarmerID]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_UnitTbl_UnitID] FOREIGN KEY([UnitID])
REFERENCES [dbo].[UnitTbl] ([UnitID])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_UnitTbl_UnitID]
GO
ALTER TABLE [dbo].[StateTbl]  WITH CHECK ADD  CONSTRAINT [FK_StateTbl_CountryTbl_CountryID] FOREIGN KEY([CountryID])
REFERENCES [dbo].[CountryTbl] ([CountryID])
GO
ALTER TABLE [dbo].[StateTbl] CHECK CONSTRAINT [FK_StateTbl_CountryTbl_CountryID]
GO
ALTER TABLE [dbo].[TraderFarmerTbl]  WITH CHECK ADD  CONSTRAINT [FK_TraderFarmerTbl_CityTbl_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTbl] ([CityID])
GO
ALTER TABLE [dbo].[TraderFarmerTbl] CHECK CONSTRAINT [FK_TraderFarmerTbl_CityTbl_CityID]
GO
ALTER TABLE [dbo].[UserOrderComplaintSolutionTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderComplaintSolutionTbl_UserOrderComplaintTbl_UserOrderComplaintID] FOREIGN KEY([UserOrderComplaintID])
REFERENCES [dbo].[UserOrderComplaintTbl] ([UserOrderComplaintID])
GO
ALTER TABLE [dbo].[UserOrderComplaintSolutionTbl] CHECK CONSTRAINT [FK_UserOrderComplaintSolutionTbl_UserOrderComplaintTbl_UserOrderComplaintID]
GO
ALTER TABLE [dbo].[UserOrderComplaintTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderComplaintTbl_UserOrderTbl_UserOrderID] FOREIGN KEY([UserOrderID])
REFERENCES [dbo].[UserOrderTbl] ([UserOrderID])
GO
ALTER TABLE [dbo].[UserOrderComplaintTbl] CHECK CONSTRAINT [FK_UserOrderComplaintTbl_UserOrderTbl_UserOrderID]
GO
ALTER TABLE [dbo].[UserOrderDetTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderDetTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[UserOrderDetTbl] CHECK CONSTRAINT [FK_UserOrderDetTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[UserOrderDetTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderDetTbl_UserOrderTbl_UserOrderID] FOREIGN KEY([UserOrderID])
REFERENCES [dbo].[UserOrderTbl] ([UserOrderID])
GO
ALTER TABLE [dbo].[UserOrderDetTbl] CHECK CONSTRAINT [FK_UserOrderDetTbl_UserOrderTbl_UserOrderID]
GO
ALTER TABLE [dbo].[UserOrderPaymentTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderPaymentTbl_UserOrderTbl_UserOrderID] FOREIGN KEY([UserOrderID])
REFERENCES [dbo].[UserOrderTbl] ([UserOrderID])
GO
ALTER TABLE [dbo].[UserOrderPaymentTbl] CHECK CONSTRAINT [FK_UserOrderPaymentTbl_UserOrderTbl_UserOrderID]
GO
ALTER TABLE [dbo].[UserOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserOrderTbl_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[UserOrderTbl] CHECK CONSTRAINT [FK_UserOrderTbl_Users_UserID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_CityTbl_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTbl] ([CityID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_CityTbl_CityID]
GO
ALTER TABLE [dbo].[WishListTbl]  WITH CHECK ADD  CONSTRAINT [FK_WishListTbl_ProductTbl_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[WishListTbl] CHECK CONSTRAINT [FK_WishListTbl_ProductTbl_ProductID]
GO
ALTER TABLE [dbo].[WishListTbl]  WITH CHECK ADD  CONSTRAINT [FK_WishListTbl_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[WishListTbl] CHECK CONSTRAINT [FK_WishListTbl_Users_UserID]
GO
