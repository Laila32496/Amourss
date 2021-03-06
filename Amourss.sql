USE [master]
GO
/****** Object:  Database [Amourss]    Script Date: 10/16/2018 8:03:11 AM ******/
CREATE DATABASE [Amourss]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Amourss', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Amourss.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Amourss_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Amourss_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Amourss] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Amourss].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Amourss] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Amourss] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Amourss] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Amourss] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Amourss] SET ARITHABORT OFF 
GO
ALTER DATABASE [Amourss] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Amourss] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Amourss] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Amourss] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Amourss] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Amourss] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Amourss] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Amourss] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Amourss] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Amourss] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Amourss] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Amourss] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Amourss] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Amourss] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Amourss] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Amourss] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Amourss] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Amourss] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Amourss] SET  MULTI_USER 
GO
ALTER DATABASE [Amourss] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Amourss] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Amourss] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Amourss] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Amourss] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Amourss] SET QUERY_STORE = OFF
GO
USE [Amourss]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Amourss]
GO
/****** Object:  Table [dbo].[Cause]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cause](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [varchar](max) NULL,
	[Title] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[EarningGoal] [float] NULL,
	[AchievedGoal] [float] NULL,
	[Featured] [int] NULL,
	[TimeStamp] [datetime] NOT NULL,
	[TextStyle] [varchar](max) NOT NULL,
	[TextColor] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Email] [varchar](max) NOT NULL,
	[Subject] [varchar](max) NOT NULL,
	[Message] [varchar](max) NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HelpOption]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HelpOption](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [varchar](max) NULL,
	[Title] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomePage]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomePage](
	[LightLogoImage] [varchar](max) NULL,
	[DarkLogoImage] [varchar](max) NULL,
	[Facebook] [varchar](max) NULL,
	[Twitter] [varchar](max) NULL,
	[GooglePlus] [varchar](max) NULL,
	[Instagram] [varchar](max) NULL,
	[LinkedIn] [varchar](max) NULL,
	[Vimeo] [varchar](max) NULL,
	[FooterDescription] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[Phone] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Lat] [float] NULL,
	[Lng] [float] NULL,
	[Location] [varchar](max) NULL,
	[CompanyTitle] [varchar](max) NULL,
	[CompanySubTitle] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomePageVideo]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomePageVideo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VideoLink] [varchar](max) NULL,
	[VideoTitle] [varchar](max) NULL,
	[VideoDescription] [varchar](max) NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mission]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[ImagePath] [varchar](max) NULL,
	[ImageTitle] [varchar](max) NULL,
	[Subtitle] [varchar](max) NULL,
	[SubDescription] [varchar](max) NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
	[Phone] [varchar](50) NULL,
	[TimeStamp] [datetime] NOT NULL,
	[ImagePath] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhyUs]    Script Date: 10/16/2018 8:03:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhyUs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [varchar](max) NULL,
	[Title] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cause] ON 

INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (5, N'~/Images/Causes/Cause-IH54Q.jpg', N'YOU DREAM IT, WE BUILD IT', N'Amour’s Fanoon-e-Khas Exhibition held on 30th and 31st of January, 2018 under the projects of Amour Foundation in Pilac, Punjabi Complex in Qadafi Stadium Lahore Pakistan.', 0, 0, 2, CAST(N'2018-10-05T23:22:32.810' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (6, N'~/Images/Causes/Cause-QMVLY.jpg', N'WE WANT EMPLOYMENT NOT CHARITY', N'Exhibition arranged by AMOUR in which dress, shoes , feature articles and many other handmade decoration pieces were designed by special people to encourage these disable people to live like normal people.', 0, 0, 2, CAST(N'2018-10-05T23:23:11.607' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (7, N'~/Images/Causes/Cause-60GG7.jpg', N'JUST LOVE NOT SYMPATHIES', N'Struggle improve the living standard of special person.
Struggle to point out and make sure to provide facilities for the Handicapped.', 0, 0, 2, CAST(N'2018-10-05T23:23:39.587' AS DateTime), N'Box', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (8, N'~/Images/Causes/Cause-GN07X.jpg', N'HANDMADE CRAFT DESIGNED BY SPECIAL PEOPLE', NULL, 0, 0, 2, CAST(N'2018-10-05T23:23:54.680' AS DateTime), N'Box', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (14, N'~/Images/Causes/Cause-XGAWN.jpg', NULL, NULL, 0, 0, 2, CAST(N'2018-10-05T23:29:23.440' AS DateTime), N'Box', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (15, N'~/Images/Causes/Cause-FWAGQ.jpg', NULL, NULL, 0, 0, 2, CAST(N'2018-10-05T23:29:28.983' AS DateTime), N'Box', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (17, N'~/Images/Causes/Cause-NQ2AP.jpg', N'PRIZE DISTRIBUTION', N'31st January, 2018, Prize Award Distribution ceremony', 0, 0, 2, CAST(N'2018-10-05T23:30:42.373' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (18, N'~/Images/Causes/Cause-0609F.jpg', NULL, NULL, 0, 0, 2, CAST(N'2018-10-05T23:31:07.503' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (20, N'~/Images/Causes/Cause-VWM9G.jpg', N'MY ADVICE TO OTHER DISABLED PEOPLE WOULD BE, CONCENTRATE ON THINGS YOUR DISABILITY DOESN’T PREVENT YOU DOING WELL, AND DON’T REGRET THE THINGS IT INTERFERES WITH. DON’T BE DISABLED IN SPIRIT AS WELL AS PHYSICALLY.” -STEPHEN HAWKING', NULL, 0, 0, 2, CAST(N'2018-10-05T23:38:39.257' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (1010, N'~/Images/Causes/Cause-27YUG.jpg', N'Fanoon-e-Khas Handicraft Exhibition', N'Exhibition held on 30th and 31st of January, 2018 under the projects of Amour Foundation in Pilac, Punjabi Complex in Qadafi Stadium Lahore Pakistan aim to promote those skillful handicapped special children who are carrying their life with hope and struggle.', 20000, 15000, 1, CAST(N'2018-10-08T00:54:43.693' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (1011, N'~/Images/Causes/Cause-CT3U6.jpg', N'Amour-Medical Camp', N'Amour (NGO) organised one day free medical camp for the patients of Tuberculosis (TB), Hepatitis, and diabetic at Punjab small industry housing society DHA Lahore on Thursday morning. The camp inaugrated by president Amour “Laila Tul Qaddar”  different specialist doctors Dr Munir Ghori (general physician) Govt shdra hospital, Dr Waqar, and Dr Ali (orthopedic surgeon) from Hameed Latif and shalamar hospital and their para medic staffs treated hundreds of patients according to theirs doctors prescription.', 0, 0, 1, CAST(N'2018-10-08T00:55:24.557' AS DateTime), N'Normal', N'White')
INSERT [dbo].[Cause] ([ID], [ImagePath], [Title], [Description], [EarningGoal], [AchievedGoal], [Featured], [TimeStamp], [TextStyle], [TextColor]) VALUES (1012, N'~/Images/Causes/Cause-UQ656.jpg', N'Activity for Mobilization of Disabled Person', N'AMOUR  - JUST LOVE , NOT SYMPATHY An activity in McDonalds’  was organized by their heartily Collaboration . This activity was done for the seek of  get together of those special persons who also have the right to live a happy and enjoyable life as normal persons do. This activity was arranged by McDonalds’ with all their Love and Respect and took part in the activities and performances of special children. All staff of McDonalds’ is very cooperative and lovable who treats our special persons with all their love and smiles.', 0, 0, 1, CAST(N'2018-10-08T00:56:08.187' AS DateTime), N'Normal', N'White')
SET IDENTITY_INSERT [dbo].[Cause] OFF
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (1, N'klsjdalkdj', N'sakldjlk', N'jalk', N'lkjsaklj', CAST(N'2018-10-07T15:13:41.123' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (2, N'hkjhkjh', N'kjhkjh', N'kjhkjhkjh', N'kjhkjh', CAST(N'2018-10-07T15:14:27.000' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (3, N'hkjhkjh', N'kjhkjh', N'kjhkjhkjh', N'kjhkjh', CAST(N'2018-10-07T15:14:28.710' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (4, N'hkjhkjh', N'kjhkjh', N'kjhkjhkjh', N'kjhkjh', CAST(N'2018-10-07T15:14:28.893' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (5, N'hkjhkjh', N'kjhkjh', N'kjhkjhkjh', N'kjhkjh', CAST(N'2018-10-07T15:14:29.060' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (6, N'jhkjhkj', N'hkj', N'hkjhkjh', N'kjhkj', CAST(N'2018-10-07T15:15:10.480' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (7, N'kjhkj', N'zetawars@hotmail.com', N'khk', N'hkkjhkj', CAST(N'2018-10-07T15:15:38.287' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (8, N'kjhkj', N'zetawars@hotmail.com', N'khk', N'hkkjhkj', CAST(N'2018-10-07T15:15:51.663' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (9, N'kjhkj', N'zetawars@hotmail.com', N'khk', N'hkkjhkj', CAST(N'2018-10-07T15:16:07.497' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (10, N'kjhkjhk', N'zetawars@hotmail.com', N'hkhkjh', N'kjhkjhkjh', CAST(N'2018-10-07T15:17:12.640' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (11, N'kjhkjhkj', N'zetawars@hotmail.com', N'hkkjhkh', N'kjhkjhjkhk', CAST(N'2018-10-07T15:19:38.460' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (12, N'Raw Meterial', N'zetawars@hotmail.com', N'kjhkjhkjh', N'lkjkljkljkljlkjlkjlkjklj', CAST(N'2018-10-07T15:20:23.950' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (13, N'hkjhkj', N'zetawars@hotmail.com', N'hkjhkjhkjh', N'kjhkjhkjhkjh', CAST(N'2018-10-07T15:21:01.387' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (14, N'Admin', N'zetawars@hotmail.com', N'kjhkjhkjh', N'hkjdhsakdshkjafhdl kf hdf hsdf sdaf ', CAST(N'2018-10-07T15:22:58.110' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (15, N'hkjh', N'zetawars@hotmail.com', N'khkj', N'hkjh', CAST(N'2018-10-07T15:32:57.497' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (16, N'kjhkjhkj', N'zetawars@hotmail.com', N'hkjhkj', N'hkjhkjhkj', CAST(N'2018-10-07T15:33:50.793' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (17, N'jhkjh', N'zetawars@hotmail.com', N'khjhkj', N'hkjhkjh', CAST(N'2018-10-07T15:35:08.807' AS DateTime))
INSERT [dbo].[Contact] ([ID], [Name], [Email], [Subject], [Message], [TimeStamp]) VALUES (18, N'askdjaklj', N'zetawars@hotmail.com', N'kljsldjl', N'jsalkdjlk', CAST(N'2018-10-07T15:37:20.077' AS DateTime))
SET IDENTITY_INSERT [dbo].[Contact] OFF
SET IDENTITY_INSERT [dbo].[HomePage] ON 

INSERT [dbo].[HomePage] ([LightLogoImage], [DarkLogoImage], [Facebook], [Twitter], [GooglePlus], [Instagram], [LinkedIn], [Vimeo], [FooterDescription], [Address], [Phone], [Email], [ID], [Lat], [Lng], [Location], [CompanyTitle], [CompanySubTitle]) VALUES (N'~/Images/Setting/LightLogo.png', N'~/Images/Setting/DarkLogo.png', N'kljakldsajdklj', N'kljsaldkjkl', N'jsalkdjaklj', N'klsjklj', N'klsajklj', N'kljklj', N'kljsakldjsakldsajklj', N'E-74 Punjab Small Industrial Housing Society DHA Lahore, Pakistan', N'askld', N'touseefsy@gmail.com', 2, 31.4748712, 74.3734092, N'DHA, Lahore, Pakistan', N'AMOURS', N'AMOURS -JUST LOVE NOT SYMPATHIES')
SET IDENTITY_INSERT [dbo].[HomePage] OFF
SET IDENTITY_INSERT [dbo].[Mission] ON 

INSERT [dbo].[Mission] ([ID], [Title], [Description], [ImagePath], [ImageTitle], [Subtitle], [SubDescription], [TimeStamp]) VALUES (2, N'Technical Training', N'To Establish various technical training program such as IT Technology Software development desktop publishing web designing.Arts & crafts, sewing & stitching and any others skill training program which can enables amputees to generate source of earning an honorable way.', N'~/Images/Missions/Techn.IP4PQ.jpg', N'Fanoon-e-Khas , A Handicraft Exibition', N'Empathy is better than Sympathy', N'Exhibition held on 30th and 31st of January, 2018 under the projects of Amour Foundation in Pilac, Punjabi Complex in Qadafi Stadium Lahore Pakistan. Miss Sughran Sadaf (Govt Employee of Punjabi Cultural Society), Ma’am Azra Aftab (Actress), Major Sohail Sb, Almas Sb (Rotary Club) and many more honorable personalities were chief guests to encourage those special people there. Amour has arranged this exhibition in which Feature Articles ,  dresses , Shoes and many other handmade decoration pieces were presented for the earning of those disabled persons.', CAST(N'2018-10-07T11:31:41.993' AS DateTime))
INSERT [dbo].[Mission] ([ID], [Title], [Description], [ImagePath], [ImageTitle], [Subtitle], [SubDescription], [TimeStamp]) VALUES (3, N'Educational Training', N'To Provide handicapped user-friendly education envoirment and provide best teacher who teach with your mentality level.To Provide teaching facilities such as Islamic education services such as Islamic law Hadith and Memorizing quran at the nearest locations and many of things.
Learn More', N'~/Images/Missions/Educa.8QU7X.jpg', N'Activity for mobilization of disable person', N'Just love Not Sympathies', N'One day outdoor activity for AMOUR disable persons was organized with love and care in cooperation with McDonald’s Lahore.', CAST(N'2018-10-07T11:32:59.910' AS DateTime))
INSERT [dbo].[Mission] ([ID], [Title], [Description], [ImagePath], [ImageTitle], [Subtitle], [SubDescription], [TimeStamp]) VALUES (4, N'Residential Aids', N'To provide residential aids to amputees in shape of small homes, essential repair of their homes.To provide Special Washroom facilities while travelling on Motorway and GT Road or where ever are the rest places throughout the Pakistan.', N'~/Images/Missions/Resid.BGIPK.jpg', N'Free Medical Camp-Amour', NULL, N'Amour (NGO) organised one day free medical camp for the patients of Tuberculosis (TB), Hepatitis, and diabetic at Punjab small industry housing society DHA Lahore on Thursday morning. The camp was inaugurated by president Amour “Laila Tul Qaddar”  different specialist doctors Dr Munir Ghori (general physician) Govt shdra hospital, Dr Waqar, and Dr Ali (orthopedic surgeon) from Hameed Latif and shalamar hospital and their para medic staffs treated hundreds of patients according to theirs doctors prescription.', CAST(N'2018-10-07T11:34:07.107' AS DateTime))
SET IDENTITY_INSERT [dbo].[Mission] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [Phone], [TimeStamp], [ImagePath]) VALUES (1, N'Zawar', N'Mahmood', N'zetawars@hotmail.com', N'Zawar123', N'03074665233', CAST(N'2018-10-05T20:18:45.790' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Cause] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[Cause] ADD  DEFAULT ('Normal') FOR [TextStyle]
GO
ALTER TABLE [dbo].[Cause] ADD  DEFAULT ('Black') FOR [TextColor]
GO
ALTER TABLE [dbo].[Contact] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[HelpOption] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[HomePageVideo] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
ALTER TABLE [dbo].[WhyUs] ADD  DEFAULT (getdate()) FOR [TimeStamp]
GO
USE [master]
GO
ALTER DATABASE [Amourss] SET  READ_WRITE 
GO
