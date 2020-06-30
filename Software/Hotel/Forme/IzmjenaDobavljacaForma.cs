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
    public partial class IzmjenaDobavljacaForma : Form
    {
        Dobavljac odabraniDobavljac;
        public IzmjenaDobavljacaForma(Dobavljac dobavljac)
        {
            InitializeComponent();
            odabraniDobavljac = dobavljac;
        }
        
        
        private void PopuniTextBoxeve()
        {
            using (var context = new PI20_021_DBEntities2())
            {
                tbIzmjeniNazivDobavljaca.Text = odabraniDobavljac.Naziv.ToString();
                tbIzmjeniAdresuDobavljaca.Text = odabraniDobavljac.Adresa.ToString();
                tbIzmjeniDatumPocDobavljaca.Text = odabraniDobavljac.Datum_pocetka_ugovora.ToString("yyyy-MM-dd");
                tbIzmjeniDatumIstekaDobavljaca.Text = odabraniDobavljac.Datum_isteka_ugovora.ToString("yyyy-MM-dd");
                tbIzmjeniTelefonDobavljaca.Text = odabraniDobavljac.Telefon.ToString();
                tbIzmjeniEmailDobaljaca.Text = odabraniDobavljac.Email.ToString();
                tbIzmjeniZiroRacDobavljaca.Text = odabraniDobavljac.Broj_ziro_racuna.ToString();


                


                
            }
        }
        private void Azuriraj()
        {
            
            using (var context = new PI20_021_DBEntities2())
            {
                int ID = int.Parse(odabraniDobavljac.ID_dobavljac.ToString());
                string nazivDobavljaca = tbIzmjeniNazivDobavljaca.Text.ToString();
                string adresaDobavljaca = tbIzmjeniAdresuDobavljaca.Text.ToString();
                DateTime datumPocetkaUgovora = DateTime.Parse(tbIzmjeniDatumPocDobavljaca.Text);
                DateTime datumIstekaUgovora = DateTime.Parse(tbIzmjeniDatumIstekaDobavljaca.Text);
                string ziroRacun = tbIzmjeniZiroRacDobavljaca.Text;
                string telefon = tbIzmjeniTelefonDobavljaca.Text.ToString();
                string email = tbIzmjeniEmailDobaljaca.Text.ToString();
                
                
                var upit2 = from d in context.Dobavljac
                            where d.ID_dobavljac == ID
                            select d;
                
                if (upit2.FirstOrDefault() != null)
                {
                    foreach (var item in upit2)
                    {
                        item.Naziv = nazivDobavljaca;
                        item.Adresa = adresaDobavljaca;
                        item.Datum_pocetka_ugovora = datumPocetkaUgovora;
                        item.Datum_isteka_ugovora = datumIstekaUgovora;
                        item.Broj_ziro_racuna = ziroRacun;
                        item.Telefon = telefon;
                        item.Email = email;
                        


                    }

                    context.SaveChanges();

                    MessageBox.Show("Uspješno ste izmjenili podatke o gostu");
                }
                btbIzmjeniDobavljaca.Enabled = false;
            }
        }

        private void IzmjenaDobavljacaForma_Load(object sender, EventArgs e)
        {
            
            PopuniTextBoxeve();
        }

        private void btbIzmjeniDobavljaca_Click(object sender, EventArgs e)
        {
            Azuriraj();
        }
    }
}
