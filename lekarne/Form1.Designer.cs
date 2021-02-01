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
            this.pributton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imelek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oglej = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ogledprofilabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pributton
            // 
            this.pributton.Cursor = System.Windows.Forms.Cursors.Default;
            this.pributton.Location = new System.Drawing.Point(820, 30);
            this.pributton.Name = "pributton";
            this.pributton.Size = new System.Drawing.Size(163, 49);
            this.pributton.TabIndex = 1;
            this.pributton.Text = "Prijava";
            this.pributton.UseVisualStyleBackColor = true;
            this.pributton.Click += new System.EventHandler(this.pributton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(58, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 493);
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
            // ogledprofilabutton
            // 
            this.ogledprofilabutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ogledprofilabutton.Location = new System.Drawing.Point(820, 30);
            this.ogledprofilabutton.Name = "ogledprofilabutton";
            this.ogledprofilabutton.Size = new System.Drawing.Size(163, 49);
            this.ogledprofilabutton.TabIndex = 3;
            this.ogledprofilabutton.Text = "Oglej si profil";
            this.ogledprofilabutton.UseVisualStyleBackColor = true;
            this.ogledprofilabutton.Click += new System.EventHandler(this.ogledprofilabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 580);
            this.Controls.Add(this.ogledprofilabutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pributton);
            this.Name = "Form1";
            this.Text = "Pregled lekarn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pributton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imelek;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraj;
        private System.Windows.Forms.DataGridViewButtonColumn oglej;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button ogledprofilabutton;
    }
}

