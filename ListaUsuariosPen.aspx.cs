﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class ListaUsuariosPen : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            using (SqlConnection openCon = new SqlConnection("workstation id=tarragoReach.mssql.somee.com;packet size=4096;user id=tarrago_SQLLogin_1;pwd=n84vsf5e47;data source=tarragoReach.mssql.somee.com;persist security info=False;initial catalog=tarragoReach"))
            {

                string saveStaff = "UPDATE Usuario SET Status = @Status WHERE Row = @Row";
                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Status", SqlDbType.VarChar).Value = "APROBADO";
                    querySaveStaff.Parameters.Add("@Row", SqlDbType.Int).Value = Int32.Parse(GridView1.Rows[i].Cells[0].Text);
                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                    }
                    catch (SqlException ex)
                    {
                    }
                }

            }
        }
    }
}