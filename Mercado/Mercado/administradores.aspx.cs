using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class administradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string resultado;
        int? respuesta;

        protected void botonIngresar_Click(object sender, EventArgs e)
        {
            if (nickAdministrador.Text == "Nestor" && contrasenaUsuario.Text == "MercadoTOP")
            {

                Session["nickUsuario"] = nickAdministrador.Text;

                Response.Redirect("panelNestor.aspx");


            }




            db.loguearUsuario(nickAdministrador.Text, contrasenaUsuario.Text, ref resultado);
            db.usuarioRelacionadoAdministrador(nickUsuario.Text, ref respuesta);

            string[] logueo = resultado.ToString().Split('?');

            if (respuesta == -1 || respuesta == -6)
            {

                string script = @"<script type='text/javascript'>
                            alert('no existe ese usuario');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            } 


            if (resultado == "-1" || resultado == "-6")
            {
                string script = @"<script type='text/javascript'>
                            alert('no puede loguearse');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else
            {
                Session["nickUsuario"] = nickAdministrador.Text;
                Session["usuarioRelacionado"] = respuesta;
                Session["id_Usuario"] = logueo[2];




                Response.Redirect("panelUsuario.aspx");

            }


        }


    }
}