USE [Movie_Database]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 4/9/2023 1:12:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[first_name] [nvarchar](255) NOT NULL,
	[last_name] [nvarchar](255) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO