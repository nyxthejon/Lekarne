namespace lekarne
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imelek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglej = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delkraj = new System.Windows.Forms.Button();
            this.updkraj = new System.Windows.Forms.Button();
            this.kimetext = new System.Windows.Forms.TextBox();
            this.kposttext = new System.Windows.Forms.TextBox();
            this.insertkraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(831, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(831, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prijava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imelek,
            this.tellek,
            this.dcas,
            this.nas,
            this.kraj,
            this.oglej,
            this.delete});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(41, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 493);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imelek
            // 
            this.imelek.HeaderText = "Ime Lekarne";
            this.imelek.Name = "imelek";
            // 
            // tellek
            // 
            this.tellek.HeaderText = "Telefon Lekarne";
            this.tellek.Name = "tellek";
            // 
            // dcas
            // 
            this.dcas.HeaderText = "Delovni Čas";
            this.dcas.Name = "dcas";
            // 
            // nas
            // 
            this.nas.HeaderText = "Naslov";
            this.nas.Name = "nas";
            // 
            // kraj
            // 
            this.kraj.HeaderText = "Kraj";
            this.kraj.Name = "kraj";
            // 
            // oglej
            // 
            this.oglej.HeaderText = "Oglej Si Več";
            this.oglej.Name = "oglej";
            this.oglej.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oglej.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            // 
            // delkraj
            // 
            this.delkraj.Location = new System.Drawing.Point(831, 311);
            this.delkraj.Name = "delkraj";
            this.delkraj.Size = new System.Drawing.Size(163, 51);
            this.delkraj.TabIndex = 3;
            this.delkraj.Text = "Izbriši kraj";
            this.delkraj.UseVisualStyleBackColor = true;
            this.delkraj.Visible = false;
            this.delkraj.Click += new System.EventHandler(this.delkraj_Click);
            // 
            // updkraj
            // 
            this.updkraj.Location = new System.Drawing.Point(831, 368);
            this.updkraj.Name = "updkraj";
            this.updkraj.Size = new System.Drawing.Size(163, 51);
            this.updkraj.TabIndex = 4;
            this.updkraj.Text = "Posodobi kraj";
            this.updkraj.UseVisualStyleBackColor = true;
            this.updkraj.Visible = false;
            this.updkraj.Click += new System.EventHandler(this.updkraj_Click);
            // 
            // kimetext
            // 
            this.kimetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kimetext.Location = new System.Drawing.Point(831, 441);
            this.kimetext.Name = "kimetext";
            this.kimetext.Size = new System.Drawing.Size(163, 29);
            this.kimetext.TabIndex = 5;
            this.kimetext.Text = "Vnesi ime kraja";
            this.kimetext.Click += new System.EventHandler(this.kimetext_Click);
            // 
            // kposttext
            // 
            this.kposttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kposttext.Location = new System.Drawing.Point(831, 476);
            this.kposttext.Name = "kposttext";
            this.kposttext.Size = new System.Drawing.Size(163, 29);
            this.kposttext.TabIndex = 6;
            this.kposttext.Text = "Vnesi posto";
            this.kposttext.Click += new System.EventHandler(this.kposttext_Click);
            // 
            // insertkraj
            // 
            this.insertkraj.Location = new System.Drawing.Point(831, 517);
            this.insertkraj.Name = "insertkraj";
            this.insertkraj.Size = new System.Drawing.Size(163, 51);
            this.insertkraj.TabIndex = 7;
            this.insertkraj.Text = "Vnesi kraj";
            this.insertkraj.UseVisualStyleBackColor = true;
            this.insertkraj.Click += new System.EventHandler(this.insertkraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 580);
            this.Controls.Add(this.insertkraj);
            this.Controls.Add(this.kposttext);
            this.Controls.Add(this.kimetext);
            this.Controls.Add(this.updkraj);
            this.Controls.Add(this.delkraj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Vnesi kraj";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imelek;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraj;
        private System.Windows.Forms.DataGridViewButtonColumn oglej;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button delkraj;
        private System.Windows.Forms.Button updkraj;
        private System.Windows.Forms.TextBox kimetext;
        private System.Windows.Forms.TextBox kposttext;
        private System.Windows.Forms.Button insertkraj;
    }
}

