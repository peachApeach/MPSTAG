using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPSTAG.Customers
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetListCustomerAsync();
    }
}
