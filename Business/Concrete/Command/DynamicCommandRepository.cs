using Dapper;
using HyperCompanyCase.Business.Abstract.Command;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HyperCompanyCase.Business.Concrete.Command
{
    public class DynamicCommandRepository : IDynamicCommandRepository
    {
        private readonly string _connectionString;

        public DynamicCommandRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetSection("Database:ConnectionString").Value;
        }

        public async Task<int> AddAsync<T>(T entity)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            int? result = await db.InsertAsync(entity);
            return result.GetValueOrDefault();
        }

        public async Task<int> UpdateAsync<T>(T entity)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            int? result = await db.UpdateAsync(entity);
            return result.GetValueOrDefault();
        }

        public async Task<int> HardDeleteAsync<T>(int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            int? result = await db.DeleteAsync<T>(id);
            return result.GetValueOrDefault();
        }
    }

}
