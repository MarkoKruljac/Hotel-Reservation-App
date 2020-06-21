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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

                            Admin = false;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);

                            MessageBox.Show("Uspjesno ste prijavljeni kao zaposlenik");
                            
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
                            Admin = true;
                            GlavnaForma glavnaForma = new GlavnaForma(Admin);

                            MessageBox.Show("Uspjesno ste prijavljeni kao adminstrator");
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
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
