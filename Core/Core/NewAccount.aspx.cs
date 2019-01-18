using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class NewAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBConnectionString"].ToString();
            DBmodelDataContext db = new DBmodelDataContext(connectionString);
            Cuenta account = new Cuenta();
            Cliente cliente = db.Clientes.FirstOrDefault(t => t.CedulaIdentidad.Equals(cedulaBox.Text));
            account.NumeroDeCuenta = rnd.Next(1, 5000);
            account.Tipo = tipoBox.Text;
            account.Propietario = cliente.Nombre;
            account.Saldo = Convert.ToInt64(saldoBox.Text);
            account.IdCuenta = cliente.ID;
            account.TasaInteres = 0;
            db.Cuentas.InsertOnSubmit(account);
            db.SubmitChanges();
            ClientScript.RegisterStartupScript(typeof(Page), "NewAccount", "window.close();", true);
        }
    }
}