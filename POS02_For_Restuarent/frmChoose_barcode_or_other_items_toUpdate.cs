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
    public partial class frmChoose_barcode_or_other_items_toUpdate: Form
    {
        public frmChoose_barcode_or_other_items_toUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_barcode_items_Click(object sender, EventArgs e)
        {
            frmUpdate_barcodeItems updateBarcodeItems = new frmUpdate_barcodeItems();
            updateBarcodeItems.ShowDialog();
        }

        private void btnUpdate_other_items_Click(object sender, EventArgs e)
        {
            frmUpdateOther_items update_other_items = new frmUpdateOther_items();
            update_other_items.Show();
        }
    }
}
