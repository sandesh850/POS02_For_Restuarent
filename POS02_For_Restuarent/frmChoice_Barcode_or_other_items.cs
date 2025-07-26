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
    public partial class frmChoice_Barcode_or_other_items : Form
    {
        public frmChoice_Barcode_or_other_items()
        {
            InitializeComponent();
        }

        private void btnAdd_barcode_items_Click(object sender, EventArgs e)
        {
            frmAddBarcode_Items addBarcode_Items = new frmAddBarcode_Items();
            addBarcode_Items.ShowDialog();
        }

        private void btnAdd_other_items_Click(object sender, EventArgs e)
        {
            frmAddOther_items add = new frmAddOther_items();
            add.ShowDialog();
        }
    }
}
