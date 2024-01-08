using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter dbYeteneklerAdd = new DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter();
            dbYeteneklerAdd.YetenekAdd(TxtYetenek.Text);
            Response.Redirect("AdminYetenekler.Aspx");

        }
    }
}