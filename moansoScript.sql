USE [master]
GO
/****** Object:  Database [DBMoanso]    Script Date: 9/06/2023 01:42:23 ******/
CREATE DATABASE [DBMoanso]
 CONTAINMENT = NONE
 ON  PRIMARY 
--Modifica los FILENAME y coloca la ruta donde tienes instalado tu Microsoft SQL Server para que no te genere un error y tambien el LEDGER = OFF
( NAME = N'DBMoanso', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQL\MSSQL\DATA\DBMoanso.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBMoanso_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQL\MSSQL\DATA\DBMoanso_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBMoanso] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBMoanso].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBMoanso] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBMoanso] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBMoanso] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBMoanso] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBMoanso] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBMoanso] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBMoanso] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBMoanso] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBMoanso] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBMoanso] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBMoanso] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBMoanso] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBMoanso] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBMoanso] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBMoanso] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBMoanso] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBMoanso] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBMoanso] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBMoanso] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBMoanso] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBMoanso] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBMoanso] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBMoanso] SET RECOVERY FULL 
GO
ALTER DATABASE [DBMoanso] SET  MULTI_USER 
GO
ALTER DATABASE [DBMoanso] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBMoanso] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBMoanso] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBMoanso] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBMoanso] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBMoanso] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBMoanso', N'ON'
GO
ALTER DATABASE [DBMoanso] SET QUERY_STORE = OFF
GO
USE [DBMoanso]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[desCiudad] [nvarchar](50) NOT NULL,
	[estCiudad] [bit] NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](50) NULL,
	[rucCliente] [char](10) NULL,
	[idTipoCliente] [int] NULL,
	[estCliente] [bit] NULL,
	[fecRegCliente] [datetime] NULL,
	[idCiudad] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaCiudad]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeshabilitaCiudad]
(
@idCiudad int
)
as
begin
	update Ciudad set
	estCiudad = 0 
	where idCiudad = @idCiudad
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaCliente]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeshabilitaCliente]
(
@idCliente int
)
as
begin
	update Cliente set
	estCliente = 0 
	where idCliente = @idCliente
end
GO
/****** Object:  StoredProcedure [dbo].[spEditaCiudad]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaCiudad]
(
@idCiudad int,
@desCiudad varchar(50),
@estCiudad bit)
as
begin
	update Ciudad set 
	desCiudad = @desCiudad,
	estCiudad = @estCiudad 
	where idCiudad = @idCiudad
end
GO
/****** Object:  StoredProcedure [dbo].[spEditaCliente]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaCliente]
(
@idCliente int,
@razonSocial varchar(50),
@rucCliente char(10),
@idTipoCliente int,
@idCiudad int,
@fecRegCliente date,
@estCliente bit)
as
begin
	update Cliente set 
	razonSocial = @razonSocial,
	rucCliente = @rucCliente,
	idTipoCliente = @idTipoCliente,
	idCiudad = @idCiudad,
	fecRegCliente = @fecRegCliente,
	estCliente = @estCliente 
	where idCliente = @idCliente
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertaCiudad]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaCiudad]
(
@desCiudad varchar(50),
@estCiudad bit
)
as
begin
	insert into Ciudad(desCiudad, estCiudad) values(@desCiudad, @estCiudad)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertaCliente]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaCliente]
(
@razonSocial varchar(50),
@rucCliente char(50),
@idTipoCliente int,
@fecRegCliente date,
@idCiudad int,
@estCliente bit
)
as
begin
	insert into Cliente(razonSocial,rucCliente,idTipoCliente,fecRegCliente, idCiudad, estCliente) values(@razonSocial,@rucCliente, @idTipoCliente,@fecRegCliente,@idCiudad, @estCliente)
end
GO
/****** Object:  StoredProcedure [dbo].[spListarCiudad]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarCiudad]
AS
	SELECT * FROM Ciudad WHERE estCiudad = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarCliente]    Script Date: 9/06/2023 01:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListarCliente]
AS
	SELECT * FROM Cliente WHERE estCliente = 1
GO
USE [master]
GO
ALTER DATABASE [DBMoanso] SET  READ_WRITE 
GO
