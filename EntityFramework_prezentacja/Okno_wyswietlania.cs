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
    public partial class Okno_wyswietlania : Form
    {
        public Okno_wyswietlania()
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

                if (cbox_wybor.SelectedIndex != -1)
                {
                    if (!cbox_wybor.SelectedItem.Equals("All"))
                    {
                        samochody = samochody.Where(s => s.samochod_marka == cbox_wybor.SelectedItem);                       
                   }
                    
                }

                dataGridView1.DataSource = samochody.ToList();
            }

            
        }

        private void Okno_wyswietlania_Load(object sender, EventArgs e)
        {
            using (var data = new Entities())
            {
                var samochody = from s in data.SAMOCHODY select s.MARKA;
                cbox_wybor.Items.AddRange(samochody.ToArray());
                cbox_wybor.SelectedIndex = -1;
            }
        }

        private void btn_wyswietl_Click(object sender, EventArgs e)
        {
            wyswietlDane();
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
