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
using static POS02_For_Restuarent.frmMainForm;

namespace POS02_For_Restuarent
{   
  
    public partial class frmQuantityConfigeOtherItems: Form
    {
        //Public_Items public_Items = new Public_Items();
       
        // my code
        public frmMainForm _frmMainForm;// code used to access the another form
       
        public frmQuantityConfigeOtherItems(frmMainForm frmMain)
        {
            InitializeComponent();
            _frmMainForm = frmMain; // code used to access the another form
        }

        private void frmQuantityConfigeOtherItems_Load(object sender, EventArgs e)
        {
            // used to retrieve and display item name in tbx
            if(Public_Items.ItemNames != "Search")
            {
                tbxItemName.Text = Public_Items.ItemNames;

            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            try
            {
                if(tbxquantity.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the Qty"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tbxquantity.Focus();
                }
                else
                {
                    //step 01

                    // my code || use to insert values into non-barcodeItem_Names list
                    if (!Public_Items.non_barcodeItem_Names.Contains(tbxItemName.Text))
                    {
                        Public_Items.non_barcodeItem_Names.Add(tbxItemName.Text);
                    }


                    // use to insert values for frmMainForm lbxIncluded_items_to_the_bill (Item Names)
                    foreach (string item in Public_Items.non_barcodeItem_Names)
                    {
                        if (!_frmMainForm.lbxIncluded_items_to_the_bill.Items.Contains(item))
                        {
                            _frmMainForm.lbxIncluded_items_to_the_bill.Items.Add(item);
                        }

                    }

                    //Step 02

                    // Inserting qty into list
                    Public_Items.non_barcodeItem_qty.Add(Convert.ToInt32(tbxquantity.Text));


                    ////Step 03 || Used to count the non-barcode item categories 
                    ////Int32 non_barcode_item_count = 0;
                    //Int32 existing_values_of_tbxCategories_mainform= 0;
                    //Int32 newValue = 0;

                    //existing_values_of_tbxCategories_mainform = Convert.ToInt32(_frmMainForm.tbxCategories.Text);
                    ////non_barcode_item_count = Public_Items.non_barcodeItem_Names.Count;
                    //newValue = existing_values_of_tbxCategories_mainform + 1;
                    //_frmMainForm.tbxCategories.Text = newValue.ToString();


                    //newValue = 0;   

                    //MessageBox.Show(non_barcode_item_count.ToString());
                    //step 04
                    // used to calculate the total qty 
                    Int32 valueOf_tbxQty_mainForm = 0;
                    Int32 existing_value_of_tbxQuantity = 0;

                    valueOf_tbxQty_mainForm = Convert.ToInt32(_frmMainForm.tbxQty.Text);
                    existing_value_of_tbxQuantity = Convert.ToInt32(tbxquantity.Text);
                    Int32 totalCount = existing_value_of_tbxQuantity + valueOf_tbxQty_mainForm;
                    _frmMainForm.tbxQty.Text = totalCount.ToString();

                    //Step 05 || database integration

                    if (Program.ds.Tables["TblNoN_BarcodeItems_prices_dst"] != null)
                    {
                        Program.ds.Tables["TblNoN_BarcodeItems_prices_dst"].Clear();
                    }

                    // used to retrieve the single item price from the database
                    Program.da = new SqlDataAdapter("SELECT Price FROM TblOther_Items WHERE ItemName='" + tbxItemName.Text + "' ", Program.con);
                    Program.da.Fill(Program.ds, "TblNoN_BarcodeItems_prices_dst");

                    double non_barcode_item_price = Convert.ToDouble(Program.ds.Tables["TblNoN_BarcodeItems_prices_dst"].Rows[0]["Price"]);

                    // Inserting non_barcode item price into list
                    Public_Items.non_barcodeItem_Price.Add(non_barcode_item_price);

                    // calculating amount (in bill/ part of the bill. not in this form)
                    int Bill_QTY = 0;
                    Bill_QTY = Convert.ToInt16(tbxquantity.Text);

                    double amount = 0;
                    amount = Bill_QTY * non_barcode_item_price;
                    Public_Items.Amount.Add(amount);

                    // calculating the total of all item (ex: fish bun , 4, 4 x Rs.450)
                    double existing_value_of_tbxTotal = 0;
                    double qty = 0;
                    double totalOfSinglItem = 0;
                    double final_cal = 0;

                    existing_value_of_tbxTotal = Convert.ToDouble(_frmMainForm.tbxTotal.Text);
                    qty = Convert.ToDouble(tbxquantity.Text);

                    totalOfSinglItem = qty * non_barcode_item_price;
                    final_cal = totalOfSinglItem + existing_value_of_tbxTotal;
                    _frmMainForm.tbxTotal.Text = final_cal.ToString();
                    //MessageBox.Show(totalOfSinglItem.ToString(), "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmQuantityConfigeOtherItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            //count.count_of_qty = 0;
        }
    }

    public class count
    {
        public static Int32 count_of_qty = 0;
        public static Int32 qty = 0;
    }

}
