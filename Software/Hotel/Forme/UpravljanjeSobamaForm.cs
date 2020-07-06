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
    public partial class UpravljanjeSobamaForm : Form
    {
        public UpravljanjeSobamaForm()
        {
            InitializeComponent();
        }



        private void Sobe_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sobe_btn_Click(object sender, EventArgs e)
        {

        }

        public void DohvatiSobe()
        {

            using (var context = new PI20_021_DBEntities2())
            {

                var upit = from s in context.Soba
                           from vs in context.VrstaSobe


                           where s.ID_vrste_sobe == vs.ID_vrsta_sobe
                           select new
                           {
                               brojSobe=s.ID_soba,
                               cijenaSobe=vs.Cijena,
                               opisSobe=s.Opis

                           };

                Sobe_dgv.DataSource = upit.ToList();
            }
        }

        private void UpravljanjeSobamaForm_Load(object sender, EventArgs e)
        {
            DohvatiSobe();
        }
    }
}
