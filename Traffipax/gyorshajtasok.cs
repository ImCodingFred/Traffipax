using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffipax
{
    public partial class gyorshajtasok : Form
    {
        public gyorshajtasok()
        {
            InitializeComponent();
        }
        int sebesseg = 0;
        (int kategoria, int birsag) buntetes = (0, 0);
        private void Mseb_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(Mseb_tb.Text);
                if (a > 180)
                {
                    MessageBox.Show("180 km/h túl lépett.");
                    Mseb_tb.Focus();
                }
                else if (a < 0)
                {
                    MessageBox.Show("0 km/h-nál kevesebb.");
                    Mseb_tb.Focus();
                }
                else
                {
                    sebesseg = a;
                    if (a > 0 && a < 99.9)
                    {
                        buntetes = (0, 0);
                    }
                    else if (a > 100 && a < 119.9)
                    {
                        buntetes = (1, 0);
                    }
                    else if (a > 119.9 && a < 134.9)
                    {
                        buntetes = (2, 39000);
                    }
                    else if (a > 134.9 && a < 149.9)
                    {
                        buntetes = (3, 58500);
                    }
                    else if (a > 149.9 && a < 164.9)
                    {
                        buntetes = (4, 78000);
                    }
                    else if (a > 164.9 && a < 180)
                    {
                        buntetes = (5, 117000);
                    }
                    kat_l.Text = buntetes.kategoria.ToString() + ".";
                    bunt_l.Text = buntetes.birsag.ToString() + " Ft";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Csak számot adjon meg!");
                Mseb_tb.Focus();
            }

        }

        private void Ment_btn_Click(object sender, EventArgs e)
        {
            if (Rszam_tb.Text == "")
            {
                MessageBox.Show("A Rendszám üres!");
                Rszam_tb.Focus();
            }
            else if (Mseb_tb.Text == "")
            {
                MessageBox.Show("A mért sebesség üres");
                Mseb_tb.Focus();
            }
            else
            {
                var sw = new StreamWriter("gyorshajtasok.txt",true);
                sw.WriteLine(Rszam_tb.Text + ";" + buntetes.kategoria + ";" + sebesseg + ";" + buntetes.birsag);
                sw.Close();
            }
        }

        private void Elvet_btn_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny= MessageBox.Show("Biztos elveti?", "Elvetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eredmeny == DialogResult.Yes)
            {
                Rszam_tb.Text = "";
                Mseb_tb.Text = "";
                sebesseg = 0;
                kat_l.Text = "0.";
                bunt_l.Text = "0 Ft";
                this.Close();
            }
        }
    }
}
