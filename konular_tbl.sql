﻿USE [yazılımyapımı]
GO

/****** Object:  Table [dbo].[konular_tbl]    Script Date: 18.05.2022 16:06:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[konular_tbl](
	[Id] [int] NOT NULL,
	[konu_adi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_konular_tbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


