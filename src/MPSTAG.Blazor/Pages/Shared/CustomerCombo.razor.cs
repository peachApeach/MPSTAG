using MPSTAG.Customers;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace MPSTAG.Blazor.Pages.Shared
{
    public partial class CustomerCombo
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerCombo(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public async Task GetCustomer(ComboBoxReadEventArgs args)
        {
            args.Data = await _customerAppService.GetCustomerAppService();
        }
    }
}
