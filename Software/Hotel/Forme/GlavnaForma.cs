using Hotel.Forme;
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
    public partial class GlavnaForma : Form
    {
        public bool admin;
        public GlavnaForma(bool Admin)
        {
            InitializeComponent();
            admin = Admin;
        }

        private void odjava_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrijava frmPrijava = new frmPrijava();
            frmPrijava.ShowDialog();
        }

        private void pomoc_btn_Click(object sender, EventArgs e)
        {

        }

        private void dnevniPlan_btn_Click(object sender, EventArgs e)
        {
            DnevniPlan dnevniPlan = new DnevniPlan();
            dnevniPlan.ShowDialog();

        }

        private void dobavljaci_btn_Click(object sender, EventArgs e)
        {
            DobavljačForm dobavljačForm = new DobavljačForm();
            dobavljačForm.ShowDialog();
        }

        private void racun_btn_Click(object sender, EventArgs e)
        {

        }

        private void rezervacije_btn_Click(object sender, EventArgs e)
        {
            RezervacijaForm rezervacijaForm = new RezervacijaForm();
            rezervacijaForm.ShowDialog();
        }

        private void zaposlenici_btn_Click(object sender, EventArgs e)
        {
            ZaposlenikForm zaposlenikForm = new ZaposlenikForm();
            zaposlenikForm.ShowDialog();
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            GostiForma gostiForma = new GostiForma();
            gostiForma.ShowDialog();
            
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            frmPrijava frmPrijava = new frmPrijava();
            if(admin==false)
            {
                dobavljaci_btn.Enabled=false;
                zaposlenici_btn.Enabled=false;
            }
            
        }
    }
}
