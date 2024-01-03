using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dbDeneyimler = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            Repeater1.DataSource = dbDeneyimler.DeneyimListe();
            Repeater1.DataBind();
        }
    }
}