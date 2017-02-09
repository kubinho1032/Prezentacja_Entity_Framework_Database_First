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
    public partial class Okno_dodawania : Form
    {
        public Okno_dodawania()
        {
            InitializeComponent();
            zmien_baze();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            bool poprawne_dane = true;
            

            if(tbox_id!=null && tbox_marka!=null && tbox_rok_produkcji != null)
            {
                using (var samochody = new Entities())
                {
                    try { 
                     var samochod = new SAMOCHODY { ID_SAMOCHOD = Convert.ToDecimal(tbox_id.Text), MARKA=tbox_marka.Text, ROK_PRODUKCJI = Convert.ToDecimal(tbox_rok_produkcji.Text) };
                     samochody.SAMOCHODY.Add(samochod);
                        samochody.SaveChanges();
                        MessageBox.Show("Dodano");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Błędne dane");
                        tbox_rok_produkcji.Clear();
                        tbox_marka.Clear();
                        tbox_id.Clear();
                        poprawne_dane = false;
                    }                
                    
                }
            }
            
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zmien_baze()
        {
           

            using (var samochody = new Entities(db_helper.change_db()))
            {
                SAMOCHODY s1 = (SAMOCHODY)samochody.SAMOCHODY.Where(x => x.MARKA == "Nissan").First();
                MessageBox.Show(s1.MARKA);
            }
          }
        }
    }

