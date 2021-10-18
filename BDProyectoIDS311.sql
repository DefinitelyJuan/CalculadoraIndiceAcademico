USE MASTER
GO 
CREATE DATABASE INTEC
GO
USE INTEC
GO
--TABLAS
CREATE TABLE [dbo].[Student](
	[Id] [uniqueidentifier] NOT NULL,
	[Seq] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](70) NOT NULL,
	[LastName] [varchar](70) NOT NULL,
	[NickName] [varchar](35) NULL,
	[DayOfBirth] [date] NULL,
	[Email] [varchar](254) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentSubjectCross](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
	[SubjectId] [uniqueidentifier] NOT NULL,
	[Grade] [smallint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_StudentSubjectCross] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [uniqueidentifier] NOT NULL,
	[Seq] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Credits] [smallint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE INTEC
GO

CREATE TABLE Indice(
	StudentID int PRIMARY KEY NOT NULL,
	SubjectID char(6) NOT NULL,
	SubjectName varchar(30) NOT NULL,
	Credits int NOT NULL,
	Grade char(2) NOT NULL
)
Go
--VALORES
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Id], [Seq], [Name], [Code], [Credits], [CreatedDate]) VALUES (N'681a8e10-61ef-4ee1-8200-26cc1a06a0e3', 1, N'Desarrollo SoftwareII', N'AH012', 4, CAST(N'2021-05-25T17:45:37.360' AS DateTime))
INSERT [dbo].[Subject] ([Id], [Seq], [Name], [Code], [Credits], [CreatedDate]) VALUES (N'3facf18d-1fdb-4d0b-9b90-4a5f9d560833', 2, N'Programacion III', N'CS092', 3, CAST(N'2021-05-25T17:46:00.593' AS DateTime))
INSERT [dbo].[Subject] ([Id], [Seq], [Name], [Code], [Credits], [CreatedDate]) VALUES (N'6ebdd067-db47-47d1-b241-edc5b14e8193', 3, N'Lab Desarrollo Software II', N'AH012F', 2, CAST(N'2021-05-25T17:46:37.913' AS DateTime))
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
--CONSTRAINT
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[StudentSubjectCross] ADD  CONSTRAINT [DF_StudentSubjectCross_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Subject] ADD  CONSTRAINT [DF_Subject_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Subject] ADD  CONSTRAINT [DF_Subject_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[StudentSubjectCross]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjectCross_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[StudentSubjectCross] CHECK CONSTRAINT [FK_StudentSubjectCross_Student]
GO
ALTER TABLE [dbo].[StudentSubjectCross]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjectCross_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([Id])
GO
ALTER TABLE [dbo].[StudentSubjectCross] CHECK CONSTRAINT [FK_StudentSubjectCross_Subject]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PROCEDIMIENTO
CREATE PROCEDURE [dbo].[sp_subjects]

AS

SELECT Name, CreatedDate FROM [SUBJECT] ORDER BY [Name] ASC
GO
USE [master]
GO
ALTER DATABASE [INTEC] SET  READ_WRITE 
GO

USE INTEC
Go

CREATE PROCEDURE spInsertSubject
@StudentID int,
@SubjectID char(6),
@SubjectName varchar(30),
@Credits int,
@Grade char(2)
AS
BEGIN
INSERT INTO Indice (StudentID, SubjectID, SubjectName, Credits, Grade) VALUES (@StudentID, @SubjectID, @SubjectName, @Credits, @Grade)
END;
Go

USE INTEC
Go

CREATE PROCEDURE spCountSubject
@StudentID int 
AS
BEGIN
SELECT COUNT(*) FROM Indice WHERE (StudentID = @StudentID)
END;
Go