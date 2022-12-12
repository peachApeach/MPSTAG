using Dapper;
using MPSTAG.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace MPSTAG.Customers
{
    public class CustomerRepository : DapperRepository<MPSDbContext>, ICustomerRepository, ITransientDependency
    {
        public CustomerRepository(IDbContextProvider<MPSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<Customer>> GetListCustomerAsync()
        {
            var dbConnection = await GetDbConnectionAsync();

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat(@"
                SELECT cust_id, name
                FROM T_CUSTOMER
                WHERE org_code = 'KR' AND status <> 3");

            var customers = await dbConnection.QueryAsync<Customer>(
                builder.ToString(),
                null,
                transaction: await GetDbTransactionAsync(),
                commandType: CommandType.Text
            );
            List<Customer> emptyList = new List<Customer>();

                return (List<Customer>)customers;
        }

    }
}
