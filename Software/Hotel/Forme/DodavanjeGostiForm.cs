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

                string ime = tbDodajImeGostu.Text;
                string prezime = tbDodajPrezimeGostu.Text;
                string telefon = tbDodajTelefoGosta.Text;
                string adresa = tbDodajAdresuGosta.Text;
                string email = tbDodajEmailGosta.Text;
                string vrstaGosta = cbDodajVrstuGosta.SelectedItem.ToString();


                var upit = from vG in context.VrstaGosta
                           from g in context.Gost
                           where vG.VrsteGosta == vrstaGosta 
                           select vG.ID_vrsta_gosta;

                Gost gost = new Gost
                {
                    Ime = ime,
                    Prezime = prezime,
                    Telefon = telefon,
                    Adresa = adresa,
                    Email = email,
                    ID_vrste_gosta = upit.FirstOrDefault()

                };


                
                context.Gost.Add(gost);
                context.SaveChanges();
                MessageBox.Show("Uspješno ste dodali gosta");


                   
                





            }

        }

        private void btnDodajGosta_Click(object sender, EventArgs e)
        {
            DodajGosta();
        }
    }
}
