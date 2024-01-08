using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminEgitimUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Enabled = false;
            TxtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEgitimGet = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
                TxtBaslik.Text = dbEgitimGet.EgitimGetById(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dbEgitimGet.EgitimGetById(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAciklama.Text = dbEgitimGet.EgitimGetById(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtGNot.Text = dbEgitimGet.EgitimGetById(Convert.ToInt16(id))[0].GNOT;
                TxtTarih.Text = dbEgitimGet.EgitimGetById(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEgitimUpdate = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            dbEgitimUpdate.EgitimUpdate(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGNot.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminEğitimler.Aspx");
        }
    }
}