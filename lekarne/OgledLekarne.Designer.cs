namespace lekarne
{
    partial class OgledLekarne
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.krajcombo = new System.Windows.Forms.ComboBox();
            this.updatesliko = new System.Windows.Forms.Button();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.nazajbutton = new System.Windows.Forms.Button();
            this.nastext = new System.Windows.Forms.TextBox();
            this.dcastext = new System.Windows.Forms.TextBox();
            this.teltext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imetext = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opistext = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stdelavcev = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delavcidatagrid = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delavcidatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 594);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.krajcombo);
            this.tabPage1.Controls.Add(this.updatesliko);
            this.tabPage1.Controls.Add(this.confirmbutton);
            this.tabPage1.Controls.Add(this.updatebutton);
            this.tabPage1.Controls.Add(this.nazajbutton);
            this.tabPage1.Controls.Add(this.nastext);
            this.tabPage1.Controls.Add(this.dcastext);
            this.tabPage1.Controls.Add(this.teltext);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.imetext);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.opistext);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lekarne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // krajcombo
            // 
            this.krajcombo.Enabled = false;
            this.krajcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krajcombo.FormattingEnabled = true;
            this.krajcombo.Location = new System.Drawing.Point(183, 246);
            this.krajcombo.Name = "krajcombo";
            this.krajcombo.Size = new System.Drawing.Size(355, 32);
            this.krajcombo.TabIndex = 35;
            this.krajcombo.TabStop = false;
            // 
            // updatesliko
            // 
            this.updatesliko.Location = new System.Drawing.Point(613, 329);
            this.updatesliko.Name = "updatesliko";
            this.updatesliko.Size = new System.Drawing.Size(294, 51);
            this.updatesliko.TabIndex = 34;
            this.updatesliko.Text = "Posodobi sliko";
            this.updatesliko.UseVisualStyleBackColor = true;
            this.updatesliko.Click += new System.EventHandler(this.updatesliko_Click_1);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.Location = new System.Drawing.Point(16, 344);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(188, 48);
            this.confirmbutton.TabIndex = 33;
            this.confirmbutton.Text = "Potrdi spremembe";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click_1);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(16, 344);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(188, 48);
            this.updatebutton.TabIndex = 32;
            this.updatebutton.Text = "Spremeni ";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click_1);
            // 
            // nazajbutton
            // 
            this.nazajbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazajbutton.Location = new System.Drawing.Point(16, 512);
            this.nazajbutton.Name = "nazajbutton";
            this.nazajbutton.Size = new System.Drawing.Size(171, 48);
            this.nazajbutton.TabIndex = 31;
            this.nazajbutton.Text = "Nazaj";
            this.nazajbutton.UseVisualStyleBackColor = true;
            this.nazajbutton.Click += new System.EventHandler(this.nazajbutton_Click);
            // 
            // nastext
            // 
            this.nastext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nastext.Location = new System.Drawing.Point(183, 198);
            this.nastext.Name = "nastext";
            this.nastext.ReadOnly = true;
            this.nastext.Size = new System.Drawing.Size(355, 29);
            this.nastext.TabIndex = 30;
            // 
            // dcastext
            // 
            this.dcastext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcastext.Location = new System.Drawing.Point(183, 149);
            this.dcastext.Name = "dcastext";
            this.dcastext.ReadOnly = true;
            this.dcastext.Size = new System.Drawing.Size(355, 29);
            this.dcastext.TabIndex = 29;
            // 
            // teltext
            // 
            this.teltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltext.Location = new System.Drawing.Point(183, 100);
            this.teltext.Name = "teltext";
            this.teltext.ReadOnly = true;
            this.teltext.Size = new System.Drawing.Size(355, 29);
            this.teltext.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Opis slike";
            // 
            // imetext
            // 
            this.imetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imetext.Location = new System.Drawing.Point(183, 45);
            this.imetext.Name = "imetext";
            this.imetext.ReadOnly = true;
            this.imetext.Size = new System.Drawing.Size(355, 29);
            this.imetext.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(564, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 280);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // opistext
            // 
            this.opistext.Location = new System.Drawing.Point(564, 413);
            this.opistext.Name = "opistext";
            this.opistext.ReadOnly = true;
            this.opistext.Size = new System.Drawing.Size(387, 136);
            this.opistext.TabIndex = 24;
            this.opistext.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Delovni Čas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stdelavcev);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.delavcidatagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delavci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stdelavcev
            // 
            this.stdelavcev.AutoSize = true;
            this.stdelavcev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdelavcev.Location = new System.Drawing.Point(860, 21);
            this.stdelavcev.Name = "stdelavcev";
            this.stdelavcev.Size = new System.Drawing.Size(60, 24);
            this.stdelavcev.TabIndex = 2;
            this.stdelavcev.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Število delavcev v lekarni:";
            // 
            // delavcidatagrid
            // 
            this.delavcidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delavcidatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.telefon,
            this.kraj,
            this.email});
            this.delavcidatagrid.Location = new System.Drawing.Point(30, 21);
            this.delavcidatagrid.Name = "delavcidatagrid";
            this.delavcidatagrid.Size = new System.Drawing.Size(543, 521);
            this.delavcidatagrid.TabIndex = 0;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // kraj
            // 
            this.kraj.HeaderText = "Kraj";
            this.kraj.Name = "kraj";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // OgledLekarne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "OgledLekarne";
            this.Text = "v";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delavcidatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox krajcombo;
        private System.Windows.Forms.Button updatesliko;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button nazajbutton;
        private System.Windows.Forms.TextBox nastext;
        private System.Windows.Forms.TextBox dcastext;
        private System.Windows.Forms.TextBox teltext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imetext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox opistext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView delavcidatagrid;
        private System.Windows.Forms.Label stdelavcev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}