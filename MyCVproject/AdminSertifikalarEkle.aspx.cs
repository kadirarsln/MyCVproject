using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminSertifikalarEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalarAdd = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
            dbSertifikalarAdd.SertifikaAdd(TxtBaslik.Text, TxtSertifika.Text);
            Response.Redirect("AdminSertifikalar.Aspx");
        }
    }
}