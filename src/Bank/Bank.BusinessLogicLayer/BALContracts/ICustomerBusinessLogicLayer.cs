using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BusinessLogicLayer.BALContracts
{
    public interface ICustomerBusinessLogicLayer
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerByConditon(Predicate<Customer> peridicate);
        bool DeleteCustomer(Customer customerId);
        bool UpdateCustomer(Customer customer);
        Guid AddCustomer(Customer customer);

    }
}
