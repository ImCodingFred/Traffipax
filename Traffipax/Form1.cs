namespace Traffipax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gyorsh = new gyorshajtasok();
            gyorsh.ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisztikákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stat = new statisztika();
            stat.ShowDialog();
        }
    }
}
