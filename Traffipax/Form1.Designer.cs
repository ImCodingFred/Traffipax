namespace Traffipax
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gyorshajtásokToolStripMenuItem = new ToolStripMenuItem();
            rögzítésToolStripMenuItem = new ToolStripMenuItem();
            statisztikákToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gyorshajtásokToolStripMenuItem, statisztikákToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(267, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gyorshajtásokToolStripMenuItem
            // 
            gyorshajtásokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rögzítésToolStripMenuItem });
            gyorshajtásokToolStripMenuItem.Name = "gyorshajtásokToolStripMenuItem";
            gyorshajtásokToolStripMenuItem.Size = new Size(92, 20);
            gyorshajtásokToolStripMenuItem.Text = "gyorshajtások";
            // 
            // rögzítésToolStripMenuItem
            // 
            rögzítésToolStripMenuItem.Name = "rögzítésToolStripMenuItem";
            rögzítésToolStripMenuItem.Size = new Size(115, 22);
            rögzítésToolStripMenuItem.Text = "rögzítés";
            rögzítésToolStripMenuItem.Click += rögzítésToolStripMenuItem_Click;
            // 
            // statisztikákToolStripMenuItem
            // 
            statisztikákToolStripMenuItem.Name = "statisztikákToolStripMenuItem";
            statisztikákToolStripMenuItem.Size = new Size(76, 20);
            statisztikákToolStripMenuItem.Text = "statisztikák";
            statisztikákToolStripMenuItem.Click += statisztikákToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(55, 20);
            kilépésToolStripMenuItem.Text = "kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 48);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Főmenü";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gyorshajtásokToolStripMenuItem;
        private ToolStripMenuItem rögzítésToolStripMenuItem;
        private ToolStripMenuItem statisztikákToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
    }
}
