CREATE TABLE [dbo].[Doctor] (
    [DoctorId] INT IDENTITY (1, 1) NOT NULL,
    [PersonId] INT NULL,
    PRIMARY KEY CLUSTERED ([DoctorId] ASC),
    FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);

