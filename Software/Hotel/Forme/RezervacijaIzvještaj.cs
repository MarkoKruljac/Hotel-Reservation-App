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
    public partial class RezervacijaIzvještaj : Form
    {
        public RezervacijaIzvještaj()
        {
            InitializeComponent();
        }

        private void RezervacijaIzvještaj_Load(object sender, EventArgs e)
        {
            using (var context = new PI20_021_DBEntities2())
            {
                var brojDana = from d in context.BrojRezervacijaDanas
                               select d;

                var brojMjesec = from m in context.BrojRezervacijaMjesec
                                 select m;

                var brojGodina = from g in context.BrojRezervacijaGodina
                                select g;

                brojRezervacijaDanasBindingSource.DataSource = brojDana.ToList();
                brojRezervacijaMjesecBindingSource.DataSource = brojMjesec.ToList();
                brojRezervacijaGodinaBindingSource.DataSource = brojGodina.ToList();
            }
            this.rvRezervacija.RefreshReport();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void ExportToPDF()
        {

        }
    }
}
