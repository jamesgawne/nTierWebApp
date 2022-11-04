using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDL;

namespace CustomerBL
{
    public class clsBusinessLayer
    {
        public CustomerDL.clsDataAccessLayer objDataLayer = new CustomerDL.clsDataAccessLayer();

        public void AddNewCustomer(string custname, string custaddr, string custcountry, string custcity, string custpincode)
        {
            objDataLayer.AddNewCustomerDB(custname, custaddr, custcountry, custcity, custpincode);
        }

        public void UpdateCustome(int custid, string custname, string custaddr, string custcountry, string custcity, string custpincode)
        {
            objDataLayer.UpdateCustomerDB(custid, custname, custaddr, custcountry, custcity, custpincode);
        }

        public void DeleteCustomer(int custid)
        {
            objDataLayer.DeleteCustomerDB(custid);
        }

        public object LoadCustomer()
        {
            return objDataLayer.LoadCustomerDB();
        }
    }
}
