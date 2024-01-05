using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminEğitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEğitimler = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            Repeater1.DataSource = dbEğitimler.EgitimListe();
            Repeater1.DataBind();
        }
    }
}