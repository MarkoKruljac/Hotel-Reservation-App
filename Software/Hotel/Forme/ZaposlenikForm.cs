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
    public partial class ZaposlenikForm : Form
    {
        public ZaposlenikForm()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DohvatiZaposlenike()
        {
            using (var context = new PI20_021_DBEntities2())
            {
                string imeAdmina = frmPrijava.imeZaposlenika;
                string prezimeAdmina = frmPrijava.prezimeZaposlenika;
                int IDhotel = frmPrijava.IDhotela;
                var hotelAdmina = from k in context.Korisnik
                                  where IDhotel == k.ID_hotela
                                  select k.ID_hotela;

                int IDhotela = int.Parse(hotelAdmina.FirstOrDefault().ToString());

                var upit = from k in context.Korisnik
                           from vk in context.VrstaKorisnika
                           from ss in context.StrucnaSprema
                           from h in context.Hotel
                           where k.ID_vrste_korisnika == vk.ID_vrsta_korisnika && k.ID_strucne_spreme == ss.ID_strucna_sprema
                           && k.ID_hotela == h.ID_hotel && IDhotela == k.ID_hotela
                           select new
                           {
                               ID = k.ID_korisnik,
                               Ime = k.Ime,
                               Prezime = k.Prezime,
                               DatumZaposlenja = k.Datum_zaposlenja,
                               Email = k.Email,
                               OIB = k.OIB,
                               Adresa = k.Adresa,
                               Telefon = k.Telefon,
                               KorisnickoIme = k.Korisnicko_ime,
                               Lozinka = k.Lozinka,
                               VrstaKorisnika = vk.Naziv,
                               StrucnaSprema = ss.Naziv,
                           };

                dgvZaposlenici.DataSource = upit.ToList();
            }
        }

        private void DohvatiZaposlenikePoPrezimenu(string prezime)
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upit = from k in context.Korisnik
                           from vk in context.VrstaKorisnika
                           from ss in context.StrucnaSprema
                           from h in context.Hotel
                           where k.ID_vrste_korisnika == vk.ID_vrsta_korisnika && k.ID_strucne_spreme == ss.ID_strucna_sprema
                           && k.ID_hotela == h.ID_hotel && k.Prezime.Contains(prezime)
                           select new
                           {
                               ID = k.ID_korisnik,
                               Ime = k.Ime,
                               Prezime = k.Prezime,
                               DatumZaposlenja = k.Datum_zaposlenja,
                               Email = k.Email,
                               OIB = k.OIB,
                               Adresa = k.Adresa,
                               Telefon = k.Telefon,
                               KorisnickoIme = k.Korisnicko_ime,
                               Lozinka = k.Lozinka,
                               VrstaKorisnika = vk.Naziv,
                               StrucnaSprema = ss.Naziv,
                           };

                dgvZaposlenici.DataSource = upit.ToList();
            }
        }
        private void ZaposlenikForm_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenike();
        }

        private void btnOsvjeziZaposlenike_Click(object sender, EventArgs e)
        {
            DohvatiZaposlenike();
        }

        private void tbPretragaPoPrezimenu_TextChanged(object sender, EventArgs e)
        {
            string prezimeZaposlenika = tbPretragaPoPrezimenu.Text;
            DohvatiZaposlenikePoPrezimenu(prezimeZaposlenika);
        }

        private void btnDodajZaposlenike_Click_1(object sender, EventArgs e)
        {
            DodavanjeZaposlenika dodavanjeZaposlenika = new DodavanjeZaposlenika();
            dodavanjeZaposlenika.ShowDialog();
            this.Hide();
        }

        private void btnIzmijeniZaposlenika_Click_1(object sender, EventArgs e)
        {
            if(dgvZaposlenici.CurrentRow == null)
            {
                MessageBox.Show("Nema vise dostupnih zaposlenika!");
                btnIzbrisiZaposlenika.Enabled = false;
                btnIzmijeniZaposlenika.Enabled = false;
            }
            else { 
            int ID = int.Parse(dgvZaposlenici.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from k in context.Korisnik
                           where k.ID_korisnik == ID
                           select k;
                Korisnik odabraniKorisnik = upit.FirstOrDefault();
                IzmjenaZaposlenikaForm izmjenaZaposlenika = new IzmjenaZaposlenikaForm(odabraniKorisnik);
                izmjenaZaposlenika.ShowDialog();

            }
            }
        }

        private void btnIzbrisiZaposlenika_Click_1(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow == null)
            {
                MessageBox.Show("Nema vise dostupnih zaposlenika!");
                btnIzbrisiZaposlenika.Enabled = false;
                btnIzmijeniZaposlenika.Enabled = false;
            }
            else { 
            int ID = int.Parse(dgvZaposlenici.CurrentRow.Cells[0].Value.ToString());

            using (var context = new PI20_021_DBEntities2())
            {
                var upit = (from k in context.Korisnik
                            where k.ID_korisnik == ID
                            select k);
                context.Korisnik.Attach(upit.FirstOrDefault());
                context.Korisnik.Remove(upit.FirstOrDefault());
                context.SaveChanges();
            }
            DohvatiZaposlenike();
            }
        }
    }
}
