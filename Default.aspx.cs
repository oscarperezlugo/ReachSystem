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

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            string nombre = GridView1.Rows[i].Cells[1].Text;
            string clase = GridView1.Rows[i].Cells[2].Text;

            HttpCookie nombreS = new HttpCookie("nombreProdC");
            nombreS.Value = nombre;
            nombreS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(nombreS);

            HttpCookie claseS = new HttpCookie("clasProdC");
            claseS.Value = clase;
            claseS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(claseS);

            Response.Redirect("CreacionProductoDos.aspx");
        }
    }
}