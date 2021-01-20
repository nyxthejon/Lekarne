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
            this.izblekbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodlekarnebutton
            // 
            this.dodlekarnebutton.Location = new System.Drawing.Point(216, 98);
            this.dodlekarnebutton.Name = "dodlekarnebutton";
            this.dodlekarnebutton.Size = new System.Drawing.Size(392, 89);
            this.dodlekarnebutton.TabIndex = 0;
            this.dodlekarnebutton.Text = "Dodaj novo lekarno";
            this.dodlekarnebutton.UseVisualStyleBackColor = true;
            this.dodlekarnebutton.Click += new System.EventHandler(this.dodlekarnebutton_Click);
            // 
            // izblekbutton
            // 
            this.izblekbutton.Location = new System.Drawing.Point(216, 227);
            this.izblekbutton.Name = "izblekbutton";
            this.izblekbutton.Size = new System.Drawing.Size(392, 84);
            this.izblekbutton.TabIndex = 1;
            this.izblekbutton.Text = "Izbriši lekarno";
            this.izblekbutton.UseVisualStyleBackColor = true;
            this.izblekbutton.Click += new System.EventHandler(this.izblekbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.izblekbutton);
            this.Controls.Add(this.dodlekarnebutton);
            this.Name = "profil";
            this.Text = "profil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodlekarnebutton;
        private System.Windows.Forms.Button izblekbutton;
        private System.Windows.Forms.Button button1;
    }
}