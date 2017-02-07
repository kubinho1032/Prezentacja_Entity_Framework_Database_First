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
    }
}
