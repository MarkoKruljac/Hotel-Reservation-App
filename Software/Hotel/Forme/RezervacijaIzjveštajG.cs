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

            this.rvGraficki.RefreshReport();
        }
    }
}
