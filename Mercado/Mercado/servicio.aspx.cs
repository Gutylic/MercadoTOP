using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class servicio : System.Web.UI.Page
    {

        DataClasses1DataContext db = new DataClasses1DataContext();

        int? resultado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Categoria1.Visible = true;

                Categoria1.DataSource = db.categoriaServicios1().ToList();

                Categoria1.DataTextField = "serviciosCategoria1";

                Categoria1.DataValueField = "id_Servicios1";

                Categoria1.DataBind();

                Session["cA0"] = 1;

            }
        }


        protected void Categoria1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Categoria1.SelectedItem.ToString() == "Selecciona una opción")
            {
                Categoria2.Visible = false;

                Categoria3.Visible = false;

                Categoria4.Visible = false;

                Categoria5.Visible = false;

                ImageOk.Visible = false;

                return;
            }


            Categoria2.Visible = false;

            Categoria3.Visible = false;

            Categoria4.Visible = false;

            Categoria5.Visible = false;

            ImageOk.Visible = false;

            db.categoriaServicios2Cero(int.Parse(Categoria1.SelectedValue), ref resultado);

            Session["cA1"] = Categoria1.SelectedValue;

            if (resultado != 0)
            {
                ImageOk.Visible = false;

                Categoria2.Visible = true;

                Categoria2.DataSource = db.categoriaServicios2(int.Parse(Categoria1.SelectedValue)).ToList();

                Categoria2.DataTextField = "serviciosCategoria2";

                Categoria2.DataValueField = "id_Servicios2";

                Categoria2.DataBind();

                return;

            }
            else
            {

                ImageOk.Visible = true;

                Categoria2.Visible = false;

                return;
            }

        }

        protected void Categoria2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Categoria2.SelectedItem.ToString() == "Selecciona una opción")
            {

                Categoria3.Visible = false;

                Categoria4.Visible = false;

                Categoria5.Visible = false;

                ImageOk.Visible = false;

                return;
            }


            Categoria3.Visible = false;

            Categoria4.Visible = false;

            Categoria5.Visible = false;

            ImageOk.Visible = false;

            db.categoriaServicios3Cero(int.Parse(Categoria2.SelectedValue), ref resultado);

            Session["cA2"] = Categoria2.SelectedValue;

            if (resultado != 0)
            {
                ImageOk.Visible = false;

                Categoria3.Visible = true;

                Categoria3.DataSource = db.categoriaServicios3(int.Parse(Categoria2.SelectedValue)).ToList();

                Categoria3.DataTextField = "serviciosCategoria3";

                Categoria3.DataValueField = "id_Servicios3";

                Categoria3.DataBind();

                return;

            }
            else
            {
                ImageOk.Visible = true;

                Categoria3.Visible = false;

                return;
            }
        }

        protected void Categoria3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categoria3.SelectedItem.ToString() == "Selecciona una opción")
            {
                Categoria4.Visible = false;

                Categoria5.Visible = false;

                ImageOk.Visible = false;

                return;
            }


            Categoria4.Visible = false;

            ImageOk.Visible = false;

            db.categoriaServicios4Cero(int.Parse(Categoria3.SelectedValue), ref resultado);

            Session["cA3"] = Categoria3.SelectedValue;

            if (resultado != 0)
            {
                ImageOk.Visible = false;

                Categoria4.Visible = true;

                Categoria4.DataSource = db.categoriaServicios4(int.Parse(Categoria3.SelectedValue)).ToList();

                Categoria4.DataTextField = "serviciosCategoria4";

                Categoria4.DataValueField = "id_Servicios4";

                Categoria4.DataBind();

                return;

            }
            else
            {
                ImageOk.Visible = true;

                Categoria4.Visible = false;

                return;
            }
        }


        protected void Categoria4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categoria4.SelectedItem.ToString() == "Selecciona una opción")
            {
                
                Categoria5.Visible = false;

                ImageOk.Visible = false;

                return;
            }


            Categoria5.Visible = false;

            ImageOk.Visible = false;

            db.categoriaServicios5Cero(int.Parse(Categoria4.SelectedValue), ref resultado);

            Session["cA4"] = Categoria4.SelectedValue;

            if (resultado != 0)
            {
                ImageOk.Visible = false;

                Categoria5.Visible = true;

                Categoria5.DataSource = db.categoriaServicios5(int.Parse(Categoria4.SelectedValue)).ToList();

                Categoria5.DataTextField = "serviciosCategoria5";

                Categoria5.DataValueField = "id_Servicios5";

                Categoria5.DataBind();

                return;

            }
            else
            {
                ImageOk.Visible = true;

                Categoria5.Visible = false;

                return;
            }
        }
        
        protected void Categoria5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categoria5.SelectedItem.ToString() == "Selecciona una opción")
            {

                ImageOk.Visible = false;

                return;
            }
            else
            {
                ImageOk.Visible = true;

                return;

            }

        }

        protected void ImageOk_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Descripcion.aspx");
        }
    }

}