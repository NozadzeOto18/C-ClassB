using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figura obj_1 = new Figura();
            int gverdi_1, gverdi_2, gverdi_3;
            double radiusi;
            int perim_kvad, perim_mart, perim_samk;
            double sigrdze_wris;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);
            radiusi = double.Parse(textBox4.Text);

            perim_samk = obj_1.Perimetri(gverdi_1,  gverdi_2, gverdi_3);
            sigrdze_wris = obj_1.Perimetri(radiusi);
            perim_mart = obj_1.Perimetri(gverdi_1, gverdi_2);
            perim_kvad = obj_1.Perimetri(gverdi_1);

            label1.Text = perim_kvad.ToString();
            label2.Text = perim_mart.ToString();
            label3.Text = perim_samk.ToString();
            label4.Text = sigrdze_wris.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            double radiusi;
            int perim_kvad, perim_mart, perim_samk;
            int fart_kvad, fart_mart;
            double fart_samk, fart_wris, sigrdze_wris;

            gverdi_1 = int.Parse(textBox5.Text);
            gverdi_2 = int.Parse(textBox6.Text);
            gverdi_3 = int.Parse(textBox7.Text);
            radiusi  = double.Parse(textBox8.Text);

            Figura_1 obj_samk = new Figura_1(gverdi_1, gverdi_1, gverdi_3);
            Figura_1 obj_mart = new Figura_1(gverdi_1, gverdi_2);
            Figura_1 obj_wre  = new Figura_1(radiusi);
            Figura_1 obj_kvad = new Figura_1(gverdi_2);

            perim_kvad = obj_kvad.Perim_kvad();
            fart_kvad  = obj_kvad.Fart_kvad();
            perim_mart = obj_mart.Perim_mart();
            fart_mart  = obj_mart.Fart_mart();
            perim_samk = obj_samk.Perim_samk();
            fart_samk = obj_samk.Fart_samk();
            sigrdze_wris = obj_wre.Sigrdze_wris();
            fart_wris = obj_wre.Fart_wris();

            label21.Text = perim_kvad.ToString();
            label22.Text = fart_kvad.ToString();
            label23.Text = perim_mart.ToString();
            label24.Text = fart_mart.ToString();
            label25.Text = perim_samk.ToString();
            label26.Text = fart_samk.ToString();
            label27.Text = sigrdze_wris.ToString();
            label28.Text = sigrdze_wris.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int simagle, fudze;
            int gverdi_1, gverdi_2, gverdi_3;
            double fart_samk;
            int perim_samk;

            gverdi_1 = int.Parse(textBox11.Text);
            gverdi_2 = int.Parse(textBox10.Text);
            gverdi_3 = int.Parse(textBox9.Text);
            fudze = double.Parse(TextBox13.Text);
            simagle = double.Parse(TextBox14.Text);
        }



        /*
        private void button2_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3;
            double radiusi;
            int perim_kvad, perim_mart, perim_samk;
            int fart_kvad, fart_mart;
            double sigrdze_wris, fart_samk, fart_wris;

            gverdi_1 = int.Parse(textBox5.Text);
            gverdi_2 = int.Parse(textBox6.Text);
            gverdi_3 = int.Parse(textBox7.Text);
            radiusi = double.Parse(textBox8.Text);

            Figura_1 obj_wre = new Figura_1(radiusi);
            Figura_1 obj_mart = new Figura_1(gverdi_1, gverdi_2); ;
            Figura_1 obj_kvad = new Figura_1(gverdi_1);
            Figura_1 obj_samk = new Figura_1(gverdi_1, gverdi_2, gverdi_3);

            perim_kvad = obj_kvad.Perim_Kvad();
            fart_kvad = obj_kvad.Fart_Kvad();
            perim_mart = obj_mart.Perim_Mart();
            fart_mart = obj_mart.Fart_Mart();
            perim_samk = obj_samk.Perim_Samk();
            fart_samk = obj_samk.Fart_Samk();
            sigrdze_wris = obj_wre.Sigrdze_Wris();
            fart_wris = obj_wre.Fart_Wris();

            label13.Text = perim_kvad.ToString();
            label14.Text = fart_kvad.ToString();
            label15.Text = perim_mart.ToString();
            label16.Text = fart_mart.ToString();
            label17.Text = perim_samk.ToString();
            label18.Text = fart_samk.ToString();
            label19.Text = sigrdze_wris.ToString();
            label20.Text = fart_wris.ToString();

        }*/

    }
}
