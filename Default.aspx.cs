using System;
using System.Collections.Generic;
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
            int i = GridView1.SelectedIndex;
            string nombre = GridView1.Rows[i].Cells[1].Text;
            string clase = GridView1.Rows[i].Cells[2].Text;
            string codigo = GridView1.Rows[i].Cells[3].Text;

            HttpCookie nombreS = new HttpCookie("nombreProdC");
            nombreS.Value = nombre;
            nombreS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombreS);

            HttpCookie claseS = new HttpCookie("clasProdC");
            claseS.Value = clase;
            claseS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(claseS);

            HttpCookie codigoS = new HttpCookie("codProdC");
            codigoS.Value = codigo;
            codigoS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(codigoS);

            Response.Redirect("CreacionProductoDos.aspx");
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