using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forme
{
    public partial class DodavanjeDobavljacaForm : Form
    {
        public DodavanjeDobavljacaForm()
        {
            InitializeComponent();
        }
       
        private void DodavanjeDobavljacaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btbDodajDobavljaca_Click(object sender, EventArgs e)
        {
            using (var context = new PI20_021_DBEntities2())
            {
                try { 
                string nazivDobavljaca = tbDodajNazivDobavljaca.Text;

                string adresaDobavljaca = tbDodajAdresuDobavljaca.Text;

                DateTime datumPocetkaUgovora = DateTime.Parse(tbDodajDatumPocDobavljaca.Text);

                DateTime datumIstekaUgovora = DateTime.Parse(tbDodajDatumIstekaDobavljaca.Text);

                string telefonDobavljaca = tbDodajTelefonDobavljaca.Text;

                string emailDobavljaca = tbDodajEmailDobaljaca.Text;

                string ziroRacun = tbDodajZiroRacDobavljaca.Text;

                

                

                

                




                Dobavljac dobavljac = new Dobavljac
                {
                    Naziv = nazivDobavljaca,
                    Adresa = adresaDobavljaca,
                    Datum_pocetka_ugovora = datumPocetkaUgovora,
                    Datum_isteka_ugovora = datumIstekaUgovora,
                    Telefon = telefonDobavljaca,
                    Email = emailDobavljaca,
                    Broj_ziro_racuna = ziroRacun,
                    ID_hotela = frmPrijava.IDhotela
                     
                };
                 
                context.Dobavljac.Add(dobavljac);
                context.SaveChanges();
                MessageBox.Show("Uspješno ste dodali novog dobavljaca!");
                }
                catch
                {
                    MessageBox.Show("Neispravni podaci!");
                }
            }
        }
    }
}
