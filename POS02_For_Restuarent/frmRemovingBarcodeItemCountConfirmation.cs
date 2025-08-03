using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS02_For_Restuarent.ExternalClasses;

namespace POS02_For_Restuarent
{
    public partial class frmRemovingBarcodeItemCountConfirmation : Form
    {
        private readonly frmMainForm _frmMainForm;

        public frmRemovingBarcodeItemCountConfirmation(frmMainForm frmMainForm)
        {
            InitializeComponent();
            _frmMainForm = frmMainForm;
        }

        private void frmRemovingBarcodeItemCountConfirmation_Load(object sender, EventArgs e)
        {
            // step 01
            tbxSelectedItemName.Text = Public_Items.barcodeItemThatSelectedToRemove;

            // step 02 (calculating existing count the list of selected item)
            int selectedBarcodeItemCount = 0;

            foreach(var data in Public_Items.barcode_item_names)
            {
                if(data.Contains(Public_Items.barcodeItemThatSelectedToRemove))
                {
                   selectedBarcodeItemCount++;
                }
               

            }

            // Use to count the existing barcode item count after clicking print button
            // Reson for use thiscode: After clicking print button, the barcode item name remove from the barcode_item_names list
            foreach (KeyValuePair<string, int> pair in Public_Items.Barcode_item_name_and_qty)
            {
                if ($"{pair.Key}".Contains(Public_Items.barcodeItemThatSelectedToRemove))
                {
                    selectedBarcodeItemCount = Convert.ToInt32( $"{pair.Value}");
                }
            }

            tbxSelectedItemCount.Text = selectedBarcodeItemCount.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ///
            /// Part 01
            /// 

            // Step 01
            string ItemNameFromDatabase = "";
            var Barcode = "";
            double price = 0;
            int valueCount_That_need_to_delete = 0;

            valueCount_That_need_to_delete = Convert.ToInt16( tbxItem_count_NeedToremove.Text);


            // Step 02 Retrieving values that need to delete
            if (Program.ds.Tables["TblBarcode_Items_dst"] != null)
            {
                Program.ds.Tables["TblBarcode_Items_dst"].Clear();
            }


            string itemName = "";
            itemName = tbxSelectedItemName.Text;

            Program.da = new SqlDataAdapter("SELECT * from TblBarcode_Items WHERE ItemName='"+itemName+"' ",Program.con);
            Program.da.Fill(Program.ds, "TblBarcode_Items_dst");

           
            foreach(DataRow data in Program.ds.Tables["TblBarcode_Items_dst"].Rows)
            {
                /* MessageBox.Show(data["Barcode"].ToString());
                 MessageBox.Show(data["Price"].ToString());
                 MessageBox.Show(data["ItemName"].ToString());*/

                ItemNameFromDatabase = data["ItemName"].ToString();
                Barcode = Convert.ToString(data["Barcode"]);
                price = Convert.ToInt32(data["Price"]);

                break;
            }

            // Step 03 Removing Item or items from the lists in public item class
            int count = 0;
            while(count < valueCount_That_need_to_delete)
            {
                Public_Items.barcode_item_names.Remove(itemName);
                Public_Items.barcode.Remove(Convert.ToDouble(Barcode));
                Public_Items.barcode_item_prices_02.Remove(price);
               count++;
            }
            MessageBox.Show("Deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Step 04 Removing item from lbxIncluded_items_to_the_bill (main form)
            var selectedItem = _frmMainForm.lbxIncluded_items_to_the_bill.SelectedItem;
            if (tbxItem_count_NeedToremove.Text.Equals( tbxSelectedItemCount.Text) )
            {
                _frmMainForm.lbxIncluded_items_to_the_bill.Items.Remove(selectedItem);
                MessageBox.Show("Completely remove this item","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            //step 05 || calculating total of barcode items with existing total in tbxTotal
            double reducingValue = 0;

            reducingValue = price * Convert.ToDouble(tbxItem_count_NeedToremove.Text);

            double existig_value_of_tbxTotal = Convert.ToDouble(_frmMainForm.tbxTotal.Text);

            double new_total_of_both_val = existig_value_of_tbxTotal - reducingValue;
            _frmMainForm.tbxTotal.Text = new_total_of_both_val.ToString();


            // step 06 || calculating qty (value of tbxQty with barcode items)
            double existing_valueOf_tbxQty = Convert.ToDouble(_frmMainForm.tbxQty.Text);

            //double lenth = Public_Items.barcode_item_prices_02.Count();

            double new_qty_count = existing_valueOf_tbxQty  - Convert.ToDouble(tbxItem_count_NeedToremove.Text);
            _frmMainForm.tbxQty.Text = new_qty_count.ToString();

            this.Close();

        }
    }
}
