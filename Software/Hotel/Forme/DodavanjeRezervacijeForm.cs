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
    public partial class DodavanjeRezervacijeForm : Form
    {
        public DodavanjeRezervacijeForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustaniDR_Click(object sender, EventArgs e)
        {
            this.Close();

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
            cbUsluga.DataSource = usluge;
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
            cbVrstaRez.DataSource = vrstaRezervacija;
        }

        public void PopuniBrojSobe()
        {
            List<int> brSoba = new List<int>() { };
            List<int> zauzeteSobe = new List<int>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from s in context.Soba
                           select s.ID_soba;
                brSoba = upit.ToList();

                var upit2 = from r in context.Rezervacija
                            select r.ID_sobe;
                zauzeteSobe = upit2.ToList();
                for (int i = 0; i < zauzeteSobe.Count; i++)
                {
                    for (int j = 0; j < brSoba.Count; j++)
                    {
                        if (brSoba[j] == zauzeteSobe[i])
                        {
                            brSoba.Remove(brSoba[j]);
                        }
                    }

                }
                brSoba.Distinct();
            }
            if(brSoba.Count ==0)
            {
                
                this.Close();
                
            }
            else
            {
                cbBrojSobe.DataSource = brSoba;
            }
            


        }


        private void btnIzvrsi_Click(object sender, EventArgs e)
        {

            using (var context = new PI20_021_DBEntities2())
            {
                try
                {
                    DateTime datePoc;
                    DateTime dateZav;

                    datePoc = DateTime.Parse(tbDatumPoc.Text);
                    dateZav = DateTime.Parse(tbDatumZav.Text);

                    int cijena = int.Parse(tbCijenaRez.Text);
                    string ImeGosta = tbImeGosta.Text;

                    string PrezimeGosta = tbPrezimeGosta.Text;

                    var gost = from g in context.Gost
                               where g.Ime == tbImeGosta.Text && g.Prezime == tbPrezimeGosta.Text
                               select g.ID_gost;

                    var usluga = from u in context.Usluga
                                 where u.NazivUsluge == cbUsluga.SelectedItem.ToString()
                                 select u.ID_usluga;
                    var vrstaReze = from vR in context.VrstaRezervacije
                                    where vR.NazivVrsteRezeravcije == cbVrstaRez.SelectedItem.ToString()
                                    select vR.ID_vrsta_rezervacije;

                    int broj = int.Parse(cbBrojSobe.SelectedItem.ToString());
                    var upitZaSlobodneSobe = 
                                             from r in context.Rezervacija
                                             where r.ID_sobe == broj
                                             select r;

                    if (upitZaSlobodneSobe.FirstOrDefault() != null)
                    {
                        MessageBox.Show("Zauzeta soba!");
                        
                    }
                    else
                    {
                        Rezervacija rezervacija = new Rezervacija
                        {
                            Datum_pocetka = datePoc,
                            Datum_zavrsetka = dateZav,
                            Cijena_rezervacije = cijena,
                            ID_gosta = gost.FirstOrDefault(),
                            ID_vrste_rezervacije = vrstaReze.FirstOrDefault(),
                            ID_usluge = usluga.FirstOrDefault(),
                            ID_sobe = broj,
                            PoslanEmail = false,
                            ID_hotela = frmPrijava.IDhotela
                        };
                        context.Rezervacija.Add(rezervacija);

                        context.SaveChanges();
                        MessageBox.Show("Uspješno ste unjeli rezervaciju");
                        btnIzvrsi.Enabled = false;
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Neispravni podaci!");
                }
            }

                
            
            
        }

        private void DodavanjeRezervacijeForm_Load(object sender, EventArgs e)
        {
            
            PopuniUsluge();
            PopuniVrstuRezervacije();
            PopuniBrojSobe();
            


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbBrojSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(cbBrojSobe.SelectedItem.ToString());
            using( var context = new PI20_021_DBEntities2())
            {
                var upit = from s in context.Soba
                           from vS in context.VrstaSobe

                           where s.ID_soba == ID && s.ID_vrste_sobe == vS.ID_vrsta_sobe
                           select vS.Cijena;
                double cijenaSobe = upit.FirstOrDefault();
                tbCijenaSobe.Text = cijenaSobe.ToString();
            }
            
        }
        
        private void tbDatumPoc_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tbDatumZav_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
