
using DDDRdb.Infrastructure.Database;
using DDDRdb.Core.Entities;
using DDDRdb.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DDDRdb.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var sql = "SELECT * FROM RDB_USERS ORDER BY USERID";
            using var conn = _context.CreateConnection();
            return await conn.QueryAsync<User>(sql);
        }

        public async Task<User> GetByIdAsync(string id)
        {
            var sql = "SELECT * FROM RDB_USERS WHERE USERID = :ID";
            using var conn = _context.CreateConnection();
            return await conn.QueryFirstOrDefaultAsync<User>(sql, new { ID = id });
        }

        public async Task<int> InsertAsync(User user)
        {
            var sql = @"INSERT INTO RDB_USERS (USERID, USERNAME, ORG, DEPT, AUTHORITY)
                    VALUES (:USERID, :USERNAME, :ORG, :DEPT, :AUTHORITY)";
            using var conn = _context.CreateConnection();
            return await conn.ExecuteAsync(sql, user);
        }

        public async Task<int> UpdateAsync(User user)
        {
            var sql = @"UPDATE RDB_USERS SET USERNAME = :USERNAME,
                                         ORG      = :ORG,
                                         DEPT     = :DEPT,
                                         AUTHORITY= :AUTHORITY
                    WHERE USERID = :USERID";
            using var conn = _context.CreateConnection();
            return await conn.ExecuteAsync(sql, user);
        }

        public async Task<int> DeleteAsync(string id)
        {
            var sql = "DELETE FROM RDB_USERS WHERE USERID = :ID";
            using var conn = _context.CreateConnection();
            return await conn.ExecuteAsync(sql, new { ID = id });
        }
    }
}
