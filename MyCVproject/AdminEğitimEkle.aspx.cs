﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminEğitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEgitimlerAdd = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            dbEgitimlerAdd.EğitimAdd(TxtBaslik.Text, TxtBaslik.Text, TxtAciklama.Text, TxtGNot.Text, TxtTarih.Text);
            Response.Redirect("AdminEğitimler.Aspx");
        }
    }
}