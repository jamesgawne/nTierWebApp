using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerBL;

namespace addUser
{
    public partial class aspAddCustomer : System.Web.UI.Page
    {
        clsBusinessLayer objLogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new clsBusinessLayer();
            GridView1.DataSource = objLogic.LoadCustomer();
            GridView1.DataBind();
        }

        //protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        //{

        //}

        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
           // objLogic = new clsBusinessLayer();

            objLogic = new clsBusinessLayer();

            if (HiddenField1.Value == "")
            {
                objLogic.AddNewCustomer(txtCustName.Text, txtCustAddr.Text, txtCustCountry.Text, txtCustCity.Text, txtCustPincode.Text);
            }

            Response.Redirect("aspAddCustomer.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddCustomer_Click1(object sender, EventArgs e)
        {
            objLogic = new clsBusinessLayer();

            if (HiddenField1.Value == "")
            {
                objLogic.AddNewCustomer(txtCustName.Text, txtCustAddr.Text, txtCustCountry.Text, txtCustCity.Text, txtCustPincode.Text);
            }

            Response.Redirect("aspAddCustomer.aspx");
        }
    }
}