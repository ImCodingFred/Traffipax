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
    public partial class statisztika : Form
    {
        public statisztika()
        {
            InitializeComponent();
        }
        class stat
        {
            public string rendszam { get; set; }
            public int kat { get; set; }
            public double sebesseg { get; set; }
            public int buntetes { get; set; }

            public stat(string egesz)
            {
                string[] dbok = egesz.Split(';');
                rendszam = dbok[0];
                kat = int.Parse(dbok[1]);
                sebesseg = double.Parse(dbok[2]);
                buntetes = int.Parse((dbok[3]));
            }
        }
        List<stat> statlist = new List<stat>();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void osszfeltolt()
        {
            dataGridView1.Rows.Clear();
            foreach (stat stat in statlist)
            {
                dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
            }
            Mszama_l.Text = statlist.Count + " db.";
            Bosszeg_l.Text = statlist.Sum(stat => stat.buntetes).ToString();
        }
        private void katfeltolt(string kat)
        {
            dataGridView1.Rows.Clear();
            int i  = 0;
            int sum = 0;
            foreach (stat stat in statlist)
            {
                if (kat == "nincs gyorshajtás")
                {
                    if (stat.kat == 0)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
                if (kat == "1. kategória")
                {
                    if (stat.kat == 1)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
                if (kat == "2. kategória")
                {
                    if (stat.kat == 2)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
                if (kat == "3. kategória")
                {
                    if (stat.kat == 3)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
                if (kat == "4. kategória")
                {
                    if (stat.kat == 4)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
                if (kat == "5. kategória")
                {
                    if (stat.kat == 5)
                    {
                        dataGridView1.Rows.Add(stat.rendszam, stat.sebesseg, stat.buntetes);
                        i++;
                        sum += stat.buntetes;
                    }
                }
            }
            Mszama_l.Text = i + " db.";
            Bosszeg_l.Text = sum.ToString();
        }
        private void statisztika_Load(object sender, EventArgs e)
        {
            kategoria_cb.Visible = false;
            osszes_rb.Checked = true;
            if (File.Exists("gyorshajtasok.txt"))
            {
                var sr = new StreamReader("gyorshajtasok.txt");
                while (!sr.EndOfStream)
                {
                    statlist.Add(new stat(sr.ReadLine()));
                }
                osszfeltolt();
                sr.Close();
            }
        }

        private void osszes_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (osszes_rb.Checked)
            {
                kategoria_cb.Visible = false;
                osszfeltolt();
            }
            else
            {
                kategoria_cb.Visible = true;
                katfeltolt(kategoria_cb.Text);
            }
        }

        private void kategoria_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (osszes_rb.Checked)
            {
                kategoria_cb.Visible = false;
                osszfeltolt();
            }
            else
            {
                kategoria_cb.Visible = true;
                katfeltolt(kategoria_cb.Text);
            }
        }

        private void kategoria_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            katfeltolt(kategoria_cb.Text);
        }
    }
}
