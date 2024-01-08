using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminSertifikaDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalarDelete = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
            dbSertifikalarDelete.SertifikaDelete(Convert.ToInt16(id));
            Response.Redirect("AdminSertifikalar.Aspx");
        }
    }
}