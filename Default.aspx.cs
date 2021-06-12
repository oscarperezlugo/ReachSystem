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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count > 0)
            {
                GridView2.Attributes.Add("style", "display:none");
            }
            else
            {
                GridView1.Attributes.Add("style", "display:none");
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.Rows.Count > 0)
            {
                int i = GridView1.SelectedIndex;
                string codigo = GridView1.Rows[i].Cells[3].Text;
                string clase = GridView1.Rows[i].Cells[2].Text;
                using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
                {
                    string saveStaff = "Delete from Productos where Clase = @Clase AND Codigo=@Codigo";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Clase", SqlDbType.VarChar).Value = clase;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PRODUCTO ELIMINADO')</script>");
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
                int i = GridView2.SelectedIndex;
                string codigo = GridView2.Rows[i].Cells[3].Text;
                string clase = GridView2.Rows[i].Cells[2].Text;
                using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
                {
                    string saveStaff = "Delete from Productos where Clase = @Clase AND Codigo=@Codigo";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Clase", SqlDbType.VarChar).Value = clase;
                        querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('PRODUCTO ELIMINADO')</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }
            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramcincoC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("Default.aspx");
        }
    }
}