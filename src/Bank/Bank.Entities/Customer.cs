using Bank.Entities.contracts;
using Bank.Exceptions;
using System;
using System.Collections.Generic;


namespace Bank.Entities
{
    public class Customer : ICustomer, ICloneable
    {
        /// <summary>
        /// Interface of the Customer 
        /// </summary>

        #region Private Field
        private Guid _customerId;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _city;
        private string _country;
        private int _mobile;
        #endregion

        #region Public Properties
        public Guid CustomerID { get => _customerId; set => _customerId = value; }
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                if (value > 0)
                    _customerCode = value;
                else
                    throw new CustomerException("Customer Code positive only");
            }
        }
        public string CustomerName 
        { 
            get => _customerName;
            set
            {
                if (value.Length <= 30 && string.IsNullOrEmpty(value) == false)
                    _customerName = value;
                else
                    throw new Exception("Customer name should not be NULL");
            }
                
                
        }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Country { get => _country; set => _country = value; }
        public int Mobile { get => _mobile; set => _mobile = value; }
        #endregion

        #region Method
        public object Clone()
        {
            return new Customer()
            {
                CustomerID = this.CustomerID,
                CustomerName = this.CustomerName,
                Address = this.Address,
                City = this.City,
                Country = this.Country,
                Mobile = this.Mobile
            };
        }
        #endregion


    }
}
