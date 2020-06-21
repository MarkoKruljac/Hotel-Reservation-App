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
            cbDodajHotelDobavljaca.DataSource = hotelDobavljaca;
        }

        private void DodavanjeDobavljacaForm_Load(object sender, EventArgs e)
        {
            PopuniHotelDobavljaca();
        }

        private void btbDodajDobavljaca_Click(object sender, EventArgs e)
        {
            using (var context = new PI20_021_DBEntities2())
            {

                string nazivDobavljaca = tbDodajNazivDobavljaca.Text;

                string adresaDobavljaca = tbDodajAdresuDobavljaca.Text;

                DateTime datumPocetkaUgovora = DateTime.Parse(tbDodajDatumPocDobavljaca.Text);

                DateTime datumIstekaUgovora = DateTime.Parse(tbDodajDatumIstekaDobavljaca.Text);

                string telefonDobavljaca = tbDodajTelefonDobavljaca.Text;

                string emailDobavljaca = tbDodajEmailDobaljaca.Text;

                string ziroRacun = tbDodajZiroRacDobavljaca.Text;

                string ugovorSaHotelom = cbDodajHotelDobavljaca.SelectedItem.ToString();

                

                var hotelDobavljacaupit = from h in context.Hotel
                                         where h.Ime == cbDodajHotelDobavljaca.SelectedItem.ToString()
                                         select h;

                int idHotelaDobavljaca = hotelDobavljacaupit.FirstOrDefault().ID_hotel;




                Dobavljac dobavljac = new Dobavljac
                {
                    Naziv = nazivDobavljaca,
                    Adresa = adresaDobavljaca,
                    Datum_pocetka_ugovora = datumPocetkaUgovora,
                    Datum_isteka_ugovora = datumIstekaUgovora,
                    Telefon = telefonDobavljaca,
                    Email = emailDobavljaca,
                    Broj_ziro_racuna = ziroRacun,
                    ID_hotela = idHotelaDobavljaca
                     
                };
                context.Dobavljac.Add(dobavljac);
                context.SaveChanges();
                MessageBox.Show("Uspješno ste dodali novog dobavljaca!");
            }
        }
    }
}
