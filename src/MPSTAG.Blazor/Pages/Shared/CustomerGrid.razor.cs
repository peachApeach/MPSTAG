using MPSTAG.Customers;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace MPSTAG.Blazor.Pages.Shared
{
    public partial class CustomerGrid
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerGrid(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        private async Task readCustomers(GridReadEventArgs arg)
        {
            arg.Data = await _customerAppService.GetCustomerAppService();
        }


    }
}
