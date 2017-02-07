namespace EntityFramework_prezentacja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_wyswielt = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_usun = new System.Windows.Forms.Button();
            this.btn_modyfikuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_wyswielt
            // 
            resources.ApplyResources(this.btn_wyswielt, "btn_wyswielt");
            this.btn_wyswielt.Name = "btn_wyswielt";
            this.btn_wyswielt.UseVisualStyleBackColor = true;
            this.btn_wyswielt.Click += new System.EventHandler(this.btn_wyswielt_Click);
            // 
            // btn_dodaj
            // 
            resources.ApplyResources(this.btn_dodaj, "btn_dodaj");
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_usun
            // 
            resources.ApplyResources(this.btn_usun, "btn_usun");
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // btn_modyfikuj
            // 
            resources.ApplyResources(this.btn_modyfikuj, "btn_modyfikuj");
            this.btn_modyfikuj.Name = "btn_modyfikuj";
            this.btn_modyfikuj.UseVisualStyleBackColor = true;
            this.btn_modyfikuj.Click += new System.EventHandler(this.btn_modyfikuj_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modyfikuj);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_wyswielt);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_wyswielt;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_modyfikuj;
        private System.Windows.Forms.Label label1;
    }
}

