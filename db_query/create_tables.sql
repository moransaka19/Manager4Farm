use Manager4Hospital

create table Person
(
	PersonId int primary key identity,
	Firstname nvarchar(40),
	Surname nvarchar(40),
	DOB Datetime,
	PathToFile char(100)
);

create table Doctor
(
	DoctorId int primary key identity,
	Job nvarchar(20),
	PersonId int references Person(PersonId) 
);

create table [Procedure]
(
	ProcedureId int primary key identity,
	[Name] nvarchar(30), 
	Price smallmoney,
);

create table Appointment
(
	AppointmentId int primary key identity,
	[Date] datetime,
	ProcedureId int references [Procedure](ProcedureId),
	DoctorId int references Doctor(DoctorId),
	PersonId int references Person(PersonId),
)
