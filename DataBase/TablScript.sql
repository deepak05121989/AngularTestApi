USE [TestDB]
GO

/****** Object:  Table [dbo].[mediaItem]    Script Date: 3/1/2024 4:18:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[mediaItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[medium] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[year] [int] NULL,
	[watchedOn] [varchar](50) NULL,
	[isFavorite] [bit] NULL,
 CONSTRAINT [PK_mediaItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


