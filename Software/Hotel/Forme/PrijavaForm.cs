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
        
        public static string imeZaposlenika;
        public static string prezimeZaposlenika;
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

                var emailGostaUpit = from g in context.Gost
                                     from r in context.Rezervacija
                                     where DateTime.Compare(r.Datum_pocetka, danasnjiDatum) == 1 && (r.PoslanEmail == false || r.PoslanEmail == null) && g.ID_gost == r.ID_gosta
                                     select g;

                


                foreach (var item in emailGostaUpit)
                
                    {
                            var upitZaRezervacije = from r in context.Rezervacija
                                                    from g in context.Gost
                                                    where (r.PoslanEmail == false || r.PoslanEmail == null)
                                                    select r;
                            foreach (var item2 in upitZaRezervacije)
                            {
                                item2.PoslanEmail = true;
                            }
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
                context.SaveChanges();
                MessageBox.Show("Mailovi su  poslani!");
                 
            }

        }
        private void prijavi_btn_Click(object sender, EventArgs e)
        {

            
            imetextbox.Focus();
            if (string.IsNullOrEmpty(imetextbox.Text))
            {
                MessageBox.Show("Unesite korisnicko ime");
                
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
                            imeZaposlenika = upitZaZaposlenika.FirstOrDefault().Ime;
                            prezimeZaposlenika = upitZaZaposlenika.FirstOrDefault().Prezime;
                            Admin = false;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);

                            MessageBox.Show("Uspjesno ste prijavljeni kao zaposlenik");

                            SaljiEmail();
                            this.Hide();
                            glavnaForma.ShowDialog();
                            

                        }
                        
                        else

                        {
                            MessageBox.Show("Unešeni podaci nisu ispravni");
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
                            imeZaposlenika = upitZaAdministratora.FirstOrDefault().Ime;
                            prezimeZaposlenika = upitZaAdministratora.FirstOrDefault().Prezime;
                            Admin = true;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);
                            
                            MessageBox.Show("Uspjesno ste prijavljeni kao adminstrator");
                            SaljiEmail();
                            this.Hide();
                            
                            glavnaForma.ShowDialog();
                            

                        }
                        
                        
                        else
                        {
                               
                            MessageBox.Show("Uneseni podaci nisu ispravni/Nemate administratorska prava");
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
