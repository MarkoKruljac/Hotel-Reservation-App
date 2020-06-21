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
    public partial class IzmjenaZaposlenikaForm : Form
    {
        private Korisnik odabraniZaposlenik;

        public IzmjenaZaposlenikaForm(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniZaposlenik = korisnik;
        }

        public void PopuniVrstuZaposlenika()
        {
            List<string> vrstaZaposlenika = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from vk in context.VrstaKorisnika
                           select vk.Naziv;
                vrstaZaposlenika = upit.ToList();
            }
            vrstaZaposlenika.Distinct();
            cbIzmijeniVrstuZaposlenika.DataSource = vrstaZaposlenika;
        }

        public void PopuniStrucnuSpremu()
        {
            List<string> strucnaSprema = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from ss in context.StrucnaSprema
                           select ss.Naziv;
                strucnaSprema = upit.ToList();
            }
            cbIzmijeniStrucnuSpremuZaposlenika.DataSource = strucnaSprema;
        }

        public void PupuniHotelZaposlenika()
        {
            List<string> hotel = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from h in context.Hotel
                           select h.Ime;
                hotel = upit.ToList();
            }
            cbIzmijeniHotelZaposleniku.DataSource = hotel;
        }

        private void IzmjenaZaposlenika_Load(object sender, EventArgs e)
        {
            PopuniStrucnuSpremu();
            PopuniVrstuZaposlenika();
            PupuniHotelZaposlenika();
            PopuniTextBoxeve();
        }

        private void PopuniTextBoxeve()
        {
            using (var context = new PI20_021_DBEntities2())
            {
                tbIzmijeniImeZaposlenika.Text = odabraniZaposlenik.Ime.ToString();
                tbIzmijeniPrezimeZaposleniku.Text = odabraniZaposlenik.Prezime.ToString();
                tbIzmijeniDatumZaposlenja.Text = odabraniZaposlenik.Datum_zaposlenja.ToString("yyyy-MM-dd");
                tbIzmijeniEmailZaposleniku.Text = odabraniZaposlenik.Email.ToString();
                tbIzmijeniOIBZaposleniku.Text = odabraniZaposlenik.OIB.ToString();
                tbIzmijeniAdresuZaposlenika.Text = odabraniZaposlenik.Adresa.ToString();
                tbIzmijeniTelefonZaposleniku.Text = odabraniZaposlenik.Telefon.ToString();
                tbIzmijeniKorisnickoImeZaposlenika.Text = odabraniZaposlenik.Korisnicko_ime.ToString();
                tbIzmijeniLozinkuZaposleniku.Text = odabraniZaposlenik.Lozinka.ToString();

                var upitVrstaKorisnika = from k in context.Korisnik
                                         from vk in context.VrstaKorisnika
                                         where odabraniZaposlenik.ID_vrste_korisnika ==vk.ID_vrsta_korisnika
                                         select vk.Naziv;
                cbIzmijeniVrstuZaposlenika.Text = upitVrstaKorisnika.FirstOrDefault();


                var upitStrucnaSpremaKorisnika = from k in context.Korisnik
                                                 from ss in context.StrucnaSprema
                                                 where odabraniZaposlenik.ID_strucne_spreme == ss.ID_strucna_sprema 
                                                 select ss.Naziv;
                cbIzmijeniStrucnuSpremuZaposlenika.Text = upitStrucnaSpremaKorisnika.FirstOrDefault();


                var upitHotelKorisnika = from k in context.Korisnik
                                         from h in context.Hotel
                                         where odabraniZaposlenik.ID_hotela == h.ID_hotel
                                         select k.Ime;
                cbIzmijeniHotelZaposleniku.Text = upitHotelKorisnika.FirstOrDefault();
            }
        }

        private void Azuriraj()
        {
            using(var context = new PI20_021_DBEntities2()) {
              
                int ID = int.Parse(odabraniZaposlenik.ID_korisnik.ToString());

                string imeZaposlenika = tbIzmijeniImeZaposlenika.Text;
                string prezimeZaposlenika = tbIzmijeniPrezimeZaposleniku.Text;
                DateTime datumZaposlenjaZaposlenika = DateTime.Parse(tbIzmijeniDatumZaposlenja.Text);
                string emailZaposlenika = tbIzmijeniEmailZaposleniku.Text;
                string oibZaposlenika = tbIzmijeniOIBZaposleniku.Text;
                string adresaZaposlenika = tbIzmijeniAdresuZaposlenika.Text;
                string telefonZaposlenika = tbIzmijeniTelefonZaposleniku.Text;
                string korisnickoImeZaposlenika = tbIzmijeniKorisnickoImeZaposlenika.Text;
                string lozinkaZaposlenika = tbIzmijeniLozinkuZaposleniku.Text;
                string vrstaZaposlenika = cbIzmijeniVrstuZaposlenika.SelectedItem.ToString();
                string strucnaSpremaZaposlenika = cbIzmijeniStrucnuSpremuZaposlenika.SelectedItem.ToString(); ;
                string hotelZaposlenika = cbIzmijeniHotelZaposleniku.SelectedItem.ToString(); 

                try 
                { 
                    var upit = from k in context.Korisnik
                           where k.ID_korisnik == ID
                           select k;

                    var upit2 = from vk in context.VrstaKorisnika
                                where vk.Naziv == vrstaZaposlenika 
                                select vk.ID_vrsta_korisnika;

                    var upit3 = from ss in context.StrucnaSprema
                            where ss.Naziv == strucnaSpremaZaposlenika
                            select ss.ID_strucna_sprema;

                    var upit4 = from h in context.Hotel
                            where h.Ime == hotelZaposlenika
                            select h.ID_hotel;

                    if(upit.FirstOrDefault() != null)
                    { 
                        foreach (var item in upit)
                        {
                            item.Ime = imeZaposlenika;
                            item.Prezime = prezimeZaposlenika;
                            item.Datum_zaposlenja = datumZaposlenjaZaposlenika;
                            item.Email = emailZaposlenika;
                            item.OIB = oibZaposlenika;
                            item.Adresa = adresaZaposlenika;
                            item.Telefon = telefonZaposlenika;
                            item.Korisnicko_ime = korisnickoImeZaposlenika;
                            item.Lozinka = lozinkaZaposlenika;
                            item.ID_vrste_korisnika = upit2.FirstOrDefault();
                            item.ID_strucne_spreme = upit3.FirstOrDefault();
                            item.ID_hotela = upit4.FirstOrDefault();
                        }
                        context.SaveChanges();
                        MessageBox.Show("Uspješno ste izmjenili odabranog korisnika!");
                    }
                }
                catch
                {
                    MessageBox.Show("Nepostojeći Korisnik!");
                }
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            Azuriraj();
        }
    }
}
