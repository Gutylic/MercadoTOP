using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class registrese : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        int? resultado;

        protected void botonRegistrame_Click(object sender, EventArgs e)
        {

            if (correoUsuario.Text != repetirCorreoUsuario.Text)
            {
                correoUsuario.Text = string.Empty;
                repetirCorreoUsuario.Text = string.Empty;

                string script = @"<script type='text/javascript'>
                            alert('Correos diferentes');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            
            db.registrarUsuario(nickUsuario.Text.ToLower(), correoUsuario.Text, numeroCelular.Text, claveUsuario.Text,ref resultado);

            if (resultado == 0) {

                nickUsuario.Text = string.Empty;
                string script = @"<script type='text/javascript'>
                            alert('usuario ya existe');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            if (claveUsuario.Text.Length < 6)
            {
                nickUsuario.Text = string.Empty;
                string script = @"<script type='text/javascript'>
                            alert('clave usuario muy corta');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }

            if (resultado == -1)
            {

                numeroCelular.Text = string.Empty;
                string script = @"<script type='text/javascript'>
                            alert('celular ya existe');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            if (resultado == -6)
            {

                
                string script = @"<script type='text/javascript'>
                            alert('en estos momentos no pudo conectarse');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            
            
          
                WebClient Cliente = new WebClient();
                string baseUrl = " https://www.smsc.com.ar/api/0.2/?alias=Martiva&apikey=7c8eb8cc749dc6316ef0d5e9b8adcb5d&cmd=enviar&num=" + numeroCelular + "&msj= su codigo de activacion es: " + resultado.ToString();
                Cliente.OpenRead(baseUrl);

                      
            Response.Redirect("activarUsuario.aspx?nombre=" + nickUsuario.Text);


        }
    }
}