using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class mostrarProducto : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            etiquetaNombre.Text = Session["nickUsuario"].ToString();

            descripcionProducto.Enabled = false;
            tituloProducto.Enabled = false;
            cantidadProducto.Enabled = false;
            precioProducto.Enabled = false;
            garantiaProducto.Enabled = false;
            youtube.Enabled = false;
            CheckBoxNuevo.Enabled = false;
            CheckBoxUsado.Enabled = false;



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
            else {
                CheckBoxNuevo.Checked = false;
                CheckBoxUsado.Checked = true;

            }

            
            

        }
    }
}