using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_prezentacja
{
    public partial class Form1 : Form
    {
        bool isChecked = false;
        public static String data_source = "localhost:1521/testowa";
        public static String username = "system";
        public static String password = "admin1";



        public Form1()
        {
            InitializeComponent();
        
        }

        private void btn_wyswielt_Click(object sender, EventArgs e)
        {
            Okno_wyswietlania okno_wyswietl = new Okno_wyswietlania();
            okno_wyswietl.Location = this.Location;
            okno_wyswietl.Show();
            okno_wyswietl.FormClosing += okno_wyswietl_closing;
            this.Hide();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            Okno_dodawania okno_dodaj = new Okno_dodawania();
            okno_dodaj.Location = this.Location;
            okno_dodaj.Show();
            okno_dodaj.FormClosing += okno_dodaj_closing;
            this.Hide();
        }

        private void okno_wyswietl_closing (object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void okno_dodaj_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            okno_usuwania okno_usuwania = new okno_usuwania();
            okno_usuwania.Location = this.Location;
            okno_usuwania.Show();
            okno_usuwania.FormClosing += okno_usuwania_closing;
        }

        private void okno_usuwania_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btn_modyfikuj_Click(object sender, EventArgs e)
        {
            okno_modyfikacja okno_modyfikacji = new okno_modyfikacja();
            okno_modyfikacji.Show();
            okno_modyfikacji.FormClosing += okno_modyfikacji_closing;
            this.Hide();
        }

        private void okno_modyfikacji_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void rbutton_zmien_db_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbutton_zmien_db.Checked;

            if (rbutton_zmien_db.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            if (rbutton_zmien_db.Checked == false)
            {
                groupBox1.Enabled = false;
            }
        }

        private void btn_zmien_Click(object sender, EventArgs e)
        {
            Form1.data_source = tbox_data_source.Text;
            Form1.username = tbox_username.Text;
            Form1.password = tbox_password.Text;

            bool czy_polaczono = check_db();
            if (czy_polaczono == false)
            {
                btn_dodaj.Enabled = false;
                btn_modyfikuj.Enabled = false;
                btn_usun.Enabled = false;
                btn_wyswielt.Enabled = false;
            }
            else
            {
                btn_dodaj.Enabled = true;
                btn_modyfikuj.Enabled = true;
                btn_usun.Enabled = true;
                btn_wyswielt.Enabled = true;
            }

        }

        private void rbutton_zmien_db_Click(object sender, EventArgs e)
        {
            if (rbutton_zmien_db.Checked && !isChecked)
                rbutton_zmien_db.Checked = false;
            else
            {
                rbutton_zmien_db.Checked = true;
                isChecked = false;
            }
        }

        private bool check_db()
        {
            bool conn;
            using (var data = new Entities(db_helper.change_db(Form1.data_source, Form1.username, Form1.password)))
            {
                conn = data.Database.Exists();
                if (conn == true)
                {
                    MessageBox.Show("Połączono z bazą danych");
                }
                else
                {
                    MessageBox.Show("Brak połączenia, sprawdź bazę danych");
                }
            }
            return conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bool czy_polaczono = check_db();
            if (czy_polaczono == false)
            {
                btn_dodaj.Enabled = false;
                btn_modyfikuj.Enabled = false;
                btn_usun.Enabled = false;
                btn_wyswielt.Enabled = false;
            }
            else
            {
                btn_dodaj.Enabled = true;
                btn_modyfikuj.Enabled = true;
                btn_usun.Enabled = true;
                btn_wyswielt.Enabled = true;
            }
        }
    }
}
