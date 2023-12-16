

using Dapper;
using WebAPI.Context;
using WebAPI.Contracts;

namespace WebAPI.Repository
{

    public class TestRepository : ITestRepository
    {
        private readonly DapperContext _context;
        public TestRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Test>> Get()
        {
            var query = "SELECT * FROM Test_Table";
            using (var connection = _context.CreateConnection())
            {
                var test = await connection.QueryAsync<Test>(query);
                return test.ToList();
            }
        }
    }
}
