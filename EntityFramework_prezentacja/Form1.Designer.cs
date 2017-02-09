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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_zmien = new System.Windows.Forms.Button();
            this.tbox_password = new System.Windows.Forms.TextBox();
            this.tbox_username = new System.Windows.Forms.TextBox();
            this.tbox_data_source = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbutton_zmien_db = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_zmien);
            this.groupBox1.Controls.Add(this.tbox_password);
            this.groupBox1.Controls.Add(this.tbox_username);
            this.groupBox1.Controls.Add(this.tbox_data_source);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn_zmien
            // 
            resources.ApplyResources(this.btn_zmien, "btn_zmien");
            this.btn_zmien.Name = "btn_zmien";
            this.btn_zmien.UseVisualStyleBackColor = true;
            this.btn_zmien.Click += new System.EventHandler(this.btn_zmien_Click);
            // 
            // tbox_password
            // 
            resources.ApplyResources(this.tbox_password, "tbox_password");
            this.tbox_password.Name = "tbox_password";
            // 
            // tbox_username
            // 
            resources.ApplyResources(this.tbox_username, "tbox_username");
            this.tbox_username.Name = "tbox_username";
            // 
            // tbox_data_source
            // 
            resources.ApplyResources(this.tbox_data_source, "tbox_data_source");
            this.tbox_data_source.Name = "tbox_data_source";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rbutton_zmien_db
            // 
            resources.ApplyResources(this.rbutton_zmien_db, "rbutton_zmien_db");
            this.rbutton_zmien_db.Name = "rbutton_zmien_db";
            this.rbutton_zmien_db.TabStop = true;
            this.rbutton_zmien_db.UseVisualStyleBackColor = true;
            this.rbutton_zmien_db.CheckedChanged += new System.EventHandler(this.rbutton_zmien_db_CheckedChanged);
            this.rbutton_zmien_db.Click += new System.EventHandler(this.rbutton_zmien_db_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbutton_zmien_db);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modyfikuj);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_wyswielt);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_wyswielt;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_modyfikuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_password;
        private System.Windows.Forms.TextBox tbox_username;
        private System.Windows.Forms.TextBox tbox_data_source;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbutton_zmien_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_zmien;
    }
}

