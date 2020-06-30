using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forme
{
    public partial class GostiForma : Form
    {
        public GostiForma()
        {
            InitializeComponent();
        }

        public void DohvatiGoste()
        {
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from g in context.Gost
                           from vG in context.VrstaGosta
                           where g.ID_vrste_gosta == vG.ID_vrsta_gosta
                           select new
                           {
                               ID = g.ID_gost,
                               ImeGosta = g.Ime,
                               PrezimeGosta = g.Prezime,
                               Telefon = g.Telefon,
                               AdresaGosta = g.Adresa,
                               Email = g.Email,
                               VrstaGosta = vG.VrsteGosta

                           };
                dgvGosti.DataSource = upit.ToList();
            }
           
        }
        public void DohvatiGostePoPrezimenu(string prezime)
        {
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from g in context.Gost
                           from vG in context.VrstaGosta
                           where g.ID_vrste_gosta == vG.ID_vrsta_gosta && g.Prezime.Contains(prezime)
                           select new
                           {
                               ID = g.ID_gost,
                               ImeGosta = g.Ime,
                               PrezimeGosta = g.Prezime,
                               Telefon = g.Telefon,
                               AdresaGosta = g.Adresa,
                               Email = g.Email,
                               VrstaGosta = vG.VrsteGosta

                           };
                dgvGosti.DataSource = upit.ToList();
            }

        }
        private void GostiForma_Load(object sender, EventArgs e)
        {

            DohvatiGoste();
        }

        private void IzbrisiGosta()
        {
            if(dgvGosti.CurrentRow != null) { 
            int ID = int.Parse(dgvGosti.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                    var upit = from g in context.Gost
                               where g.ID_gost == ID
                               select g;
                    var obrisiRezervacijuGosta = from r in context.Rezervacija
                                                 from g in context.Gost
                                                 where upit.FirstOrDefault().ID_gost == r.ID_gosta
                                                 select r;
                    var upitZaBrisanjeRacunaGosta = from g in context.Gost
                                                    from ra in context.Racun
                                                    from r in context.Rezervacija
                                                    where r.ID_gosta == g.ID_gost && obrisiRezervacijuGosta.FirstOrDefault().ID_rezervacija == ra.ID_rezervacije
                                                    select ra;


                    if (upitZaBrisanjeRacunaGosta.FirstOrDefault() != null)
                    {
                        context.Racun.Remove(upitZaBrisanjeRacunaGosta.FirstOrDefault());
                        context.Rezervacija.Remove(obrisiRezervacijuGosta.FirstOrDefault());
                        context.Gost.Attach(upit.FirstOrDefault());
                        context.Gost.Remove(upit.FirstOrDefault());
                        context.SaveChanges();

                    }
                    else
                    {
                        if (obrisiRezervacijuGosta.FirstOrDefault() != null)
                        {
                            context.Rezervacija.Remove(obrisiRezervacijuGosta.FirstOrDefault());
                            context.Gost.Remove(upit.FirstOrDefault());
                            context.SaveChanges();
                        }
                        else
                        {
                            context.Gost.Remove(upit.FirstOrDefault());
                            context.SaveChanges();
                        }

                    }
                
                }
            }
            else
            {
                MessageBox.Show("Nema dostupnih gostiju");
                btnIzbrisiGosta.Enabled = false;
                btnIzmjenaGosta.Enabled = false;
            }
            DohvatiGoste();
        }
        private void btnIzbrisiGosta_Click(object sender, EventArgs e)
        {

            IzbrisiGosta();
        }   
        
        private void btnIzmjenaGosta_Click(object sender, EventArgs e)
        {
            if(dgvGosti.CurrentRow != null) { 
            int ID = int.Parse(dgvGosti.CurrentRow.Cells[0].Value.ToString());
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from g in context.Gost
                           where g.ID_gost == ID
                           select g;
                Gost odabraniGost = upit.FirstOrDefault();
                IzmjenaGostaForm izmjenaGostaForm = new IzmjenaGostaForm(odabraniGost);
                izmjenaGostaForm.ShowDialog();
                
            }
            }
            else
            {
                MessageBox.Show("Nema dostupnih gostiju");
                btnIzbrisiGosta.Enabled = false;
                btnIzmjenaGosta.Enabled = false;
            }

        }

        private void btnOsvjeziGoste_Click(object sender, EventArgs e)
        {
            DohvatiGoste();
        }

        private void btnDodajGosta_Click(object sender, EventArgs e)
        {
            DodavanjeGostiForm dodavanjeGostiForm = new DodavanjeGostiForm();
            dodavanjeGostiForm.ShowDialog();
        }

        private void tbPrezimeGosta_TextChanged(object sender, EventArgs e)
        {
            string prezimeGosta = tbPrezimeGosta.Text;
            DohvatiGostePoPrezimenu(prezimeGosta);
        }
    }
}
