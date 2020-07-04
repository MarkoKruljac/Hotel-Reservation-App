using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Security.AccessControl;

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
                var emailGostaUpit = from g in context.Gost
                                     where g.Ime == lbImeGosta.Text && g.Prezime == lbPrezimeGosta.Text
                                     select g;

                try
                {
                    string emailGosta = emailGostaUpit.FirstOrDefault().Email;
                    string emailZaposlenika = frmPrijava.emailZaposlenika;
                    string passWordZaposlenika = frmPrijava.lozinkaZaposlenika;

                    //MessageBox.Show(emailZaposlenika);
                    //MessageBox.Show(passWordZaposlenika);
                    //MessageBox.Show(emailGosta);
                    SmtpClient clientDetails = new SmtpClient();
                    clientDetails.Port = 587;
                    clientDetails.Host = "smtp.gmail.com";
                    clientDetails.EnableSsl = true;
                    clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                    clientDetails.UseDefaultCredentials = false;
                    clientDetails.Credentials = new NetworkCredential(emailZaposlenika, passWordZaposlenika);

                    //message details

                    MailMessage mailDetails = new MailMessage();
                    mailDetails.From = new MailAddress(emailZaposlenika);
                    mailDetails.To.Add(emailGosta);
                    mailDetails.Subject = $"Vaš račun br. {lbIDracuna.Text}";
                    mailDetails.IsBodyHtml = true;
                    mailDetails.Body = $"Broj računa: {lbIDracuna.Text} <br>  ------------------------------- <br>  Broj odabrane sobe: {lbBrojSobe.Text} <br>  Cijena odabrane sobe: {lbCijenaSobe.Text} <br>   Ukupno dana boravka: {lbUKDana.Text} <br>  Vrsta usluge:" +
                            $" {lbVrstaUsluge.Text} <br> Kaucija: {lbKaucija.Text} <br>  ------------------------------- <br> Ukupan iznos za platiti: {lbUkupanIznos.Text} <br><br>  Zahvaljujemo vam na vašoj posjeti! <br> Dođite nam ponovo!";
                    clientDetails.Send(mailDetails);

                }
                catch
                {

                }

                context.SaveChanges();

            }
            
            dnevniPlan.DohvatiDnevniPlanUseljenja();
            dnevniPlan.OsvjeziDnevniPlan();
            this.Close();
        }
    }
}
