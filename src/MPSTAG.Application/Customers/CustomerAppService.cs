
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MPSTAG.Customers
{
    public class CustomerAppService : MPSTAGAppService, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            //repository에 , ITransientDependency를 상속받음으로써 해당 생성자를 사용할 수 있게 되었다.
            _customerRepository = customerRepository;
        }   

        public async Task<List<CustomerDto>> GetCustomerAppService()
        {
            var customers = await _customerRepository.GetListCustomerAsync();
            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }


    }
}
