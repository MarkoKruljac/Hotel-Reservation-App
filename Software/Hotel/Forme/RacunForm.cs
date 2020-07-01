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
    
    public partial class RacunForm : Form
    {
        public static readonly List<int> listaIndeksa = new List<int>();
        Rezervacija odabranoUseljenje;
        public RacunForm(Rezervacija rezervacija)
        {
            InitializeComponent();
            odabranoUseljenje = rezervacija;
        }
        private void PopuniRacun()
        {
            frmPrijava frmPrijava = new frmPrijava();
            string imeZaposlenika = frmPrijava.imeZaposlenika;
            string prezimeZaposlenika = frmPrijava.prezimeZaposlenika;
            
            int iDrezervacije = odabranoUseljenje.ID_rezervacija;
            using (var context = new PI20_021_DBEntities2())
            {
                var upitIDracuna = from ra in context.Racun
                                   where ra.ID_rezervacije == iDrezervacije
                                   select ra.ID_racun;

                var upitImeGosta = from ra in context.Racun
                                   from r in context.Rezervacija
                                   from g in context.Gost
                                   where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije ==r.ID_rezervacija && r.ID_gosta == g.ID_gost
                                   select g.Ime;

                var upitPrezimeGosta = from ra in context.Racun
                                       from r in context.Rezervacija
                                       from g in context.Gost
                                       where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije==r.ID_rezervacija && r.ID_gosta == g.ID_gost
                                       select g.Prezime;


                var upitCijenaSobe = from ra in context.Racun
                                     from r in context.Rezervacija
                                     from s in context.Soba
                                     from vs in context.VrstaSobe
                                     where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije == r.ID_rezervacija 
                                     && r.ID_sobe == s.ID_soba && s.ID_vrste_sobe == vs.ID_vrsta_sobe
                                     select vs.Cijena;

                var upitBrojSobe = from ra in context.Racun
                                   from s in context.Soba
                                   from r in context.Rezervacija
                                   where r.ID_sobe == s.ID_soba && ra.ID_rezervacije == r.ID_rezervacija && ra.ID_rezervacije == iDrezervacije
                                   select s.ID_soba;

                var upitPocDatum = from ra in context.Racun
                                   from r in context.Rezervacija
                                   where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije == r.ID_rezervacija
                                   select r.Datum_pocetka;

                DateTime datumPoc = upitPocDatum.FirstOrDefault();

                var upitZavDatum = from ra in context.Racun
                                   from r in context.Rezervacija
                                   where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije == r.ID_rezervacija
                                   select r.Datum_zavrsetka;

                DateTime datumZav = upitZavDatum.FirstOrDefault();

                int brojDana = int.Parse((datumZav - datumPoc).TotalDays.ToString());

                var upitKaucije = from r in context.Rezervacija
                                    where r.ID_rezervacija == iDrezervacije
                                    select r.Cijena_rezervacije;


                var upitVrstaUsluge = from ra in context.Racun
                                     from r in context.Rezervacija
                                     from s in context.Soba
                                     from u in context.Usluga
                                     where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije == r.ID_rezervacija
                                     && r.ID_sobe == s.ID_soba && r.ID_usluge == u.ID_usluga
                                     select u.NazivUsluge;

                var upitUKCijena = from ra in context.Racun
                                   from r in context.Rezervacija
                                   where ra.ID_rezervacije == iDrezervacije && ra.ID_rezervacije == r.ID_rezervacija
                                   select ra.Ukupan_iznos;
                

                lbIDracuna.Text = upitIDracuna.FirstOrDefault().ToString();
                lbImeGosta.Text = upitImeGosta.FirstOrDefault();
                lbPrezimeGosta.Text = upitPrezimeGosta.FirstOrDefault();
                lbBrojSobe.Text = upitBrojSobe.FirstOrDefault().ToString();
                lbCijenaSobe.Text = upitCijenaSobe.FirstOrDefault().ToString();
                lbUKDana.Text = brojDana.ToString();
                lbKaucija.Text = upitKaucije.FirstOrDefault().ToString();
                lbVrstaUsluge.Text = upitVrstaUsluge.FirstOrDefault();
                lbUkupanIznos.Text = upitUKCijena.FirstOrDefault().ToString();
                lbImeIzdavaca.Text = imeZaposlenika;
                lbPrezimeIzdavaca.Text = prezimeZaposlenika;
            }
                
        }
        

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void RacunForm_Load(object sender, EventArgs e)
        {
            PopuniRacun();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNaplata_Click(object sender, EventArgs e)
        {
            DnevniPlan dnevniPlan = new DnevniPlan();
            int indekss = DnevniPlan.indeks;
            
            using (var context = new PI20_021_DBEntities2())
            {
                var upitZaNaplatu = from ra in context.Racun
                                    where ra.ID_rezervacije == odabranoUseljenje.ID_rezervacija
                                    select ra;
                foreach (var item in upitZaNaplatu)
                {
                    item.Placen = true;
                    listaIndeksa.Add(indekss);
                }
                context.SaveChanges();
               
            }
            
            dnevniPlan.DohvatiDnevniPlanUseljenja();
            dnevniPlan.OsvjeziDnevniPlan();
            this.Close();
        }
    }
}
