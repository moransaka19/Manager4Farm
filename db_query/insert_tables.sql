use Manager4Hospital

insert into Person(Firstname, Surname, DOB, PathToFile)
values
('PersonName1', 'PersonSurname1', '2001-1-1', 'Patient1.jpg'),
('PersonName2', 'PersonSurname2', '2002-2-2', 'Patient2.jpg'),
('PersonName3', 'PersonSurname3', '2003-3-3', 'Patient3.jpg'),
('PersonName4', 'PersonSurname4', '2004-4-4', 'doctor.jfif'),
('PersonName5', 'PersonSurname5', '2005-5-5', 'doctor2.jfif')

insert into Doctor(PersonId, Job)
values
(4, 'Job1'),
(5, 'Job2')

insert into [Procedure]([Name], Price)
values
('ProcedureName1', 1.99),
('ProcedureName2', 2.99),
('ProcedureName3', 3.99),
('ProcedureName4', 4.99),
('ProcedureName5', 5.99)

insert into Appointment([Date], ProcedureId, DoctorId, PersonId)
values
('3001-1-1', 1, 1, 1),
('3002-2-2', 2, 1, 1),
('3003-3-3', 3, 2, 2),
('3004-4-4', 4, 2, 3)



