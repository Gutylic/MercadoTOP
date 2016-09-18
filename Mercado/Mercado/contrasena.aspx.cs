using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class contrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string contrasenaUsuario;

        protected void botonContrasena_Click(object sender, EventArgs e)
        {
            db.recuperarContrasena(nickUsuario.Text, ref contrasenaUsuario);

            string[] datosObtenidos = contrasenaUsuario.ToString().Split('?');


            if (contrasenaUsuario == "0"){

                nickUsuario.Text = string.Empty;

                string script1 = @"<script type='text/javascript'>
                            alert('ese usuario no existe en nuestra base de datos');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script1, false);
                return;
            }

            WebClient Cliente = new WebClient();
            string baseUrl = " https://www.smsc.com.ar/api/0.2/?alias=Martiva&apikey=7c8eb8cc749dc6316ef0d5e9b8adcb5d&cmd=enviar&num=" + datosObtenidos[1] + "&msj= su contraseña es: " + datosObtenidos[0];
            Cliente.OpenRead(baseUrl);


            Response.Redirect("index.aspx");


            string script = @"<script type='text/javascript'>
                            alert('enviado a su celular');
                        </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);





        }
    }
}