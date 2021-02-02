namespace lekarne
{
    partial class kraji
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
            this.insertkraj = new System.Windows.Forms.Button();
            this.kposttext = new System.Windows.Forms.TextBox();
            this.kimetext = new System.Windows.Forms.TextBox();
            this.updkraj = new System.Windows.Forms.Button();
            this.delkraj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stlekarnlabel = new System.Windows.Forms.Label();
            this.nazaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertkraj
            // 
            this.insertkraj.Location = new System.Drawing.Point(377, 206);
            this.insertkraj.Name = "insertkraj";
            this.insertkraj.Size = new System.Drawing.Size(161, 41);
            this.insertkraj.TabIndex = 13;
            this.insertkraj.Text = "Vnesi kraj";
            this.insertkraj.UseVisualStyleBackColor = true;
            this.insertkraj.Click += new System.EventHandler(this.insertkraj_Click);
            // 
            // kposttext
            // 
            this.kposttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kposttext.Location = new System.Drawing.Point(377, 161);
            this.kposttext.Name = "kposttext";
            this.kposttext.Size = new System.Drawing.Size(325, 29);
            this.kposttext.TabIndex = 12;
            this.kposttext.Text = "Vnesi posto";
            this.kposttext.Click += new System.EventHandler(this.kposttext_Click);
            // 
            // kimetext
            // 
            this.kimetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kimetext.Location = new System.Drawing.Point(377, 126);
            this.kimetext.Name = "kimetext";
            this.kimetext.Size = new System.Drawing.Size(325, 29);
            this.kimetext.TabIndex = 11;
            this.kimetext.Text = "Vnesi ime kraja";
            this.kimetext.Click += new System.EventHandler(this.kimetext_Click);
            // 
            // updkraj
            // 
            this.updkraj.Location = new System.Drawing.Point(544, 206);
            this.updkraj.Name = "updkraj";
            this.updkraj.Size = new System.Drawing.Size(158, 41);
            this.updkraj.TabIndex = 10;
            this.updkraj.Text = "Posodobi kraj";
            this.updkraj.UseVisualStyleBackColor = true;
            this.updkraj.Visible = false;
            this.updkraj.Click += new System.EventHandler(this.updkraj_Click);
            // 
            // delkraj
            // 
            this.delkraj.Location = new System.Drawing.Point(377, 53);
            this.delkraj.Name = "delkraj";
            this.delkraj.Size = new System.Drawing.Size(325, 41);
            this.delkraj.TabIndex = 9;
            this.delkraj.Text = "Izbriši kraj";
            this.delkraj.UseVisualStyleBackColor = true;
            this.delkraj.Visible = false;
            this.delkraj.Click += new System.EventHandler(this.delkraj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 537);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Število lekarn v kraju:";
            // 
            // stlekarnlabel
            // 
            this.stlekarnlabel.AutoSize = true;
            this.stlekarnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlekarnlabel.Location = new System.Drawing.Point(576, 307);
            this.stlekarnlabel.Name = "stlekarnlabel";
            this.stlekarnlabel.Size = new System.Drawing.Size(89, 24);
            this.stlekarnlabel.TabIndex = 15;
            this.stlekarnlabel.Text = "Izberi kraj";
            // 
            // nazaj
            // 
            this.nazaj.Location = new System.Drawing.Point(377, 535);
            this.nazaj.Name = "nazaj";
            this.nazaj.Size = new System.Drawing.Size(325, 55);
            this.nazaj.TabIndex = 16;
            this.nazaj.Text = "Nazaj";
            this.nazaj.UseVisualStyleBackColor = true;
            this.nazaj.Click += new System.EventHandler(this.nazaj_Click);
            // 
            // kraji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 634);
            this.Controls.Add(this.nazaj);
            this.Controls.Add(this.stlekarnlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertkraj);
            this.Controls.Add(this.kposttext);
            this.Controls.Add(this.kimetext);
            this.Controls.Add(this.updkraj);
            this.Controls.Add(this.delkraj);
            this.Controls.Add(this.listBox1);
            this.Name = "kraji";
            this.Text = "kraji";
            this.Load += new System.EventHandler(this.kraji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertkraj;
        private System.Windows.Forms.TextBox kposttext;
        private System.Windows.Forms.TextBox kimetext;
        private System.Windows.Forms.Button updkraj;
        private System.Windows.Forms.Button delkraj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stlekarnlabel;
        private System.Windows.Forms.Button nazaj;
    }
}