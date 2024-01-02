using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAKKIMDATableAdapter dbHakkımda = new DataSet1TableAdapters.TBL_HAKKIMDATableAdapter();

            TextBox1.Text = dbHakkımda.HakkımdaListele()[0].AD;
            TextBox2.Text = dbHakkımda.HakkımdaListele()[0].SOYAD;
            TextBox3.Text = dbHakkımda.HakkımdaListele()[0].ADRES;
            TextBox4.Text = dbHakkımda.HakkımdaListele()[0].MAIL;
            TextBox5.Text = dbHakkımda.HakkımdaListele()[0].TELEFON;
            TextBox6.Text = dbHakkımda.HakkımdaListele()[0].FOTOGRAFD;
            TextBox7.Text = dbHakkımda.HakkımdaListele()[0].KISANOT;

        }
    }
}