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
        public void PopuniHotelDobavljaca()
        {
            List<string> hotelDobavljaca = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from h in context.Hotel
                           select h.Ime;
                hotelDobavljaca = upit.ToList();
            }
            hotelDobavljaca.Distinct();
            cbIzmjeniHotelDobavljaca.DataSource = hotelDobavljaca;
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


                var upitHotelDobavljaca = from d in context.Dobavljac
                                         from h in context.Hotel
                                         where odabraniDobavljac.ID_hotela == h.ID_hotel
                                         select h.Ime;
                cbIzmjeniHotelDobavljaca.Text = upitHotelDobavljaca.FirstOrDefault();


                
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
                string ugovorSaHotelom = cbIzmjeniHotelDobavljaca.SelectedItem.ToString();
                var upit = from h in context.Hotel
                           where h.Ime == ugovorSaHotelom
                           select h;
                var upit2 = from d in context.Dobavljac
                            where d.ID_dobavljac == ID
                            select d;
                int id = upit.FirstOrDefault().ID_hotel;
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
                        item.ID_hotela = id;


                    }

                    context.SaveChanges();

                    MessageBox.Show("Uspješno ste izmjenili podatke o gostu");
                }
                btbIzmjeniDobavljaca.Enabled = false;
            }
        }

        private void IzmjenaDobavljacaForma_Load(object sender, EventArgs e)
        {
            PopuniHotelDobavljaca();
            PopuniTextBoxeve();
        }

        private void btbIzmjeniDobavljaca_Click(object sender, EventArgs e)
        {
            Azuriraj();
        }
    }
}
