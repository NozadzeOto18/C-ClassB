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
            label2.Text = sigrdze_wris.ToString();
            label3.Text = perim_mart.ToString();
            label4.Text = perim_kvad.ToString();

        }

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

        }
    }
}
