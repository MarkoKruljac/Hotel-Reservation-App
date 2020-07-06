using Hotel.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DobavljačForm : Form
    {
        public DobavljačForm()
        {
            InitializeComponent();
        }
        private void DohvatiDobavljace()
        {
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from d in context.Dobavljac
                           from h in context.Hotel
                           where h.ID_hotel == d.ID_hotela && d.ID_hotela == frmPrijava.IDhotela
                           select new
                           {
                               IdDobavljaca = d.ID_dobavljac,
                               Naziv = d.Naziv,
                               Adresa = d.Adresa,
                               DatumPocetkaUgovora = d.Datum_pocetka_ugovora,
                               DatumIstekaUgovora = d.Datum_isteka_ugovora,
                               Telefon = d.Telefon,
                               Email = d.Email,
                               ZiroRacun = d.Broj_ziro_racuna,
                               UgovorSaHotelom = h.Ime

                           };
                dobavljaci_dtg.DataSource = upit.ToList();
            }
        }
        private void Dobavljači_Load(object sender, EventArgs e)
        {
            DohvatiDobavljace();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zatvori_btn_Click(object sender, EventArgs e)
        {

        }

        private void izbriši_btn_Click(object sender, EventArgs e)
        {
            
            if(dobavljaci_dtg.CurrentRow != null) {
                lblError.Text = "";
            int ID = int.Parse(dobavljaci_dtg.CurrentRow.Cells[0].Value.ToString());

                using (var context = new PI20_021_DBEntities2())
                {
                    var upit = (from d in context.Dobavljac
                                where d.ID_dobavljac == ID
                                select d);
                    context.Dobavljac.Attach(upit.FirstOrDefault());
                    context.Dobavljac.Remove(upit.FirstOrDefault());
                    context.SaveChanges();
                }
              }
            
            else
            {
                lblError.Text = "Nema dostupnih dobavljača!";
                izbriši_btn.Enabled = false;
                izmijeni_btn.Enabled = false;
            }
            DohvatiDobavljace();
        }

        private void izmijeni_btn_Click(object sender, EventArgs e)
        {
            if(dobavljaci_dtg.CurrentRow != null) { 
            int ID = int.Parse(dobavljaci_dtg.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from d in context.Dobavljac
                           where d.ID_dobavljac == ID
                           select d;
                Dobavljac odabraniDobavljac = upit.FirstOrDefault();
                IzmjenaDobavljacaForma izmjenaDobavljacaForma = new IzmjenaDobavljacaForma(odabraniDobavljac);
                izmjenaDobavljacaForma.ShowDialog();
                    lblError.Text = "";
            }
            }
            else
            {
                lblError.Text = "Nema dostupnih dobavljača!";
                izbriši_btn.Enabled = false;
                izmijeni_btn.Enabled = false;
            }
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            DodavanjeDobavljacaForm dodavanjeDobavljacaForm = new DodavanjeDobavljacaForm();
            dodavanjeDobavljacaForm.ShowDialog();
        }

        private void dobavljaci_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOsvjeziDobavljace_Click(object sender, EventArgs e)
        {
            DohvatiDobavljace();
        }
    }
}
