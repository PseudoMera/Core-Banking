using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace Core
{
    public partial class NewClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            using (MyBankEntities entidad = new MyBankEntities())
            {
                string nombre = nameBox.Text;
                string apellido = lnameBox.Text;
                string ciudad = cityBox.Text;
                string pais = countryBox.Text;
                string direccion = dirBox.Text;
                string telefonoResidencial = telResbox.Text;
                string telefonoCelular = telCelBox.Text;
                string sexo = genderListBox.Text;
                string cedulaIdentidad = idBox.Text;

                var c = new Cliente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Ciudad = ciudad,
                    Pais = pais,
                    Direccion = direccion,
                    TelefonoResidencial = telefonoResidencial,
                    TelefonoCelular = telefonoCelular,
                    Sexo = sexo,
                    CedulaIdentidad = cedulaIdentidad
                };

                entidad.Clientes.Add(c);
                entidad.SaveChanges();

                ClientScript.RegisterStartupScript(typeof(Page), "NewClient", "window.close();", true);
            }
        }
    }
}