using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class NewClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBConnectionString"].ToString();
            DBmodelDataContext db = new DBmodelDataContext(connectionString);
            Cliente cliente = new Cliente();
            cliente.Nombre = nameBox.Text;
            cliente.Apellido = lnameBox.Text;
            cliente.Ciudad = cityBox.Text;
            cliente.Pais = countryBox.Text;
            cliente.Direccion = dirBox.Text;
            cliente.TelefonoResidencial = telResbox.Text;
            cliente.TelefonoCelular = telCelBox.Text;
            cliente.FechaCreacion = DateTime.Now;
            cliente.Sexo = genderListBox.Text;
            cliente.CedulaIdentidad = idBox.Text;       
            db.Clientes.InsertOnSubmit(cliente);
            db.SubmitChanges();          
            ClientScript.RegisterStartupScript(typeof(Page), "NewClient", "window.close();", true);           
        }
    }
}