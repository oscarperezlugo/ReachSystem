using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Contrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            string codigo = DateTime.Now.Ticks.ToString();
            string body = "<body>" +
                   "<h5>Dear: " + text1.Value + "</h5>" +
                   "<h6>Your verification code is:</h6>" +
                   "<h5>" + codigo + "</h5>" +
                   "<h6>please copy the code</h6>" +
                   "<h6>And follow the link below to change your password:</h6>" +
                   "<h6><a href='https://tarragobrands.somee.com/Confirmacion'>Reset your password</a></h6>" +                   
                   "<h6>Kind regards,</h6>" +
                   "<h6>Tarrago Brands International.</h6>" +
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
            mail.To.Add(new MailAddress("" + text1.Value.ToString() + ""));
            mail.Subject = "Password Recovery – Tarrago Reach System";
            mail.IsBodyHtml = true;
            mail.Body = body;

            smtp.Send(mail);

            string connectionString = "workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands";
            string query = "UPDATE Usuario SET Verif=@Verif WHERE Email=@Email";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.Add("@Verif", SqlDbType.VarChar, 50).Value = codigo;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = text1.Value;


                // open connection
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                }
                finally
                {
                    con.Close();
                    Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PASSWORD RECOVERY REQUESTED');window.location='login.aspx'</script>");
                }
            }



        }
    }

}