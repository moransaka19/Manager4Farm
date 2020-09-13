CREATE TABLE [dbo].[Person] (
    [PersonId]  INT           IDENTITY (1, 1) NOT NULL,
    [Firstname] NVARCHAR (40) NULL,
    [Surname]   NVARCHAR (40) NULL,
    [DOB]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

