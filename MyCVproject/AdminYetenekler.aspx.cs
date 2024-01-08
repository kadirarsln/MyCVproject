using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminYetenekler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter dbYetenekler = new DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter();
            Repeater1.DataSource = dbYetenekler.YeteneklerimListe();
            Repeater1.DataBind();
        }
    }
}