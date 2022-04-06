using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :" + customer.FirstName);
        }

        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
