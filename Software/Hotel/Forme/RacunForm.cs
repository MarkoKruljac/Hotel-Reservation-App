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
    public partial class RacunForm : Form
    {
        Rezervacija odabranoUseljenje;
        public RacunForm(Rezervacija rezervacija)
        {
            InitializeComponent();
            odabranoUseljenje = rezervacija;
        }

        

        
        private void PopuniRacun()
        {
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
                lbIDracuna.Text = upitIDracuna.FirstOrDefault().ToString();
                lbImeGosta.Text = upitImeGosta.FirstOrDefault();
                lbPrezimeGosta.Text = upitPrezimeGosta.FirstOrDefault();
                
                                   
            }
                
        }
        private void obrisi_btn_Click(object sender, EventArgs e)
        {

        }

        

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void RacunForm_Load(object sender, EventArgs e)
        {
            PopuniRacun();
        }
    }
}
