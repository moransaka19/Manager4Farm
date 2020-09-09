using DAL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories.Implementations
{
    class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(string connectionString)
            : base(connectionString)
        { }
        public override void Add(Person item)
        {
            var query = $"insert into [dbo].[Person](Firstname, Surname, DOB) " +
                $"values ('{item.Firstname}', " +
                $"'{item.Surname}', " +
                $"'{item.DOB:yyyy-mm-dd}')";
            int? id = _dbConnection.Query<int>(query, item).FirstOrDefault();
            if (id != null)
                item.PersonId = (int)id;
        }

        public override void Update(Person item)
        {
            var query = $"update [dbo].[Person] as p " +
                $"set p.[Firstname] = '{item.Firstname}', " +
                $"p.[Surname] = '{item.Surname}', " +
                $"p.[DOB] = '{item.DOB:yyyy-mm-dd}'" +
                $"where p.[PersonId] = {item.PersonId}";
            _dbConnection.Execute(query);
        }
    }
}
