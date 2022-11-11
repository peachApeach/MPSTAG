using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MPSTAG.Customers
{
    public class CustomerAppService : ApplicationService, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }   

        public async Task<List<CustomerDto>> GetCustomerAppService()
        {
            var customers = await _customerRepository.GetListCustomerAsync();
            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
        }


    }
}
