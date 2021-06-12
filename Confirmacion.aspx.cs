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
    public partial class Confirmacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            
            if (text2.Value == text3.Value)
            {

                string connectionString = "workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands";
                string query = "UPDATE Usuario SET Pass=@Pass WHERE Verif=@Verif";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = text2.Value;
                    cmd.Parameters.Add("@Verif", SqlDbType.BigInt, 50).Value = Int64.Parse(text1.Value);

                    
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
                        Page.RegisterStartupScript("LoadFunction", "<script type='text/javascript'>alert('PASSWORD UPDATED');window.location='login.aspx'</script>");                       
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('PASWORDS NOT MATCHING')</script>");
            }
        }
    }

        
   
}