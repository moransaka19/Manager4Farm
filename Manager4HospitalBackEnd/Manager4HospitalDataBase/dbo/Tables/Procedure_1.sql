CREATE TABLE [dbo].[Procedure] (
    [ProcedureId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (30) NULL,
    [Price]       SMALLMONEY    NULL,
    PRIMARY KEY CLUSTERED ([ProcedureId] ASC)
);

