use Manager4Hospital
go
create procedure GetAppointments as
begin
	select a.AppointmentId, a.[Date], pro.*, d.*, per.* from Appointment as a 
	left join [dbo].[Procedure] as pro on pro.ProcedureId = a.ProcedureId
	left join [dbo].[Doctor] as d on d.DoctorId = a.DoctorId
	left join [dbo].[Person] as per on per.PersonId = a.PersonId 
end;

go
create procedure GetDoctors as
begin
select 
	d.DoctorId,
	d.Job,
	p.PersonId,
	p.Firstname,
	p.Surname,
	p.DOB,
	p.PathToFile
from [dbo].[Doctor] as d
left join [dbo].[Person] as p on p.PersonId = d.PersonId
end;