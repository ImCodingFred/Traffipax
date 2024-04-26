namespace Traffipax
{
    partial class statisztika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Rendszam = new DataGridViewTextBoxColumn();
            Mseb = new DataGridViewTextBoxColumn();
            Bosszeg = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            kategoria_cb = new ComboBox();
            kategoria_rb = new RadioButton();
            osszes_rb = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            Mszama_l = new Label();
            Bosszeg_l = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Rendszam, Mseb, Bosszeg });
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(407, 375);
            dataGridView1.TabIndex = 0;
            // 
            // Rendszam
            // 
            Rendszam.HeaderText = "Rendszám";
            Rendszam.Name = "Rendszam";
            // 
            // Mseb
            // 
            Mseb.HeaderText = "Mért Sebesség";
            Mseb.Name = "Mseb";
            // 
            // Bosszeg
            // 
            Bosszeg.HeaderText = "Büntetés Összege";
            Bosszeg.Name = "Bosszeg";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kategoria_cb);
            groupBox1.Controls.Add(kategoria_rb);
            groupBox1.Controls.Add(osszes_rb);
            groupBox1.Location = new Point(449, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Szűűűűűrés";
            // 
            // kategoria_cb
            // 
            kategoria_cb.FormattingEnabled = true;
            kategoria_cb.Items.AddRange(new object[] { "nincs gyorshajtás", "1. kategória", "2. kategória", "3. kategória", "4. kategória", "5. kategória" });
            kategoria_cb.Location = new Point(31, 92);
            kategoria_cb.Name = "kategoria_cb";
            kategoria_cb.Size = new Size(207, 23);
            kategoria_cb.TabIndex = 1;
            kategoria_cb.SelectedIndexChanged += kategoria_cb_SelectedIndexChanged;
            // 
            // kategoria_rb
            // 
            kategoria_rb.AutoSize = true;
            kategoria_rb.Location = new Point(31, 67);
            kategoria_rb.Name = "kategoria_rb";
            kategoria_rb.Size = new Size(173, 19);
            kategoria_rb.TabIndex = 0;
            kategoria_rb.TabStop = true;
            kategoria_rb.Text = "sebesség kategória választás";
            kategoria_rb.UseVisualStyleBackColor = true;
            kategoria_rb.CheckedChanged += kategoria_rb_CheckedChanged;
            // 
            // osszes_rb
            // 
            osszes_rb.AutoSize = true;
            osszes_rb.Location = new Point(31, 31);
            osszes_rb.Name = "osszes_rb";
            osszes_rb.Size = new Size(60, 19);
            osszes_rb.TabIndex = 0;
            osszes_rb.TabStop = true;
            osszes_rb.Text = "Összes";
            osszes_rb.UseVisualStyleBackColor = true;
            osszes_rb.CheckedChanged += osszes_rb_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 234);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Mérések száma:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 290);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Bírságok összege:";
            // 
            // Mszama_l
            // 
            Mszama_l.AutoSize = true;
            Mszama_l.Location = new Point(610, 234);
            Mszama_l.Name = "Mszama_l";
            Mszama_l.Size = new Size(30, 15);
            Mszama_l.TabIndex = 2;
            Mszama_l.Text = "0 db";
            Mszama_l.Click += label1_Click;
            // 
            // Bosszeg_l
            // 
            Bosszeg_l.AutoSize = true;
            Bosszeg_l.Location = new Point(610, 290);
            Bosszeg_l.Name = "Bosszeg_l";
            Bosszeg_l.Size = new Size(24, 15);
            Bosszeg_l.TabIndex = 2;
            Bosszeg_l.Text = "0 ft";
            // 
            // statisztika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bosszeg_l);
            Controls.Add(label2);
            Controls.Add(Mszama_l);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "statisztika";
            Text = "statisztika";
            Load += statisztika_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Rendszam;
        private DataGridViewTextBoxColumn Mseb;
        private DataGridViewTextBoxColumn Bosszeg;
        private GroupBox groupBox1;
        private RadioButton kategoria_rb;
        private RadioButton osszes_rb;
        private Label label1;
        private Label label2;
        private Label Mszama_l;
        private Label Bosszeg_l;
        private ComboBox kategoria_cb;
    }
}