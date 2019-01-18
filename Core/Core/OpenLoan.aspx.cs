using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class LoanPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void abrirBtn_Click(object sender, EventArgs e)
        {
            using (MyBankEntities entities = new MyBankEntities())
            {
                if (cedulaBox.Text != "" && DeudaBox.Text != "" && plazoBox.Text != "")
                {
                    int intereses = 2;
                    DateTime fechaAper = DateTime.Now;
                    TimeSpan time = new TimeSpan(36, 5, 7, 0);
                    DateTime combined = fechaAper.Add(time);
                    DateTime fechaPlazo = combined;
                    var cuentaRelaciona = entities.Clientes.FirstOrDefault(t => t.CedulaIdentidad.Equals(cedulaBox.Text));
                    int cr = cuentaRelaciona.ID;
                    float monto = Convert.ToSingle(DeudaBox.Text);
                    var c = new Prestamo
                    {
                        Intereses = intereses,
                        FechaApertura = fechaAper,
                        FechaPlazo = fechaPlazo,
                        CuentaRelacionada = cr,
                        Monto = monto
                    };

                    entities.Prestamos.Add(c);
                    entities.SaveChanges();
                } else
                {
                    Response.Write("No ha introducido ningun dato");
                }
            }

        }
    }
}