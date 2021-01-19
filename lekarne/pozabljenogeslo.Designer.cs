namespace lekarne
{
    partial class pozabljenogeslo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.prevmail = new System.Windows.Forms.Button();
            this.empanel = new System.Windows.Forms.Panel();
            this.passpanel = new System.Windows.Forms.Panel();
            this.geslobuton = new System.Windows.Forms.Button();
            this.empanel.SuspendLayout();
            this.passpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pozabljeno geslo";
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(100, 53);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(402, 29);
            this.passtext.TabIndex = 8;
            // 
            // emailtext
            // 
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.Location = new System.Drawing.Point(89, 53);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(402, 29);
            this.emailtext.TabIndex = 7;
            // 
            // prevmail
            // 
            this.prevmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevmail.Location = new System.Drawing.Point(177, 110);
            this.prevmail.Name = "prevmail";
            this.prevmail.Size = new System.Drawing.Size(233, 64);
            this.prevmail.TabIndex = 12;
            this.prevmail.Text = "Preveri ce email obstaja";
            this.prevmail.UseVisualStyleBackColor = true;
            this.prevmail.Click += new System.EventHandler(this.prevmail_Click);
            // 
            // empanel
            // 
            this.empanel.Controls.Add(this.emailtext);
            this.empanel.Controls.Add(this.prevmail);
            this.empanel.Controls.Add(this.label2);
            this.empanel.Location = new System.Drawing.Point(53, 100);
            this.empanel.Name = "empanel";
            this.empanel.Size = new System.Drawing.Size(583, 224);
            this.empanel.TabIndex = 13;
            // 
            // passpanel
            // 
            this.passpanel.Controls.Add(this.geslobuton);
            this.passpanel.Controls.Add(this.label3);
            this.passpanel.Controls.Add(this.passtext);
            this.passpanel.Location = new System.Drawing.Point(50, 100);
            this.passpanel.Name = "passpanel";
            this.passpanel.Size = new System.Drawing.Size(583, 224);
            this.passpanel.TabIndex = 14;
            // 
            // geslobuton
            // 
            this.geslobuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geslobuton.Location = new System.Drawing.Point(175, 110);
            this.geslobuton.Name = "geslobuton";
            this.geslobuton.Size = new System.Drawing.Size(253, 85);
            this.geslobuton.TabIndex = 12;
            this.geslobuton.Text = "Ustvari novo geslo";
            this.geslobuton.UseVisualStyleBackColor = true;
            this.geslobuton.Click += new System.EventHandler(this.geslobuton_Click);
            // 
            // pozabljenogeslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 527);
            this.Controls.Add(this.passpanel);
            this.Controls.Add(this.empanel);
            this.Controls.Add(this.label1);
            this.Name = "pozabljenogeslo";
            this.Text = "pozabljenogeslo";
            this.empanel.ResumeLayout(false);
            this.empanel.PerformLayout();
            this.passpanel.ResumeLayout(false);
            this.passpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Button prevmail;
        private System.Windows.Forms.Panel empanel;
        private System.Windows.Forms.Panel passpanel;
        private System.Windows.Forms.Button geslobuton;
    }
}