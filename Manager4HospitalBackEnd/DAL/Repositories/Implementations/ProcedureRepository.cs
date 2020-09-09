using DAL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories.Implementations
{
    class ProcedureRepository : BaseRepository<Procedure>, IProcedureRepository
    {
        public ProcedureRepository(string connectionString)
            : base(connectionString)
        { }
        public override void Add(Procedure item)
        {
            var query = $"insert into [dbo].[Procedure](Name, Price) " +
                $"values ('{item.Name}', " +
                $"'{item.Price}')";
            int? id = _dbConnection.Query<int>(query, item).FirstOrDefault();
            if (id != null)
                item.ProcedureId = (int)id;
        }
        public override void Update(Procedure item)
        {
            var query = $"update [dbo].[Procedure] as p " +
                $"set p.Name = '{item.Name}', p.Price = '{item.Price}' " +
                $"where p.ProcedureId = {item.ProcedureId}";
            _dbConnection.Execute(query);
        }
    }
}
