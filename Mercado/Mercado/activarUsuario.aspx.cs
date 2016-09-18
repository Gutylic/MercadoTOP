using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class activarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        int? resultado;

        protected void botonActivar_Click(object sender, EventArgs e)
        {

            string Usuario = Request.QueryString["nombre"];


            db.activarUsuario(Usuario, int.Parse(celularUsuario.Text), ref resultado);

            if (resultado == 1) {
                Response.Redirect("index.aspx");

            }
            if (resultado == 0) {

                string script = @"<script type='text/javascript'>
                            alert('no coincide el codigo de activacion');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }
            if (resultado == -6) {
                string script = @"<script type='text/javascript'>
                            alert('en estos momentos no pudo conectarse');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }

        }
    }
}