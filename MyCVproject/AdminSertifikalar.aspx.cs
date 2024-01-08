using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminSertifikalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalar = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
            Repeater1.DataSource = dbSertifikalar.SertifikalarımListe();
            Repeater1.DataBind();
        }
    }
}