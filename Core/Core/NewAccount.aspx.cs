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
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CoreDBConnectionString"].ToString();
            using (MyBankEntities entidad = new MyBankEntities())
            { 
                int idcliente = Convert.ToInt32(entidad.Clientes.FirstOrDefault(c => c.CedulaIdentidad.Equals(cedulaBox.Text)));
                string tipo = tipoBox.Text;
                float saldo = Convert.ToSingle(saldoBox.Text);
                float tasainteres = Convert.ToSingle(0);
                int numerocuenta = rnd.Next(1,10000);

                var t = new Cuenta
                {
                    ID = idcliente,
                    Tipo = tipo,
                    Saldo = saldo,
                    TasaInteres = tasainteres,
                    NumeroCuenta = numerocuenta,
                   

                };

                entidad.Cuentas.Add(t);
                
                ClientScript.RegisterStartupScript(typeof(Page), "NewAccount", "window.close();", true);
            }
        }
    }
}