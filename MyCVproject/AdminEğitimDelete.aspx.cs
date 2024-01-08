using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminEğitimDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEgitimDelete = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            dbEgitimDelete.EgitimDelete(Convert.ToInt16(id));
            Response.Redirect("AdminEğitimler.Aspx");
        }
    }
}