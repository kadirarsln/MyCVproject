using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class AdminHobiUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Enabled = false;
            TxtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_HOBILERIMTableAdapter dbHobilerGet = new DataSet1TableAdapters.TBL_HOBILERIMTableAdapter();
                TxtHobi.Text = dbHobilerGet.HobiGetById(Convert.ToInt16(id))[0].HOBI;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HOBILERIMTableAdapter dbHobilerUpdate = new DataSet1TableAdapters.TBL_HOBILERIMTableAdapter();
            dbHobilerUpdate.HobiUpdate(TxtHobi.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminHobiler.Aspx");
        }
    }
}