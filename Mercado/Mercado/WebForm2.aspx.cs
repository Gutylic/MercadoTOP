using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mercado
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string resultado(string nombre) {

            string[] f = new string[nombre.Length];

            string b;
            string c;
            int salto = 0;


            int i = 0;
            string resultado = "";

            foreach (char a in nombre)
            {
                i = i + 1;
                b = a.ToString();
                c = b.ToLower();
                f[i - 1] = a.ToString();

                if (c != b && (i - 2) != -1)
                {

                    if (f[i - 2] != " ")
                    {

                        resultado = resultado + Environment.NewLine + a.ToString();
                        salto = salto + 1;

                    }
                    else
                    {
                        resultado = resultado + a.ToString();


                    }

                }
                else
                {

                    resultado = resultado + a.ToString();


                }

            }

            return resultado;
        }


        public string contando(string nombre)
        {

            string[] f = new string[nombre.Length];

            string b;
            string c;
            int salto = 0;


            int i = 0;
            string resultado = "";

            foreach (char a in nombre)
            {
                i = i + 1;
                b = a.ToString();
                c = b.ToLower();
                f[i - 1] = a.ToString();

                if (c != b && (i - 2) != -1)
                {

                    if (f[i - 2] != " ")
                    {

                        resultado = resultado + Environment.NewLine + a.ToString();
                        salto = salto + 1;

                    }
                    else
                    {
                        resultado = resultado + a.ToString();


                    }

                }
                else
                {

                    resultado = resultado + a.ToString();


                }

            }

            return resultado;
        }


        public string numn(string datos,decimal val)
        {



            val = (((val - 1) * 99) + val) - 1;

            int line = 0;
            string numeros = "";
            decimal r;

            foreach (int vacios in datos)
            {

                if (vacios == Convert.ToChar(10))
                {
                    line = line + 1;
                }

            }

            for (int p = 1; p <= line + 1; p++)
            {
                r = p;
                r = r + val; 
                numeros = numeros + Environment.NewLine + r.ToString();

            }

            return numeros;
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombres21 = (T21.Text.TrimStart()).TrimEnd();
            string nombres22 = (T22.Text.TrimStart()).TrimEnd(); 
            string nombres23 = (T23.Text.TrimStart()).TrimEnd();
            string nombres24 = (T24.Text.TrimStart()).TrimEnd();
            string nombres25 = (T25.Text.TrimStart()).TrimEnd();
            string nombres26 = (T26.Text.TrimStart()).TrimEnd();
            string nombres27 = (T27.Text.TrimStart()).TrimEnd();
            string nombres28 = (T28.Text.TrimStart()).TrimEnd();
            string nombres29 = (T29.Text.TrimStart()).TrimEnd();


            string nombres1 = (T41.Text.TrimStart()).TrimEnd();
            string nombres2 = (T42.Text.TrimStart()).TrimEnd();
            string nombres3 = (T43.Text.TrimStart()).TrimEnd();
            string nombres4 = (T44.Text.TrimStart()).TrimEnd();
            string nombres5 = (T45.Text.TrimStart()).TrimEnd();
            string nombres6 = (T46.Text.TrimStart()).TrimEnd();
            string nombres7 = (T47.Text.TrimStart()).TrimEnd();
            string nombres8 = (T48.Text.TrimStart()).TrimEnd();
            string nombres9 = (T49.Text.TrimStart()).TrimEnd();

            C2.Text = resultado(nombres21) + Environment.NewLine + resultado(nombres22) + Environment.NewLine + resultado(nombres23) + Environment.NewLine +
                resultado(nombres24) + Environment.NewLine + resultado(nombres25) + Environment.NewLine + resultado(nombres26) + Environment.NewLine +
                resultado(nombres27) + Environment.NewLine + resultado(nombres28) + Environment.NewLine + resultado(nombres29);

            N2.Text = numn(resultado(nombres21), decimal.Parse(T31.Text)) + Environment.NewLine + numn(resultado(nombres22), decimal.Parse(T32.Text)) + Environment.NewLine + numn(resultado(nombres23), decimal.Parse(T33.Text)) + Environment.NewLine +
                numn(resultado(nombres24), decimal.Parse(T34.Text)) + Environment.NewLine + numn(resultado(nombres25), decimal.Parse(T35.Text)) + Environment.NewLine + numn(resultado(nombres26), decimal.Parse(T36.Text)) + Environment.NewLine +
                numn(resultado(nombres27), decimal.Parse(T37.Text)) + Environment.NewLine + numn(resultado(nombres28), decimal.Parse(T38.Text)) + Environment.NewLine + numn(resultado(nombres29), decimal.Parse(T39.Text));

            c3.Text = resultado(nombres1) + Environment.NewLine + resultado(nombres2) + Environment.NewLine + resultado(nombres3) + Environment.NewLine +
               resultado(nombres4) + Environment.NewLine + resultado(nombres5) + Environment.NewLine + resultado(nombres6) + Environment.NewLine +
               resultado(nombres7) + Environment.NewLine + resultado(nombres8) + Environment.NewLine + resultado(nombres9);

            N3.Text = numn(resultado(nombres1), decimal.Parse(T51.Text)) + Environment.NewLine + numn(resultado(nombres2), decimal.Parse(T52.Text)) + Environment.NewLine + numn(resultado(nombres3), decimal.Parse(T53.Text)) + Environment.NewLine +
                numn(resultado(nombres4), decimal.Parse(T54.Text)) + Environment.NewLine + numn(resultado(nombres5), decimal.Parse(T55.Text)) + Environment.NewLine + numn(resultado(nombres6), decimal.Parse(T56.Text)) + Environment.NewLine +
                numn(resultado(nombres7), decimal.Parse(T57.Text)) + Environment.NewLine + numn(resultado(nombres8), decimal.Parse(T58.Text)) + Environment.NewLine + numn(resultado(nombres9), decimal.Parse(T59.Text));









        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            T21.Text = string.Empty;
            T22.Text = string.Empty;
            T23.Text = string.Empty;
            T24.Text = string.Empty;
            T25.Text = string.Empty;
            T26.Text = string.Empty;
            T27.Text = string.Empty;
            T28.Text = string.Empty;
            T29.Text = string.Empty;
            T41.Text = string.Empty;
            T42.Text = string.Empty;
            T43.Text = string.Empty;
            T44.Text = string.Empty;
            T45.Text = string.Empty;
            T46.Text = string.Empty;
            T47.Text = string.Empty;
            T48.Text = string.Empty;
            T49.Text = string.Empty;
         
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}