USE [master]
GO

/****** Object:  Database [EnocaProjectNew]    Script Date: 24.02.2023 01:52:19 ******/
CREATE DATABASE [EnocaProjectNew]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnocaProjectNew', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EnocaProjectNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnocaProjectNew_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EnocaProjectNew_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnocaProjectNew].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EnocaProjectNew] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET ARITHABORT OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EnocaProjectNew] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EnocaProjectNew] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET  ENABLE_BROKER 
GO

ALTER DATABASE [EnocaProjectNew] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EnocaProjectNew] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [EnocaProjectNew] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET RECOVERY FULL 
GO

ALTER DATABASE [EnocaProjectNew] SET  MULTI_USER 
GO

ALTER DATABASE [EnocaProjectNew] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EnocaProjectNew] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EnocaProjectNew] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EnocaProjectNew] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EnocaProjectNew] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EnocaProjectNew] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [EnocaProjectNew] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EnocaProjectNew] SET  READ_WRITE 
GO

