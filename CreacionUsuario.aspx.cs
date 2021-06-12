using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace ReachSystem
{
    public partial class CreacionUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["paramuSERC"] != null)
            {
                Contraseña.Attributes.Add("style", "display:none");
                BotonUsu.Text = "ACTUALIZAR USUARIO";
                string connectionString = "workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands";
                string query = "SELECT Nombre, Email, Perfil, Empresa, Pais FROM Usuario WHERE Email=@Email";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = Request.Cookies["paramuSERC"].Value;
                    


                    con.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string prenombre = dr.GetFieldValue<string>(0);
                            string correo= dr.GetFieldValue<string>(1);
                            string Perfil = dr.GetFieldValue<string>(2);
                            string empresa = dr.GetFieldValue<string>(3);
                            string pais = dr.GetFieldValue<string>(4);                            
                            string apellido = prenombre.Split(' ')[1];
                            string nombre = prenombre.Split(' ')[0];
                            Nombre.Value = nombre;
                            Text2.Value = apellido;
                            Apellido.Value = empresa;
                            Correo.Value = correo;
                            DropDownList4.SelectedValue = Perfil;
                            DropDownList2.SelectedValue = pais;                            
                            Response.Cookies["paramuSERC"].Expires = DateTime.Now.AddDays(-1);
                            HttpCookie buscarS = new HttpCookie("botonGuia");
                            buscarS.Value = "1";
                            buscarS.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(buscarS);
                        }
                        else
                        {
                           

                        }

                        dr.Close();
                    }

                    con.Close();
                }
            }
            else
            {
                BotonUsu.Text = "CREAR USUARIO";
                Button1.Attributes.Add("style", "display:none");
            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["botonGuia"] != null)
            {                
                using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
                {
                    string saveStaff = "INSERT into Usuario (Nombre, Email, FechaCreacion, Empresa, Telefono, Direccion, Perfil, Idioma, Pais, IdiomaOrig, EmpresaOrig, Status) VALUES (@Nombre, @Email, @FechaCreacion, @Empresa, @Telefono, @Direccion, @Perfil, @Idioma, @Pais, @IdiomaOrig, @EmpresaOrig, @Status)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "" + Nombre.Value.ToString() + " " + Text2.Value.ToString() + "";
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Correo.Value.ToString();
                        querySaveStaff.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = Apellido.Value.ToString();
                        querySaveStaff.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = "";/* Telefono.Value.ToString();*/
                        querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = "";/*Dirección.Value.ToString();*/
                        querySaveStaff.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = "";/* DropDownList1.SelectedValue.ToString();*/
                        querySaveStaff.Parameters.Add("@Pais", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@IdiomaOrig", SqlDbType.VarChar).Value = "";/* DropDownList3.SelectedValue.ToString();*/
                        querySaveStaff.Parameters.Add("@EmpresaOrig", SqlDbType.VarChar).Value = "";/* Text1.Value.ToString();*/
                        //querySaveStaff.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Contraseña.Value.ToString();
                        querySaveStaff.Parameters.Add("@Status", SqlDbType.VarChar).Value = "APROBADO";
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Cookies["botonGuia"].Expires = DateTime.Now.AddDays(-1);
                            Response.Write("<script>alert('USUARIO ACTUALIZADO')</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
            else
            {
                if (Contraseña.Value.ToString() != null)
                {
                    string body = "<body>" +
                        "<h4>Dear: " + Nombre.Value + "</h4>" +
                        "<h4>You have been approved as a user of the Tarrago Reach System.</h4>" +
                        "<h4>Remember that you can access with www.reach.tarrago.com</h4>" +
                        "<h4>Kind regards,</h4>" +
                        "<h4>Tarrago Brands International.</h4>" +
                        "<img  src='https://www.tarrago.com/wp-content/uploads/2019/07/logo-tarrago-web.png' />" +
                        "</body>";
                    SmtpClient smtp = new SmtpClient();
                    smtp.EnableSsl = false;
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = "smtp.tarragobrands.somee.com";
                    smtp.Port = 26;
                    smtp.Credentials = new NetworkCredential("noreply@tarragobrands.somee.com", "Otto.123");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("noreply@tarragobrands.somee.com", "Tarrago Brands International");
                    mail.To.Add(new MailAddress("" + Correo.Value.ToString() + ""));
                    mail.Subject = "Your Reach System Registration has been approved";
                    mail.IsBodyHtml = true;
                    mail.Body = body;

                    smtp.Send(mail);

                    using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
                    {
                        string saveStaff = "INSERT into Usuario (Nombre, Email, FechaCreacion, Empresa, Telefono, Direccion, Perfil, Idioma, Pais, IdiomaOrig, EmpresaOrig, Pass, Status) VALUES (@Nombre, @Email, @FechaCreacion, @Empresa, @Telefono, @Direccion, @Perfil, @Idioma, @Pais, @IdiomaOrig, @EmpresaOrig, @Pass, @Status)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = "" + Nombre.Value.ToString() + " " + Text2.Value.ToString() + "";
                            querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Correo.Value.ToString();
                            querySaveStaff.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                            querySaveStaff.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = Apellido.Value.ToString();
                            querySaveStaff.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = "";/* Telefono.Value.ToString();*/
                            querySaveStaff.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = "";/*Dirección.Value.ToString();*/
                            querySaveStaff.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = "";/* DropDownList1.SelectedValue.ToString();*/
                            querySaveStaff.Parameters.Add("@Pais", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                            querySaveStaff.Parameters.Add("@IdiomaOrig", SqlDbType.VarChar).Value = "";/* DropDownList3.SelectedValue.ToString();*/
                            querySaveStaff.Parameters.Add("@EmpresaOrig", SqlDbType.VarChar).Value = "";/* Text1.Value.ToString();*/
                            querySaveStaff.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Contraseña.Value.ToString();
                            querySaveStaff.Parameters.Add("@Status", SqlDbType.VarChar).Value = "APROBADO";
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('USUARIO REGISTRADO')</script>");
                            }
                            catch (SqlException ex)
                            {
                                Response.Write("Error" + ex);
                            }
                        }
                    }

                }
                else
                {
                    Response.Write("<script>alert('LAS CONTRASEÑAS NO COINCIDEN')</script>");
                }
            }
            

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
            {
                string saveStaff = "Delete from Usuario where Email = @Email";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;                    
                    querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Correo.Value.ToString();                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('USUARIO ELIMINADO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }

        }
            
            


        
    }
}
