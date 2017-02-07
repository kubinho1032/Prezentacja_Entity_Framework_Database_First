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
    public partial class okno_modyfikacja : Form
    {
        object wybrany_samochod;
        SAMOCHODY s_do_aktualizacji;

        public okno_modyfikacja()
        {
            InitializeComponent();
        }

        private void wyswietlDane()
        {
            using (var data = new Entities())
            {
                var samochody = from s in data.SAMOCHODY select s.MARKA;
                cbox_wybor.Items.AddRange(samochody.ToArray());
                cbox_wybor.SelectedIndex = -1;
            }
        }

        private void okno_modyfikacja_Load(object sender, EventArgs e)
        {
            wyswietlDane();
        }

        private void cbox_wybor_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(cbox_wybor.SelectedIndex != -1)
            {
                wybrany_samochod = cbox_wybor.SelectedItem;

                using (var samochody = new Entities())
                {
                    s_do_aktualizacji = (SAMOCHODY)samochody.SAMOCHODY.Where(x => x.MARKA == wybrany_samochod).First();

                    tbox_id.Text = s_do_aktualizacji.ID_SAMOCHOD.ToString();
                    tbox_marka.Text = s_do_aktualizacji.MARKA;
                    tbox_rocznik.Text = s_do_aktualizacji.ROK_PRODUKCJI.ToString();
                }
            }
        }

        private void btn_akutalizuj_Click(object sender, EventArgs e)
        {
            bool poprawne_dane = true;

           if(tbox_id!=null && tbox_marka!=null && tbox_rocznik!= null)
            {
                try { 
                s_do_aktualizacji.ID_SAMOCHOD = Convert.ToDecimal(tbox_id.Text);
                s_do_aktualizacji.MARKA = tbox_marka.Text;
                s_do_aktualizacji.ROK_PRODUKCJI = Convert.ToDecimal(tbox_rocznik.Text);
                }
                catch(Exception ez)
                {
                    MessageBox.Show("Błędne dane");
                    poprawne_dane = false;
                }

                if (poprawne_dane == true)
                {
                    using (var data = new Entities())
                    {
                        try { 
                        data.Entry(s_do_aktualizacji).State = System.Data.Entity.EntityState.Modified;
                        data.SaveChanges();
                            MessageBox.Show("Zaktualizowano");
                            tbox_id.Clear();
                            tbox_marka.Clear();
                            tbox_rocznik.Clear();
                            cbox_wybor.SelectedIndex = -1;
                        }
                        catch(Exception ezz)
                        {
                            MessageBox.Show("Błąd aktualizacji");
                        }
                    }
                }
                             
            }
 
        }
    }
}
