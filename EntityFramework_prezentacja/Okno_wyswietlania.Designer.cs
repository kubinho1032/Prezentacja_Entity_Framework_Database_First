﻿namespace EntityFramework_prezentacja
{
    partial class Okno_wyswietlania
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_wyswietl = new System.Windows.Forms.Button();
            this.cbox_wybor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_wyswietl
            // 
            this.btn_wyswietl.Location = new System.Drawing.Point(130, 208);
            this.btn_wyswietl.Name = "btn_wyswietl";
            this.btn_wyswietl.Size = new System.Drawing.Size(121, 23);
            this.btn_wyswietl.TabIndex = 1;
            this.btn_wyswietl.Text = "Wyświetl wybrane";
            this.btn_wyswietl.UseVisualStyleBackColor = true;
            this.btn_wyswietl.Click += new System.EventHandler(this.btn_wyswietl_Click);
            // 
            // cbox_wybor
            // 
            this.cbox_wybor.FormattingEnabled = true;
            this.cbox_wybor.Items.AddRange(new object[] {
            "All"});
            this.cbox_wybor.Location = new System.Drawing.Point(130, 169);
            this.cbox_wybor.Name = "cbox_wybor";
            this.cbox_wybor.Size = new System.Drawing.Size(121, 21);
            this.cbox_wybor.TabIndex = 2;
            // 
            // Okno_wyswietlania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.cbox_wybor);
            this.Controls.Add(this.btn_wyswietl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Okno_wyswietlania";
            this.Text = "Wyświetlanie samochodów";
            this.Load += new System.EventHandler(this.Okno_wyswietlania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_wyswietl;
        private System.Windows.Forms.ComboBox cbox_wybor;
    }
}