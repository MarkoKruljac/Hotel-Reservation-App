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
    public partial class RezervacijaIzvještaji : Form
    {
        public RezervacijaIzvještaji()
        {
            InitializeComponent();
        }

        private void RezervacijaIzvještaji_Load(object sender, EventArgs e)
        {
            using (var context = new PI20_021_DBEntities2())
            {

                var upit = from r in context.Rezervacija
                           select r;

                List<Rezervacija> sveRezervacije = upit.ToList();
                RezervacijaBindingSource.DataSource = sveRezervacije;

            }

            this.rvRezervacija.RefreshReport();
        }
    }
}
