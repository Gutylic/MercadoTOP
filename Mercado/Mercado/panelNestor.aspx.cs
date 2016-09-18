using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class panelNestor : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int? resultado;

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void botonCrearAdministrador_Click(object sender, EventArgs e)
        {
            db.insertarAdministrador(nickAdministrador.Text, ref resultado);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Administrador creado');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            string script1 = @"<script type='text/javascript'>
                            alert('no pude crear administrador');
                        </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script1, false);
            return;
        }

        protected void botonBorrarAdministrador_Click(object sender, EventArgs e)
        {
            db.borrarAdministrador(nickAdministrador.Text, ref resultado);
            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Administrador borrado');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }

            string script1 = @"<script type='text/javascript'>
                            alert('Administrador no pudo ser borrado');
                        </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script1, false);
            return;




        }

        protected void mostrarProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("productosNestor.aspx");
        }
    }
}