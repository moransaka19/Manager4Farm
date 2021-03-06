﻿using DAL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories.Implementations
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(string connectionString)
            : base(connectionString)
        {
        }

        public override IEnumerable<Appointment> GetAll()
        {
            var result = _dbConnection.Query<Appointment, Procedure, Doctor, Person, Appointment>("GetAppointments",
                map: (a, proc, doc, pers) => 
                {
                    a.ProcedureId = proc.ProcedureId;
                    a.Procedure = proc;
                    a.DoctorId = doc.DoctorId;
                    a.Doctor = doc;
                    a.PersonId = pers.PersonId;
                    a.Person = pers;

                    return a;
                },
                splitOn: "ProcedureId,DoctorId,PersonId",
                commandType: System.Data.CommandType.StoredProcedure);

            return result;
        }

        public override void Add(Appointment item)
        {
            var query = $"insert into [dbo].[Appointment]([Date], ProcedureId, DoctorId, PersonId)" +
                $"values ('{item.Date:yyyy-mm-dd}', {item.ProcedureId}, {item.DoctorId}, {item.PersonId})";
            int? id = _dbConnection.Query<int>(query, item).FirstOrDefault();
            if (id != null)
                item.AppointmentId = (int)id;
        }

        public override void Update(Appointment item)
        {
            var query = $"update [dbo].[Appointment] as a " +
                $"set a.[Date] = '{item.Date:yyyy-mm-dd}', " +
                $"a.ProcedureId = {item.ProcedureId}, " +
                $"a.DoctorId = {item.DoctorId} " +
                $"a.PersonId = {item.PersonId} " +
                $"where a.AppointmentId = {item.AppointmentId}";
            _dbConnection.Execute(query);
        }
    }
}
