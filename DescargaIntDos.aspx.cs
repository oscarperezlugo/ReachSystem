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
    public partial class DescargaIntDos : System.Web.UI.Page
    {
        string CLASE;
        string IDIOMA;
        string NOMBRE;
        protected void Page_Load(object sender, EventArgs e)
        {
            IDIOMA = Request.Cookies["paramunoC"].Value;
            CLASE = Request.Cookies["paramdosC"].Value;
            NOMBRE = Request.Cookies["paramtresC"].Value;
            if (GridView1.Rows.Count == 0)
            {
                Label1.Text = "Sorry we have not got the required product. Please try again by entering the product short code.";
                GridView1.Attributes.Add("style", "display:none");
            }
            else
            {
                Label1.Attributes.Add("style", "display:none");
            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Descarga.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            using (SqlConnection openCon = new SqlConnection("workstation id=tarragobrands.mssql.somee.com;packet size=4096;user id=tarragobrands_SQLLogin_1;pwd=mjmdlqn93g;data source=tarragobrands.mssql.somee.com;persist security info=False;initial catalog=tarragobrands"))
            {
                string saveStaff = "SELECT Archivo FROM Productos WHERE Idioma=@Idioma AND Clase=@Clase AND Nombre=@Nombre";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = IDIOMA;
                    querySaveStaff.Parameters.Add("@Clase", SqlDbType.VarChar).Value = CLASE;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = GridView1.Rows[i].Cells[0].Text;

                    try
                    {
                        openCon.Open();
                        using (SqlDataReader dr = querySaveStaff.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string archivo = dr.GetFieldValue<string>(0);
                                var transporte = Convert.FromBase64String(archivo);
                                Response.Clear();
                                Response.ClearHeaders();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("content-disposition", "attachment; filename=" + "" + IDIOMA + " " + CLASE + " " + GridView1.Rows[0].Cells[0].Text + ".pdf");
                                Response.BufferOutput = true; ;
                                Response.OutputStream.Write(transporte, 0, transporte.Length);
                                Response.End();

                            }
                            else
                            {

                            }

                            dr.Close();
                        }
                        openCon.Close();


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