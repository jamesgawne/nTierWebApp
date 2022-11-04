using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerBL;

namespace addUser
{
    public partial class _Default : Page
    {
        clsBusinessLayer objLogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new clsBusinessLayer();
        }
    }
}