namespace lekarne
{
    partial class updateuporanbik
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
            this.telefontext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.imetext = new System.Windows.Forms.TextBox();
            this.krajtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailtext
            // 
            this.emailtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtext.Location = new System.Drawing.Point(192, 108);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(388, 29);
            this.emailtext.TabIndex = 0;
            // 
            // telefontext
            // 
            this.telefontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefontext.Location = new System.Drawing.Point(192, 228);
            this.telefontext.Name = "telefontext";
            this.telefontext.Size = new System.Drawing.Size(388, 29);
            this.telefontext.TabIndex = 1;
            this.telefontext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passtext
            // 
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(192, 168);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(388, 29);
            this.passtext.TabIndex = 2;
            // 
            // imetext
            // 
            this.imetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imetext.Location = new System.Drawing.Point(192, 347);
            this.imetext.Name = "imetext";
            this.imetext.Size = new System.Drawing.Size(388, 29);
            this.imetext.TabIndex = 3;
            // 
            // krajtext
            // 
            this.krajtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krajtext.Location = new System.Drawing.Point(192, 284);
            this.krajtext.Name = "krajtext";
            this.krajtext.Size = new System.Drawing.Size(388, 29);
            this.krajtext.TabIndex = 4;
            // 
            // updateuporanbik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 781);
            this.Controls.Add(this.krajtext);
            this.Controls.Add(this.imetext);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.telefontext);
            this.Controls.Add(this.emailtext);
            this.Name = "updateuporanbik";
            this.Text = "update uporabnik";
            this.Load += new System.EventHandler(this.updateuporanbik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox telefontext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox imetext;
        private System.Windows.Forms.TextBox krajtext;
    }
}