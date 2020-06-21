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
    public partial class IzmjenarezervacijeForm : Form
    {
        private Rezervacija odabranaRezervacija;
        public IzmjenarezervacijeForm(Rezervacija rezervacija)
        {
            InitializeComponent();
            odabranaRezervacija = rezervacija;
        }
        public void PopuniUsluge()
        {
            List<string> usluge = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from u in context.Usluga
                           select u.NazivUsluge;
                usluge = upit.ToList();
            }
            cbIzmjenaUsluga.DataSource = usluge;
        }
        public void PopuniVrstuRezervacije()
        {
            List<string> vrstaRezervacija = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from vR in context.VrstaRezervacije
                           select vR.NazivVrsteRezeravcije;
                vrstaRezervacija = upit.ToList();
            }
            cbIzmjenaVR.DataSource = vrstaRezervacija;
        }

        
        public void PopuniBrojSobe()
        {
            List<int> brSoba1 = new List<int>() { };
            List<int> zauzeteSobe = new List<int>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from s in context.Soba
                           select s.ID_soba;
                brSoba1 = upit.ToList();

                var upit2 = from r in context.Rezervacija
                            select r.ID_sobe;

                zauzeteSobe = upit2.ToList();
                for (int i = 0; i < zauzeteSobe.Count; i++)
                {
                    for (int j = 0; j < brSoba1.Count; j++)
                    {
                        if (brSoba1[j] == zauzeteSobe[i])
                        {
                            brSoba1.Remove(brSoba1[j]);
                        }
                    }
                    
                }
                brSoba1.Distinct();
            }
            cbIzmjenaBrojSobe.DataSource = brSoba1;
            

        }
        private void PopuniTextBoxeve()
        {
            using (var context = new PI20_021_DBEntities2()) { 
            tbIzmjenaDP.Text = odabranaRezervacija.Datum_pocetka.ToString("yyyy-MM-dd");
            tbIzmjenaDZ.Text = odabranaRezervacija.Datum_zavrsetka.ToString("yyyy-MM-dd");
            tbIzmjenaCijena.Text = odabranaRezervacija.Cijena_rezervacije.ToString();
                var upitZaIme = from r in context.Rezervacija
                                from g in context.Gost
                                where odabranaRezervacija.ID_gosta == g.ID_gost
                                select g.Ime;
                tbIzmjenaIme.Text = upitZaIme.FirstOrDefault();
                var upitZaPrezime = from r in context.Rezervacija
                                from g in context.Gost
                                where odabranaRezervacija.ID_gosta == g.ID_gost
                                select g.Prezime;
                tbIzmjenaPrezime.Text = upitZaPrezime.FirstOrDefault();
                var upitZaVrstuRez = from r in context.Rezervacija
                                     from vR in context.VrstaRezervacije
                                     where odabranaRezervacija.ID_vrste_rezervacije == vR.ID_vrsta_rezervacije
                                     select vR.NazivVrsteRezeravcije;
                cbIzmjenaVR.Text = upitZaVrstuRez.FirstOrDefault();
                
                var upitZaUslugu = from r in context.Rezervacija
                                   from u in context.Usluga
                                   where odabranaRezervacija.ID_usluge == u.ID_usluga
                                   select u.NazivUsluge;
                cbIzmjenaUsluga.Text = upitZaUslugu.FirstOrDefault();
                var upitZaBrojSobe = from r in context.Rezervacija
                                     from s in context.Soba
                                     where r.ID_sobe == s.ID_soba
                                     select s.ID_soba;
                cbIzmjenaBrojSobe.Text = upitZaBrojSobe.FirstOrDefault().ToString();
             
            }
        }
        private void Azuriraj()
        {
            
            using(var context = new PI20_021_DBEntities2()) {
              
            int ID = int.Parse(odabranaRezervacija.ID_rezervacija.ToString());
            DateTime datumPocetka = DateTime.Parse(tbIzmjenaDP.Text);
            DateTime datumZavrsetka =DateTime.Parse(tbIzmjenaDZ.Text);
            double cijena = int.Parse(tbIzmjenaCijena.Text);
            string imeGosta = tbIzmjenaIme.Text;
            string prezimeGosta = tbIzmjenaPrezime.Text;
            string vrstaRezervacije = cbIzmjenaVR.SelectedItem.ToString();
            string usluga = cbIzmjenaUsluga.SelectedItem.ToString();
            int brojSobe = int.Parse(cbIzmjenaBrojSobe.SelectedItem.ToString());
            double cijenaSobe = int.Parse(tbIzmjenaCijenaSobe.Text);
                try { 
                var upit = from r in context.Rezervacija
                           where r.ID_rezervacija == ID
                           select r;

                    var upit2 = from g in context.Gost
                                where g.Ime == imeGosta && g.Prezime == prezimeGosta 
                                select g.ID_gost;

                var upit3 = from vR in context.VrstaRezervacije
                            where vR.NazivVrsteRezeravcije == vrstaRezervacije
                            select vR;
                int idVrsteRezervacije = upit3.FirstOrDefault().ID_vrsta_rezervacije;

                

                var upit5 = from u in context.Usluga
                            where u.NazivUsluge == usluga
                            select u;
                int idUsluge = upit5.FirstOrDefault().ID_usluga;

             if(upit.FirstOrDefault() != null) { 
                foreach (var item in upit)
                {
                        item.Datum_pocetka = datumPocetka;
                        item.Datum_zavrsetka = datumZavrsetka;
                        item.Cijena_rezervacije = cijena;
                        item.ID_gosta = upit2.FirstOrDefault();
                        item.ID_vrste_rezervacije = idVrsteRezervacije;
                        
                        item.ID_usluge = idUsluge;
                        item.ID_sobe = brojSobe;
                }
                    context.SaveChanges();
                    MessageBox.Show("Uspjesno ste izmjenili odabranu rezervaciju");
                }
                }
                catch
                {
                    MessageBox.Show("Nepostojeci gost!!");
                }
            }
        }
        private void IzmjenarezervacijeForm_Load(object sender, EventArgs e)
        {
            PopuniUsluge();
            PopuniVrstuRezervacije();
            PopuniTextBoxeve();
            PopuniBrojSobe();
        }

        private void btnIzvrsiIzmjenu_Click(object sender, EventArgs e)
        {
            Azuriraj();
        }

        private void cbIzmjenaBrojSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(cbIzmjenaBrojSobe.SelectedItem.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from s in context.Soba
                           from vS in context.VrstaSobe

                           where s.ID_soba == ID && s.ID_vrste_sobe == vS.ID_vrsta_sobe
                           select vS.Cijena;
                double cijenaSobe = upit.FirstOrDefault();
                tbIzmjenaCijenaSobe.Text = cijenaSobe.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbIzmjenaPrezime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
