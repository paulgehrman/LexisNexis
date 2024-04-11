IF EXISTS(SELECT * FROM sys.databases WHERE name = 'LexisNexis')
  BEGIN
    DROP DATABASE [LexisNexis]
  END
GO

CREATE DATABASE [LexisNexis]
GO

USE [LexisNexis]
GO

/****** Object:  Table [dbo].[Recipes]    Script Date: 4/11/2024 9:11:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Recipes](
	[RecipeId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[ImageName] [varchar](100) NULL,
	[Image] [varbinary](max) NULL,
 CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[RecipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



CREATE TABLE [dbo].[RecipeIngredients](
	[RecipeIngredientId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NOT NULL,
	[Ingredient] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ReceiptIngredients] PRIMARY KEY CLUSTERED 
(
	[RecipeIngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RecipeIngredients]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptIngredients_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RecipeIngredients] CHECK CONSTRAINT [FK_ReceiptIngredients_Recipes]
GO


CREATE TABLE [dbo].[RecipeInstructions](
	[RecipeInstructionId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NOT NULL,
	[Instruction] [nvarchar](2000) NOT NULL,
 CONSTRAINT [PK_RecipeInstructions] PRIMARY KEY CLUSTERED 
(
	[RecipeInstructionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RecipeInstructions]  WITH CHECK ADD  CONSTRAINT [FK_RecipeInstructions_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RecipeInstructions] CHECK CONSTRAINT [FK_RecipeInstructions_Recipes]
GO


