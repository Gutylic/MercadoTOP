using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Mercado
{
    public partial class vender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string resultado;

        [WebMethod()]
        public static void AbandonarSesion()
        {
            HttpContext.Current.Session.Remove("id_Usuario");
            HttpContext.Current.Session.Remove("nickUsuario");
            HttpContext.Current.Session.Remove("passwordUsuario");
        }

        protected void botonRegistrate_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrese.aspx");
        }

        protected void botonIngresar_Click(object sender, EventArgs e)
        {


            db.loguearUsuario(celularUsuario.Text, claveUsuario.Text,ref resultado);

            string[] respuestas = resultado.Split('?');

            if (respuestas[2] == "-1" || respuestas[0] == "-6")
            {
                string script = @"<script type='text/javascript'>
                            alert('no puede loguearse');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else
            {
                Session["passwordUsuario"] = claveUsuario.Text;
                Session["nickUsuario"] = celularUsuario.Text;
                Session["id_Usuario"] = resultado;

                Session["usuarioRelacionado"] = resultado;

                if (mantenerConectado.Checked)
                {
                    GuardarCookie((string)Session["nickUsuario"], (string)Session["passwordUsuario"], Convert.ToInt32(Session["id_Usuario"]));

                }
                else
                {
                    EliminarCookie();
                }

                Response.Redirect("paginaPrincipal.aspx");

            }




        }


        public void GuardarCookie(string Usuario, string Password, int ID)
        {

            HttpCookie VariableCookie = new HttpCookie("Usuario_Recordado");
            VariableCookie.Values.Add("nickUsuario", Usuario);
            VariableCookie.Values.Add("passwordUsuario", Password);
            VariableCookie.Values.Add("id_Usuario", ID.ToString());
            VariableCookie.Expires = DateTime.Now.AddDays(90);
            Response.Cookies.Add(VariableCookie);

        }

        public void EliminarCookie()
        {
            HttpCookie VariableCookie = new HttpCookie("Usuario_Recordado");
            VariableCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(VariableCookie);
        }



        protected void Nosemiclave_Click(object sender, EventArgs e)
        {
            Response.Redirect("contrasena.aspx");
        }
    }
}