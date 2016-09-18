using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class Descripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        DataClasses1DataContext db = new DataClasses1DataContext();
        int? resultado;

        protected void botonPublicar_Click(object sender, EventArgs e)
        {

            db.ultimaFoto(ref resultado);

            if (tituloProducto.Text.Length < 5)
            {
                tituloProducto.Text = string.Empty;
                string script = @"<script type='text/javascript'>
                            alert('pocas palabras de titulo');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            string imagen1 = null;
            string imagen2 = null;
            string imagen3 = null;
            string imagen4 = null;

            if (foto1.HasFile)
            {

                if (foto1.PostedFile.ContentType != "image/png")
                {
                    string script = @"<script type='text/javascript'>
                                alert('no tiene formato la foto 1');
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }



                    if (foto1.PostedFile.ContentLength > 102400)
                    {
                        string script = @"<script type='text/javascript'>
                                alert('la foto 1 es muy grande);
                            </script>";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                        return;
                    }

                foto1.PostedFile.SaveAs(Server.MapPath("Fotos/") + Session["nickUsuario"].ToString() + resultado.ToString() + ".png");

                //foto1.SaveAs("C:\\Fotos\\" + Session["nickUsuario"].ToString() + "#" + resultado.ToString() + ".png");
                imagen1 = Session["nickUsuario"].ToString() + resultado.ToString() + ".png";


            }

            if (foto2.HasFile)
            {

                if (foto2.PostedFile.ContentType != "image/png")
                {
                    string script = @"<script type='text/javascript'>
                                alert('no tiene formato la foto 2');
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }



                if (foto2.PostedFile.ContentLength > 102400)
                {
                    string script = @"<script type='text/javascript'>
                                alert('la foto 2 es muy grande);
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }

                foto2.PostedFile.SaveAs(Server.MapPath("Fotos/") + Session["nickUsuario"].ToString() + (resultado+1).ToString() + ".png");

               // foto2.SaveAs("C:\\Fotos\\" + Session["nickUsuario"].ToString() + "#" + (resultado + 1).ToString() + ".png" );
                imagen2 = Session["nickUsuario"].ToString() + (resultado + 1).ToString() + ".png";


            }

            if (foto3.HasFile)
            {

                if (foto3.PostedFile.ContentType != "image/png")
                {
                    string script = @"<script type='text/javascript'>
                                alert('no tiene formato la foto 3');
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }



                if (foto3.PostedFile.ContentLength > 102400)
                {
                    string script = @"<script type='text/javascript'>
                                alert('la foto 3 es muy grande);
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }


                foto3.PostedFile.SaveAs(Server.MapPath("Fotos/") + Session["nickUsuario"].ToString() + (resultado + 2).ToString() + ".png");

                //foto3.SaveAs("C:\\Fotos\\" + Session["nickUsuario"].ToString() + "#" + (resultado + 2).ToString() + ".png");
                imagen3 = Session["nickUsuario"].ToString() + (resultado + 2).ToString() + ".png";

            }

            if (foto4.HasFile)
            {

                if (foto4.PostedFile.ContentType != "image/png")
                {
                    string script = @"<script type='text/javascript'>
                                alert('no tiene formato la foto 4');
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }



                if (foto4.PostedFile.ContentLength > 102400)
                {
                    string script = @"<script type='text/javascript'>
                                alert('la foto 4 es muy grande);
                            </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    return;
                }


                foto4.PostedFile.SaveAs(Server.MapPath("Fotos/") + Session["nickUsuario"].ToString() + (resultado + 3).ToString() + ".png");
               // foto4.SaveAs("C:\\Fotos\\" + Session["nickUsuario"].ToString() + "#" + (resultado + 3).ToString() + ".png");
                imagen4 = Session["nickUsuario"].ToString() + (resultado + 3).ToString() + ".png";


            }

            if (int.Parse(cantidad.Text) < 0 || cantidad.Text == string.Empty)
            {

                string script = @"<script type='text/javascript'>
                            alert('falszta cantidad');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }


            if (descripcionProducto.Text.Length <= 10) {

                string script = @"<script type='text/javascript'>
                            alert('pocas palabras de descripcion');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }

            int cA0 = int.Parse(Session["cA0"].ToString());
            int cA1;
            if (Session["cA1"] == null)
            {
                cA1 = 0;

            } else
            {
                cA1 = int.Parse(Session["cA1"].ToString());
            }

            int cA2;
            if (Session["cA2"] == null)
            {
                cA2 = 0;

            }
            else
            {
                cA2 = int.Parse(Session["cA2"].ToString());
            }

            int cA3;
            if (Session["cA3"] == null)
            {
                cA3 = 0;

            }
            else
            {
                cA3 = int.Parse(Session["cA3"].ToString());
            }
            int cA4;
            if (Session["cA4"] == null)
            {
                cA4 = 0;

            }
            else
            {
                cA4 = int.Parse(Session["cA4"].ToString());
            }
            int cA5;
            if (Session["cA5"] == null)
            {
                cA5 = 0;

            }
            else
            {
                cA5 = int.Parse(Session["cA5"].ToString());
            }
            int cA6;
            if (Session["cA6"] == null)
            {
                cA6 = 0;

            }
            else
            {
                cA6 = int.Parse(Session["cA6"].ToString());
            }

            bool val;

            if (checkNuevo.Checked)
            {
                val = true;
            }
            else {
                val = false;
            }

            db.insertarProducto(imagen1,imagen2,imagen3,imagen4, tituloProducto.Text, youtube.Text, int.Parse(Session["usuarioRelacionado"].ToString()), int.Parse(Session["id_Usuario"].ToString()), int.Parse(cantidad.Text), descripcionProducto.Text, val, garantia.Text, cA0, cA1,cA2,cA3,cA4,cA5,cA6,precio.Text,ref resultado);

            string script1 = @"<script type='text/javascript'>
                            alert('publicado correctamente en espera');
                            location.href = 'paginaPrincipal.aspx'
                        </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script1, false);
            return;


        }

      

        protected void checkNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNuevo.Checked)
            {
                checkUsuado.Checked = false;
                return;
                
            }

           checkUsuado.Checked = true;

        }

        protected void checkUsuado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUsuado.Checked)
            {
                checkNuevo.Checked = false;
                return;

            }

            checkNuevo.Checked = true;
        }
    }
}