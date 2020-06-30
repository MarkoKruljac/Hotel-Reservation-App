using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{   
    public partial class DnevniPlan : Form
    {
        
        public DnevniPlan()
        {
            InitializeComponent();

            
        }

        private void dnevniPlan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void DohvatiDnevniPlanUseljenja()
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upitIseljenja = from r in context.Rezervacija
                                    from vr in context.VrstaRezervacije
                                    from g in context.Gost
                                    from u in context.Usluga
                                    from s in context.Soba
                                    from vS in context.VrstaSobe
                                    from ra in context.Racun
                                    where s.ID_soba == r.ID_sobe && r.ID_vrste_rezervacije == vr.ID_vrsta_rezervacije
                                    && r.ID_gosta == g.ID_gost && r.ID_usluge == u.ID_usluga
                                    && s.ID_vrste_sobe == vS.ID_vrsta_sobe && r.Datum_pocetka.Day == DateTime.Now.Day && r.Datum_pocetka.Month == DateTime.Now.Month &&
                                    r.Datum_pocetka.Year == DateTime.Now.Year 
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
                dgvIseljenjeDnevniPlan.DataSource = upitIseljenja.ToList();




            }
        }

        private void DohvatiDnevniPlanIseljenja()
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upitIseljenja = from r in context.Rezervacija
                           from vr in context.VrstaRezervacije
                           from g in context.Gost
                           from u in context.Usluga
                           from s in context.Soba
                           from vS in context.VrstaSobe
                           from ra in context.Racun
                           where s.ID_soba == r.ID_sobe && r.ID_vrste_rezervacije == vr.ID_vrsta_rezervacije
                           && r.ID_gosta == g.ID_gost && r.ID_usluge == u.ID_usluga
                           && s.ID_vrste_sobe == vS.ID_vrsta_sobe && r.Datum_zavrsetka.Day == DateTime.Now.Day && r.Datum_zavrsetka.Month == DateTime.Now.Month &&
                           r.Datum_zavrsetka.Year == DateTime.Now.Year && ra.ID_rezervacije == r.ID_rezervacija && ra.Placen == true
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
                dgvIseljenjeDnevniPlan.DataSource = upitIseljenja.ToList();
            }
        }
        
        private void DnevniPlan_Load(object sender, EventArgs e)
        {
           
            DohvatiDnevniPlanUseljenja();
            
            DohvatiDnevniPlanIseljenja();
            if (dgvIseljenjeDnevniPlan == null)
            {
                btnObaviIseljenja.Enabled = false;
            }
        }
        public void OsvjeziDnevniPlan()
        {
            DohvatiDnevniPlanUseljenja();
            DohvatiDnevniPlanIseljenja();
            
        }
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziDnevniPlan();
        }

        private void Izbrisi(int id)
        {
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = (from r in context.Rezervacija
                            where r.ID_rezervacija == id
                            select r);
                context.Rezervacija.Attach(upit.FirstOrDefault());
                context.Rezervacija.Remove(upit.FirstOrDefault());
                context.SaveChanges();
            }
        }
        
        private void btnObavljenPlan_Click(object sender, EventArgs e)
        {
        }

        private void btnObaviIseljenja_Click(object sender, EventArgs e)
        {
            if (dgvIseljenjeDnevniPlan.CurrentRow != null) { 
                int IDiseljenja = int.Parse(dgvIseljenjeDnevniPlan.CurrentRow.Cells[0].Value.ToString());
                using (var context = new PI20_021_DBEntities2()) {
                    var upitt = from ra in context.Racun
                                where ra.ID_rezervacije == IDiseljenja
                                select ra;
                    if (upitt.FirstOrDefault() != null) {
                        RezervacijaForm rezervacijaForm = new RezervacijaForm();
                        rezervacijaForm.ObrisiRacun(IDiseljenja);
                        Izbrisi(IDiseljenja);
                        DohvatiDnevniPlanIseljenja();
                    }
                    else
                    {
                        Izbrisi(IDiseljenja);
                        DohvatiDnevniPlanIseljenja();
                    }
                }
                
                
            }
            else
            {
                btnObaviIseljenja.Enabled = false;
            }
            
        }
   
        public void UnesiRacunUBazu()
        {
            int ID = int.Parse(dnevniPlanUseljenje_dgv.CurrentRow.Cells[0].Value.ToString());
            
            using (var context = new PI20_021_DBEntities2())
            {
                var upitZaDatum = from r in context.Rezervacija
                                  where ID == r.ID_rezervacija
                                  select r.Datum_pocetka;
                DateTime datumPoc = upitZaDatum.FirstOrDefault();
                var upitZaDatumZarsteka = from r in context.Rezervacija
                                  where datumPoc == r.Datum_pocetka && ID==r.ID_rezervacija
                                  select r.Datum_zavrsetka;
                DateTime datumZav = upitZaDatumZarsteka.FirstOrDefault();
                int brojDana = int.Parse((datumZav-datumPoc).TotalDays.ToString());
                var upitZaUslugu = from r in context.Rezervacija  
                                  from u in context.Usluga
                                  where  ID ==r.ID_rezervacija && r.ID_usluge == u.ID_usluga
                                  select u.CijenaUsluge;
                var upitZaCijenuSobe = from r in context.Rezervacija
                                  from s in context.Soba
                                  from vS in context.VrstaSobe
                                  where r.ID_rezervacija == ID && r.ID_sobe == s.ID_soba && s.ID_vrste_sobe == vS.ID_vrsta_sobe
                                  select vS.Cijena;
                var upitZaKauciju = from r in context.Rezervacija
                                  where r.ID_rezervacija == ID
                                  select r.Cijena_rezervacije;
                var upitZaIDrezaervacje = from r in context.Rezervacija
                                          where ID == r.ID_rezervacija
                                          select r.ID_rezervacija;
                var upitZaIDsobe = from r in context.Rezervacija
                                   from s in context.Soba
                                          where ID == r.ID_rezervacija && r.ID_sobe == s.ID_soba
                                          select s.ID_soba;
                Racun racun = new Racun
                {
                    Datum = upitZaDatum.FirstOrDefault(),
                    Ukupan_iznos = (upitZaKauciju.FirstOrDefault() + (upitZaCijenuSobe.FirstOrDefault() * upitZaUslugu.FirstOrDefault() * brojDana)),
                    Nacin_placanja = "Gotovina",
                    Placen = false,
                    ID_rezervacije = upitZaIDrezaervacje.FirstOrDefault(),
                    ID_sobe = upitZaIDsobe.FirstOrDefault()
                };
                
                 context.Racun.Add(racun);
                context.SaveChanges();         
            }
        }
        

        
        private void DohvatiTrenutnoUseljenje()
        {
            int ID = int.Parse(dnevniPlanUseljenje_dgv.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2()) {
                var upit = from r in context.Rezervacija
                           from ra in context.Racun
                           where r.ID_rezervacija == ID && ra.ID_rezervacije == r.ID_rezervacija
                           select r;

                Rezervacija odabranoUseljenje = upit.FirstOrDefault();
                RacunForm racunForm = new RacunForm(odabranoUseljenje);
                
                racunForm.ShowDialog();
            }
        }
        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            
            if(dnevniPlanUseljenje_dgv.CurrentRow != null) { 
            int ID = int.Parse(dnevniPlanUseljenje_dgv.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                var provjera = from ra in context.Racun
                               where ra.ID_rezervacije == ID
                               select ra.ID_rezervacije;
                if(ID != provjera.FirstOrDefault())
                {
                    UnesiRacunUBazu();
                   
                    DohvatiTrenutnoUseljenje();
                }
                else {
                    DohvatiTrenutnoUseljenje();
                }
            }
            }
            else
            {
                MessageBox.Show("Nema dostupnih rezervacija!");
                btnIzdajRacun.Enabled = false;
            }
        }

        
    }
}
