using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class LoanPayment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pagarBtn_Click(object sender, EventArgs e)
        {
            using (MyBankEntities entities = new MyBankEntities())
            {
                if (saldoBox.Text != "" && cedulaBox != "")
                {
                    float monto = Convert.ToSingle(saldoBox.Text);
                    Cliente rest = entities.Clientes.FirstOrDefault(c => c.CedulaIdentidad == cedulaBox.Text);
                    Prestamo prest = entities.Prestamos.FirstOrDefault(c => c.CuentaRelacionada == rest.ID);

                    if (monto > prest.Monto)
                    {
                        Response.Write("No puedes pagar de mas");
                    }
                    else
                    {
                        prest.Monto -= monto;
                    }


                    entities.SaveChanges();
                    Response.Redirect("~/adminPage.aspx");
                } else
                {
                    Response.Write("No ha introducido ningun dato");
                }
        }
    }
}