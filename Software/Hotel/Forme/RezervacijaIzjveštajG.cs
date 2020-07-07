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
    public partial class RezervacijaIzjveštajG : Form
    {
        public RezervacijaIzjveštajG()
        {
            InitializeComponent();
        }

        private void RezervacijaIzjveštajG_Load(object sender, EventArgs e)
        {

            using (var context = new PI20_021_DBEntities2())
            {
                dohvatiMjesecnuStatistikuResultBindingSource.DataSource = context.DohvatiMjesecnuStatistiku().ToList();
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
