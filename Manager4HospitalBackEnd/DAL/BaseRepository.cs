using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class BaseRepository<T> : IBaseRepository<T>, IDisposable
    {
        protected readonly DbConnection _dbConnection;

        public BaseRepository(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public virtual IEnumerable<T> GetAll() 
            => _dbConnection.Query<T>($"select * from [{typeof(T).Name}]");
        public virtual T GetById(int id)
            => _dbConnection.QuerySingle<T>($"select  from [{typeof(T).Name}] " +
                $"where [{typeof(T).Name}].Id = {id}");
        public abstract void Add(T item);
        public abstract void Update(T item);
        public void Dispose()
        {
            _dbConnection.Close();
        }
    }
}
