CREATE TABLE [dbo].[Appointment] (
    [AppointmentId] INT      IDENTITY (1, 1) NOT NULL,
    [Date]          DATETIME NULL,
    [ProcedureId]   INT      NULL,
    [DoctorId]      INT      NULL,
    [PersonId]      INT      NULL,
    PRIMARY KEY CLUSTERED ([AppointmentId] ASC),
    FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[Doctor] ([DoctorId]),
    FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    FOREIGN KEY ([ProcedureId]) REFERENCES [dbo].[Procedure] ([ProcedureId])
);

