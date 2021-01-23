namespace lekarne
{
    partial class profil
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
            this.dodlekarnebutton = new System.Windows.Forms.Button();
            this.updateuporabnik = new System.Windows.Forms.Button();
            this.deluporabnika = new System.Windows.Forms.Button();
            this.ime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodlekarnebutton
            // 
            this.dodlekarnebutton.Location = new System.Drawing.Point(42, 119);
            this.dodlekarnebutton.Name = "dodlekarnebutton";
            this.dodlekarnebutton.Size = new System.Drawing.Size(392, 89);
            this.dodlekarnebutton.TabIndex = 0;
            this.dodlekarnebutton.Text = "Dodaj novo lekarno";
            this.dodlekarnebutton.UseVisualStyleBackColor = true;
            this.dodlekarnebutton.Click += new System.EventHandler(this.dodlekarnebutton_Click);
            // 
            // updateuporabnik
            // 
            this.updateuporabnik.Location = new System.Drawing.Point(42, 248);
            this.updateuporabnik.Name = "updateuporabnik";
            this.updateuporabnik.Size = new System.Drawing.Size(392, 84);
            this.updateuporabnik.TabIndex = 1;
            this.updateuporabnik.Text = "Spremeni podatke o uporabniku";
            this.updateuporabnik.UseVisualStyleBackColor = true;
            this.updateuporabnik.Click += new System.EventHandler(this.izblekbutton_Click);
            // 
            // deluporabnika
            // 
            this.deluporabnika.Location = new System.Drawing.Point(42, 370);
            this.deluporabnika.Name = "deluporabnika";
            this.deluporabnika.Size = new System.Drawing.Size(392, 83);
            this.deluporabnika.TabIndex = 2;
            this.deluporabnika.Text = "Izbriši uporabnika";
            this.deluporabnika.UseVisualStyleBackColor = true;
            this.deluporabnika.Click += new System.EventHandler(this.deluporabnika_Click);
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(42, 37);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(35, 13);
            this.ime.TabIndex = 3;
            this.ime.Text = "label1";
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 621);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.deluporabnika);
            this.Controls.Add(this.updateuporabnik);
            this.Controls.Add(this.dodlekarnebutton);
            this.Name = "profil";
            this.Text = "profil";
            this.Load += new System.EventHandler(this.profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodlekarnebutton;
        private System.Windows.Forms.Button updateuporabnik;
        private System.Windows.Forms.Button deluporabnika;
        private System.Windows.Forms.Label ime;
    }
}