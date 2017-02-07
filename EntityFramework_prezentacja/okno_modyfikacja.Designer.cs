namespace EntityFramework_prezentacja
{
    partial class okno_modyfikacja
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
            this.btn_akutalizuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_marka = new System.Windows.Forms.TextBox();
            this.tbox_rocznik = new System.Windows.Forms.TextBox();
            this.cbox_wybor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_akutalizuj
            // 
            this.btn_akutalizuj.Location = new System.Drawing.Point(188, 213);
            this.btn_akutalizuj.Name = "btn_akutalizuj";
            this.btn_akutalizuj.Size = new System.Drawing.Size(92, 36);
            this.btn_akutalizuj.TabIndex = 0;
            this.btn_akutalizuj.Text = "Aktualizuj";
            this.btn_akutalizuj.UseVisualStyleBackColor = true;
            this.btn_akutalizuj.Click += new System.EventHandler(this.btn_akutalizuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualizuj wybrany samochód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id samochodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rok produkcji";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tbox_rocznik);
            this.groupBox1.Controls.Add(this.tbox_marka);
            this.groupBox1.Controls.Add(this.tbox_id);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(141, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(33, 9);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(121, 20);
            this.tbox_id.TabIndex = 0;
            // 
            // tbox_marka
            // 
            this.tbox_marka.Location = new System.Drawing.Point(33, 41);
            this.tbox_marka.Name = "tbox_marka";
            this.tbox_marka.Size = new System.Drawing.Size(121, 20);
            this.tbox_marka.TabIndex = 1;
            // 
            // tbox_rocznik
            // 
            this.tbox_rocznik.Location = new System.Drawing.Point(33, 77);
            this.tbox_rocznik.Name = "tbox_rocznik";
            this.tbox_rocznik.Size = new System.Drawing.Size(121, 20);
            this.tbox_rocznik.TabIndex = 2;
            // 
            // cbox_wybor
            // 
            this.cbox_wybor.FormattingEnabled = true;
            this.cbox_wybor.Location = new System.Drawing.Point(174, 52);
            this.cbox_wybor.Name = "cbox_wybor";
            this.cbox_wybor.Size = new System.Drawing.Size(121, 21);
            this.cbox_wybor.TabIndex = 6;
            this.cbox_wybor.SelectedIndexChanged += new System.EventHandler(this.cbox_wybor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Samochód do edycji:";
            // 
            // okno_modyfikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox_wybor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_akutalizuj);
            this.Name = "okno_modyfikacja";
            this.Text = "Aktualizuj samochód";
            this.Load += new System.EventHandler(this.okno_modyfikacja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_akutalizuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_rocznik;
        private System.Windows.Forms.TextBox tbox_marka;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.ComboBox cbox_wybor;
        private System.Windows.Forms.Label label5;
    }
}