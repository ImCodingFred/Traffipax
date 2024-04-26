namespace Traffipax
{
    partial class gyorshajtasok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gyorshajtasok));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bunt_l = new Label();
            label5 = new Label();
            label6 = new Label();
            kat_l = new Label();
            label8 = new Label();
            Rszam_tb = new TextBox();
            Mseb_tb = new TextBox();
            Ment_btn = new Button();
            Elvet_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Rendszám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Sebességhatár:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 183);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 0;
            label3.Text = "Büntetési kategória:";
            // 
            // bunt_l
            // 
            bunt_l.AutoSize = true;
            bunt_l.Location = new Point(495, 183);
            bunt_l.Name = "bunt_l";
            bunt_l.Size = new Size(28, 15);
            bunt_l.TabIndex = 0;
            bunt_l.Text = "0 Ft";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 105);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 0;
            label5.Text = "Mért sebesség:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 105);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 0;
            label6.Text = "100 km/h";
            // 
            // kat_l
            // 
            kat_l.AutoSize = true;
            kat_l.Location = new Point(160, 183);
            kat_l.Name = "kat_l";
            kat_l.Size = new Size(102, 15);
            kat_l.TabIndex = 0;
            kat_l.Text = "Nincs gyorshajtás";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 183);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 0;
            label8.Text = "Büntetés összege:";
            // 
            // Rszam_tb
            // 
            Rszam_tb.CharacterCasing = CharacterCasing.Upper;
            Rszam_tb.Location = new Point(100, 34);
            Rszam_tb.Name = "Rszam_tb";
            Rszam_tb.Size = new Size(100, 23);
            Rszam_tb.TabIndex = 1;
            // 
            // Mseb_tb
            // 
            Mseb_tb.Location = new Point(442, 102);
            Mseb_tb.Name = "Mseb_tb";
            Mseb_tb.Size = new Size(100, 23);
            Mseb_tb.TabIndex = 2;
            Mseb_tb.TextChanged += Mseb_tb_TextChanged;
            // 
            // Ment_btn
            // 
            Ment_btn.Image = (Image)resources.GetObject("Ment_btn.Image");
            Ment_btn.ImageAlign = ContentAlignment.MiddleRight;
            Ment_btn.Location = new Point(80, 251);
            Ment_btn.Name = "Ment_btn";
            Ment_btn.Size = new Size(130, 43);
            Ment_btn.TabIndex = 3;
            Ment_btn.Text = "Mentés";
            Ment_btn.UseVisualStyleBackColor = true;
            Ment_btn.Click += Ment_btn_Click;
            // 
            // Elvet_btn
            // 
            Elvet_btn.Image = (Image)resources.GetObject("Elvet_btn.Image");
            Elvet_btn.ImageAlign = ContentAlignment.MiddleRight;
            Elvet_btn.Location = new Point(391, 251);
            Elvet_btn.Name = "Elvet_btn";
            Elvet_btn.Size = new Size(130, 43);
            Elvet_btn.TabIndex = 3;
            Elvet_btn.Text = "Elvetés";
            Elvet_btn.UseVisualStyleBackColor = true;
            Elvet_btn.Click += Elvet_btn_Click;
            // 
            // gyorshajtasok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 338);
            Controls.Add(Elvet_btn);
            Controls.Add(Ment_btn);
            Controls.Add(Mseb_tb);
            Controls.Add(Rszam_tb);
            Controls.Add(label8);
            Controls.Add(bunt_l);
            Controls.Add(kat_l);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "gyorshajtasok";
            Text = "Gyorshajtások rögzítése";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label bunt_l;
        private Label label5;
        private Label label6;
        private Label kat_l;
        private Label label8;
        private TextBox Rszam_tb;
        private TextBox Mseb_tb;
        private Button Ment_btn;
        private Button Elvet_btn;
    }
}