namespace Traffipax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void r�gz�t�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gyorsh = new gyorshajtasok();
            gyorsh.ShowDialog();
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisztik�kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stat = new statisztika();
            stat.ShowDialog();
        }
    }
}
