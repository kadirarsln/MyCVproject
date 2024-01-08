using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminHobiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HOBILERIMTableAdapter dbHobiler = new DataSet1TableAdapters.TBL_HOBILERIMTableAdapter();
            Repeater1.DataSource = dbHobiler.HobilerimListe();
            Repeater1.DataBind();
        }
    }
}