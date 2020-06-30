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
    public partial class DodavanjeGostiForm : Form
    {
        public DodavanjeGostiForm()
        {
            InitializeComponent();
        }
        public void PopuniVrstuGosta()
        {
            List<string> vrstaGosta = new List<string>() { };
            using (var context = new PI20_021_DBEntities2())
            {
                var upit = from vG in context.VrstaGosta
                           select vG.VrsteGosta;
                vrstaGosta = upit.ToList();
            }
            cbDodajVrstuGosta.DataSource = vrstaGosta;
        }
        private void DodavanjeGostiForm_Load(object sender, EventArgs e)
        {
            PopuniVrstuGosta();
        }
        private void DodajGosta()
        {
            using (var context = new PI20_021_DBEntities2())
            {
               
                string imeGosta = tbDodajImeGostu.Text;
                string prezimeGosta = tbDodajPrezimeGostu.Text;
                string telefonGosta = tbDodajTelefoGosta.Text;
                string adresaGosta = tbDodajAdresuGosta.Text;
                string emailGosta = tbDodajEmailGosta.Text;
                string vrstaGostaa = cbDodajVrstuGosta.SelectedItem.ToString();


                var upitZaIDvrste = from vG in context.VrstaGosta
                           where vG.VrsteGosta == vrstaGostaa 
                           select vG.ID_vrsta_gosta;
                if (!string.IsNullOrEmpty(tbDodajImeGostu.Text) && !string.IsNullOrEmpty(tbDodajPrezimeGostu.Text) &&
                    !string.IsNullOrEmpty(tbDodajTelefoGosta.Text) && !string.IsNullOrEmpty(tbDodajAdresuGosta.Text) && !string.IsNullOrEmpty(tbDodajEmailGosta.Text))
                {
                    Gost novigost = new Gost
                    {
                        Ime = imeGosta,
                        Prezime = prezimeGosta,
                        Telefon = telefonGosta,
                        Adresa = adresaGosta,
                        Email = emailGosta,
                        ID_vrste_gosta = upitZaIDvrste.FirstOrDefault(),
                        ID_hotela = frmPrijava.IDhotela


                    };

                    
                        context.Gost.Add(novigost);
                        context.SaveChanges();
                        MessageBox.Show("Uspješno ste dodali gosta");
                    
                
                }
                else
                {
                    MessageBox.Show("Nepotuni podaci o gostu!");
                }
                
            }
                
            

        }

        private void btnDodajGosta_Click(object sender, EventArgs e)
        {
            DodajGosta();
        }
    }
}
