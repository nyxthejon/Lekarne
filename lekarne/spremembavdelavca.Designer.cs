namespace lekarne
{
    partial class spremembavdelavca
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
            this.prevtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevbutton = new System.Windows.Forms.Button();
            this.prevpanel = new System.Windows.Forms.Panel();
            this.dodpanel = new System.Windows.Forms.Panel();
            this.doddelbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lekarnecombo = new System.Windows.Forms.ComboBox();
            this.nazajbutton = new System.Windows.Forms.Button();
            this.prevpanel.SuspendLayout();
            this.dodpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // prevtext
            // 
            this.prevtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevtext.Location = new System.Drawing.Point(20, 94);
            this.prevtext.Name = "prevtext";
            this.prevtext.Size = new System.Drawing.Size(367, 29);
            this.prevtext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodajanje delavcev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vnesite skrivno gelso za prevejanje če ste res delavec";
            // 
            // prevbutton
            // 
            this.prevbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevbutton.Location = new System.Drawing.Point(116, 152);
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.Size = new System.Drawing.Size(171, 53);
            this.prevbutton.TabIndex = 3;
            this.prevbutton.Text = "Preveri";
            this.prevbutton.UseVisualStyleBackColor = true;
            this.prevbutton.Click += new System.EventHandler(this.prevbutton_Click);
            // 
            // prevpanel
            // 
            this.prevpanel.Controls.Add(this.label2);
            this.prevpanel.Controls.Add(this.prevbutton);
            this.prevpanel.Controls.Add(this.prevtext);
            this.prevpanel.Location = new System.Drawing.Point(95, 118);
            this.prevpanel.Name = "prevpanel";
            this.prevpanel.Size = new System.Drawing.Size(409, 244);
            this.prevpanel.TabIndex = 4;
            // 
            // dodpanel
            // 
            this.dodpanel.Controls.Add(this.doddelbutton);
            this.dodpanel.Controls.Add(this.label3);
            this.dodpanel.Controls.Add(this.lekarnecombo);
            this.dodpanel.Location = new System.Drawing.Point(95, 115);
            this.dodpanel.Name = "dodpanel";
            this.dodpanel.Size = new System.Drawing.Size(409, 244);
            this.dodpanel.TabIndex = 5;
            // 
            // doddelbutton
            // 
            this.doddelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doddelbutton.Location = new System.Drawing.Point(50, 142);
            this.doddelbutton.Name = "doddelbutton";
            this.doddelbutton.Size = new System.Drawing.Size(316, 48);
            this.doddelbutton.TabIndex = 2;
            this.doddelbutton.Text = "Dodaj";
            this.doddelbutton.UseVisualStyleBackColor = true;
            this.doddelbutton.Click += new System.EventHandler(this.doddelbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Izberite v kateri lekarni opravljate delo";
            // 
            // lekarnecombo
            // 
            this.lekarnecombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lekarnecombo.FormattingEnabled = true;
            this.lekarnecombo.Location = new System.Drawing.Point(50, 75);
            this.lekarnecombo.Name = "lekarnecombo";
            this.lekarnecombo.Size = new System.Drawing.Size(316, 32);
            this.lekarnecombo.TabIndex = 0;
            // 
            // nazajbutton
            // 
            this.nazajbutton.Location = new System.Drawing.Point(12, 560);
            this.nazajbutton.Name = "nazajbutton";
            this.nazajbutton.Size = new System.Drawing.Size(152, 58);
            this.nazajbutton.TabIndex = 6;
            this.nazajbutton.Text = "Nazaj";
            this.nazajbutton.UseVisualStyleBackColor = true;
            this.nazajbutton.Click += new System.EventHandler(this.nazajbutton_Click);
            // 
            // spremembavdelavca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 630);
            this.Controls.Add(this.nazajbutton);
            this.Controls.Add(this.dodpanel);
            this.Controls.Add(this.prevpanel);
            this.Controls.Add(this.label1);
            this.Name = "spremembavdelavca";
            this.Text = "spremembavdelavca";
            this.prevpanel.ResumeLayout(false);
            this.prevpanel.PerformLayout();
            this.dodpanel.ResumeLayout(false);
            this.dodpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prevtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prevbutton;
        private System.Windows.Forms.Panel prevpanel;
        private System.Windows.Forms.Panel dodpanel;
        private System.Windows.Forms.Button doddelbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lekarnecombo;
        private System.Windows.Forms.Button nazajbutton;
    }
}