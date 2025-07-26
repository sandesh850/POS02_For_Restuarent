using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS02_For_Restuarent
{
    public partial class frmChoose_barcode_or_other_items_toRemove: Form
    {
        public frmChoose_barcode_or_other_items_toRemove()
        {
            InitializeComponent();
        }

        private void btnRemove_barcode_items_Click(object sender, EventArgs e)
        {
            frmRemove_Barcode_items removeBar = new frmRemove_Barcode_items();
            removeBar.ShowDialog();
        }

        private void btnRemove_other_items_Click(object sender, EventArgs e)
        {
            frmRemove_other_items removeOther = new frmRemove_other_items();
            removeOther.ShowDialog();
        }
    }
}
