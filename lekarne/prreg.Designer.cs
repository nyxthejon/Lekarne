namespace lekarne
{
    partial class prreg
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
            this.emailtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pributton = new System.Windows.Forms.Button();
            this.regbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pozb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailtext
            // 
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.Location = new System.Drawing.Point(214, 135);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(402, 29);
            this.emailtext.TabIndex = 0;
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(214, 203);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(402, 29);
            this.passtext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prijava";
            // 
            // pributton
            // 
            this.pributton.Location = new System.Drawing.Point(312, 286);
            this.pributton.Name = "pributton";
            this.pributton.Size = new System.Drawing.Size(210, 54);
            this.pributton.TabIndex = 3;
            this.pributton.Text = "Prijava";
            this.pributton.UseVisualStyleBackColor = true;
            this.pributton.Click += new System.EventHandler(this.pributton_Click);
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(312, 365);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(210, 54);
            this.regbutton.TabIndex = 4;
            this.regbutton.Text = "Registracija";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // pozb
            // 
            this.pozb.Location = new System.Drawing.Point(312, 437);
            this.pozb.Name = "pozb";
            this.pozb.Size = new System.Drawing.Size(210, 54);
            this.pozb.TabIndex = 7;
            this.pozb.Text = "Pozabljeno geslo";
            this.pozb.UseVisualStyleBackColor = true;
            this.pozb.Click += new System.EventHandler(this.pozb_Click);
            // 
            // prreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 524);
            this.Controls.Add(this.pozb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.pributton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.emailtext);
            this.Name = "prreg";
            this.Text = "prreg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pributton;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pozb;
    }
}