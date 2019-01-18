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
           
        }

        protected void NewCliente_Click(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            DBmodelDataContext dbContext = new DBmodelDataContext();
            Cliente client = dbContext.Clientes.FirstOrDefault(t => t.CedulaIdentidad == SearchBox.Text);
            Cuenta cuent = new Cuenta();

            gridClientes.DataSource = from clientes in dbContext.Clientes where clientes.CedulaIdentidad == SearchBox.Text select clientes;
            gridClientes.DataBind();
           
            cuentasGV.DataSource = client.Cuentas;
            cuentasGV.DataBind();   
        }

        protected void openCliente_Click(object sender, EventArgs e)
        {
            if(gridClientes.Rows.Count > 0)
                Response.Redirect("~/PerfilCliente.aspx");
        }
    }
}