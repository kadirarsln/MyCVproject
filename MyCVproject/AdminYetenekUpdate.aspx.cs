using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminYetenekUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Enabled = false;
            TxtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter dbYetenekGet = new DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter();
                TxtYetenek.Text = dbYetenekGet.YetenekGetDataById(Convert.ToInt16(id))[0].YETENEK;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter dbYetenekUpdate = new DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter();
            dbYetenekUpdate.YetenekUpdate(TxtYetenek.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminYetenekler.Aspx");
        }
    }
}