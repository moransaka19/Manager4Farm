using DAL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories.Implementations
{

    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(string connectionString) : base(connectionString)
        {
        }

        public override void Add(Doctor item)
        {
            var query = $"insert into [dbo].[Doctor](Job, PersonId) " +
                $"values ('{item.Job}', {item.PersonId})";
            int? id = _dbConnection.Query<int>(query, item).FirstOrDefault();
            if (id != null)
                item.DoctorId = (int)id;
        }

        public override void Update(Doctor item)
        {
            var query = $"update [dbo].[Doctor] as d" +
                $"set d.Job = '{item.Job}', d.PersonId = {item.PersonId} " +
                $"where d.DoctorId = {item.DoctorId}";
            _dbConnection.Execute(query);
        }
    }
}
