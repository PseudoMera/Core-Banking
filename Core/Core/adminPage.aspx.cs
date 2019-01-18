using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (MyBankEntities entidad = new MyBankEntities())
            {
                movimientosGV.DataSource = (from u in entidad.Movimientos select u).ToList();
                movimientosGV.DataBind();
            }
        }

        protected void NewCliente_Click(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            Cuenta cuent = new Cuenta();
            using (MyBankEntities entidad = new MyBankEntities())
            {
                // Cliente client = from cliente in entidad.Clientes where cliente.CedulaIdentidad == SearchBox.Text select cliente;
                var cli = entidad.Clientes.FirstOrDefault(t => t.CedulaIdentidad.Equals(SearchBox.Text));

                gridClientes.DataSource = (from u in entidad.Clientes where u.CedulaIdentidad == SearchBox.Text select u).ToList();
                gridClientes.DataBind();
                var cuentaRelaciona = entidad.Clientes.FirstOrDefault();

                cuentasGV.DataSource = (from u in entidad.Cuentas where u.ID == cli.ID select u).ToList();
                cuentasGV.DataBind();

                prestamoGV.DataSource = (from u in entidad.Prestamos where u.CuentaRelacionada == cli.ID select u).ToList();
                prestamoGV.DataBind();

                

               // transaccionesGV.DataSource = (from u in entidad.Movimientos select u).ToList();
              // transaccionesGV.DataBind();
               // cuentasGV.DataSource = ;
               // cuentasGV.DataBind();
            }
        }

        protected void openCliente_Click(object sender, EventArgs e)
        {
            if(gridClientes.Rows.Count > 0)
                Response.Redirect("~/PerfilCliente.aspx");
        }

        protected void AbrirPrestamo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OpenLoan.aspx");
        }
    }
}