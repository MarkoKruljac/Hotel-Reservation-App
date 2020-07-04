using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forme
{
    public partial class IzmjenaGostaForm : Form
    {
        private Gost odabraniGost;
        public IzmjenaGostaForm(Gost gost)
        {
            InitializeComponent();
            odabraniGost = gost;
            
            
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
            cbVrstaGostaIzmjena.DataSource = vrstaGosta;
        }
        private void PopuniTextBoxeve()
        {
            using(var context = new PI20_021_DBEntities2())
            {
                
                tbImeGostaIzmjena.Text = odabraniGost.Ime;
                tbPrezimeGostaIzmjena.Text = odabraniGost.Prezime;
                tbTelefonGostaIzmjena.Text = odabraniGost.Telefon;
                tbAdresaGostaIzmjena.Text = odabraniGost.Adresa;
                tbEmailGostaIzmjena.Text = odabraniGost.Email;
                var upit = 
                           from vG in context.VrstaGosta
                           where odabraniGost.ID_vrste_gosta == vG.ID_vrsta_gosta
                           select vG.VrsteGosta;
                cbVrstaGostaIzmjena.Text = upit.FirstOrDefault();
                
            }
            
            
        }
        
        private void IzmjenaGostaForm_Load(object sender, EventArgs e)
        {
            
            PopuniVrstuGosta();
            PopuniTextBoxeve();
        }

        private void tbIDIzmjenaGosta_TextChanged(object sender, EventArgs e)
        {

        }
        private void Azuriraj()
        {
            try { 
            using (var context = new PI20_021_DBEntities2())
            {
                int ID = int.Parse(odabraniGost.ID_gost.ToString());
                string ime = tbImeGostaIzmjena.Text.ToString();
                string prezime = tbPrezimeGostaIzmjena.Text.ToString();
                string adresa= tbAdresaGostaIzmjena.Text.ToString();
                string telefon = tbTelefonGostaIzmjena.Text.ToString();
                string email = tbEmailGostaIzmjena.Text.ToString();
                string vrstaGosta = cbVrstaGostaIzmjena.SelectedItem.ToString();
                var upit = from vG in context.VrstaGosta
                           where vG.VrsteGosta == vrstaGosta
                           select vG;
                var upit2 = from g in context.Gost
                            where g.ID_gost == ID
                            select g;
                int id = upit.FirstOrDefault().ID_vrsta_gosta;
                if ( upit2.FirstOrDefault() != null) { 
                foreach (var item in upit2)
                {
                    item.Ime = ime;
                    item.Prezime = prezime;
                    item.Adresa = adresa;
                    item.Telefon = telefon;
                    item.Email = email;
                    item.ID_vrste_gosta = id;
        
                    
                }
                
                context.SaveChanges();

                        lblError.Text = "Uspješno ste izmjenili podatke o gostu";   //novo

                }
                        
            }
            }
            catch
            {
                lblError.Text = "Nepotpuni podaci!";    //novo
            }
        }
        private void btnIzvrsiGost_Click(object sender, EventArgs e)
        {
            Azuriraj();
        }

        private void btnIzlazIzmjenaGosta_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            
        }

        
    }
}
