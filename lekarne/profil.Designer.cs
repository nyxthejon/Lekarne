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
            this.label1 = new System.Windows.Forms.Label();
            this.emlab = new System.Windows.Forms.Label();
            this.paslab = new System.Windows.Forms.Label();
            this.tellab = new System.Windows.Forms.Label();
            this.krlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodlekarnebutton
            // 
            this.dodlekarnebutton.Location = new System.Drawing.Point(45, 68);
            this.dodlekarnebutton.Name = "dodlekarnebutton";
            this.dodlekarnebutton.Size = new System.Drawing.Size(392, 89);
            this.dodlekarnebutton.TabIndex = 0;
            this.dodlekarnebutton.Text = "Dodaj novo lekarno";
            this.dodlekarnebutton.UseVisualStyleBackColor = true;
            this.dodlekarnebutton.Click += new System.EventHandler(this.dodlekarnebutton_Click);
            // 
            // updateuporabnik
            // 
            this.updateuporabnik.Location = new System.Drawing.Point(45, 197);
            this.updateuporabnik.Name = "updateuporabnik";
            this.updateuporabnik.Size = new System.Drawing.Size(392, 84);
            this.updateuporabnik.TabIndex = 1;
            this.updateuporabnik.Text = "Spremeni podatke o uporabniku";
            this.updateuporabnik.UseVisualStyleBackColor = true;
            this.updateuporabnik.Click += new System.EventHandler(this.izblekbutton_Click);
            // 
            // deluporabnika
            // 
            this.deluporabnika.Location = new System.Drawing.Point(45, 319);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izpis podatkov";
            // 
            // emlab
            // 
            this.emlab.AutoSize = true;
            this.emlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emlab.Location = new System.Drawing.Point(182, 497);
            this.emlab.Name = "emlab";
            this.emlab.Size = new System.Drawing.Size(111, 20);
            this.emlab.TabIndex = 5;
            this.emlab.Text = "Izpis podatkov";
            // 
            // paslab
            // 
            this.paslab.AutoSize = true;
            this.paslab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paslab.Location = new System.Drawing.Point(182, 538);
            this.paslab.Name = "paslab";
            this.paslab.Size = new System.Drawing.Size(111, 20);
            this.paslab.TabIndex = 6;
            this.paslab.Text = "Izpis podatkov";
            // 
            // tellab
            // 
            this.tellab.AutoSize = true;
            this.tellab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellab.Location = new System.Drawing.Point(182, 579);
            this.tellab.Name = "tellab";
            this.tellab.Size = new System.Drawing.Size(111, 20);
            this.tellab.TabIndex = 7;
            this.tellab.Text = "Izpis podatkov";
            // 
            // krlab
            // 
            this.krlab.AutoSize = true;
            this.krlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krlab.Location = new System.Drawing.Point(182, 617);
            this.krlab.Name = "krlab";
            this.krlab.Size = new System.Drawing.Size(111, 20);
            this.krlab.TabIndex = 8;
            this.krlab.Text = "Izpis podatkov";
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 755);
            this.Controls.Add(this.krlab);
            this.Controls.Add(this.tellab);
            this.Controls.Add(this.paslab);
            this.Controls.Add(this.emlab);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emlab;
        private System.Windows.Forms.Label paslab;
        private System.Windows.Forms.Label tellab;
        private System.Windows.Forms.Label krlab;
    }
}