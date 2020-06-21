using Hotel.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class RezervacijaForm : Form
    {
        public RezervacijaForm()
        {
            InitializeComponent();
        }

        private void zatvori_btn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
        private void ObrisiRacun(int ID)
        {
            
            using (var context = new PI20_021_DBEntities2())
            {
                var upitZaBrisanjeRacuna = from ra in context.Racun
                                           where ra.ID_rezervacije == ID
                                           select ra;
                context.Racun.Attach(upitZaBrisanjeRacuna.FirstOrDefault());
                context.Racun.Remove(upitZaBrisanjeRacuna.FirstOrDefault());
                context.SaveChanges();
            }

        }
        
        public void ObrisiRezervaciju()
        {
            if (rezervacija_dtg.CurrentRow == null)
            {
                MessageBox.Show("Nema vise dostupnih rezervacija!");
                izbriši_btn.Enabled = false;
                izmijeni_btn.Enabled = false;
            }
            else
            {
                int IDbrisanja = int.Parse(rezervacija_dtg.CurrentRow.Cells[0].Value.ToString());



                using (var context = new PI20_021_DBEntities2())
                {
                    var ProvjeraPostojiLiRacun = from ra in context.Racun
                                                 where IDbrisanja == ra.ID_rezervacije
                                                 select ra;

                    if (ProvjeraPostojiLiRacun.FirstOrDefault() != null)
                    {
                        ObrisiRacun(IDbrisanja);
                    }
                    var upit = (from r in context.Rezervacija
                                where r.ID_rezervacija == IDbrisanja
                                select r);
                    context.Rezervacija.Attach(upit.FirstOrDefault());
                    context.Rezervacija.Remove(upit.FirstOrDefault());
                    context.SaveChanges();
                }
                DohvatiRezervacije();
            }
        }
        private void izbriši_btn_Click(object sender, EventArgs e)
        {

            ObrisiRezervaciju();

        }

        private void izmijeni_btn_Click(object sender, EventArgs e)
        {
            if(rezervacija_dtg.CurrentRow == null)
            {
                MessageBox.Show("Nema dostupnih rezervacija!");
                izmijeni_btn.Enabled = false;
                izbriši_btn.Enabled = false;
            }
            else { 
            int ID = int.Parse(rezervacija_dtg.CurrentRow.Cells[0].Value.ToString());
           
                using (var context = new PI20_021_DBEntities2())
                {
                    var ProvjeraPostojiLiRacun_izmjena = from ra in context.Racun
                                             where ID == ra.ID_rezervacije
                                             select ra;

                    if (ProvjeraPostojiLiRacun_izmjena.FirstOrDefault() != null)
                    {
                        ObrisiRacun(ID);
                    }

                var upit = from r in context.Rezervacija
                            where r.ID_rezervacija == ID
                            select r;
                    Rezervacija odabranaRezervacija = upit.FirstOrDefault();
                    IzmjenarezervacijeForm izmjenarezervacijeForm= new IzmjenarezervacijeForm(odabranaRezervacija);
                    izmjenarezervacijeForm.ShowDialog();

                }

            }
        }
        
        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            DodavanjeRezervacijeForm dodavanjeRezervacijeForm = new DodavanjeRezervacijeForm();
            dodavanjeRezervacijeForm.ShowDialog();
            this.Hide();
            
        }

        private void rezervacija_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DohvatiRezervacije()
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upit = from r in context.Rezervacija
                           from vr in context.VrstaRezervacije
                           
                           from g in context.Gost
                           from u in context.Usluga
                           from s in context.Soba
                           from vS in context.VrstaSobe
                           where s.ID_soba==r.ID_sobe && r.ID_vrste_rezervacije == vr.ID_vrsta_rezervacije 
                           
                           && r.ID_gosta == g.ID_gost && r.ID_usluge == u.ID_usluga
                           && s.ID_vrste_sobe == vS.ID_vrsta_sobe
                           select new
                           {
                               ID = r.ID_rezervacija,
                               DatumPocetka = r.Datum_pocetka,
                               DatumZavrsetka = r.Datum_zavrsetka,
                               CijenaRezervacije = r.Cijena_rezervacije,
                               NazivVrsteRez = vr.NazivVrsteRezeravcije,
                               ImeGosta = g.Ime,
                               PrezimeGosta = g.Prezime,
                               
                               BrojSobe = s.ID_soba,
                               CijenaSobe = vS.Cijena,
                               VrstaUsluge = u.NazivUsluge

                           };

                rezervacija_dtg.DataSource = upit.ToList();
            }
        }
        private void DohvatiRezervacijePoPrezimenu(string prezime)
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upit = from r in context.Rezervacija
                           from vr in context.VrstaRezervacije
                          
                           from g in context.Gost
                           from u in context.Usluga
                           from s in context.Soba
                           from vS in context.VrstaSobe
                           where s.ID_soba == r.ID_sobe && r.ID_vrste_rezervacije == vr.ID_vrsta_rezervacije
                           
                           && r.ID_gosta == g.ID_gost && r.ID_usluge == u.ID_usluga
                           && s.ID_vrste_sobe == vS.ID_vrsta_sobe && g.Prezime.Contains(prezime)
                           select new
                           {
                               ID = r.ID_rezervacija,
                               DatumPocetka = r.Datum_pocetka,
                               DatumZavrsetka = r.Datum_zavrsetka,
                               CijenaRezervacije = r.Cijena_rezervacije,
                               NazivVrsteRez = vr.NazivVrsteRezeravcije,
                               ImeGosta = g.Ime,
                               PrezimeGosta = g.Prezime,
                               BrojSobe = s.ID_soba,
                               CijenaSobe = vS.Cijena,
                               VrstaUsluge = u.NazivUsluge

                           };

                rezervacija_dtg.DataSource = upit.ToList();
            }
        }
        private void RezervacijaForm_Load(object sender, EventArgs e)
        {
            DohvatiRezervacije();
            if(rezervacija_dtg.CurrentRow == null)
            {
                izbriši_btn.Enabled = false;
                izmijeni_btn.Enabled = false;
            }
        }

        private void btnOsvjeziRezervacije_Click(object sender, EventArgs e)
        {
            DohvatiRezervacije();
        }

        private void tbPretragaPoPrezimenu_TextChanged(object sender, EventArgs e)
        {
            string prezimeGosta = tbPretragaPoPrezimenu.Text;
            DohvatiRezervacijePoPrezimenu(prezimeGosta);
        }
    }
}
