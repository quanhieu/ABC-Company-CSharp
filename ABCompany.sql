CREATE DATABASE ABCompany 
USE ABCompany


/****** Object:  Table [dbo].[db_OrderDetail]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_OrderDetail](
	[ProductID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[QuantityOrder] [int] NULL,
	[PriceOrder] [float] NULL,
 CONSTRAINT [PK_db_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[db_Registration]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_Registration](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[EmailRe] [varchar](50) NULL,
	[AddressRe] [nvarchar](100) NULL,
	[FullName] [nvarchar](50) NULL,
	[SecurityQuestion] [nvarchar](100) NULL,
	[DOB] [date] NULL,
	[SexRe] [nchar](10) NULL,
	[LoginID] [int] NULL,
 CONSTRAINT [PK_db_Registration] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_Category]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Avatar] [nvarchar](100) NULL,
	[NumOrder] [int] NULL,
	[CategoryIDFar] [int] NULL,
 CONSTRAINT [PK_db_Category] PRIMARY KEY CLUSTERED 
( 
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_CategoryNews]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_CategoryNews](
	[NewsCode] [int] IDENTITY(1,1) NOT NULL,
	[NewsName] [nvarchar](100) NULL,
	[Avatar] [nvarchar](100) NULL,
	[NumOrder] [int] NULL,
	[NewsCodeFar] [int] NOT NULL,
 CONSTRAINT [PK_CategoryNews] PRIMARY KEY CLUSTERED 
( 
	[NewsCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_Order]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [datetime] NULL,
	[OrderMoney] [float] NULL,
	[OrderPay] [nvarchar](300) NULL,
	[CustomerID] [int] NULL,
	[CustomerNA] [nvarchar](50) NULL,
	[CallNumCUS] [varchar](15) NULL,
	[EmailCUS] [varchar](50) NULL,
	[OrderDetail] [nvarchar](300) NULL,    /**********************************************************************************************************/
 CONSTRAINT [PK_db_Order] PRIMARY KEY CLUSTERED 
( 
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[db_Customer]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerNa] [nvarchar](50) NULL,
	[AddressCus] [nvarchar](100) NULL,
	[CallNumCUS] [varchar](15) NULL,
	[EmailCUS] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_db_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[db_Status]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_Status](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_db_Status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_Menu]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](50) NULL,
	[Link] [varchar](200) NULL,
	[MenuIDFar] [int] NULL,
	[NumOrderMenu] [int] NULL,
 CONSTRAINT [PK_db_Menu] PRIMARY KEY CLUSTERED 
( 
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[db_GroupAds]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_GroupAds](
	[GroupAdsID] [int] IDENTITY(1,1) NOT NULL,
	[GroupAdsName] [nvarchar](50) NULL,
	[LocationGA] [nvarchar](30) NULL,
	[NumOrderGA] [int] NULL,
	[AvatarGA] [nvarchar](100) NULL,
 CONSTRAINT [PK_db_GroupAds] PRIMARY KEY CLUSTERED 
( 
	[GroupAdsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_GroupProduct ]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_GroupProduct ](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](100) NULL,
	[Avatar] [nvarchar](100) NULL,
	[NumOrder] [int] NULL,
	[NumShow] [int] NULL,
 CONSTRAINT [PK_db_GroupProduct ] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[db_Ads]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_Ads](
	[AdsID] [int] IDENTITY(1,1) NOT NULL,
	[AdsName] [nvarchar](50) NULL,
	[TypeAds] [nvarchar](20) NULL,
	[ImageAds] [nvarchar](100) NULL,
	[Link] [nchar](100) NULL,
	[NumOrderAds] [int] NULL,
	[GroupAdsID] [int] NULL,
 CONSTRAINT [PK_db_Ads] PRIMARY KEY CLUSTERED 
( 
	[AdsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_LoginAccess]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_LoginAccess](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [varchar](10) NULL,
 CONSTRAINT [PK_db_LoginAccess] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_Products]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[StatusID] [int] NULL,
	[SupplyID] [int] NULL,
	[ImageP] [nvarchar](100) NULL,
	[QuantityP] [int] NULL,
	[PriceP] [float] NULL,
	[DescribeP] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[DateCancel] [datetime] NULL,
	[CategoryID] [int] NULL,
	[GroupID] [int] NULL,
 CONSTRAINT [PK_db_Products] PRIMARY KEY CLUSTERED 
( 
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_Supply]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_Supply](
	[SupplyID] [int] IDENTITY(1,1) NOT NULL,
	[SupplyName] [varchar](10) NULL,
 CONSTRAINT [PK_db_Supply] PRIMARY KEY CLUSTERED 
(
	[SupplyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_News]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_News](
	[NewsID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Avatar] [nvarchar](200) NULL,
	[Describe] [nvarchar](200) NULL,
	[PostDate] [datetime] NULL,
	[View] [int] NULL,
	[Detail] [nvarchar](max) NULL,
	[NumOrder] [int] NULL,
	[NewsCode] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


SET IDENTITY_INSERT [dbo].[db_Ads] OFF
ALTER TABLE [dbo].[db_OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_db_ChiTietDonDatHang_db_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[db_Order] ([OrderID])
GO
ALTER TABLE [dbo].[db_OrderDetail] CHECK CONSTRAINT [FK_db_OrderDetail_db_Order]
GO
ALTER TABLE [dbo].[db_OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_db_OrderDetail_db_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[db_Products] ([ProductID])
GO
ALTER TABLE [dbo].[db_OrderDetail] CHECK CONSTRAINT [FK_db_OrderDetail_db_Products]
GO

ALTER TABLE [dbo].[db_Registration]  WITH CHECK ADD  CONSTRAINT [FK_db_Registration_db_LoginAccess] FOREIGN KEY([LoginID])
REFERENCES [dbo].[db_LoginAccess] ([LoginID])
GO
ALTER TABLE [dbo].[db_Registration] CHECK CONSTRAINT [FK_db_Registration_db_LoginAccess]
GO
ALTER TABLE [dbo].[db_Order]  WITH CHECK ADD  CONSTRAINT [FK_db_Order_db_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[db_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[db_Order] CHECK CONSTRAINT [FK_db_Order_db_Customer]
GO

ALTER TABLE [dbo].[db_Ads]  WITH CHECK ADD  CONSTRAINT [FK_db_Ads_db_GroupAds] FOREIGN KEY([GroupAdsID])
REFERENCES [dbo].[db_GroupAds] ([GroupAdsID])
GO
ALTER TABLE [dbo].[db_Ads] CHECK CONSTRAINT [FK_db_Ads_db_GroupAds]
GO

ALTER TABLE [dbo].[db_Products]  WITH CHECK ADD  CONSTRAINT [FK_db_Products_db_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[db_Category] ([CategoryID])
GO
ALTER TABLE [dbo].[db_Products] CHECK CONSTRAINT [FK_db_Products_db_Category]
GO
ALTER TABLE [dbo].[db_Products]  WITH CHECK ADD  CONSTRAINT [FK_db_Products_db_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[db_Status] ([StatusID])
GO
ALTER TABLE [dbo].[db_Products] CHECK CONSTRAINT [FK_db_Products_db_Status]
GO
ALTER TABLE [dbo].[db_Products]  WITH CHECK ADD  CONSTRAINT [FK_db_Products_db_GroupProduct ] FOREIGN KEY([GroupID])
REFERENCES [dbo].[db_GroupProduct ] ([GroupID])
GO
ALTER TABLE [dbo].[db_Products] CHECK CONSTRAINT [FK_db_Products_db_GroupProduct ]
GO
ALTER TABLE [dbo].[db_Products]  WITH CHECK ADD  CONSTRAINT [FK_db_Products_db_Supply] FOREIGN KEY([SupplyID])
REFERENCES [dbo].[db_Supply] ([SupplyID])
GO
ALTER TABLE [dbo].[db_Products] CHECK CONSTRAINT [FK_db_Products_db_Supply]
GO
ALTER TABLE [dbo].[db_News]  WITH CHECK ADD  CONSTRAINT [FK_News_CategoryNews] FOREIGN KEY([NewsCode])
REFERENCES [dbo].[db_CategoryNews] ([NewsCode])
GO
ALTER TABLE [dbo].[db_News] CHECK CONSTRAINT [FK_News_CategoryNews]
GO




/*===============================================================================================================================================*/
/****** Object:  StoredProcedure [dbo].[CapNhatLuotXemTinTuc]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateNewsView]
@id int
as
update db_News set Views=Views+1 where NewsID=@id
GO

/****** Object:  StoredProcedure [dbo].[chitietdondathang_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderDetail_delete]
@productid int,
@orderid int
AS
BEGIN
	delete db_OrderDetail where ProductID=@productid and OrderID=@orderid
END


GO
/****** Object:  StoredProcedure [dbo].[chitietdondathang_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orderdetail_inser]
@productid int,
@orderid int,
@quantityorder int,
@priceorder float,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from dbo.db_OrderDetail where @productid=ProductID and @orderid=OrderID))
	begin
	insert into db_OrderDetail(ProductID,OrderID,QuantityOrder,PriceOrder) values(@productid,@orderid,@quantityorder,@priceorder)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[chitietdondathang_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderDetail_update]
@productid int,
@orderid int,
@quantityorder int,
@priceorder float
AS
BEGIN
	update db_OrderDetail set QuantityOrder=@quantityorder,PriceOrder=@priceorder where ProductID=@productid and OrderID=@orderid
END


GO

/****** Object:  StoredProcedure [dbo].[dangky_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registration_delete]
@username varchar(50)
AS
BEGIN
	delete from dbo.db_Registration where UserName=@username
END


GO
/****** Object:  StoredProcedure [dbo].[dangky_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registration_inser]
@username varchar(50),
@password varchar(50) ,
@emailre varchar(50),
@addressre nvarchar(50),
@fullname nvarchar(50),
@securityquestion nvarchar(100),
@dob date,
@sexre nvarchar(10),
@loginid int,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Registration where @username=UserName))
	begin
	insert into db_Registration(UserName,Password,EmailRe,AddressRe,FullName,SecurityQuestion,DOB,SexRe,LoginID) values(@username,@password,@emailre,@addressre,@fullname,@securityquestion,@dob,@sexre,@loginid)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[dangky_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registration_update]
@username varchar(50),
@password varchar(50) ,
@emailre varchar(50),
@addressre nvarchar(50),
@fullname nvarchar(50),
@securityquestion nvarchar(100),
@dob date,
@sexre nvarchar(10),
@loginid int
AS
BEGIN
	update dbo.db_Registration set Password=@password,EmailRe=@emailre,AddressRe=@addressre,FullName=@fullname,SecurityQuestion=@securityquestion,DOB=@dob,SexRe=@sexre,LoginID=@loginid where UserName=@username
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuc_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_delete]
@categoryid int
AS
BEGIN
	delete from db_Category where CategoryID=@categoryid
	delete from db_Products where CategoryID=@categoryid
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuc_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_inser]
@categoryname nvarchar(50),
@avatar nvarchar(100),
@numorder int,
@categoryidfar int,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Category where @categoryname=CategoryName))
	begin
	insert into db_Category( CategoryName,Avatar,NumOrder,CategoryIDFar) values(@categoryname,@avatar,@numorder,@categoryidfar)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuc_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Category_update]
@categoryid int,
@categoryname nvarchar(50),
@avatar nvarchar(100),
@numorder int,
@categoryidfar int
AS
BEGIN
	update db_Category set CategoryName=@categoryname,Avatar=@avatar,NumOrder=@numorder,CategoryIDFar=@categoryidfar where CategoryID=@categoryid
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuctin_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[CategoryNews_delete]
@newscode int
AS
BEGIN
	delete from db_CategoryNews where NewsCode=@newscode
	delete from dbo.db_News where NewsCode=@newscode
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuctin_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CategoryNews_inser]
@categoryname nvarchar(50),
@avatar nvarchar(100),
@numorder int,
@categoryidfar int,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from dbo.db_Category where @categoryname=CategoryName))
	begin
	insert into db_CategoryNews(NewsName,Avatar,NumOrder,NewsCodeFar) values(@categoryname,@avatar,@numorder,@categoryidfar)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[danhmuctin_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[CategoryNews_update]
@newscode int,
@newsname nvarchar(50),
@avatar nvarchar(100),
@numorder int,
@newscodefar int
AS
BEGIN
	update db_CategoryNews set NewsName=@newsname,Avatar=@avatar,NumOrder=@numorder,NewsCodeFar=@newscodefar where NewsCode=@newscode
END


GO
/****** Object:  StoredProcedure [dbo].[dondathang_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Order_delete]
@orderID int
AS
BEGIN
	delete from db_OrderDetail where OrderID=@orderID
	delete from db_Order where OrderID=@orderID
END


GO
/****** Object:  StoredProcedure [dbo].[dondathang_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Order_inser]
@datecreated datetime,
@ordermoney float,
@orderpay nvarchar(300),
@customerid int,
@customerna nvarchar(50),
@callnumcus varchar(15),
@emailcus varchar(50),
@orderdetail  nvarchar(300),
@ret int out
AS
BEGIN
	set @ret=1
	begin
	insert into db_Order(DateCreated,OrderMoney,OrderPay,CustomerID,CustomerNA,CallNumCUS,EmailCUS, OrderDetail) values(@datecreated,@ordermoney,@orderpay,@customerid,@customerna,@callnumcus,@emailcus, @orderdetail)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[dondathang_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Order_update]
@orderid int,
@datecreated datetime,
@ordermoney float,
@orderpay nvarchar(300),
@customerid int,
@customerna nvarchar(50),
@callnumcus varchar(15),
@emailcus varchar(50),
@orderdetail NVARCHAR(300)
AS
BEGIN
	update db_Order set DateCreated=@datecreated,OrderMoney=@ordermoney,OrderPay=@orderpay,CustomerID=@customerid,CustomerNA=@customerna,CallNumCUS=@callnumcus,EmailCUS=@emailcus, OrderDetail=@orderdetail  where OrderID=@orderid
END


GO

/****** Object:  StoredProcedure [dbo].[khachang_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_delete]
@customerid int
AS
BEGIN
	delete from db_Customer where CustomerID=@customerid
END


GO
/****** Object:  StoredProcedure [dbo].[khachang_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_inser]
@customerna nvarchar(50),
@addresscus nvarchar(100),
@callNumcus varchar(15),
@emailcus varchar(50),
@password nvarchar(50),
@ret int out
AS
BEGIN
	set @ret=1
	begin
	insert into db_Customer(CustomerNa,AddressCus,CallNumCUS,EmailCUS,Password) values(@customerna,@addresscus,@callNumcus,@emailcus,@password)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[khachang_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Customer_update]
@customerid int,
@customerna nvarchar(50),
@addresscus nvarchar(100),
@callNumcus varchar(15),
@emailcus varchar(50),
@password nvarchar(50)
AS
BEGIN
	update db_Customer set CustomerNa=@customerna,AddressCus=@addresscus,CallNumCUS=@callNumcus,EmailCUS=@emailcus, Password=@password where CustomerID=@customerid
END


GO

/****** Object:  StoredProcedure [dbo].[mau_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Status_delete]
@statusid int
AS
BEGIN
	delete from db_Status where StatusID=@statusid
END


GO
/****** Object:  StoredProcedure [dbo].[mau_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Status_inser]
@statusname nvarchar(50),
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Status where @statusname=StatusName))
	begin
	insert into db_Status(StatusName) values(@statusname)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[mau_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Status_update]
@statusid int,
@statusname nvarchar(50)
AS
BEGIN
	update db_Status set StatusName=@statusname where StatusID=@statusid
END


GO
/****** Object:  StoredProcedure [dbo].[menu_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[menu_delete]
@menuid int
AS
BEGIN
	delete from db_Menu where MenuID=@menuid
END


GO
/****** Object:  StoredProcedure [dbo].[menu_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[menu_inser]
@menuname nvarchar(50),
@link varchar(200),
@menuidfar int,
@numordermenu INT,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Menu where @menuname=MenuName))
	begin
	insert into db_Menu(MenuName,Link,MenuIDFar,NumOrderMenu) values(@menuname,@link,@menuidfar,@numordermenu)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[menu_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[menu_update]
@menuid int,
@menuname nvarchar(50),
@link varchar(200),
@menuidfar int,
@numordermenu int
AS
BEGIN
	update db_Menu set MenuName=@menuname,Link=@link,MenuIDFar=@menuidfar,NumOrderMenu=@numordermenu where MenuID=@menuid
END


GO

/****** Object:  StoredProcedure [dbo].[nhomquangcao_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupAds_delete]
@groupadsid int
AS
BEGIN
	delete from db_GroupAds where GroupAdsID=@groupadsid
END


GO
/****** Object:  StoredProcedure [dbo].[nhomquangcao_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupAds_inser]
@groupadsname nvarchar(50),
@locationga nvarchar(30),
@numorderga int,
@avatarga nvarchar(100),
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_GroupAds where @groupadsname=GroupAdsName))
	begin
	insert into db_GroupAds(GroupAdsName,LocationGA,NumOrderGA,AvatarGA) values(@groupadsname,@locationga,@numorderga,@avatarga)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[nhomquangcao_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupAds_update]
@groupadsid int,
@groupadsname nvarchar(50),
@locationga nvarchar(30),
@numorderga int,
@avatarga nvarchar(100)
AS
BEGIN
	update db_GroupAds set GroupAdsName=@groupadsname,LocationGA=@locationga,NumOrderGA=@numorderga,AvatarGA=@avatarga where GroupAdsID=@groupadsid
END


GO
/****** Object:  StoredProcedure [dbo].[nhomsanpham_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupProduct_delete]
@groupid int
AS
BEGIN
	delete from db_GroupProduct  where GroupID=@groupid
END


GO
/****** Object:  StoredProcedure [dbo].[nhomsanpham_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupProduct_inser]
@groupname nvarchar(100),
@avatar nvarchar(100),
@numorder int,
@numshow INT,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_GroupProduct where GroupName=@groupname))
	begin
	insert into db_GroupProduct(GroupName,Avatar,NumOrder,NumShow) values(@groupname,@avatar,@numorder,@numshow)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[nhomsanpham_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GroupProduct_update]
@groupid int,
@groupname nvarchar(100),
@avatar nvarchar(100),
@numorder int,
@numshow INT
AS
BEGIN
	update db_GroupProduct set GroupName=@groupname,Avatar=@avatar,NumOrder=@numorder,NumShow=@numshow where GroupID=@groupid
END


GO

/****** Object:  StoredProcedure [dbo].[quangcao_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ads_delete]
@adsid int
AS
BEGIN
	delete from db_Ads where AdsID=@adsid
END


GO
/****** Object:  StoredProcedure [dbo].[quangcao_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ads_inser]
@adsname nvarchar(50),
@typeads nvarchar(20),
@imageads nvarchar(100),
@link nchar(100),
@numorderads int,
@groupadsid INT,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Ads where @adsname=AdsName))
	begin
	insert into db_Ads(AdsName,TypeAds,ImageAds,Link,NumOrderAds,GroupAdsID) values(@typeads,@typeads,@imageads,@link,@numorderads,@groupadsid)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[quangcao_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ads_update]
@adsid int,
@adsname nvarchar(50),
@typeads nvarchar(20),
@imageads nvarchar(100),
@link nchar(100),
@numorderads int,
@groupadsid int
AS
BEGIN
	update db_Ads set AdsName=@adsname,TypeAds=@typeads,ImageAds=@imageads,Link=@link,NumOrderAds=@numorderads,GroupAdsID=@groupadsid where AdsID=@adsid
END


GO












/*-------------------------------------------------------------------------------------------------------------------------------------------------------------*/
/****** Object:  StoredProcedure [dbo].[quyendangnhap_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginAccess_delete]
@loginid int
AS
BEGIN
	delete from db_LoginAccess where LoginID=@loginid
END


GO
/****** Object:  StoredProcedure [dbo].[quyendangnhap_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginAccess_inser]
@loginname varchar(10),
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_LoginAccess where @loginname=LoginName))
	begin
	insert into db_LoginAccess(LoginName) values(@loginname)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[quyendangnhap_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginAccess_update]
@loginid int,
@loginname varchar(100)
AS
BEGIN
	update db_LoginAccess set LoginName=@loginname where LoginID=@loginid
END


GO
/****** Object:  StoredProcedure [dbo].[sanpham_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_delete]
@productid int
AS
BEGIN
	delete from db_Products where ProductID=@productid
END


GO
/****** Object:  StoredProcedure [dbo].[sanpham_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_inser]
@productname nvarchar(100),
@statusid int,
@supplyid int,
@imagep nvarchar(100),
@quantityp int,
@pricep float,
@describep nvarchar(MAX),
@datecreated datetime,
@datecancel datetime,
@categoryid int,
@groupid int,
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Products where @productname=ProductName))
	begin
	insert into db_Products(ProductName,StatusID,SupplyID,ImageP,QuantityP,PriceP,DescribeP,DateCreated,DateCancel,CategoryID,GroupID) 
															VALUES(@productname,@statusid,@supplyid,@imagep,@quantityp,@pricep,@describep,@datecreated,@datecancel,@categoryid,@groupid)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[sanpham_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Products_update]
@productid int,
@productname nvarchar(100),
@statusid int,
@supplyid int,
@imagep nvarchar(100),
@quantityp int,
@pricep float,
@describep nvarchar(MAX),
@datecreated datetime,
@datecancel datetime,
@categoryid int,
@groupid int
AS
BEGIN
	update db_Products set ProductName=@productname,StatusID=@statusid,SupplyID=@supplyid,ImageP=@imagep,QuantityP=@quantityp,PriceP=@pricep,DescribeP=@describep,DateCreated=@datecreated,DateCancel=@datecancel,CategoryID=@categoryid,GroupID=@groupid where ProductID=@productid
END


GO
/****** Object:  StoredProcedure [dbo].[size_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Supply_delete]
@supplyid int
AS
BEGIN
	delete from db_Supply where SupplyID=@supplyid
END


GO
/****** Object:  StoredProcedure [dbo].[size_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Supply_inser]
@supplyname varchar(10),
@ret int out
AS
BEGIN
	set @ret=1
	if(not exists(select * from db_Supply where @supplyname=SupplyName ))
	begin
	insert into db_Supply(SupplyName) values(@supplyname)
	set @ret=2
	end
END


GO
/****** Object:  StoredProcedure [dbo].[size_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Supply_update]
@supplyid int,
@supplyname varchar(10)
AS
BEGIN
	update db_Supply set SupplyName=@supplyname where SupplyID=@supplyid
END


GO

/****** Object:  StoredProcedure [dbo].[thongtin_chitietdondathang]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_OrderDetail]
AS
BEGIN
	select * from db_OrderDetail
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_chitietdondathang_by_madondathang]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_OrderDetail_by_Orderid]
(
@orderid int
)
AS
BEGIN
	select * from db_OrderDetail where OrderID=@orderid
END


GO

/****** Object:  StoredProcedure [dbo].[thongtin_dangky]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Registration]
AS
BEGIN
	select * from db_Registration
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dangky_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Registration_by_id]
@username varchar(50)
AS
BEGIN
	select * from db_Registration where UserName=@username
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dangky_by_id_matkhau]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Registration_by_id_Password]
@username varchar(50),
@password varchar(50)
AS
BEGIN
	select * from db_Registration where UserName=@username and Password=@password
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dangky_by_tendangnhap]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Registration_by_UserName]
@username VARCHAR(50)
AS
BEGIN
	select * from db_Registration WHERE UserName=@username
END
GO
/****** Object:  StoredProcedure [dbo].[thongtin_dangky_by_tendangnhap_matkhau]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[info_Registration_by_UserName_Password]
@username VARCHAR(50),
@password VARCHAR(50)
AS
BEGIN
	select * from db_Registration WHERE UserName=@username AND Password=@password
END
GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuc]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Category]
AS
BEGIN
	select * from db_Category order by NumOrder
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuc_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure  [dbo].[info_Category_by_id]
(
@categoryid INT
)
AS
BEGIN
	select * from db_Category where CategoryID=@categoryid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuc_by_MaDMCha]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure  [dbo].[info_Category_by_CategoryIDFar]
(
@categoryidfar INT
)
AS
BEGIN
	select * from db_Category where CategoryIDFar=@categoryidfar
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuctin]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_CategoryNews]
AS
BEGIN
	select * from db_CategoryNews order by NumOrder
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuctin_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure  [dbo].[info_CategoryNews_by_id]
(
@NewsCode INT
)
AS
BEGIN
	select * from db_CategoryNews where NewsCode=@NewsCode
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_danhmuctin_by_MaDMCha]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure  [dbo].[info_CategoryNews_by_NewsCodeFar]
(
@newscodefar INT
)
AS
BEGIN
	select * from db_CategoryNews where NewsCodeFar=@newscodefar
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dondathang]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Order]
AS
BEGIN
	select * from db_Order
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dondathang_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Order_by_id]
@orderid int
AS
BEGIN
	select * from db_Order where OrderID=@orderid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_dondathang_by_mathanhtoan]    Script Date: 4/15/2018 1:46:05 AM ******/
/**************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Order_by_OrderPay]
@orderpay nvarchar(300)
AS
BEGIN
	select * from db_Order where OrderPay=@orderpay
END


GO

/****** Object:  StoredProcedure [dbo].[thongtin_dondathang_desc]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[info_Order_desc]
AS
BEGIN
	select * from db_Order order by OrderID desc
END


GO

/****** Object:  StoredProcedure [dbo].[thongtin_khachhang]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Customer]
AS
BEGIN
	select * from db_Customer
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_khachhang_by_emailkh]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Customer_by_EmailCUS]
@emailcus nvarchar(50)
AS
BEGIN
	select * from db_Customer where EmailCUS=@emailcus
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_khachhang_by_emailkh_matkhau]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Customer_by_EmailCUS_Password]
@emailcus nvarchar(50),
@password nvarchar(50)
AS
BEGIN
	select * from db_Customer where EmailCUS=@emailcus and Password=@password
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_khachhang_by_makh]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Customer_by_CustomerID]
@customerid nvarchar(50)
AS
BEGIN
	select * from db_Customer where CustomerID=@customerid
END
GO


/****** Object:  StoredProcedure [dbo].[thongtin_mau]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Status]
AS
BEGIN
	select * from db_Status
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_mau_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Statusu_by_id]
@StatusID INT
AS
BEGIN
	select * from db_Status where StatusID=@StatusID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_menu]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_menu]
AS
BEGIN
	select * from db_Menu
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_menu_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_menu_by_id]
@menuid int
AS
BEGIN
	select * from db_Menu where MenuID=@menuid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_menu_by_mamenucha]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_menu_by_@MenuIDFar]
@MenuIDFar int
AS
BEGIN
	select * from db_Menu where MenuIDFar=@MenuIDFar
END


GO

/****** Object:  StoredProcedure [dbo].[thongtin_nhomquangcao]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_GroupAds]
AS
BEGIN
	select * from db_GroupAds
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_nhomquangcao_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_GroupAds_by_id]
@groupadsid int
AS
BEGIN
	select * from db_GroupAds where GroupAdsID=@groupadsid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_nhomquangcao_by_vitriqc]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_GroupAds_by_LocationGA]
@locationga nvarchar(30)
AS
BEGIN
	select * from db_GroupAds where LocationGA=@locationga
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_nhomsp]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_GroupProduct]
AS
BEGIN
	select * from db_GroupProduct order by NumOrder
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_nhomsp_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_GroupProduct_by_id]
@groupid int
AS
BEGIN
	select * from db_GroupProduct where GroupID=@groupid
END


GO


/****** Object:  StoredProcedure [dbo].[thongtin_quangcao]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Ads]
AS
BEGIN
	select * from db_Ads
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_quangcao_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Ads_by_id]
@adsid int
AS
BEGIN
	select * from db_Ads where AdsID=@adsid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_quangcao_by_nhomquangcaoid]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Ads_by_GroupAdsID]
@groupadsid int
AS
BEGIN
	select * from db_Ads where GroupAdsID=@groupadsid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_quyendangnhap]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[info_LoginAccess]
AS
BEGIN
	select * from db_LoginAccess
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_quyendangnhap_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_LoginAccess_by_id]
@loginid int
AS
BEGIN
	select * from db_LoginAccess where LoginID=@loginid
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Products]
AS
BEGIN
	select * from db_Products
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Products_by_id]
@ProductID INT
AS
BEGIN
	select * from db_Products where ProductID=@ProductID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_madm]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Products_by_CategoryID]
@CategoryID INT
AS
BEGIN
	select top 3 * from db_Products where CategoryID=@CategoryID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_madm_tatca]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Products_by_CategoryID_all]
@CategoryID INT
AS
BEGIN
	select * from db_Products where CategoryID=@CategoryID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_nhomid]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Products_by_GroupID]
@GroupID INT,
@NumShow INT
AS
BEGIN
	declare @sql nvarchar(300)
	set @sql='select top '+ CAST(@NumShow as varchar(10)) +' * from db_Products where GroupID='+CAST(@GroupID as varchar(10))
	exec sp_executesql @sql
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_nhomid1]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Products_by_GroupID1]
@GroupID INT,
@NumShow INT
AS 
BEGIN
	DECLARE @sql NVARCHAR(300)
	SET @sql='select top '+CAST(@NumShow as varchar(10))+' * FROM db_Products WHERE GroupID=' + +CAST(@GroupID as varchar(10))
	EXEC sys.sp_executesql @sql
	
END
GO
/****** Object:  StoredProcedure [dbo].[thongtin_sanpham_by_tukhoa]    Script Date: 4/15/2018 1:46:05 AM ******//****************SEARCH PRODUCT************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_Products_by_keyword]
@KeyWord nvarchar(100)
AS
BEGIN
	select * from db_Products where ProductName like N'%'+@KeyWord+'%'
END


GO

EXEC dbo.info_Products_by_keyword @KeyWord = N'logi' -- nvarchar(100)


sort price products
SELECT * FROM dbo.db_Products WHERE PriceP BETWEEN '0' AND '300' 
SELECT * FROM dbo.db_Products WHERE PriceP BETWEEN '300' AND '800' 
SELECT * FROM dbo.db_Products WHERE PriceP BETWEEN '800' AND '2000' 

SELECT * FROM dbo.db_Products WHERE PriceP > '2000'
/****** Object:  StoredProcedure [dbo].[thongtin_size]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[info_Supply]
AS
BEGIN
	select * from db_Supply
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_size_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_Supply_by_id]
@SupplyID INT
AS
BEGIN
	select * from db_Supply where SupplyID=@SupplyID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_tintuc]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[info_News]
AS
BEGIN
	select * from db_News order by NumOrder
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_tintuc_by_id]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_News_by_id]
@NewsID INT
AS
BEGIN
	select * from db_News where NewsID=@NewsID
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_tintuc_by_madm]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_News_by_NewsCode]
@NewsCode INT
AS
BEGIN
	select top 6 * from db_News where NewsCode=@NewsCode
END


GO
/****** Object:  StoredProcedure [dbo].[thongtin_tintuc_by_madm_tatca]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[info_News_by_NewsCode_all]
@NewsCode INT
AS
BEGIN
	select * from db_News where NewsCode=@NewsCode
END


GO
/****** Object:  StoredProcedure [dbo].[tintuc_delete]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[News_delete]
@NewsID int
AS
BEGIN
	delete from db_News where NewsID=@NewsID
END


GO
/****** Object:  StoredProcedure [dbo].[tintuc_inser]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[News_inser]
@Title nvarchar(200),
@Avatar nvarchar(200),
@Describe nvarchar(200),
@PostDate date,
@Views int,
@Detail nvarchar(MAX),
@NumOrder int,
@NewsCode int
AS
BEGIN
	begin
	insert into db_News(Title,Avatar,Describe,PostDate,Views,Detail,NumOrder,NewsCode) values(@Title,@Avatar,@Describe,@PostDate,@Views,@Detail,@NumOrder,@NewsCode)
	end
END


GO
/****** Object:  StoredProcedure [dbo].[tintuc_update]    Script Date: 4/15/2018 1:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[News_update]
@NewsID INT,
@Title nvarchar(200),
@Avatar nvarchar(200),
@Describe nvarchar(200),
@PostDate date,
@Views int,
@Detail nvarchar(MAX),
@NumOrder int,
@NewsCode int

AS
BEGIN
	update db_News set Title=@Title,Avatar=@Avatar,Describe=@Describe, PostDate=@PostDate,Views=@Views,Detail=@Detail,NumOrder=@NumOrder,NewsCode=@NewsCode where NewsID=@NewsID
END






 
 
 
 
 