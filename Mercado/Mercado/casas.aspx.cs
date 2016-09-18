using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class casas : System.Web.UI.Page
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Categoria1.Visible = true;

                Categoria1.DataSource = db.categoriaCasas1().ToList();

                Categoria1.DataTextField = "casasCategoria1";

                Categoria1.DataValueField = "id_Casas1";

                Categoria1.DataBind();

                Session["cA0"] = 1;
            }
        }

        int? resultado;

        protected void Categoria1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Categoria1.SelectedItem.ToString() == "Selecciona una opción")
            {
                Categoria2.Visible = false;
                               
                ImageOk.Visible = false;

                return;
            }


            Categoria2.Visible = false;

            ImageOk.Visible = false;

            db.categoriaCasas2Cero(int.Parse(Categoria1.SelectedValue), ref resultado);

            Session["cA1"] = Categoria1.SelectedValue;

            if (resultado != 0)
            {
                ImageOk.Visible = false;

                Categoria2.Visible = true;

                Categoria2.DataSource = db.categoriaCasas2(int.Parse(Categoria1.SelectedValue)).ToList();

                Categoria2.DataTextField = "casasCategoria2";

                Categoria2.DataValueField = "id_Casas2";

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