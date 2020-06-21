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
    public partial class DodavanjeZaposlenika : Form
    {
        public DodavanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cbDodajVrstuZaposlenika.DataSource = vrstaZaposlenika;
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
            cbDodajStrucnuSpremuZaposlenika.DataSource = strucnaSprema;
        }

        public void PopuniHotel()
        {
            List<string> hotel = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from h in context.Hotel
                           select h.Ime;
                hotel = upit.ToList();
            }
            cbDodajHotelZaposleniku.DataSource = hotel;
        }

        private void DodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            PopuniVrstuZaposlenika();
            PopuniStrucnuSpremu();
            PopuniHotel();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            
                using (var context = new PI20_021_DBEntities2())
                {

                    string imeZaposlenika = tbDodajImeZaposlenika.Text;

                    string prezimeZaposlenika = tbDodajPrezimeZaposleniku.Text;

                    DateTime datumZaposlenja = DateTime.Parse(tbDodajDatumZaposlenja.Text);

                    string emailZaposlenika = tbDodajEmailZaposleniku.Text;

                    string OIBZaposlenika = tbDodajOIBZaposleniku.Text;

                    string adresaZaposlenika = tbDodajAdresuZaposlenika.Text;

                    string telefonZaposlenika = tbDodajTelefonZaposleniku.Text;

                    string korisnickoImeZaposlenika = tbDodajKorisnickoImeZaposlenika.Text;

                    string lozinkaZaposlenika = tbDodajLozinkuZaposleniku.Text;

                    var vrstaKorisnikaupit = from vk in context.VrstaKorisnika
                                    where vk.Naziv == cbDodajVrstuZaposlenika.SelectedItem.ToString()
                                    select vk;

                    int IDvrste = vrstaKorisnikaupit.FirstOrDefault().ID_vrsta_korisnika;

                    var strucnaSpremaupit = from ss in context.StrucnaSprema
                                    where ss.Naziv == cbDodajStrucnuSpremuZaposlenika.SelectedItem.ToString()
                                    select ss;

                    int IDspreme = strucnaSpremaupit.FirstOrDefault().ID_strucna_sprema;

                    var hotelZaposlenikaUpit = from h in context.Hotel
                                            where h.Ime == cbDodajHotelZaposleniku.SelectedItem.ToString()
                                            select h;

                    int IDhotela = hotelZaposlenikaUpit.FirstOrDefault().ID_hotel;


                    Korisnik korisnik = new Korisnik
                    {
                        Ime = imeZaposlenika,
                        Prezime = prezimeZaposlenika,
                        Datum_zaposlenja = datumZaposlenja,
                        Email = emailZaposlenika,
                        OIB = OIBZaposlenika,
                        Adresa = adresaZaposlenika,
                        Telefon = telefonZaposlenika,
                        Korisnicko_ime = korisnickoImeZaposlenika,
                        Lozinka = lozinkaZaposlenika,
                        ID_vrste_korisnika = IDvrste,
                        ID_strucne_spreme = IDspreme,
                        ID_hotela = IDhotela
                    };
                        context.Korisnik.Add(korisnik);
                        context.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali novog zaposlenika!");
                }
            
        }
    }
}
