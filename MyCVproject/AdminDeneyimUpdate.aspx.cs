using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminDeneyimUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Enabled = false;
            TxtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dbDeneyimGet = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
                TxtBaslik.Text = dbDeneyimGet.DeneyimGetById(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dbDeneyimGet.DeneyimGetById(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAciklama.Text = dbDeneyimGet.DeneyimGetById(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtTarih.Text = dbDeneyimGet.DeneyimGetById(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dbDeneyimUpdate = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            dbDeneyimUpdate.DeneyimUpdate(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}