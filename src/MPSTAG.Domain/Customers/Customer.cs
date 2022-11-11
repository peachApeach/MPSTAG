using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MPSTAG.Customers
{
    public class Customer
    {
        public int customer_id { get; set; }
        public string name { get; set; }

        //public override object[] GetKeys()
        //{
        //    return new object[] { customer_id };
        //}

    }
}
