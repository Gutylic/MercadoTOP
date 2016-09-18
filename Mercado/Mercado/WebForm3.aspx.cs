using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;


namespace Mercado
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        long B;
        long C;
        long E;
      

        public long resultadoColumna5(long A, long col) {

            switch (col)
            {
                case 1:

                    B = (((A - 1) * 99) + A);

                    return B;


                case 2:

                    B = (((A - 1) * 99) + A) + 100;

                    return B;
            }



            B = (((A - 1) * 99) + A) + col;

            return B;

        }

      


        public string resultadoPalabras(string nombre)
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

        public string resultadoNumeros(string datos, long val, long cuadro)
        {

            long calculo = (cuadro * 100) - 100;

            val = val - 1 + calculo;


            



            long line = 0;
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



        long col51; 
        long col61;
        long col52;
        long col62; 
        long col53;
        long col63; 
        long col54; 
        long col64;
        long col55; 
        long col65;
        long col56;
        long col66;
        long col57;
        long col67;
        long col58;
        long col68;
        long col59;
        long col69;
        long col510;
        long col610;
        long col511;
        long col611;
        long col512;
        long col612;
        long col513;
        long col613;
        long col514;
        long col614;
        long col515;
        long col615;
        long col516;
        long col616;
        long col517;
        long col617;
        long col518;
        long col618;
        long col519;
        long col619;
        long col520;
        long col620;
        long col521;
        long col621;
        long col522;
        long col622;
        long col523;
        long col623;
        long col524;
        long col624;
        long col525;
        long col625;
        long col526;
        long col626;
        long col527;
        long col627;
        long col528;
        long col628;
        long col529;
        long col629;
        long col530;
        long col630;
        long col531;
        long col631;
        long col532;
        long col632;
        long col533;
        long col633;
        long col534;
        long col634;
        long col535;
        long col635;
        long col536;
        long col636;
        long col537;
        long col637;
        long col538;
        long col638;
        long col539;
        long col639;
        long col540;
        long col640;
        long col541;
        long col641;


        public long columna(string textocaja) {

            long col;

            if (textocaja == string.Empty)
            {

                return col = 0;
            }
            else
            {
                return col = long.Parse(textocaja);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            long A = long.Parse(TextBox1.Text);

            string Columna4 = (TextBox20.Text.TrimStart()).TrimEnd();

            string Columna51 = (TextBox12.Text.TrimStart()).TrimEnd();
            string Columna61 = (TextBox13.Text.TrimStart()).TrimEnd();
            string Columna52 = (TextBox14.Text.TrimStart()).TrimEnd();
            string Columna62 = (TextBox15.Text.TrimStart()).TrimEnd();
            string Columna53 = (TextBox25.Text.TrimStart()).TrimEnd();
            string Columna63 = (TextBox27.Text.TrimStart()).TrimEnd();
            string Columna54 = (TextBox29.Text.TrimStart()).TrimEnd();
            string Columna64 = (TextBox31.Text.TrimStart()).TrimEnd();
            string Columna55 = (TextBox33.Text.TrimStart()).TrimEnd();
            string Columna65 = (TextBox35.Text.TrimStart()).TrimEnd();

            string Columna56 = (TextBox49.Text.TrimStart()).TrimEnd();
            string Columna66 = (TextBox51.Text.TrimStart()).TrimEnd();
            string Columna57 = (TextBox53.Text.TrimStart()).TrimEnd();
            string Columna67 = (TextBox55.Text.TrimStart()).TrimEnd();
            string Columna58 = (TextBox57.Text.TrimStart()).TrimEnd();
            string Columna68 = (TextBox59.Text.TrimStart()).TrimEnd();
            string Columna59 = (TextBox61.Text.TrimStart()).TrimEnd();
            string Columna69 = (TextBox63.Text.TrimStart()).TrimEnd();
            string Columna510 = (TextBox65.Text.TrimStart()).TrimEnd();
            string Columna610 = (TextBox67.Text.TrimStart()).TrimEnd();

            string Columna511 = (TextBox69.Text.TrimStart()).TrimEnd();
            string Columna611 = (TextBox71.Text.TrimStart()).TrimEnd();
            string Columna512 = (TextBox73.Text.TrimStart()).TrimEnd();
            string Columna612 = (TextBox75.Text.TrimStart()).TrimEnd();
            string Columna513 = (TextBox77.Text.TrimStart()).TrimEnd();
            string Columna613 = (TextBox79.Text.TrimStart()).TrimEnd();
            string Columna514 = (TextBox81.Text.TrimStart()).TrimEnd();
            string Columna614 = (TextBox83.Text.TrimStart()).TrimEnd();
            string Columna515 = (TextBox85.Text.TrimStart()).TrimEnd();
            string Columna615 = (TextBox87.Text.TrimStart()).TrimEnd();

            string Columna516 = (TextBox89.Text.TrimStart()).TrimEnd();
            string Columna616 = (TextBox91.Text.TrimStart()).TrimEnd();
            string Columna517 = (TextBox93.Text.TrimStart()).TrimEnd();
            string Columna617 = (TextBox95.Text.TrimStart()).TrimEnd();
            string Columna518 = (TextBox97.Text.TrimStart()).TrimEnd();
            string Columna618 = (TextBox99.Text.TrimStart()).TrimEnd();
            string Columna519 = (TextBox101.Text.TrimStart()).TrimEnd();
            string Columna619 = (TextBox103.Text.TrimStart()).TrimEnd();
            string Columna520 = (TextBox105.Text.TrimStart()).TrimEnd();
            string Columna620 = (TextBox107.Text.TrimStart()).TrimEnd();

            string Columna521 = (TextBox109.Text.TrimStart()).TrimEnd();
            string Columna621 = (TextBox111.Text.TrimStart()).TrimEnd();
            string Columna522 = (TextBox113.Text.TrimStart()).TrimEnd();
            string Columna622 = (TextBox115.Text.TrimStart()).TrimEnd();
            string Columna523 = (TextBox117.Text.TrimStart()).TrimEnd();
            string Columna623 = (TextBox119.Text.TrimStart()).TrimEnd();
            string Columna524 = (TextBox121.Text.TrimStart()).TrimEnd();
            string Columna624 = (TextBox123.Text.TrimStart()).TrimEnd();
            string Columna525 = (TextBox125.Text.TrimStart()).TrimEnd();
            string Columna625 = (TextBox127.Text.TrimStart()).TrimEnd();

            string Columna526 = (TextBox129.Text.TrimStart()).TrimEnd();
            string Columna626 = (TextBox131.Text.TrimStart()).TrimEnd();
            string Columna527 = (TextBox133.Text.TrimStart()).TrimEnd();
            string Columna627 = (TextBox135.Text.TrimStart()).TrimEnd();
            string Columna528 = (TextBox137.Text.TrimStart()).TrimEnd();
            string Columna628 = (TextBox139.Text.TrimStart()).TrimEnd();
            string Columna529 = (TextBox141.Text.TrimStart()).TrimEnd();
            string Columna629 = (TextBox143.Text.TrimStart()).TrimEnd();
            string Columna530 = (TextBox145.Text.TrimStart()).TrimEnd();
            string Columna630 = (TextBox147.Text.TrimStart()).TrimEnd();

            string Columna531 = (TextBox149.Text.TrimStart()).TrimEnd();
            string Columna631 = (TextBox151.Text.TrimStart()).TrimEnd();
            string Columna532 = (TextBox153.Text.TrimStart()).TrimEnd();
            string Columna632 = (TextBox155.Text.TrimStart()).TrimEnd();
            string Columna533 = (TextBox157.Text.TrimStart()).TrimEnd();
            string Columna633 = (TextBox159.Text.TrimStart()).TrimEnd();
            string Columna534 = (TextBox161.Text.TrimStart()).TrimEnd();
            string Columna634 = (TextBox163.Text.TrimStart()).TrimEnd();
            string Columna535 = (TextBox165.Text.TrimStart()).TrimEnd();
            string Columna635 = (TextBox167.Text.TrimStart()).TrimEnd();

            string Columna536 = (TextBox169.Text.TrimStart()).TrimEnd();
            string Columna636 = (TextBox171.Text.TrimStart()).TrimEnd();
            string Columna537 = (TextBox173.Text.TrimStart()).TrimEnd();
            string Columna637 = (TextBox175.Text.TrimStart()).TrimEnd();
            string Columna538 = (TextBox177.Text.TrimStart()).TrimEnd();
            string Columna638 = (TextBox179.Text.TrimStart()).TrimEnd();
            string Columna539 = (TextBox181.Text.TrimStart()).TrimEnd();
            string Columna639 = (TextBox183.Text.TrimStart()).TrimEnd();
            string Columna540 = (TextBox185.Text.TrimStart()).TrimEnd();
            string Columna640 = (TextBox187.Text.TrimStart()).TrimEnd();

            string Columna541 = (TextBox189.Text.TrimStart()).TrimEnd();
            string Columna641 = (TextBox191.Text.TrimStart()).TrimEnd();

            col51 = columna(TextBox21.Text);
            col61 = columna(TextBox22.Text);
            col52 = columna(TextBox23.Text);
            col62 = columna(TextBox24.Text);
            col53 = columna(TextBox26.Text);
            col63 = columna(TextBox28.Text);
            col54 = columna(TextBox30.Text);
            col64 = columna(TextBox32.Text);
            col55 = columna(TextBox34.Text);
            col65 = columna(TextBox36.Text);

            col56 = columna(TextBox50.Text);
            col66 = columna(TextBox52.Text);
            col57 = columna(TextBox54.Text);
            col67 = columna(TextBox56.Text);
            col58 = columna(TextBox58.Text);
            col68 = columna(TextBox60.Text);
            col59 = columna(TextBox62.Text);
            col69 = columna(TextBox64.Text);
            col510 = columna(TextBox66.Text);
            col610 = columna(TextBox68.Text);

            col511 = columna(TextBox70.Text);
            col611 = columna(TextBox72.Text);
            col512 = columna(TextBox74.Text);
            col612 = columna(TextBox76.Text);
            col513 = columna(TextBox78.Text);
            col613 = columna(TextBox80.Text);
            col514 = columna(TextBox82.Text);
            col614 = columna(TextBox84.Text);
            col515 = columna(TextBox86.Text);
            col615 = columna(TextBox88.Text);

            col516 = columna(TextBox90.Text);
            col616 = columna(TextBox92.Text);
            col517 = columna(TextBox94.Text);
            col617 = columna(TextBox96.Text);
            col518 = columna(TextBox98.Text);
            col618 = columna(TextBox100.Text);
            col519 = columna(TextBox102.Text);
            col619 = columna(TextBox104.Text);
            col520 = columna(TextBox106.Text);
            col620 = columna(TextBox108.Text);

            col521 = columna(TextBox110.Text);
            col621 = columna(TextBox112.Text);
            col522 = columna(TextBox114.Text);
            col622 = columna(TextBox116.Text);
            col523 = columna(TextBox118.Text);
            col623 = columna(TextBox120.Text);
            col524 = columna(TextBox122.Text);
            col624 = columna(TextBox124.Text);
            col525 = columna(TextBox126.Text);
            col625 = columna(TextBox128.Text);

            col526 = columna(TextBox130.Text);
            col626 = columna(TextBox132.Text);
            col527 = columna(TextBox134.Text);
            col627 = columna(TextBox136.Text);
            col528 = columna(TextBox138.Text);
            col628 = columna(TextBox140.Text);
            col529 = columna(TextBox142.Text);
            col629 = columna(TextBox144.Text);
            col530 = columna(TextBox146.Text);
            col630 = columna(TextBox148.Text);

            col531 = columna(TextBox150.Text);
            col631 = columna(TextBox152.Text);
            col532 = columna(TextBox154.Text);
            col632 = columna(TextBox156.Text);
            col533 = columna(TextBox158.Text);
            col633 = columna(TextBox160.Text);
            col534 = columna(TextBox162.Text);
            col634 = columna(TextBox164.Text);
            col535 = columna(TextBox166.Text);
            col635 = columna(TextBox168.Text);

            col536 = columna(TextBox170.Text);
            col636 = columna(TextBox172.Text);
            col537 = columna(TextBox174.Text);
            col637 = columna(TextBox176.Text);
            col538 = columna(TextBox178.Text);
            col638 = columna(TextBox180.Text);
            col539 = columna(TextBox182.Text);
            col639 = columna(TextBox184.Text);
            col540 = columna(TextBox186.Text);
            col640 = columna(TextBox188.Text);

            col541 = columna(TextBox190.Text);
            col641 = columna(TextBox192.Text);

            TextBox2.Text = resultadoPalabras(Columna4);
            TextBox8.Text = resultadoPalabras(Columna51);
            TextBox10.Text = resultadoPalabras(Columna61);
            TextBox16.Text = resultadoPalabras(Columna52);
            TextBox18.Text = resultadoPalabras(Columna62);
            TextBox37.Text = resultadoPalabras(Columna53);
            TextBox39.Text = resultadoPalabras(Columna63);
            TextBox41.Text = resultadoPalabras(Columna54);
            TextBox43.Text = resultadoPalabras(Columna64);
            TextBox45.Text = resultadoPalabras(Columna55);
            TextBox47.Text = resultadoPalabras(Columna65);

            TextBox193.Text = resultadoPalabras(Columna56);
            TextBox195.Text = resultadoPalabras(Columna66);
            TextBox197.Text = resultadoPalabras(Columna57);
            TextBox199.Text = resultadoPalabras(Columna67);
            TextBox201.Text = resultadoPalabras(Columna58);
            TextBox203.Text = resultadoPalabras(Columna68);
            TextBox205.Text = resultadoPalabras(Columna59);
            TextBox207.Text = resultadoPalabras(Columna69);
            TextBox209.Text = resultadoPalabras(Columna510);
            TextBox211.Text = resultadoPalabras(Columna610);
            TextBox213.Text = resultadoPalabras(Columna511);

            TextBox215.Text = resultadoPalabras(Columna611);
            TextBox217.Text = resultadoPalabras(Columna512);
            TextBox219.Text = resultadoPalabras(Columna612);
            TextBox221.Text = resultadoPalabras(Columna513);
            TextBox223.Text = resultadoPalabras(Columna613);
            TextBox225.Text = resultadoPalabras(Columna514);
            TextBox227.Text = resultadoPalabras(Columna614);
            TextBox229.Text = resultadoPalabras(Columna515);
            TextBox231.Text = resultadoPalabras(Columna615);
            TextBox233.Text = resultadoPalabras(Columna516);
            TextBox235.Text = resultadoPalabras(Columna616);

            TextBox237.Text = resultadoPalabras(Columna517);
            TextBox239.Text = resultadoPalabras(Columna617);
            TextBox241.Text = resultadoPalabras(Columna518);
            TextBox243.Text = resultadoPalabras(Columna618);
            TextBox245.Text = resultadoPalabras(Columna519);
            TextBox247.Text = resultadoPalabras(Columna619);
            TextBox249.Text = resultadoPalabras(Columna520);
            TextBox251.Text = resultadoPalabras(Columna620);
            TextBox253.Text = resultadoPalabras(Columna521);
            TextBox255.Text = resultadoPalabras(Columna621);
            TextBox257.Text = resultadoPalabras(Columna522);


            TextBox259.Text = resultadoPalabras(Columna622);
            TextBox261.Text = resultadoPalabras(Columna523);
            TextBox263.Text = resultadoPalabras(Columna623);
            TextBox265.Text = resultadoPalabras(Columna524);
            TextBox267.Text = resultadoPalabras(Columna624);
            TextBox269.Text = resultadoPalabras(Columna525);
            TextBox271.Text = resultadoPalabras(Columna625);
            TextBox273.Text = resultadoPalabras(Columna526);
            TextBox275.Text = resultadoPalabras(Columna626);
            TextBox277.Text = resultadoPalabras(Columna527);
            TextBox279.Text = resultadoPalabras(Columna627);


            TextBox281.Text = resultadoPalabras(Columna528);
            TextBox283.Text = resultadoPalabras(Columna628);
            TextBox285.Text = resultadoPalabras(Columna529);
            TextBox287.Text = resultadoPalabras(Columna629);
            TextBox289.Text = resultadoPalabras(Columna530);
            TextBox291.Text = resultadoPalabras(Columna630);
            TextBox293.Text = resultadoPalabras(Columna531);
            TextBox295.Text = resultadoPalabras(Columna631);
            TextBox297.Text = resultadoPalabras(Columna532);
            TextBox299.Text = resultadoPalabras(Columna632);
            TextBox301.Text = resultadoPalabras(Columna533);

            TextBox303.Text = resultadoPalabras(Columna633);
            TextBox305.Text = resultadoPalabras(Columna534);
            TextBox307.Text = resultadoPalabras(Columna634);
            TextBox309.Text = resultadoPalabras(Columna535);
            TextBox311.Text = resultadoPalabras(Columna635);
            TextBox313.Text = resultadoPalabras(Columna536);
            TextBox315.Text = resultadoPalabras(Columna636);
            TextBox317.Text = resultadoPalabras(Columna537);
            TextBox319.Text = resultadoPalabras(Columna637);
            TextBox321.Text = resultadoPalabras(Columna538);
            TextBox323.Text = resultadoPalabras(Columna638);

            TextBox325.Text = resultadoPalabras(Columna539);
            TextBox327.Text = resultadoPalabras(Columna639);
            TextBox329.Text = resultadoPalabras(Columna540);
            TextBox331.Text = resultadoPalabras(Columna640);
            TextBox333.Text = resultadoPalabras(Columna541);
            TextBox335.Text = resultadoPalabras(Columna641);
            


            E = ((A - 1) * 99) + A;

            B = ((E - 1) * 99) + E;

            C = ((B - 1) * 99) + B;


            TextBox3.Text = resultadoNumeros(resultadoPalabras(Columna4), E, 1 );

            TextBox9.Text = resultadoNumeros(resultadoPalabras(Columna51), B, col51);
            TextBox17.Text = resultadoNumeros(resultadoPalabras(Columna52), B, col52);
            TextBox38.Text = resultadoNumeros(resultadoPalabras(Columna53), B, col53);
            TextBox42.Text = resultadoNumeros(resultadoPalabras(Columna54), B, col54);
            TextBox46.Text = resultadoNumeros(resultadoPalabras(Columna55), B, col55);

            TextBox194.Text = resultadoNumeros(resultadoPalabras(Columna56), B, col56);
            TextBox198.Text = resultadoNumeros(resultadoPalabras(Columna57), B, col57);
            TextBox202.Text = resultadoNumeros(resultadoPalabras(Columna58), B, col58);
            TextBox206.Text = resultadoNumeros(resultadoPalabras(Columna59), B, col59);
            TextBox210.Text = resultadoNumeros(resultadoPalabras(Columna510), B, col510);

            TextBox214.Text = resultadoNumeros(resultadoPalabras(Columna511), B, col511);
            TextBox218.Text = resultadoNumeros(resultadoPalabras(Columna512), B, col512);
            TextBox222.Text = resultadoNumeros(resultadoPalabras(Columna513), B, col513);
            TextBox226.Text = resultadoNumeros(resultadoPalabras(Columna514), B, col514);
            TextBox230.Text = resultadoNumeros(resultadoPalabras(Columna515), B, col515);

            TextBox234.Text = resultadoNumeros(resultadoPalabras(Columna516), B, col516);
            TextBox238.Text = resultadoNumeros(resultadoPalabras(Columna517), B, col517);
            TextBox242.Text = resultadoNumeros(resultadoPalabras(Columna518), B, col518);
            TextBox246.Text = resultadoNumeros(resultadoPalabras(Columna519), B, col519);
            TextBox250.Text = resultadoNumeros(resultadoPalabras(Columna520), B, col520);

            TextBox254.Text = resultadoNumeros(resultadoPalabras(Columna521), B, col521);
            TextBox258.Text = resultadoNumeros(resultadoPalabras(Columna522), B, col522);
            TextBox262.Text = resultadoNumeros(resultadoPalabras(Columna523), B, col523);
            TextBox266.Text = resultadoNumeros(resultadoPalabras(Columna524), B, col524);
            TextBox270.Text = resultadoNumeros(resultadoPalabras(Columna525), B, col525);

            TextBox274.Text = resultadoNumeros(resultadoPalabras(Columna526), B, col526);
            TextBox278.Text = resultadoNumeros(resultadoPalabras(Columna527), B, col527);
            TextBox282.Text = resultadoNumeros(resultadoPalabras(Columna528), B, col528);
            TextBox286.Text = resultadoNumeros(resultadoPalabras(Columna528), B, col529);
            TextBox290.Text = resultadoNumeros(resultadoPalabras(Columna530), B, col530);

            TextBox294.Text = resultadoNumeros(resultadoPalabras(Columna531), B, col531);
            TextBox298.Text = resultadoNumeros(resultadoPalabras(Columna532), B, col532);
            TextBox302.Text = resultadoNumeros(resultadoPalabras(Columna533), B, col533);
            TextBox306.Text = resultadoNumeros(resultadoPalabras(Columna534), B, col534);
            TextBox310.Text = resultadoNumeros(resultadoPalabras(Columna535), B, col535);

            TextBox314.Text = resultadoNumeros(resultadoPalabras(Columna536), B, col536);
            TextBox318.Text = resultadoNumeros(resultadoPalabras(Columna537), B, col537);
            TextBox322.Text = resultadoNumeros(resultadoPalabras(Columna538), B, col538);
            TextBox326.Text = resultadoNumeros(resultadoPalabras(Columna539), B, col539);
            TextBox330.Text = resultadoNumeros(resultadoPalabras(Columna540), B, col540);

            TextBox334.Text = resultadoNumeros(resultadoPalabras(Columna541), B, col541);



            TextBox11.Text = resultadoNumeros(resultadoPalabras(Columna61), C, col61);
            TextBox19.Text = resultadoNumeros(resultadoPalabras(Columna62), C, col62);
            TextBox40.Text = resultadoNumeros(resultadoPalabras(Columna63), C, col63);
            TextBox44.Text = resultadoNumeros(resultadoPalabras(Columna64), C, col64);
            TextBox48.Text = resultadoNumeros(resultadoPalabras(Columna65), C, col65);

            TextBox196.Text = resultadoNumeros(resultadoPalabras(Columna66), C, col66);
            TextBox200.Text = resultadoNumeros(resultadoPalabras(Columna67), C, col67);
            TextBox204.Text = resultadoNumeros(resultadoPalabras(Columna68), C, col68);
            TextBox208.Text = resultadoNumeros(resultadoPalabras(Columna69), C, col69);
            TextBox212.Text = resultadoNumeros(resultadoPalabras(Columna610), C, col610);

            TextBox216.Text = resultadoNumeros(resultadoPalabras(Columna611), C, col611);
            TextBox220.Text = resultadoNumeros(resultadoPalabras(Columna612), C, col612);
            TextBox224.Text = resultadoNumeros(resultadoPalabras(Columna613), C, col613);
            TextBox228.Text = resultadoNumeros(resultadoPalabras(Columna614), C, col614);
            TextBox232.Text = resultadoNumeros(resultadoPalabras(Columna615), C, col615);

            TextBox236.Text = resultadoNumeros(resultadoPalabras(Columna616), C, col616);
            TextBox240.Text = resultadoNumeros(resultadoPalabras(Columna617), C, col617);
            TextBox244.Text = resultadoNumeros(resultadoPalabras(Columna618), C, col618);
            TextBox248.Text = resultadoNumeros(resultadoPalabras(Columna619), C, col619);
            TextBox252.Text = resultadoNumeros(resultadoPalabras(Columna620), C, col620);

            TextBox256.Text = resultadoNumeros(resultadoPalabras(Columna621), C, col621);
            TextBox260.Text = resultadoNumeros(resultadoPalabras(Columna622), C, col622);
            TextBox264.Text = resultadoNumeros(resultadoPalabras(Columna623), C, col623);
            TextBox268.Text = resultadoNumeros(resultadoPalabras(Columna624), C, col624);
            TextBox272.Text = resultadoNumeros(resultadoPalabras(Columna625), C, col625);

            TextBox276.Text = resultadoNumeros(resultadoPalabras(Columna626), C, col626);
            TextBox280.Text = resultadoNumeros(resultadoPalabras(Columna627), C, col627);
            TextBox284.Text = resultadoNumeros(resultadoPalabras(Columna628), C, col628);
            TextBox288.Text = resultadoNumeros(resultadoPalabras(Columna628), C, col629);
            TextBox292.Text = resultadoNumeros(resultadoPalabras(Columna630), C, col630);

            TextBox296.Text = resultadoNumeros(resultadoPalabras(Columna631), C, col631);
            TextBox300.Text = resultadoNumeros(resultadoPalabras(Columna632), C, col632);
            TextBox304.Text = resultadoNumeros(resultadoPalabras(Columna633), C, col633);
            TextBox308.Text = resultadoNumeros(resultadoPalabras(Columna634), C, col634);
            TextBox312.Text = resultadoNumeros(resultadoPalabras(Columna635), C, col635);

            TextBox316.Text = resultadoNumeros(resultadoPalabras(Columna636), C, col636);
            TextBox320.Text = resultadoNumeros(resultadoPalabras(Columna637), C, col637);
            TextBox324.Text = resultadoNumeros(resultadoPalabras(Columna638), C, col638);
            TextBox328.Text = resultadoNumeros(resultadoPalabras(Columna639), C, col639);
            TextBox332.Text = resultadoNumeros(resultadoPalabras(Columna640), C, col640);

            TextBox336.Text = resultadoNumeros(resultadoPalabras(Columna641), C, col641);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        
        protected void Button3_Click1(object sender, EventArgs e)
        {
               Response.Redirect("WebForm2.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            
            TextBox8.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox10.Text = string.Empty;

            TextBox11.Text = string.Empty;
            TextBox12.Text = string.Empty;
            TextBox13.Text = string.Empty;
            TextBox14.Text = string.Empty;
            TextBox15.Text = string.Empty;
            TextBox16.Text = string.Empty;
            TextBox17.Text = string.Empty;
            TextBox18.Text = string.Empty;
            TextBox19.Text = string.Empty;
            TextBox20.Text = string.Empty;

            TextBox21.Text = string.Empty;
            TextBox22.Text = string.Empty;
            TextBox23.Text = string.Empty;
            TextBox24.Text = string.Empty;
            TextBox25.Text = string.Empty;
            TextBox26.Text = string.Empty;
            TextBox27.Text = string.Empty;
            TextBox28.Text = string.Empty;
            TextBox29.Text = string.Empty;
            TextBox30.Text = string.Empty;

            TextBox31.Text = string.Empty;
            TextBox32.Text = string.Empty;
            TextBox33.Text = string.Empty;
            TextBox34.Text = string.Empty;
            TextBox35.Text = string.Empty;
            TextBox36.Text = string.Empty;
            TextBox37.Text = string.Empty;
            TextBox38.Text = string.Empty;
            TextBox39.Text = string.Empty;
            TextBox40.Text = string.Empty;

            TextBox41.Text = string.Empty;
            TextBox42.Text = string.Empty;
            TextBox43.Text = string.Empty;
            TextBox44.Text = string.Empty;
            TextBox45.Text = string.Empty;
            TextBox46.Text = string.Empty;
            TextBox47.Text = string.Empty;
            TextBox48.Text = string.Empty;
            TextBox49.Text = string.Empty;
            TextBox50.Text = string.Empty;

            TextBox61.Text = string.Empty;
            TextBox62.Text = string.Empty;
            TextBox63.Text = string.Empty;
            TextBox64.Text = string.Empty;
            TextBox65.Text = string.Empty;
            TextBox66.Text = string.Empty;
            TextBox67.Text = string.Empty;
            TextBox68.Text = string.Empty;
            TextBox69.Text = string.Empty;
            TextBox70.Text = string.Empty;

            TextBox71.Text = string.Empty;
            TextBox72.Text = string.Empty;
            TextBox73.Text = string.Empty;
            TextBox74.Text = string.Empty;
            TextBox75.Text = string.Empty;
            TextBox76.Text = string.Empty;
            TextBox77.Text = string.Empty;
            TextBox78.Text = string.Empty;
            TextBox79.Text = string.Empty;
            TextBox80.Text = string.Empty;

            TextBox81.Text = string.Empty;
            TextBox82.Text = string.Empty;
            TextBox83.Text = string.Empty;
            TextBox84.Text = string.Empty;
            TextBox85.Text = string.Empty;
            TextBox86.Text = string.Empty;
            TextBox87.Text = string.Empty;
            TextBox88.Text = string.Empty;
            TextBox89.Text = string.Empty;
            TextBox90.Text = string.Empty;

            TextBox91.Text = string.Empty;
            TextBox92.Text = string.Empty;
            TextBox93.Text = string.Empty;
            TextBox94.Text = string.Empty;
            TextBox95.Text = string.Empty;
            TextBox96.Text = string.Empty;
            TextBox97.Text = string.Empty;
            TextBox98.Text = string.Empty;
            TextBox99.Text = string.Empty;
            TextBox100.Text = string.Empty;

            TextBox101.Text = string.Empty;
            TextBox102.Text = string.Empty;
            TextBox103.Text = string.Empty;
            TextBox104.Text = string.Empty;
            TextBox105.Text = string.Empty;
            TextBox106.Text = string.Empty;
            TextBox107.Text = string.Empty;
            TextBox108.Text = string.Empty;
            TextBox109.Text = string.Empty;
            TextBox110.Text = string.Empty;

            TextBox111.Text = string.Empty;
            TextBox112.Text = string.Empty;
            TextBox113.Text = string.Empty;
            TextBox114.Text = string.Empty;
            TextBox115.Text = string.Empty;
            TextBox116.Text = string.Empty;
            TextBox117.Text = string.Empty;
            TextBox118.Text = string.Empty;
            TextBox119.Text = string.Empty;
            TextBox120.Text = string.Empty;

            TextBox121.Text = string.Empty;
            TextBox122.Text = string.Empty;
            TextBox123.Text = string.Empty;
            TextBox124.Text = string.Empty;
            TextBox125.Text = string.Empty;
            TextBox126.Text = string.Empty;
            TextBox127.Text = string.Empty;
            TextBox128.Text = string.Empty;
            TextBox129.Text = string.Empty;
            TextBox130.Text = string.Empty;

            TextBox131.Text = string.Empty;
            TextBox132.Text = string.Empty;
            TextBox133.Text = string.Empty;
            TextBox134.Text = string.Empty;
            TextBox135.Text = string.Empty;
            TextBox136.Text = string.Empty;
            TextBox137.Text = string.Empty;
            TextBox138.Text = string.Empty;
            TextBox139.Text = string.Empty;
            TextBox140.Text = string.Empty;

            TextBox141.Text = string.Empty;
            TextBox142.Text = string.Empty;
            TextBox143.Text = string.Empty;
            TextBox144.Text = string.Empty;
            TextBox145.Text = string.Empty;
            TextBox146.Text = string.Empty;
            TextBox147.Text = string.Empty;
            TextBox148.Text = string.Empty;
            TextBox149.Text = string.Empty;
            TextBox150.Text = string.Empty;

            TextBox161.Text = string.Empty;
            TextBox162.Text = string.Empty;
            TextBox163.Text = string.Empty;
            TextBox164.Text = string.Empty;
            TextBox165.Text = string.Empty;
            TextBox166.Text = string.Empty;
            TextBox167.Text = string.Empty;
            TextBox168.Text = string.Empty;
            TextBox169.Text = string.Empty;
            TextBox170.Text = string.Empty;

            TextBox171.Text = string.Empty;
            TextBox172.Text = string.Empty;
            TextBox173.Text = string.Empty;
            TextBox174.Text = string.Empty;
            TextBox175.Text = string.Empty;
            TextBox176.Text = string.Empty;
            TextBox177.Text = string.Empty;
            TextBox178.Text = string.Empty;
            TextBox179.Text = string.Empty;
            TextBox180.Text = string.Empty;

            TextBox181.Text = string.Empty;
            TextBox182.Text = string.Empty;
            TextBox183.Text = string.Empty;
            TextBox184.Text = string.Empty;
            TextBox185.Text = string.Empty;
            TextBox186.Text = string.Empty;
            TextBox187.Text = string.Empty;
            TextBox188.Text = string.Empty;
            TextBox189.Text = string.Empty;
            TextBox190.Text = string.Empty;

            TextBox191.Text = string.Empty;
            TextBox192.Text = string.Empty;
            TextBox193.Text = string.Empty;
            TextBox194.Text = string.Empty;
            TextBox195.Text = string.Empty;
            TextBox196.Text = string.Empty;
            TextBox197.Text = string.Empty;
            TextBox198.Text = string.Empty;
            TextBox199.Text = string.Empty;
            TextBox200.Text = string.Empty;

            TextBox201.Text = string.Empty;
            TextBox202.Text = string.Empty;
            TextBox203.Text = string.Empty;
            TextBox204.Text = string.Empty;
            TextBox205.Text = string.Empty;
            TextBox206.Text = string.Empty;
            TextBox207.Text = string.Empty;
            TextBox208.Text = string.Empty;
            TextBox209.Text = string.Empty;
            TextBox210.Text = string.Empty;

            TextBox211.Text = string.Empty;
            TextBox212.Text = string.Empty;
            TextBox213.Text = string.Empty;
            TextBox214.Text = string.Empty;
            TextBox215.Text = string.Empty;
            TextBox216.Text = string.Empty;
            TextBox217.Text = string.Empty;
            TextBox218.Text = string.Empty;
            TextBox219.Text = string.Empty;
            TextBox220.Text = string.Empty;

            TextBox221.Text = string.Empty;
            TextBox222.Text = string.Empty;
            TextBox223.Text = string.Empty;
            TextBox224.Text = string.Empty;
            TextBox225.Text = string.Empty;
            TextBox226.Text = string.Empty;
            TextBox227.Text = string.Empty;
            TextBox228.Text = string.Empty;
            TextBox229.Text = string.Empty;
            TextBox230.Text = string.Empty;

            TextBox231.Text = string.Empty;
            TextBox232.Text = string.Empty;
            TextBox233.Text = string.Empty;
            TextBox234.Text = string.Empty;
            TextBox235.Text = string.Empty;
            TextBox236.Text = string.Empty;
            TextBox237.Text = string.Empty;
            TextBox238.Text = string.Empty;
            TextBox239.Text = string.Empty;
            TextBox240.Text = string.Empty;

            TextBox241.Text = string.Empty;
            TextBox242.Text = string.Empty;
            TextBox243.Text = string.Empty;
            TextBox244.Text = string.Empty;
            TextBox245.Text = string.Empty;
            TextBox246.Text = string.Empty;
            TextBox247.Text = string.Empty;
            TextBox248.Text = string.Empty;
            TextBox249.Text = string.Empty;
            TextBox250.Text = string.Empty;

            TextBox261.Text = string.Empty;
            TextBox262.Text = string.Empty;
            TextBox263.Text = string.Empty;
            TextBox264.Text = string.Empty;
            TextBox265.Text = string.Empty;
            TextBox266.Text = string.Empty;
            TextBox267.Text = string.Empty;
            TextBox268.Text = string.Empty;
            TextBox269.Text = string.Empty;
            TextBox270.Text = string.Empty;

            TextBox271.Text = string.Empty;
            TextBox272.Text = string.Empty;
            TextBox273.Text = string.Empty;
            TextBox274.Text = string.Empty;
            TextBox275.Text = string.Empty;
            TextBox276.Text = string.Empty;
            TextBox277.Text = string.Empty;
            TextBox278.Text = string.Empty;
            TextBox279.Text = string.Empty;
            TextBox280.Text = string.Empty;

            TextBox281.Text = string.Empty;
            TextBox282.Text = string.Empty;
            TextBox283.Text = string.Empty;
            TextBox284.Text = string.Empty;
            TextBox285.Text = string.Empty;
            TextBox286.Text = string.Empty;
            TextBox287.Text = string.Empty;
            TextBox288.Text = string.Empty;
            TextBox289.Text = string.Empty;
            TextBox290.Text = string.Empty;

            TextBox291.Text = string.Empty;
            TextBox292.Text = string.Empty;
            TextBox293.Text = string.Empty;
            TextBox294.Text = string.Empty;
            TextBox295.Text = string.Empty;
            TextBox296.Text = string.Empty;
            TextBox297.Text = string.Empty;
            TextBox298.Text = string.Empty;
            TextBox299.Text = string.Empty;
            TextBox300.Text = string.Empty;

            TextBox301.Text = string.Empty;
            TextBox302.Text = string.Empty;
            TextBox303.Text = string.Empty;
            TextBox304.Text = string.Empty;
            TextBox305.Text = string.Empty;
            TextBox306.Text = string.Empty;
            TextBox307.Text = string.Empty;
            TextBox308.Text = string.Empty;
            TextBox309.Text = string.Empty;
            TextBox310.Text = string.Empty;

            TextBox311.Text = string.Empty;
            TextBox312.Text = string.Empty;
            TextBox313.Text = string.Empty;
            TextBox314.Text = string.Empty;
            TextBox315.Text = string.Empty;
            TextBox316.Text = string.Empty;
            TextBox317.Text = string.Empty;
            TextBox318.Text = string.Empty;
            TextBox319.Text = string.Empty;
            TextBox320.Text = string.Empty;

            TextBox321.Text = string.Empty;
            TextBox322.Text = string.Empty;
            TextBox323.Text = string.Empty;
            TextBox324.Text = string.Empty;
            TextBox325.Text = string.Empty;
            TextBox326.Text = string.Empty;
            TextBox327.Text = string.Empty;
            TextBox328.Text = string.Empty;
            TextBox329.Text = string.Empty;
            TextBox330.Text = string.Empty;

            TextBox331.Text = string.Empty;
            TextBox332.Text = string.Empty;
            TextBox333.Text = string.Empty;
            TextBox334.Text = string.Empty;
            TextBox335.Text = string.Empty;
            TextBox336.Text = string.Empty;
           

            TextBox51.Text = string.Empty;
            TextBox52.Text = string.Empty;
            TextBox53.Text = string.Empty;
            TextBox54.Text = string.Empty;
            TextBox55.Text = string.Empty;
            TextBox56.Text = string.Empty;
            TextBox57.Text = string.Empty;
            TextBox58.Text = string.Empty;
            TextBox59.Text = string.Empty;
            TextBox60.Text = string.Empty;

            TextBox151.Text = string.Empty;
            TextBox152.Text = string.Empty;
            TextBox153.Text = string.Empty;
            TextBox154.Text = string.Empty;
            TextBox155.Text = string.Empty;
            TextBox156.Text = string.Empty;
            TextBox157.Text = string.Empty;
            TextBox158.Text = string.Empty;
            TextBox159.Text = string.Empty;
            TextBox160.Text = string.Empty;

            TextBox251.Text = string.Empty;
            TextBox252.Text = string.Empty;
            TextBox253.Text = string.Empty;
            TextBox254.Text = string.Empty;
            TextBox255.Text = string.Empty;
            TextBox256.Text = string.Empty;
            TextBox257.Text = string.Empty;
            TextBox258.Text = string.Empty;
            TextBox259.Text = string.Empty;
            TextBox260.Text = string.Empty;


            TextBox340.Text = string.Empty;
            TextBox337.Text = string.Empty;
            TextBox338.Text = string.Empty;
            TextBox339.Text = string.Empty;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox340.Text = TextBox8.Text + Environment.NewLine + TextBox16.Text + Environment.NewLine + TextBox37.Text + Environment.NewLine + TextBox41.Text + Environment.NewLine + TextBox45.Text + Environment.NewLine + TextBox193.Text + Environment.NewLine + TextBox197.Text + Environment.NewLine + TextBox201.Text + Environment.NewLine + TextBox205.Text + Environment.NewLine + TextBox209.Text + Environment.NewLine + TextBox213.Text + Environment.NewLine + TextBox217.Text + Environment.NewLine + TextBox221.Text + Environment.NewLine + TextBox225.Text + Environment.NewLine + TextBox229.Text + Environment.NewLine + TextBox233.Text + Environment.NewLine + TextBox237.Text + Environment.NewLine + TextBox241.Text + Environment.NewLine + TextBox245.Text + Environment.NewLine + TextBox249.Text + Environment.NewLine + TextBox253.Text + Environment.NewLine + TextBox257.Text + Environment.NewLine + TextBox261.Text + Environment.NewLine + TextBox265.Text + Environment.NewLine + TextBox269.Text + Environment.NewLine + TextBox273.Text + Environment.NewLine + TextBox277.Text + Environment.NewLine + TextBox281.Text + Environment.NewLine + TextBox285.Text + Environment.NewLine + TextBox289.Text + Environment.NewLine + TextBox293.Text + Environment.NewLine + TextBox297.Text + Environment.NewLine + TextBox301.Text + Environment.NewLine + TextBox305.Text + Environment.NewLine + TextBox309.Text + Environment.NewLine + TextBox313.Text + Environment.NewLine + TextBox317.Text + Environment.NewLine + TextBox321.Text + Environment.NewLine + TextBox325.Text + Environment.NewLine + TextBox329.Text + Environment.NewLine + TextBox333.Text;
            TextBox337.Text = TextBox9.Text + Environment.NewLine + TextBox17.Text + Environment.NewLine + TextBox38.Text + Environment.NewLine + TextBox42.Text + Environment.NewLine + TextBox46.Text + Environment.NewLine + TextBox194.Text + Environment.NewLine + TextBox198.Text + Environment.NewLine + TextBox202.Text + Environment.NewLine + TextBox206.Text + Environment.NewLine + TextBox210.Text + Environment.NewLine + TextBox214.Text + Environment.NewLine + TextBox218.Text + Environment.NewLine + TextBox222.Text + Environment.NewLine + TextBox226.Text + Environment.NewLine + TextBox230.Text + Environment.NewLine + TextBox234.Text + Environment.NewLine + TextBox238.Text + Environment.NewLine + TextBox242.Text + Environment.NewLine + TextBox246.Text + Environment.NewLine + TextBox250.Text + Environment.NewLine + TextBox254.Text + Environment.NewLine + TextBox258.Text + Environment.NewLine + TextBox262.Text + Environment.NewLine + TextBox266.Text + Environment.NewLine + TextBox270.Text + Environment.NewLine + TextBox274.Text + Environment.NewLine + TextBox278.Text + Environment.NewLine + TextBox282.Text + Environment.NewLine + TextBox286.Text + Environment.NewLine + TextBox290.Text + Environment.NewLine + TextBox294.Text + Environment.NewLine + TextBox298.Text + Environment.NewLine + TextBox302.Text + Environment.NewLine + TextBox306.Text + Environment.NewLine + TextBox310.Text + Environment.NewLine + TextBox314.Text + Environment.NewLine + TextBox318.Text + Environment.NewLine + TextBox322.Text + Environment.NewLine + TextBox326.Text + Environment.NewLine + TextBox330.Text + Environment.NewLine + TextBox334.Text;
            TextBox338.Text = TextBox10.Text + Environment.NewLine + TextBox18.Text + Environment.NewLine + TextBox39.Text + Environment.NewLine + TextBox43.Text + Environment.NewLine + TextBox47.Text + Environment.NewLine + TextBox195.Text + Environment.NewLine + TextBox199.Text + Environment.NewLine + TextBox203.Text + Environment.NewLine + TextBox207.Text + Environment.NewLine + TextBox211.Text + Environment.NewLine + TextBox215.Text + Environment.NewLine + TextBox219.Text + Environment.NewLine + TextBox223.Text + Environment.NewLine + TextBox227.Text + Environment.NewLine + TextBox231.Text + Environment.NewLine + TextBox235.Text + Environment.NewLine + TextBox239.Text + Environment.NewLine + TextBox240.Text + Environment.NewLine + TextBox247.Text + Environment.NewLine + TextBox251.Text + Environment.NewLine + TextBox255.Text + Environment.NewLine + TextBox259.Text + Environment.NewLine + TextBox263.Text + Environment.NewLine + TextBox267.Text + Environment.NewLine + TextBox271.Text + Environment.NewLine + TextBox275.Text + Environment.NewLine + TextBox279.Text + Environment.NewLine + TextBox283.Text + Environment.NewLine + TextBox287.Text + Environment.NewLine + TextBox291.Text + Environment.NewLine + TextBox295.Text + Environment.NewLine + TextBox299.Text + Environment.NewLine + TextBox303.Text + Environment.NewLine + TextBox307.Text + Environment.NewLine + TextBox311.Text + Environment.NewLine + TextBox315.Text + Environment.NewLine + TextBox319.Text + Environment.NewLine + TextBox323.Text + Environment.NewLine + TextBox327.Text + Environment.NewLine + TextBox331.Text + Environment.NewLine + TextBox335.Text;
            TextBox339.Text = TextBox11.Text + Environment.NewLine + TextBox19.Text + Environment.NewLine + TextBox40.Text + Environment.NewLine + TextBox44.Text + Environment.NewLine + TextBox48.Text + Environment.NewLine + TextBox196.Text + Environment.NewLine + TextBox200.Text + Environment.NewLine + TextBox204.Text + Environment.NewLine + TextBox208.Text + Environment.NewLine + TextBox212.Text + Environment.NewLine + TextBox216.Text + Environment.NewLine + TextBox220.Text + Environment.NewLine + TextBox224.Text + Environment.NewLine + TextBox228.Text + Environment.NewLine + TextBox232.Text + Environment.NewLine + TextBox236.Text + Environment.NewLine + TextBox240.Text + Environment.NewLine + TextBox241.Text + Environment.NewLine + TextBox248.Text + Environment.NewLine + TextBox252.Text + Environment.NewLine + TextBox256.Text + Environment.NewLine + TextBox260.Text + Environment.NewLine + TextBox264.Text + Environment.NewLine + TextBox268.Text + Environment.NewLine + TextBox272.Text + Environment.NewLine + TextBox276.Text + Environment.NewLine + TextBox280.Text + Environment.NewLine + TextBox284.Text + Environment.NewLine + TextBox288.Text + Environment.NewLine + TextBox292.Text + Environment.NewLine + TextBox296.Text + Environment.NewLine + TextBox300.Text + Environment.NewLine + TextBox304.Text + Environment.NewLine + TextBox308.Text + Environment.NewLine + TextBox312.Text + Environment.NewLine + TextBox316.Text + Environment.NewLine + TextBox320.Text + Environment.NewLine + TextBox324.Text + Environment.NewLine + TextBox328.Text + Environment.NewLine + TextBox332.Text + Environment.NewLine + TextBox336.Text;

            
            


        }
    }
}