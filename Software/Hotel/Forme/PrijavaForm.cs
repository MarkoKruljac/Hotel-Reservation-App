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
    
    public partial class frmPrijava : Form
    {
        public static string emailZaposlenika;
        public static string lozinkaZaposlenika;
        public static string imeZaposlenika;
        public static string prezimeZaposlenika;
        public static int IDprijavljenog;
        public static int IDhotela;
        public int brojac;
        public frmPrijava()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SaljiEmail()
        {

            using (var context = new PI20_021_DBEntities2())
            {

                DateTime danasnjiDatum = DateTime.Now;



                var upitEmailZaposlenika = from k in context.Korisnik
                                           where k.Korisnicko_ime == imetextbox.Text
                                           select k.Email;

                var upitPasswordEmailZaposlenika = from k in context.Korisnik
                                                   where k.Lozinka == tbLozinka.Text
                                                   select k.Lozinka;
                var upitZaPoslanEmail = from r in context.Rezervacija
                                        where r.PoslanEmail == false
                                        select r.ID_gosta;

                var emailGostaUpit = from g in context.Gost
                                     from r in context.Rezervacija
                                     where DateTime.Compare(r.Datum_pocetka, danasnjiDatum) == 1 && (r.PoslanEmail == false || r.PoslanEmail == null) && g.ID_gost == r.ID_gosta
                                     && g.Email.Contains("@gmail.com")
                                     select g;

                


                foreach (var item in emailGostaUpit)
                
                    {
                            var upitZaRezervacije = from r in context.Rezervacija
                                                    from g in context.Gost
                                                    where (r.PoslanEmail == false || r.PoslanEmail == null) && r.ID_gosta == emailGostaUpit.FirstOrDefault().ID_gost 
                                                    && DateTime.Compare(r.Datum_pocetka, danasnjiDatum) == 1
                                                    select r;
                    foreach (var item2 in upitZaRezervacije)
                    {
                        item2.PoslanEmail = true;
                    }
                            
                            try
                            {
                                string emailGosta = item.Email;

                                string emailZaposlenika = upitEmailZaposlenika.FirstOrDefault();
                                string passWordZaposlenika = upitPasswordEmailZaposlenika.FirstOrDefault();
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
                                mailDetails.Subject = "Automatski podsjetnik za rezervacije";
                                mailDetails.IsBodyHtml = true;
                                mailDetails.Body = "Sutra imate zakazanu rezervaciju";
                                clientDetails.Send(mailDetails);
                               
                             }
                            catch
                            {
                                continue;
                            }
                    
                        

                        


                }
                context.SaveChanges();
                 
            }

        }
        private void prijavi_btn_Click(object sender, EventArgs e)
        {

            
            imetextbox.Focus();
            if (string.IsNullOrEmpty(imetextbox.Text))
            {
                lblError.Text = "Unesite korisnicko ime"; //novo
                
                return;
            }
            else
            {
                using (var context = new PI20_021_DBEntities2())
                {
                    
                    bool Admin;
                    if (zaposlenik_rbtn.Checked == true)
                    {
                        

                        var upitZaZaposlenika = from k in context.Korisnik
                                                join vk in context.VrstaKorisnika
                                                on k.ID_vrste_korisnika equals vk.ID_vrsta_korisnika
                                                where k.Korisnicko_ime == imetextbox.Text && k.Lozinka == tbLozinka.Text && vk.Naziv == zaposlenik_rbtn.Text
                                                select k;
                        if (upitZaZaposlenika.FirstOrDefault() != null)
                        {
                            emailZaposlenika = upitZaZaposlenika.FirstOrDefault().Email;
                            lozinkaZaposlenika = upitZaZaposlenika.FirstOrDefault().Lozinka;
                            imeZaposlenika = upitZaZaposlenika.FirstOrDefault().Ime;
                            prezimeZaposlenika = upitZaZaposlenika.FirstOrDefault().Prezime;
                            IDhotela = upitZaZaposlenika.FirstOrDefault().ID_hotela;
                            Admin = false;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);


                            SaljiEmail();
                            this.Hide();
                            glavnaForma.ShowDialog();
                            

                        }
                        
                        else

                        {
                            lblError.Text = "Unešeni podaci nisu ispravni"; //novo
                        }
                    }
                    if (administrator_rbtn.Checked == true)
                    {

                        var upitZaAdministratora = from k in context.Korisnik
                                                   join vk in context.VrstaKorisnika
                                                   on k.ID_vrste_korisnika equals vk.ID_vrsta_korisnika
                                                   where k.Korisnicko_ime == imetextbox.Text && k.Lozinka == tbLozinka.Text && vk.Naziv == administrator_rbtn.Text
                                                   select k;
                        if (upitZaAdministratora.FirstOrDefault() != null)
                        {
                            emailZaposlenika = upitZaAdministratora.FirstOrDefault().Email;
                            lozinkaZaposlenika = upitZaAdministratora.FirstOrDefault().Lozinka;
                            imeZaposlenika = upitZaAdministratora.FirstOrDefault().Ime;
                            prezimeZaposlenika = upitZaAdministratora.FirstOrDefault().Prezime;
                            IDprijavljenog = upitZaAdministratora.FirstOrDefault().ID_korisnik;
                            IDhotela = upitZaAdministratora.FirstOrDefault().ID_hotela;
                            Admin = true;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);
                            
                            SaljiEmail();
                            this.Hide();
                            
                            glavnaForma.ShowDialog();
                            

                        }
                        
                        
                        else
                        {
                               
                            lblError.Text = "Uneseni podaci nisu ispravni/Nemate administratorska prava";   //novo
                        }
                    }

                }
            }
        }

        private void odustani_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijavagroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {
            tbLozinka.PasswordChar = '*';
            
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
