using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminSertifikaUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Enabled = false;
            TxtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalarGet = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
                TxtBaslik.Text = dbSertifikalarGet.SertifikaGetById(Convert.ToInt16(id))[0].BASLIK;
                TxtSertifika.Text = dbSertifikalarGet.SertifikaGetById(Convert.ToInt16(id))[0].SERTIFIKALARIM;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalarUpdate = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
            dbSertifikalarUpdate.SertifikaUpdate(TxtBaslik.Text, TxtSertifika.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminSertifikalar.Aspx");
        }
    }
}