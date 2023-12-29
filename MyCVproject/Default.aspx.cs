using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAKKIMDATableAdapter dbHakkımda = new DataSet1TableAdapters.TBL_HAKKIMDATableAdapter();
            Repeater1.DataSource = dbHakkımda.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter dbDeneyimlerim = new DataSet1TableAdapters.TBL_DENEYIMLERIMTableAdapter();
            Repeater2.DataSource = dbDeneyimlerim.DeneyimListe();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBL_EGITIMTableAdapter dbEgitim = new DataSet1TableAdapters.TBL_EGITIMTableAdapter();
            Repeater3.DataSource = dbEgitim.EgitimListe();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBL_HOBILERIMTableAdapter dbHobilerim = new DataSet1TableAdapters.TBL_HOBILERIMTableAdapter();
            Repeater5.DataSource = dbHobilerim.HobilerimListe();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBL_SERTIFIKATableAdapter dbSertifikalarım = new DataSet1TableAdapters.TBL_SERTIFIKATableAdapter();
            Repeater6.DataSource = dbSertifikalarım.SertifikalarımListe();
            Repeater6.DataBind();

            DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter dbYeteneklerim = new DataSet1TableAdapters.TBL_YETENEKLERIMTableAdapter();
            Repeater4.DataSource = dbYeteneklerim.YeteneklerimListe();
            Repeater4.DataBind();
        }
    }
}