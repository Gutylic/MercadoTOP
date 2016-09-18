using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Mercado
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();


        protected void Page_Load(object sender, EventArgs e)
        {






        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Label1.Text = DropDownList1.SelectedValue + " - " + DropDownList2.SelectedValue;
        }

        int? resultado;

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Visible = false;

            Label1.Text = string.Empty;


         //   db.segundoCero(int.Parse(DropDownList1.SelectedValue), ref resultado);

            if (resultado == 0) {

                Label1.Text = "OK todo confirmado";

                return;

            }

            DropDownList2.Visible = true;

       //     DropDownList2.DataSource = db.segundo(int.Parse(DropDownList1.SelectedValue)).ToList();

            DropDownList2.DataTextField = "tipo";

            DropDownList2.DataValueField = "id";

            DropDownList2.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DropDownList1.Visible = true;

          //  DropDownList1.DataSource = db.uno().ToList();

            DropDownList1.DataTextField = "tipo";

            DropDownList1.DataValueField = "id";

            DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nombres = TextBox1.Text.TrimStart();
            nombres = nombres.TrimEnd();
            string b;
            string c;
            string[] f = new string[nombres.Length];
            int salto = 0;


            int i = 0;
            string resultado = "";

            foreach (char a in nombres)
            {
                i = i + 1;
                b = a.ToString();
                c = b.ToLower();
                f[i - 1] = a.ToString();

                if (c != b && (i - 2) != -1) {

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

            TextBox2.Text = resultado;
            decimal pueblo;
            string numeros = "";
            decimal p1 = (Convert.ToDecimal(TextBox3.Text) - 1) * 99;
            decimal p2 = Convert.ToDecimal(TextBox3.Text);
            for (decimal j = 0; j <= salto; j++) {

                pueblo = p1 + p2 + j;
                if (j == 0)
                {

                    numeros = pueblo.ToString();
                }
                else
                {

                    numeros = numeros + Environment.NewLine + pueblo.ToString();

                }

                
            }

            TextBox5.Text = numeros;

        }









    


        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox6.Text = String.Empty;
            TextBox7.Text = String.Empty;
            TextBox8.Text = String.Empty;
            TextBox9.Text = String.Empty;
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (TextBox3.Text != string.Empty) {
                TextBox4.Text = (((Convert.ToDecimal(TextBox3.Text) - 1) * 99) + Convert.ToDecimal(TextBox3.Text)).ToString();
                TextBox12.Text = (((Convert.ToDecimal(TextBox4.Text) - 1) * 99) + Convert.ToDecimal(TextBox4.Text)).ToString();
                TextBox13.Text = (((Convert.ToDecimal(TextBox12.Text) - 1) * 99) + Convert.ToDecimal(TextBox12.Text)).ToString();
                TextBox14.Text = (((Convert.ToDecimal(TextBox13.Text) - 1) * 99) + Convert.ToDecimal(TextBox13.Text)).ToString();
                TextBox15.Text = (((Convert.ToDecimal(TextBox14.Text) - 1) * 99) + Convert.ToDecimal(TextBox14.Text)).ToString();
                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                return;
            }


            if (TextBox3.Text == string.Empty && TextBox4.Text != string.Empty) {

                

                TextBox12.Text = (((Convert.ToDecimal(TextBox4.Text) - 1) * 99) + Convert.ToDecimal(TextBox4.Text)).ToString();
                TextBox13.Text = (((Convert.ToDecimal(TextBox12.Text) - 1) * 99) + Convert.ToDecimal(TextBox12.Text)).ToString();
                TextBox14.Text = (((Convert.ToDecimal(TextBox13.Text) - 1) * 99) + Convert.ToDecimal(TextBox13.Text)).ToString();
                TextBox15.Text = (((Convert.ToDecimal(TextBox14.Text) - 1) * 99) + Convert.ToDecimal(TextBox14.Text)).ToString();
                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();
                return;
            }



            if (TextBox3.Text == string.Empty && TextBox4.Text == string.Empty && TextBox12.Text != string.Empty)
            {
                
                

                TextBox13.Text = (((Convert.ToDecimal(TextBox12.Text) - 1) * 99) + Convert.ToDecimal(TextBox12.Text)).ToString();
                TextBox14.Text = (((Convert.ToDecimal(TextBox13.Text) - 1) * 99) + Convert.ToDecimal(TextBox13.Text)).ToString();
                TextBox15.Text = (((Convert.ToDecimal(TextBox14.Text) - 1) * 99) + Convert.ToDecimal(TextBox14.Text)).ToString();
                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox4.Text = ((Convert.ToDecimal(TextBox12.Text) + 99) / 100).ToString();
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();

                return;
            }
            if (TextBox3.Text == string.Empty && TextBox4.Text == string.Empty && TextBox12.Text == string.Empty && TextBox13.Text != string.Empty)
            {

                
               
                
            
                TextBox14.Text = (((Convert.ToDecimal(TextBox13.Text) - 1) * 99) + Convert.ToDecimal(TextBox13.Text)).ToString();
                TextBox15.Text = (((Convert.ToDecimal(TextBox14.Text) - 1) * 99) + Convert.ToDecimal(TextBox14.Text)).ToString();
                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox12.Text = ((Convert.ToDecimal(TextBox13.Text) + 99) / 100).ToString();
                TextBox4.Text = ((Convert.ToDecimal(TextBox12.Text) + 99) / 100).ToString();
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();

                return;
            }

            if (TextBox3.Text == string.Empty && TextBox4.Text == string.Empty && TextBox12.Text == string.Empty && TextBox13.Text == string.Empty && TextBox14.Text != string.Empty)
            {

                

                TextBox15.Text = (((Convert.ToDecimal(TextBox14.Text) - 1) * 99) + Convert.ToDecimal(TextBox14.Text)).ToString();
                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox13.Text = ((Convert.ToDecimal(TextBox14.Text) + 99) / 100).ToString();
                
                TextBox12.Text = ((Convert.ToDecimal(TextBox13.Text) + 99) / 100).ToString();
                TextBox4.Text = ((Convert.ToDecimal(TextBox12.Text) + 99) / 100).ToString(); 
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();
                return;
            }


            if (TextBox3.Text == string.Empty && TextBox4.Text == string.Empty && TextBox12.Text == string.Empty && TextBox13.Text == string.Empty && TextBox14.Text == string.Empty && TextBox15.Text != string.Empty)
            {
                

                TextBox16.Text = (((Convert.ToDecimal(TextBox15.Text) - 1) * 99) + Convert.ToDecimal(TextBox15.Text)).ToString();
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox14.Text = ((Convert.ToDecimal(TextBox15.Text) + 99) / 100).ToString();
                TextBox13.Text = ((Convert.ToDecimal(TextBox14.Text) + 99) / 100).ToString();               
                
                TextBox12.Text = ((Convert.ToDecimal(TextBox13.Text) + 99) / 100).ToString();
                TextBox4.Text = ((Convert.ToDecimal(TextBox12.Text) + 99) / 100).ToString();           
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();                

                return;
            }

            if (TextBox3.Text == string.Empty && TextBox4.Text == string.Empty && TextBox12.Text == string.Empty && TextBox13.Text == string.Empty && TextBox14.Text == string.Empty && TextBox15.Text == string.Empty && TextBox16.Text != string.Empty)
            {
                TextBox17.Text = (((Convert.ToDecimal(TextBox16.Text) - 1) * 99) + Convert.ToDecimal(TextBox16.Text)).ToString();
                TextBox15.Text = ((Convert.ToDecimal(TextBox16.Text) + 99) / 100).ToString();
                TextBox14.Text = ((Convert.ToDecimal(TextBox15.Text) + 99) / 100).ToString();
                TextBox13.Text = ((Convert.ToDecimal(TextBox14.Text) + 99) / 100).ToString();
                TextBox12.Text = ((Convert.ToDecimal(TextBox13.Text) + 99) / 100).ToString();
                TextBox4.Text = ((Convert.ToDecimal(TextBox12.Text) + 99) / 100).ToString();
                TextBox3.Text = ((Convert.ToDecimal(TextBox4.Text) + 99) / 100).ToString();
                
                
                
                
              

                
                return;
            }




        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string cantidadpalabrasrepetidas;
            string machito="";
            int line = 0;
            
            cantidadpalabrasrepetidas = TextBox7.Text;

            foreach (int jo in cantidadpalabrasrepetidas) {

                if (jo == Convert.ToChar(10)) {
                    line = line + 1;
                }

            }
            
            for (int t = 1; t <= (int.Parse(TextBox8.Text) * int.Parse(TextBox10.Text) * int.Parse(TextBox6.Text)); t++)
            {
                machito = cantidadpalabrasrepetidas + Environment.NewLine + machito;
            }

            TextBox7.Text = machito;


            decimal inicio = Convert.ToDecimal(TextBox11.Text);

            string totalprimera = "";

            decimal cuenta = 0;

                        

            for (int rrrr = 1; rrrr <= int.Parse(TextBox6.Text); rrrr++) { 


                for (int rrr = 1; rrr <= int.Parse(TextBox8.Text); rrr++){

           

                    for (int rr = 1; rr <= int.Parse(TextBox10.Text); rr++) {

                       

                            for (int r = 0; r <= line; r++) {

                                cuenta = r + inicio;

                                totalprimera = totalprimera + Environment.NewLine + cuenta.ToString();

                            }

                    if (rrr == 1)
                    {
                        inicio = Convert.ToDecimal(TextBox11.Text);
                        inicio = inicio + 100 * rr;
                    }

                    else
                    {
                        inicio = inicio + 100;

                    }

                 }

                    if (rrrr == 1)
                    {
                        inicio = Convert.ToDecimal(TextBox11.Text);
                        inicio = inicio + 10000 * rrr;

                    }

                    else
                    {
                        inicio = inicio + 10000;

                    }

                }

                inicio = Convert.ToDecimal(TextBox11.Text);
                inicio = inicio + 1000000;

            }
            
            TextBox9.Text = totalprimera; 



        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string cantidadpalabrasrepetidas;
            string machito = "";
            int line = 0;

            cantidadpalabrasrepetidas = TextBox7.Text;

            foreach (int jo in cantidadpalabrasrepetidas)
            {

                if (jo == Convert.ToChar(10))
                {
                    line = line + 1;
                }

            }

            for (int t = 1; t <= (int.Parse(TextBox8.Text) * int.Parse(TextBox10.Text)); t++)
            {
                machito = cantidadpalabrasrepetidas + Environment.NewLine + machito;
            }

            TextBox7.Text = machito;


            decimal inicio = Convert.ToDecimal(TextBox11.Text);

            string totalprimera = "";

            decimal cuenta = 0;



            

                for (int rrr = 1; rrr <= int.Parse(TextBox8.Text); rrr++)
                {



                    for (int rr = 1; rr <= int.Parse(TextBox10.Text); rr++)
                    {



                        for (int r = 0; r <= line; r++)
                        {

                            cuenta = r + inicio;

                            totalprimera = totalprimera + Environment.NewLine + cuenta.ToString();

                        }

                        if (rrr == 1)
                        {
                            inicio = Convert.ToDecimal(TextBox11.Text);
                            inicio = inicio + 100 * rr;
                        }

                        else
                        {
                            inicio = inicio + 100;

                        }

                    }

                   
                   

                }

               

            

            TextBox9.Text = totalprimera;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string cantidadpalabrasrepetidas;
            string machito = "";
            int line = 0;

            cantidadpalabrasrepetidas = TextBox7.Text;

            foreach (int jo in cantidadpalabrasrepetidas)
            {

                if (jo == Convert.ToChar(10))
                {
                    line = line + 1;
                }

            }

            for (int t = 1; t <= (int.Parse(TextBox10.Text)); t++)
            {
                machito = cantidadpalabrasrepetidas + Environment.NewLine + machito;
            }

            TextBox7.Text = machito;


            decimal inicio = Convert.ToDecimal(TextBox11.Text);

            string totalprimera = "";

            decimal cuenta = 0;





           


                for (int rr = 1; rr <= int.Parse(TextBox10.Text); rr++)
                {



                    for (int r = 0; r <= line; r++)
                    {

                        cuenta = r + inicio;

                        totalprimera = totalprimera + Environment.NewLine + cuenta.ToString();

                    }

                   
                        inicio = inicio + 100;

                    

                }




            





            TextBox9.Text = totalprimera;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox14.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox12.Text = string.Empty;
            TextBox13.Text = string.Empty;
            TextBox15.Text = string.Empty;
            TextBox16.Text = string.Empty;
            TextBox17.Text = string.Empty;

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}