USE [Task1]
GO
/****** Object:  User [IIS APPPOOL\DefaultAppPool]    Script Date: 7/14/2020 2:48:35 PM ******/
CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 7/14/2020 2:48:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[Unit Type] [varchar](50) NOT NULL,
	[Rate] [int] NOT NULL,
	[DateCreated] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
