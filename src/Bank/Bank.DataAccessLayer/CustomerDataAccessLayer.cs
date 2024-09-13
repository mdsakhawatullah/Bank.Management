

using Bank.DataAccessLayer.DALContracts;
using Bank.Entities;
using Bank.Exceptions;

namespace Bank.DataAccessLayer
{
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        #region Private Fields
        private static List<Customer> _customer;


        #endregion

        #region Constructor
        static CustomerDataAccessLayer() {
            _customer = new List<Customer>();
        }

        #endregion

        #region Properties
        private static List<Customer> Customers { get => _customer; set => _customer = value; }

        #endregion

        #region Method
        public List<Customer> GetCustomers()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                Customers.ForEach(item => customerList.Add(item.Clone() as Customer));

                return customerList;
            }
            catch(CustomerException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public List<Customer> GetCustomerByConditon(Predicate<Customer> predicate)
        {
            try
            {
                List<Customer> customersList = new List<Customer>();

                List<Customer> filteredCustomer = Customers.FindAll(predicate);

                filteredCustomer.ForEach(item => filteredCustomer.Add(item.Clone() as Customer));
                return filteredCustomer;
            }

            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Guid AddCustomer(Customer customer)
        {
            try
            {


                customer.CustomerID = Guid.NewGuid();
                Customers.Add(customer);

                return customer.CustomerID;
            }

            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {


                Customer existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = customer.CustomerCode;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Mobile = customer.Mobile;

                    return true;

                }
                return false;
            }

            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                if (Customers.RemoveAll(item => item.CustomerID == customer.CustomerID) > 0)
                    return true;
                else
                    return false;
            }

            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
