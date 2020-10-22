using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=tarragoReach.mssql.somee.com;packet size=4096;user id=tarrago_SQLLogin_1;pwd=n84vsf5e47;data source=tarragoReach.mssql.somee.com;persist security info=False;initial catalog=tarragoReach";
            string query = "SELECT Nombre, Row, Perfil FROM Usuario WHERE Email=@Email AND Pass=@Pass;";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = Correo.Value.ToString();
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = Contrasena.Value.ToString();


                con.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string nombre = dr.GetFieldValue<string>(0);
                        int Row = dr.GetFieldValue<int>(1);
                        string Perfil = dr.GetFieldValue<string>(2);
                        HttpCookie nombreS = new HttpCookie("nombreC");
                        nombreS.Value = nombre;
                        nombreS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(nombreS);
                        
                        HttpCookie idclienteS = new HttpCookie("idclienteC");
                        idclienteS.Value = Row.ToString();
                        idclienteS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(idclienteS);
                        
                        HttpCookie perfilS = new HttpCookie("PerfilC");
                        perfilS.Value = Perfil;
                        perfilS.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(perfilS);

                        Response.Write("<script>alert('BIENVENIDO')</script>");
                        Response.Redirect("Default.aspx");

                    }
                    else
                    {
                        Response.Write("<script>alert('Usuario y Contraseña incorrectos')</script>");

                    }

                    dr.Close();
                }

                con.Close();
            }
        }

    }
    
}