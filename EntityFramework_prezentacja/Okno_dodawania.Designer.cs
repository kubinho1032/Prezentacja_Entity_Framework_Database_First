namespace EntityFramework_prezentacja
{
    partial class Okno_dodawania
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
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_marka = new System.Windows.Forms.TextBox();
            this.tbox_rok_produkcji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(188, 179);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(91, 37);
            this.btn_dodaj.TabIndex = 0;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj nowy samochód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rok produkcji";
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(257, 57);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(100, 20);
            this.tbox_id.TabIndex = 5;
            // 
            // tbox_marka
            // 
            this.tbox_marka.Location = new System.Drawing.Point(257, 93);
            this.tbox_marka.Name = "tbox_marka";
            this.tbox_marka.Size = new System.Drawing.Size(100, 20);
            this.tbox_marka.TabIndex = 6;
            // 
            // tbox_rok_produkcji
            // 
            this.tbox_rok_produkcji.Location = new System.Drawing.Point(257, 127);
            this.tbox_rok_produkcji.Name = "tbox_rok_produkcji";
            this.tbox_rok_produkcji.Size = new System.Drawing.Size(100, 20);
            this.tbox_rok_produkcji.TabIndex = 7;
            // 
            // Okno_dodawania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.tbox_rok_produkcji);
            this.Controls.Add(this.tbox_marka);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dodaj);
            this.Name = "Okno_dodawania";
            this.Text = "Dodawanie samochodu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.TextBox tbox_marka;
        private System.Windows.Forms.TextBox tbox_rok_produkcji;
    }
}