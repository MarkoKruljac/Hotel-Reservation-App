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

        private void UpravljanjeSobamaForm_Load(object sender, EventArgs e)
        {
            using ( var context = new PI20_021_DBEntities2())
            {
                int IdHotela = frmPrijava.IDhotela;
                var upitZaSobe = from s in context.Soba
                                 from vS in context.VrstaSobe
                                 from h in context.Hotel
                                 where s.ID_vrste_sobe == vS.ID_vrsta_sobe && s.ID_hotela == IdHotela && h.ID_hotel == s.ID_hotela
                                 select new
                                 {
                                    BrojSobe = s.ID_soba,
                                    PripadajuciHotel = h.Ime,
                                    CijenaSobe = vS.Cijena,
                                    OpisSobe = s.Opis
                                 };
                dgvSobe.DataSource = upitZaSobe.ToList();
            }
        }
    }
}
