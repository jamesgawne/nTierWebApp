using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CustomerDL
{
    public class clsDataAccessLayer
    {
        private string conn = ConfigurationManager.ConnectionStrings["MyThreeTier"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();
        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }

        public void AddNewCustomerDB(string custname, string custaddr, string custcountry, string custcity, string custpincode)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into CustomerRecord (customer_name,customer_address,customer_country,customer_city,customer_pincode) VALUES ('" + custname + "','" + custaddr + "','" + custcity + "','" + custcountry + "','" + custpincode + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCustomerDB(int custid, string custname, string custaddr, string custcity, string custcountry, string custpincode)
        {
            DataSet ds = new DataSet();
            string sql = "Update CustomerRecord set customer_name'" + custname + "',customer_address ='" + custaddr + "',customer_country = '" + custcountry + "',customer_city = '" + custcity + "', customer_pincode = '" + custpincode + "' Where customer_id = '" + custid + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCustomerDB(int custid)
        {
            DataSet ds = new DataSet();
            string sql = "Delete FROM CustomerRecord WHERE Customer_id = '" + custid + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public object LoadCustomerDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM CustomerRecord order by customer_id";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
