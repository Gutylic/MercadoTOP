using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class actualizarProducto : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int? resultado;

        protected void Page_Load(object sender, EventArgs e)
        {
            etiquetaNombre.Text = Session["nickUsuario"].ToString();
            
            List<mostrarProductoElegidoResult> Datos;
            Datos = db.mostrarProductoElegido(int.Parse(Session["Identificador"].ToString())).ToList();
            tituloProducto.Text = Datos[0].tituloProducto;
            descripcionProducto.Text = Datos[0].descripcionProducto;
            garantiaProducto.Text = Datos[0].tiempoGarantia;
            precioProducto.Text = Datos[0].precioProducto;
            youtube.Text = Datos[0].ubicacionVideo;
            cantidadProducto.Text = Datos[0].cantidadProducto.ToString();
            if (Datos[0].ubicacionFoto1 == null)
            {
                Datos[0].ubicacionFoto1 = "vacio.png";

            }
            if (Datos[0].ubicacionFoto2 == null)
            {
                Datos[0].ubicacionFoto2 = "vacio.png";

            }

            if (Datos[0].ubicacionFoto3 == null)
            {
                Datos[0].ubicacionFoto3 = "vacio.png";

            }
            if (Datos[0].ubicacionFoto4 == null)
            {
                Datos[0].ubicacionFoto4 = "vacio.png";

            }
            Image1.ImageUrl = "Fotos/" + Datos[0].ubicacionFoto1;
            Image2.ImageUrl = "Fotos/" + Datos[0].ubicacionFoto2;
            Image3.ImageUrl = "Fotos/" + Datos[0].ubicacionFoto3;
            Image4.ImageUrl = "Fotos/" + Datos[0].ubicacionFoto4;

            bool? estado = Datos[0].estadoProducto;

            if (estado == true)
            {
                CheckBoxNuevo.Checked = true;
                CheckBoxUsado.Checked = false;
            }
            else
            {
                CheckBoxNuevo.Checked = false;
                CheckBoxUsado.Checked = true;

            }




        }

        protected void botonActivacion_Click(object sender, EventArgs e)
        {
            db.activarProducto(int.Parse(Session["Identificador"].ToString()), ref resultado);

            if (resultado == 1)
            {
                botonActivacion.Text = "Producto Activado";
                botonActivacion.Enabled = false;
                string script = @"<script type='text/javascript'>
                            alert('producto actualizado');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;

            }
            else {

               


                string script = @"<script type='text/javascript'>
                            alert('no se puede activar');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;


            }




        }
    }
}