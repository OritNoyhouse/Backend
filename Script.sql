USE [master]
GO
/****** Object:  Database [OritProjectGoodLuck]    Script Date: 26/12/2021 03:16:39 ******/
CREATE DATABASE [OritProjectGoodLuck]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OritProjectGoodLuck', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OritProjectGoodLuck.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OritProjectGoodLuck_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OritProjectGoodLuck_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OritProjectGoodLuck] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OritProjectGoodLuck].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OritProjectGoodLuck] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ARITHABORT OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OritProjectGoodLuck] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OritProjectGoodLuck] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OritProjectGoodLuck] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OritProjectGoodLuck] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET RECOVERY FULL 
GO
ALTER DATABASE [OritProjectGoodLuck] SET  MULTI_USER 
GO
ALTER DATABASE [OritProjectGoodLuck] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OritProjectGoodLuck] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OritProjectGoodLuck] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OritProjectGoodLuck] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OritProjectGoodLuck] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OritProjectGoodLuck] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OritProjectGoodLuck', N'ON'
GO
ALTER DATABASE [OritProjectGoodLuck] SET QUERY_STORE = OFF
GO
USE [OritProjectGoodLuck]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[street] [nchar](10) NOT NULL,
	[numberHouse] [int] NOT NULL,
	[city] [nchar](10) NOT NULL,
	[floor] [int] NOT NULL,
	[cnisa] [int] NOT NULL,
	[numberFlat] [int] NOT NULL,
	[IsParking] [nchar](10) NOT NULL,
	[heaara] [nchar](10) NULL,
	[codeAdress] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[codeAdress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConditationMedical]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConditationMedical](
	[idConditation] [int] NOT NULL,
	[teurConditation] [nchar](10) NOT NULL,
	[doctorOpinion] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ConditationMedical] PRIMARY KEY CLUSTERED 
(
	[idConditation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DailyReportToDoctor]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyReportToDoctor](
	[idDoctor] [int] NOT NULL,
	[patientsForTomorow] [nvarchar](50) NOT NULL,
	[adressesList] [nvarchar](50) NOT NULL,
	[machines] [nvarchar](50) NULL,
	[fastestWay] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DailyReportToDoctor] PRIMARY KEY CLUSTERED 
(
	[idDoctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DailyRoute]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyRoute](
	[dateO] [date] NOT NULL,
	[idMishmeret] [int] NOT NULL,
	[idDoctor] [int] NOT NULL,
	[nunbersOfPatients] [int] NOT NULL,
	[currentIndex] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DailyRoute_1] PRIMARY KEY CLUSTERED 
(
	[idMishmeret] ASC,
	[idDoctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] NOT NULL,
	[firstName] [nchar](10) NOT NULL,
	[lastName] [nchar](10) NOT NULL,
	[codeStatusCovid] [int] NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[hoursOfWork] [nchar](10) NOT NULL,
	[location] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[codeMachine] [int] NOT NULL,
	[nameMachine] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[codeMachine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentOfPatient]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentOfPatient](
	[idMachine] [int] NOT NULL,
	[idPatient] [int] NOT NULL,
	[dateOfTake] [date] NOT NULL,
	[dateOfReturn] [date] NOT NULL,
 CONSTRAINT [PK_EquipmentOfPatient] PRIMARY KEY CLUSTERED 
(
	[idMachine] ASC,
	[idPatient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[locationId] [int] NOT NULL,
	[x] [float] NOT NULL,
	[y] [float] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[locationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHomeHospitalization]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHomeHospitalization](
	[idOrder] [int] IDENTITY(1,1) NOT NULL,
	[idPatient] [int] NOT NULL,
	[idDoctor] [int] NULL,
	[dateOf] [date] NOT NULL,
	[hourOfVisit] [datetime] NULL,
	[levelOfUrgent] [int] NULL,
 CONSTRAINT [PK_OrderHomeHospitalization] PRIMARY KEY CLUSTERED 
(
	[idOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id] [int] NOT NULL,
	[firstName] [nchar](10) NULL,
	[lastName] [nchar](10) NOT NULL,
	[statuscovid19] [int] NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[codeAdress] [int] NOT NULL,
	[machine] [int] NULL,
	[medicalCondition] [int] NOT NULL,
	[age] [int] NULL,
	[levelUrgent] [int] NULL,
	[doctorId] [int] NULL,
	[locationId] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleForDoctor]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleForDoctor](
	[idDoctor] [int] NOT NULL,
	[idMishmeret] [int] NOT NULL,
	[day] [nchar](10) NOT NULL,
	[fromHour] [datetime] NOT NULL,
	[toHour] [datetime] NOT NULL,
 CONSTRAINT [PK_ScheduleForDoctor] PRIMARY KEY CLUSTERED 
(
	[idDoctor] ASC,
	[idMishmeret] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusCovid19]    Script Date: 26/12/2021 03:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusCovid19](
	[codeStatus] [int] NOT NULL,
	[descriptionStatus] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusCovid19] PRIMARY KEY CLUSTERED 
(
	[codeStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 26/12/2021 03:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[idStorage] [int] IDENTITY(1,1) NOT NULL,
	[locationId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DailyReportToDoctor]  WITH CHECK ADD  CONSTRAINT [FK_DailyReportToDoctor_Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[DailyReportToDoctor] CHECK CONSTRAINT [FK_DailyReportToDoctor_Doctor]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Location] FOREIGN KEY([location])
REFERENCES [dbo].[Location] ([locationId])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Location]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_StatusCovid19] FOREIGN KEY([codeStatusCovid])
REFERENCES [dbo].[StatusCovid19] ([codeStatus])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_StatusCovid19]
GO
ALTER TABLE [dbo].[OrderHomeHospitalization]  WITH CHECK ADD  CONSTRAINT [FK_OrderHomeHospitalization_Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[OrderHomeHospitalization] CHECK CONSTRAINT [FK_OrderHomeHospitalization_Doctor]
GO
ALTER TABLE [dbo].[OrderHomeHospitalization]  WITH CHECK ADD  CONSTRAINT [FK_OrderHomeHospitalization_Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Patient] ([id])
GO
ALTER TABLE [dbo].[OrderHomeHospitalization] CHECK CONSTRAINT [FK_OrderHomeHospitalization_Patient]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Adress] FOREIGN KEY([codeAdress])
REFERENCES [dbo].[Adress] ([codeAdress])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Adress]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_ConditationMedical] FOREIGN KEY([medicalCondition])
REFERENCES [dbo].[ConditationMedical] ([idConditation])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_ConditationMedical]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Equipment] FOREIGN KEY([machine])
REFERENCES [dbo].[Equipment] ([codeMachine])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Equipment]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_EquipmentOfPatient] FOREIGN KEY([machine], [id])
REFERENCES [dbo].[EquipmentOfPatient] ([idMachine], [idPatient])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_EquipmentOfPatient]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Location] FOREIGN KEY([locationId])
REFERENCES [dbo].[Location] ([locationId])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Location]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_StatusCovid19] FOREIGN KEY([statuscovid19])
REFERENCES [dbo].[StatusCovid19] ([codeStatus])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_StatusCovid19]
GO
ALTER TABLE [dbo].[ScheduleForDoctor]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleForDoctor_DailyRoute] FOREIGN KEY([idMishmeret], [idDoctor])
REFERENCES [dbo].[DailyRoute] ([idMishmeret], [idDoctor])
GO
ALTER TABLE [dbo].[ScheduleForDoctor] CHECK CONSTRAINT [FK_ScheduleForDoctor_DailyRoute]
GO
ALTER TABLE [dbo].[ScheduleForDoctor]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleForDoctor_Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[ScheduleForDoctor] CHECK CONSTRAINT [FK_ScheduleForDoctor_Doctor]
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_Location] FOREIGN KEY([locationId])
REFERENCES [dbo].[Location] ([locationId])
GO
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Storage_Location]
GO
USE [master]
GO
ALTER DATABASE [OritProjectGoodLuck] SET  READ_WRITE 
GO
