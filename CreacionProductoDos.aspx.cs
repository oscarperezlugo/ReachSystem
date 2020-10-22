using ReachSystem.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class CreacionProductoDos : System.Web.UI.Page
    {
        string NOMBRE;
        string CLASE;        
        protected void Page_Load(object sender, EventArgs e)
        {
            NOMBRE = Request.Cookies["nombreProdC"].Value;
            CLASE = Request.Cookies["clasProdC"].Value;
        }
        private ObservableCollection<Lineas> _linea;
        public ObservableCollection<Lineas> Lineas
        {
            get
            {
                return _linea ?? (_linea = new ObservableCollection<Lineas>());

            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload2.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload2.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Bulgarian",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload1.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Dansk",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload3.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload3.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload3.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Eesti keel",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload4.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload4.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload4.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "English",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload5.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload5.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload5.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Español",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload6.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload6.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload6.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Français",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload7.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload7.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload7.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Deutsch",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload8.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload8.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload8.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Gaeilge",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload9.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload9.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload9.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Greek",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload10.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload10.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload10.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Hrvatski Jezik",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload11.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload11.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload11.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Italiano",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload12.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload12.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload12.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Latviešu",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload13.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload13.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload13.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Lietuvių",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload14.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload14.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload14.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Magyar",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload15.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload15.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload15.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Malti",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload16.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload16.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload16.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Nederlands",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload17.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload17.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload17.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Norsk",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload18.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload18.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload18.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Polski",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload19.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload19.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload19.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Português",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload20.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload20.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload20.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Română",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload20.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload20.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload20.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Română",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload21.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload21.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload21.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Russian",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload22.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload22.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload22.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Slovenčina",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload23.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload23.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload23.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Slovenščina",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload24.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload24.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload24.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Suomi",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload25.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload25.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload25.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Svenska",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload26.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload26.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload26.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Türkçe",
                    Archivo = transferente
                };
                Lineas.Add(linea);
            }
            if (FileUpload27.HasFile == true)
            {
                string transferente;
                Byte[] Archivod = null;
                string nombreArchivo = string.Empty;
                string extensionArchivo = string.Empty;

                using (BinaryReader reader = new
                BinaryReader(FileUpload27.PostedFile.InputStream))
                {
                    Archivod = reader.ReadBytes(FileUpload27.PostedFile.ContentLength);
                    transferente = Convert.ToBase64String(Archivod);
                }
                var linea = new Lineas()
                {
                    Clase = CLASE,
                    NombreProd = NOMBRE,
                    Idioma = "Čeština",
                    Archivo = transferente
                };
                Lineas.Add(linea);
                for (int i = 0; i < Lineas.Count; i++)
                {
                    using (SqlConnection openCon = new SqlConnection("workstation id=tarragoReach.mssql.somee.com;packet size=4096;user id=tarrago_SQLLogin_1;pwd=n84vsf5e47;data source=tarragoReach.mssql.somee.com;persist security info=False;initial catalog=tarragoReach"))
                    {
                        string saveStaff = "INSERT into Producto (Nombre, Clase, Idioma, Archivo) VALUES (@Nombre, @Clase, @Idioma, @Archivo)";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = NOMBRE;
                            querySaveStaff.Parameters.Add("@Clase", SqlDbType.VarChar).Value = CLASE;
                            querySaveStaff.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = Lineas[i].Idioma;
                            querySaveStaff.Parameters.Add("@Archivo", SqlDbType.VarChar).Value = Lineas[i].Archivo;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                                openCon.Close();
                                Response.Write("<script>alert('PRODUCTO CREADO')</script>");
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
    }
}
