using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class paginaPrincipal : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            etiquetaNombre.Text = (string)Session["nickUsuario"];

            if (!Page.IsPostBack) // se carga la primera vez al abrir la pagina
            {

                Resultado_DataList();
            }
        }

        protected void Identificador(object sender, DataListCommandEventArgs e)
        {
            Session["Identificador"] = int.Parse(e.CommandName); // identificador para saber que linkbutton presione 
            Response.Redirect("mostrarProducto.aspx");
            return;

        }
        public void Resultado_DataList()
        {

            DataList_Productos.DataSource = resultadoProductos();// muestra el datalist de mis ejercicios paginado de a 20 datos
            DataList_Productos.DataBind();

        }

        public List<mostrarTodosProductosResult> resultadoProductos()
        {
            return db.mostrarTodosProductos().ToList();
        }




        protected void LinkVender_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubirProducto1.aspx");
        }
    }
}