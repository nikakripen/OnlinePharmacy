USE [master]
GO

/****** Object:  Database [pharmacy]    Script Date: 27.05.2016 14:11:22 ******/
CREATE DATABASE [pharmacy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\pharmacy.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\pharmacy_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [pharmacy] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pharmacy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [pharmacy] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [pharmacy] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [pharmacy] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [pharmacy] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [pharmacy] SET ARITHABORT OFF 
GO

ALTER DATABASE [pharmacy] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [pharmacy] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [pharmacy] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [pharmacy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [pharmacy] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [pharmacy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [pharmacy] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [pharmacy] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [pharmacy] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [pharmacy] SET  DISABLE_BROKER 
GO

ALTER DATABASE [pharmacy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [pharmacy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [pharmacy] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [pharmacy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [pharmacy] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [pharmacy] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [pharmacy] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [pharmacy] SET RECOVERY FULL 
GO

ALTER DATABASE [pharmacy] SET  MULTI_USER 
GO

ALTER DATABASE [pharmacy] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [pharmacy] SET DB_CHAINING OFF 
GO

ALTER DATABASE [pharmacy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [pharmacy] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [pharmacy] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [pharmacy] SET  READ_WRITE 
GO
