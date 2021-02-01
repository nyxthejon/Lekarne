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
            this.kbutton = new System.Windows.Forms.Button();
            this.nazajnaizpisbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.odjavabutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodlekarnebutton
            // 
            this.dodlekarnebutton.Location = new System.Drawing.Point(119, 154);
            this.dodlekarnebutton.Name = "dodlekarnebutton";
            this.dodlekarnebutton.Size = new System.Drawing.Size(392, 89);
            this.dodlekarnebutton.TabIndex = 0;
            this.dodlekarnebutton.Text = "Dodaj novo lekarno";
            this.dodlekarnebutton.UseVisualStyleBackColor = true;
            this.dodlekarnebutton.Click += new System.EventHandler(this.dodlekarnebutton_Click);
            // 
            // updateuporabnik
            // 
            this.updateuporabnik.Location = new System.Drawing.Point(19, 486);
            this.updateuporabnik.Name = "updateuporabnik";
            this.updateuporabnik.Size = new System.Drawing.Size(392, 84);
            this.updateuporabnik.TabIndex = 1;
            this.updateuporabnik.Text = "Spremeni podatke o uporabniku";
            this.updateuporabnik.UseVisualStyleBackColor = true;
            this.updateuporabnik.Click += new System.EventHandler(this.izblekbutton_Click);
            // 
            // deluporabnika
            // 
            this.deluporabnika.Location = new System.Drawing.Point(19, 387);
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
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izpis podatkov";
            // 
            // emlab
            // 
            this.emlab.AutoSize = true;
            this.emlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emlab.Location = new System.Drawing.Point(79, 86);
            this.emlab.Name = "emlab";
            this.emlab.Size = new System.Drawing.Size(111, 20);
            this.emlab.TabIndex = 5;
            this.emlab.Text = "Izpis podatkov";
            // 
            // paslab
            // 
            this.paslab.AutoSize = true;
            this.paslab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paslab.Location = new System.Drawing.Point(79, 126);
            this.paslab.Name = "paslab";
            this.paslab.Size = new System.Drawing.Size(111, 20);
            this.paslab.TabIndex = 6;
            this.paslab.Text = "Izpis podatkov";
            // 
            // tellab
            // 
            this.tellab.AutoSize = true;
            this.tellab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellab.Location = new System.Drawing.Point(79, 167);
            this.tellab.Name = "tellab";
            this.tellab.Size = new System.Drawing.Size(111, 20);
            this.tellab.TabIndex = 7;
            this.tellab.Text = "Izpis podatkov";
            // 
            // krlab
            // 
            this.krlab.AutoSize = true;
            this.krlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krlab.Location = new System.Drawing.Point(79, 202);
            this.krlab.Name = "krlab";
            this.krlab.Size = new System.Drawing.Size(111, 20);
            this.krlab.TabIndex = 8;
            this.krlab.Text = "Izpis podatkov";
            // 
            // kbutton
            // 
            this.kbutton.Location = new System.Drawing.Point(119, 264);
            this.kbutton.Name = "kbutton";
            this.kbutton.Size = new System.Drawing.Size(392, 83);
            this.kbutton.TabIndex = 9;
            this.kbutton.Text = "Ogled, brisanje in urejanje krajev";
            this.kbutton.UseVisualStyleBackColor = true;
            this.kbutton.Click += new System.EventHandler(this.kbutton_Click);
            // 
            // nazajnaizpisbutton
            // 
            this.nazajnaizpisbutton.Location = new System.Drawing.Point(12, 544);
            this.nazajnaizpisbutton.Name = "nazajnaizpisbutton";
            this.nazajnaizpisbutton.Size = new System.Drawing.Size(260, 83);
            this.nazajnaizpisbutton.TabIndex = 10;
            this.nazajnaizpisbutton.Text = "Vrni se nazaj na izpis";
            this.nazajnaizpisbutton.UseVisualStyleBackColor = true;
            this.nazajnaizpisbutton.Click += new System.EventHandler(this.nazajnaizpisbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.emlab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.paslab);
            this.panel1.Controls.Add(this.krlab);
            this.panel1.Controls.Add(this.tellab);
            this.panel1.Location = new System.Drawing.Point(98, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 334);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.deluporabnika);
            this.panel2.Controls.Add(this.updateuporabnik);
            this.panel2.Location = new System.Drawing.Point(665, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 595);
            this.panel2.TabIndex = 12;
            // 
            // odjavabutton
            // 
            this.odjavabutton.Location = new System.Drawing.Point(356, 544);
            this.odjavabutton.Name = "odjavabutton";
            this.odjavabutton.Size = new System.Drawing.Size(278, 82);
            this.odjavabutton.TabIndex = 13;
            this.odjavabutton.Text = "Odjavi se iz računa";
            this.odjavabutton.UseVisualStyleBackColor = true;
            this.odjavabutton.Click += new System.EventHandler(this.odjavabutton_Click);
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 639);
            this.Controls.Add(this.odjavabutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nazajnaizpisbutton);
            this.Controls.Add(this.kbutton);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.dodlekarnebutton);
            this.Name = "profil";
            this.Text = "profil";
            this.Load += new System.EventHandler(this.profil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button kbutton;
        private System.Windows.Forms.Button nazajnaizpisbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button odjavabutton;
    }
}