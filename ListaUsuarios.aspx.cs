using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ListaUsuarios : Page
    {
        int M;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( GridView1.Rows.Count > 0)
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
                string correo = GridView1.Rows[i].Cells[0].Text;
                HttpCookie buscarS = new HttpCookie("paramuSERC");
                buscarS.Value = correo;
                buscarS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(buscarS);
                Response.Redirect("CreacionUsuario.aspx");
            }
            else
            {
                int i = GridView2.SelectedIndex;
                string correo = GridView2.Rows[i].Cells[0].Text;
                HttpCookie buscarS = new HttpCookie("paramuSERC");
                buscarS.Value = correo;
                buscarS.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(buscarS);
                Response.Redirect("CreacionUsuario.aspx");
            }

            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramcuatroC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("ListaUsuarios.aspx");
        }
        
    }
}