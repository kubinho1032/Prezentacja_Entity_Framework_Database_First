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
    public partial class okno_usuwania : Form
    {
        public okno_usuwania()
        {
            InitializeComponent();
            wyswietlDane();
        }

        private void wyswietlDane()
        {
            using (var data = new Entities())
            {
                var samochody = from s in data.SAMOCHODY
                                select new
                                {
                                    samochod_id = s.ID_SAMOCHOD,
                                    samochod_marka = s.MARKA,
                                    samochod_rocznik = s.ROK_PRODUKCJI
                                };

                dataGridView1.DataSource = samochody.ToList();
            }

        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            using (var samochody = new Entities())
            {
                Decimal id = 0;
                bool czy_odczytano = true;

                try {
                    id = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                catch(Exception ez)
                {
                    MessageBox.Show("Błąd odczytywania wybranego samochodu z grida");
                    czy_odczytano = false;
                }

                if (czy_odczytano == true) {
                    try {
                        SAMOCHODY s1 = (SAMOCHODY)samochody.SAMOCHODY.Where(s => s.ID_SAMOCHOD == id).First();
                        samochody.SAMOCHODY.Remove(s1);
                        samochody.SaveChanges();
                        wyswietlDane();
                        MessageBox.Show("Usunięto");
                    }
                    catch(Exception ezz)
                    {
                        MessageBox.Show("Błąd usuwania");
                    }
                }
            }
        }
    }
}
