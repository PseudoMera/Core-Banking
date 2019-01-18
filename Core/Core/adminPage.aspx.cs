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
            gridClientes.DataSource = from cliente in dbContext.Clientes
                                      where cliente.CedulaIdentidad == SearchBox.Text
                                      orderby cliente.ID
                                      select cliente;
            gridClientes.DataBind();
        }
    }
}