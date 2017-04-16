USE [master]
GO

CREATE DATABASE [Magazine]
GO

USE [Magazine]
GO

/****** Object:  Table [dbo].[Store] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store] (
    [Id] [int] NOT NULL IDENTITY(1,1),
	[Name] [nvarchar](max),
    [Address] [nvarchar](max),
    [StartWorkTime] [nvarchar](max) NOT NULL,
    [EndWorkTime] [nvarchar](max) NOT NULL
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Item] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item] (
    [Id] [int] NOT NULL IDENTITY(1,1),
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
	[StoreId] [int] NOT NULL DEFAULT 0
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE INDEX [IX_StoreId] ON [dbo].[Item]([StoreId])


/****** Object:  Foreign Key [FK_Item_Store_StoreId] ******/
ALTER TABLE [dbo].[Item] 
WITH CHECK ADD CONSTRAINT [FK_Item_Store_StoreId] 
FOREIGN KEY ([StoreId]) REFERENCES [dbo].[Store] ([Id]) 
ON DELETE CASCADE
ON UPDATE CASCADE


/****** Object:  Seed test data ******/
INSERT INTO [dbo].[Store]
	VALUES ('LightPoint', '220113, Belarus, Minsk city,  5-1 Melezha str., Apt. 306', '11.00 A.M.', '00.00 A.M.')
INSERT INTO [dbo].[Store]
	VALUES ('EPAM', '1/1 Academician Kuprevich Street, Suite 110, 220141 Minsk Belarus', '8.30 A.M.', '20.00 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('HTP', 'Kuprevicha, 1/1, 220141, Minsk, Belarus.', '9.30 A.M.', '22.30 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('Itransition', 'Street Kuĺman 1, Minsk 220013, Belarus', '10.00 A.M.', '21.00 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('Wargaming', 'Partizansky Ave. 178/2, Minsk', '7.00 A.M.', '23.00 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('Scand Ltd.', '8b/1-520 Fabritsiusa str., 220007 Minsk, Belarus', '8.00 A.M.', '18.00 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('exp(capital)', '36 Internacyjanalnaya str. 6th floor, Minsk 220022, Belarus', '6.00 A.M.', '17.00 P.M.')
INSERT INTO [dbo].[Store]
	VALUES ('WorkFusion', '48 Wall Street, 7th floor New York NY 10005 ', '7.30 A.M.', '20.30 P.M.')

INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 1', 'Description by LightPoint 1', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 2', 'Description by LightPoint 2', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 3', 'Description by LightPoint 3', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 4', 'Description by LightPoint 4', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 5', 'Description by LightPoint 5', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 6', 'Description by LightPoint 6', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 7', 'Description by LightPoint 7', 1)
INSERT INTO [dbo].[Item]
	VALUES ('Item by LightPoint 8', 'Description by LightPoint 8', 1)


INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 1', 'Description by EPAM 1', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 2', 'Description by EPAM 2', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 3', 'Description by EPAM 3', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 4', 'Description by EPAM 4', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 5', 'Description by EPAM 5', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 6', 'Description by EPAM 6', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 7', 'Description by EPAM 7', 2)
INSERT INTO [dbo].[Item]
	VALUES ('Item by EPAM 8', 'Description by EPAM 8', 2)


INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 1', 'Description by HTP 1', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 2', 'Description by HTP 2', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 3', 'Description by HTP 3', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 4', 'Description by HTP 4', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 5', 'Description by HTP 5', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 6', 'Description by HTP 6', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 7', 'Description by HTP 7', 3)
INSERT INTO [dbo].[Item]
	VALUES ('Item by HTP 8', 'Description by HTP 8', 3)


INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 1', 'Description by Itransition 1', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 2', 'Description by Itransition 2', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 3', 'Description by Itransition 3', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 4', 'Description by Itransition 4', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 5', 'Description by Itransition 5', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 6', 'Description by Itransition 6', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 7', 'Description by Itransition 7', 4)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Itransition 8', 'Description by Itransition 8', 4)


INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 1', 'Description by Wargaming 1', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 2', 'Description by Wargaming 2', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 3', 'Description by Wargaming 3', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 4', 'Description by Wargaming 4', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 5', 'Description by Wargaming 5', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 6', 'Description by Wargaming 6', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 7', 'Description by Wargaming 7', 5)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Wargaming 8', 'Description by Wargaming 8', 5)



INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 1', 'Description by Scand Ltd. 1', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 2', 'Description by Scand Ltd. 2', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 3', 'Description by Scand Ltd. 3', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 4', 'Description by Scand Ltd. 4', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 5', 'Description by Scand Ltd. 5', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 6', 'Description by Scand Ltd. 6', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 7', 'Description by Scand Ltd. 7', 6)
INSERT INTO [dbo].[Item]
	VALUES ('Item by Scand Ltd. 8', 'Description by Scand Ltd. 8', 6)



INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 1', 'Description by exp(capital) 1', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 2', 'Description by exp(capital) 2', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 3', 'Description by exp(capital) 3', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 4', 'Description by exp(capital) 4', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 5', 'Description by exp(capital) 5', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 6', 'Description by exp(capital) 6', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 7', 'Description by exp(capital) 7', 7)
INSERT INTO [dbo].[Item]
	VALUES ('Item by exp(capital) 8', 'Description by exp(capital) 8', 7)



INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 1', 'Description by WorkFusion 1', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 2', 'Description by WorkFusion 2', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 3', 'Description by WorkFusion 3', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 4', 'Description by WorkFusion 4', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 5', 'Description by WorkFusion 5', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 6', 'Description by WorkFusion 6', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 7', 'Description by WorkFusion 7', 8)
INSERT INTO [dbo].[Item]
	VALUES ('Item by WorkFusion 8', 'Description by WorkFusion 8', 8)