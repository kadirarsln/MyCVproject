using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCVproject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection(@"Data Source = KADIR\SQLEXPRESS; Initial Catalog = CvWebDb; Integrated Security = True; trustServercertificate=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_ADMIN where USERNAME=@P1 and PASSWORD=@P2", connect);
            cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
            cmd.Parameters.AddWithValue("@P2", TxtPassword.Text);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Response.Redirect("AdminDeneyimler.Aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre!");
            }
            connect.Close();
        }
    }
}