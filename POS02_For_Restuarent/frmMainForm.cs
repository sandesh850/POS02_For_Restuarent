using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using POS02_For_Restuarent.ExternalClasses;

namespace POS02_For_Restuarent
{
   
    public partial class frmMainForm : Form
    {
        // Public_Items public_Items = new Public_Items();
        // public readonly frmMainForm _frmMainForm02;
        Timer ClearTextTimer;
        public frmMainForm()
        {
            InitializeComponent();
           
            
        }

       

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            frmSubLogin_Add_Items subLogin = new frmSubLogin_Add_Items();
            subLogin.ShowDialog();
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            frmSubLogin_update_items login_update_barcode_items = new frmSubLogin_update_items();
            login_update_barcode_items.ShowDialog();
        }


        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            frmSubLogin_Remove_items subRemove = new frmSubLogin_Remove_items();
            subRemove.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            ///
            /// Special code 
            /// 

            // This code use to find check whether the date limite of the software is exceeded 
            if (Program.ds.Tables["TblLastCount_dst"] != null)
            {
                Program.ds.Tables["TblLastCount_dst"].Clear();
            }

            Program.da = new SqlDataAdapter("SELECT TOP 1 count FROM Tbltracking ORDER BY count DESC",Program.con);
            Program.da.Fill(Program.ds, "TblLastCount_dst");

            int LCount = 0;
            LCount = Convert.ToInt32(Program.ds.Tables["TblLastCount_dst"].Rows[0]["count"]);

            if(LCount >= 30)
            {
                
                MessageBox.Show("Limit Exceeded","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
              
                frmProductKey productKey = new frmProductKey();
                productKey.ShowDialog();
            }




            if (Program.ds.Tables["Tbltracking_dst"] != null)
            {
                Program.ds.Tables["Tbltracking_dst"].Clear();
            }

            DateTime dateAndTime = DateTime.Now;
            string Today = dateAndTime.ToShortDateString();
            int dateCounting = 0;
            string dateAvailability_Checking = "";

            Program.da = new SqlDataAdapter("SELECT * FROM Tbltracking",Program.con);
            Program.da.Fill(Program.ds, "Tbltracking_dst");

            if (Program.ds.Tables["Tbltracking_dst"].Rows.Count <= 0)// This code use to calculate and insert date and date count in first running
            {
                dateCounting++;

                Program.cmd.Connection = Program.con;
                Program.con.Open();
                Program.cmd.CommandText = "INSERT INTO Tbltracking VALUES('"+Today+"', '"+dateCounting+"') ";
                Program.cmd.ExecuteNonQuery();
                Program.con.Close();


            }
            else
            {
                // This code is used to insert and calculate date and date count after initial-
                // reord inserting. Also main goal is this finding the current date is existing in database
                foreach (DataRow data in Program.ds.Tables["Tbltracking_dst"].Rows)
                {
                    DateTime checkingDates = Convert.ToDateTime( data["Date"]);

                    if (checkingDates.ToShortDateString() != Today)
                    {
                       
                        dateAvailability_Checking = "no";
                    }
                    else
                    {
                        dateAvailability_Checking = "yes";
                    }
                }
            }

            // This code is used to insert and calculate date and date count after initial record inserting
            if (dateAvailability_Checking == "no")
            {
                if (Program.ds.Tables["TblLastCount_dst"] != null)
                {
                    Program.ds.Tables["TblLastCount_dst"].Clear();
                }

                Program.da = new SqlDataAdapter("SELECT TOP 1 count FROM Tbltracking ORDER BY count DESC", Program.con);
                Program.da.Fill(Program.ds,"TblLastCount_dst");

                int lastCount = 0;
                lastCount = Convert.ToInt16(Program.ds.Tables["TblLastCount_dst"].Rows[0]["count"]);

                lastCount++;

                Program.cmd.Connection = Program.con;
                Program.con.Open();
                Program.cmd.CommandText = "INSERT INTO Tbltracking VALUES('" + Today + "', '" + lastCount + "') ";
                Program.cmd.ExecuteNonQuery();
                Program.con.Close();
            }





            // step 01 || Bill no calculating

            if (Program.ds.Tables["TBLlast_bill_No_dst"] != null)
            {
                Program.ds.Tables["TBLlast_bill_No_dst"].Clear();
            }

            Program.da = new SqlDataAdapter("SELECT TOP 1 Bill_no FROM TblBills ORDER BY Bill_no DESC", Program.con);
            Program.da.Fill(Program.ds, "TBLlast_bill_No_dst");

            int Last_bill_No = 0;  
            int Row_count = Program.ds.Tables["TBLlast_bill_No_dst"].Rows.Count;

            if(Row_count <= 0)
            {
                Last_bill_No++;
            }
            else
            {
                Last_bill_No = Convert.ToInt16(Program.ds.Tables["TBLlast_bill_No_dst"].Rows[0]["Bill_no"]);
                Last_bill_No = Last_bill_No + 1;

            }

           lblBill_No.Text = Last_bill_No.ToString();

            //Following code is used to show the task bar without any issue
            // Set the form to maximize without covering the taskbar
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;

            // Following code is not essencial

            // Ensure taskbar is accessible by using working area instead of full screen
            //this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;


            timer1.Start();

            //Retrieving None-Barcode item names
            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items", Program.con);
            Program.da.Fill(Program.ds, "TblItemName_dst");


            foreach (DataRow itemNames in Program.ds.Tables["TblItemName_dst"].Rows)
            {

                lbxNone_barcode_Items_search.Items.Add(itemNames["ItemName"]);
            }

            // Step 02 || Display bill details in data grid view
            Program.da = new SqlDataAdapter("SELECT * FROM TblBills",Program.con);
            Program.da.Fill(Program.ds, "TblBills_dst");

            Dgv.DataSource = Program.ds.Tables["TblBills_dst"];
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(tbxSearch.Text == string.Empty || tbxSearch.Text == "Search")
            {
                MessageBox.Show("Please select a item","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Public_Items.ItemNames = tbxSearch.Text;// used to retrieve and display item name in tbx in frmQuantityConfiguration form

                frmQuantityConfigeOtherItems quenConfig = new frmQuantityConfigeOtherItems(this);
                quenConfig.ShowDialog();
            }
           
        }

        private void btnLoginConfig_Click(object sender, EventArgs e)
        {
            frmUpdateLogin updateLogin = new frmUpdateLogin();
            updateLogin.ShowDialog();
        }

        private void tbxSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            tbxSearch.Text = "Search";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try// step 01
            {
                lbxNone_barcode_Items_search.Items.Clear();
                lbxNone_barcode_Items_search.Refresh();

                if (tbxSearch.Text == "Search")
                {
                    if (Program.ds.Tables["TblItemName_dst"] != null)
                    {
                        Program.ds.Tables["TblItemName_dst"].Clear();
                    }

                    //Retrieving None - Barcode item names
                    Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items", Program.con);
                    Program.da.Fill(Program.ds, "TblItemName_dst");


                    foreach (DataRow itemNames in Program.ds.Tables["TblItemName_dst"].Rows)
                    {

                        lbxNone_barcode_Items_search.Items.Add(itemNames["ItemName"]);
                    }
                }
                else
                {
                    if (Program.ds.Tables["TblItemNames_search_dst"] != null)
                    {
                        Program.ds.Tables["TblItemNames_search_dst"].Clear();
                    }

                    Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items WHERE ItemName LIKE '%" + tbxSearch.Text + "%' ", Program.con);
                    Program.da.Fill(Program.ds, "TblItemNames_search_dst");

                    foreach (DataRow data in Program.ds.Tables["TblItemNames_search_dst"].Rows)
                    {
                        lbxNone_barcode_Items_search.Items.Add(data["ItemName"]);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lbxNone_barcode_Items_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxNone_barcode_Items_search.SelectedItem != null)
                {
                    tbxSearch.Text = lbxNone_barcode_Items_search.SelectedItem.ToString();
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
            
        }

        private void lbxIncluded_items_to_the_bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {


            /// 
            /// Statep 01
            ///

            // TMP code (TMP = tempory)
            //lbxBName.Items.Clear();
            //foreach(var data in Public_Items.barcode_item_names)
            //{
            //    lbxBName.Items.Add(data);
            //}


            //lbxBarcode.Items.Clear();
            //foreach (var data in Public_Items.barcode)
            //{
            //    lbxBarcode.Items.Add(data);
            //}

            //lbxBprice.Items.Clear();
            //foreach (var data in Public_Items.barcode_item_prices_02)
            //{
            //    lbxBprice.Items.Add(data);
            //}

            //Step 1: Estimate Height Per Item Line (online guide)
            //Assume:

            //Header = 100 units

            //Each item line = 25 units

            //Footer = 100 units

            /// 
            /// Statep 02
            /// 

            //int width = 80;
            //int BillWidth = Convert.ToInt16(width / 25.4 * 100); // Bill width in milimeters (315 approximately)

            //int itemHeight_mm = 4; // 5mm per item line
            //int headerHeight_mm = 20;
            //int footerHeight_mm = 20;
            //int itemCount = 5;

            //int height_mm = headerHeight_mm + (itemCount * itemHeight_mm) + footerHeight_mm;
            //int BillHeight = Convert.ToInt32(height_mm / 25.4 * 100); // ≈ 150


            //PaperSize customPaperSize = new PaperSize("Custom", /*width*/BillWidth, BillHeight/*height*/);// Width: ~80mm, Height: ~254mm
            //printDocument1.DefaultPageSettings.PaperSize = customPaperSize;
            //printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0); //(optional)
            ////printDocument1.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High;(optional)
            //printPreviewDialog1.Document = printDocument1;

            //printPreviewDialog1.ShowDialog();


            // checking default width and height
            //int width = printDocument1.DefaultPageSettings.PaperSize.Width;
            //int height = printDocument1.DefaultPageSettings.PaperSize.Height;
            //MessageBox.Show("width:"+width);
            //MessageBox.Show("width:" + height);

            try
            {
                if (cmbPayment_method.Text == "Please select")
                {
                    MessageBox.Show("Please select the payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPayment_method.Focus();
                }
                else if (tbxPaidAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the paid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPaidAmount.Focus();
                }
                else
                {
                    ///
                    /// Step 03 inserting bill details into the database
                    /// 

                    // Inserting data into TblBills
                    Program.cmd.Connection = Program.con;
                    Program.con.Open();
                    Program.cmd.CommandText = "INSERT INTO TblBills VALUES('" + lblBill_No.Text + "', '" + tbxTotal.Text + "', '" + lblDate.Text + "', '" + lblTime.Text + "') ";
                    Program.cmd.ExecuteNonQuery();
                    Program.con.Close();

                    //Inserting barcode item details into the database (barcode item that included into the bill)
                    foreach (double barcodes in Public_Items.barcode)
                    {
                        Program.cmd.Connection = Program.con;
                        Program.con.Open();
                        Program.cmd.CommandText = "INSERT INTO TblBill_IteamDetails_Barcode VALUES('" + lblBill_No.Text + "', '" + barcodes + "') ";
                        Program.cmd.ExecuteNonQuery();
                        Program.con.Close();
                    }

                    // Inserting Non barcode item details into the database
                    foreach (string nonBarcodeItemNames in Public_Items.non_barcodeItem_Names)
                    {
                        Program.cmd.Connection = Program.con;
                        Program.con.Open();
                        Program.cmd.CommandText = "INSERT INTO TblBill_ItemDetails_OItems VALUES('" + lblBill_No.Text + "', '" + nonBarcodeItemNames + "') ";
                        Program.cmd.ExecuteNonQuery();
                        Program.con.Close();
                    }

                    ///
                    /// Step 04 // Algorithm type =  Counting / Frequency algorithm (This code is use to find barcode item qty and insert those new data into 
                    /// "Barcode_item_name_and_qty" list that use to print final Bill)
                    /// 
                    string ItemNameThatUsedToFindQTY = "";
                    int qty_of_one_item = 0;

                    //part 01 of the loop
                    foreach (string data in Public_Items.barcode_item_names.ToList())
                    {
                        //lbxTesting.Items.Add(data);
                        ItemNameThatUsedToFindQTY = data;
                        if (ItemNameThatUsedToFindQTY == data)
                        {
                            //part 02 of the loop
                            foreach (string names in Public_Items.barcode_item_names)
                            {
                                if (ItemNameThatUsedToFindQTY == names)
                                {
                                    qty_of_one_item++;
                                }

                            }

                            if (!Public_Items.Barcode_item_name_and_qty.ContainsKey(ItemNameThatUsedToFindQTY))
                            {
                                Public_Items.Barcode_item_name_and_qty.Add(ItemNameThatUsedToFindQTY, qty_of_one_item);
                            }


                            Public_Items.barcode_item_names.Remove(ItemNameThatUsedToFindQTY);
                            ItemNameThatUsedToFindQTY = "";
                            qty_of_one_item = 0;

                        }

                    }


                    ///
                    /// Step 05 Correct and working code
                    /// 
                    int itemCount = 0;
                    itemCount = Convert.ToInt16(Public_Items.non_barcodeItem_Names.Count + Public_Items.Barcode_item_name_and_qty.Count);
                    int dynmicHeight = 0;

                    dynmicHeight = 200 + (itemCount * 20); /*20 is a space value that single item get from the Bill*/

                    printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom",/*Width (80mm)*/315, /*Height*/ dynmicHeight);

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

          

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                /// Step 01
                if (DialogResult.Yes == MessageBox.Show("Are you sure about this?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
                {
                    /// Step 1.1
                    string checking_of_value_vailability = "";
                    string selectedItem = "";
                    selectedItem = lbxIncluded_items_to_the_bill.SelectedItem.ToString();

                    foreach(var data in Public_Items.non_barcodeItem_Names)
                    {
                        if(data == selectedItem )
                        {
                            checking_of_value_vailability = "Y";
                            break;
                        }
                        else
                        {
                            checking_of_value_vailability ="N";
                           
                        }
                    }

                    if(checking_of_value_vailability.Equals( "Y"))
                    {
                        
                        /// Step 02 || Removing non barcode items details (from lists and text boxes)
                        foreach (string non_barcode_item_names in Public_Items.non_barcodeItem_Names)
                        {
                            if (non_barcode_item_names == lbxIncluded_items_to_the_bill.Text)
                            {
                                int index = Public_Items.non_barcodeItem_Names.IndexOf(non_barcode_item_names);

                                int qty_of_item = Public_Items.non_barcodeItem_qty[index];

                                
                                /// Modifying qty value of text box
                                double existingValue = 0;
                                double newQTY = 0;
                                existingValue = Convert.ToDouble(tbxQty.Text);
                                newQTY = existingValue - qty_of_item;
                                tbxQty.Text = newQTY.ToString();

                                /// Modifying total price (value of tbxTotal)

                                if (Program.ds.Tables["TblSingleItemPrice_dst"] != null)
                                {
                                    Program.ds.Tables["TblSingleItemPrice_dst"].Clear();
                                }
                                /// retrieving single item price
                                Program.da = new SqlDataAdapter("SELECT Price FROM TblOther_Items WHERE ItemName='" + non_barcode_item_names + "' ", Program.con);
                                Program.da.Fill(Program.ds, "TblSingleItemPrice_dst");

                                double founded_priceOfRemvingItems = 0;
                                founded_priceOfRemvingItems = Convert.ToDouble(Program.ds.Tables["TblSingleItemPrice_dst"].Rows[0]["Price"]);

                                double newTotal = 0;
                                double priceThat_need_to_remove = 0;
                                double existingPriceOf_tbxTotal = 0;

                                existingPriceOf_tbxTotal = Convert.ToDouble(tbxTotal.Text);

                                priceThat_need_to_remove = qty_of_item * founded_priceOfRemvingItems;
                                newTotal = existingPriceOf_tbxTotal - priceThat_need_to_remove;
                                tbxTotal.Text = newTotal.ToString();

                                //MessageBox.Show(priceThat_need_to_remove.ToString());

                                /// Removing item from the non_barcode_itemQTY list
                                Public_Items.non_barcodeItem_qty.Remove(qty_of_item);

                                /// Removing non barcode item name
                                Public_Items.non_barcodeItem_Names.Remove(non_barcode_item_names);

                                /// Removing item name from lbxIncluded_Items_tothe_bill
                                lbxIncluded_items_to_the_bill.Items.Remove(non_barcode_item_names);

                                /// Removing value from amount list
                                Public_Items.Amount.RemoveAt(index);

                                /// Removing value from non barcode item prices list
                                Public_Items.non_barcodeItem_Price.RemoveAt(index);



                                break;

                            }
                        }

                    }
                    else
                    {

                        /// Step 03 || Removing barcode item details (first step)

                        var selectedBarcodeItem = lbxIncluded_items_to_the_bill.Text;

                        foreach (var data in Public_Items.barcode_item_names)
                        {
                            if (data.Contains(selectedBarcodeItem.ToString()))
                            {
                                //MessageBox.Show(data);
                                Public_Items.barcodeItemThatSelectedToRemove = data;
                                frmRemovingBarcodeItemCountConfirmation remove = new frmRemovingBarcodeItemCountConfirmation(this);
                                remove.ShowDialog();
                                break;

                            }

                        }

                        // new code (use to remove barcode item names after click the print button)
                        foreach (KeyValuePair<string, int> pair in Public_Items.Barcode_item_name_and_qty)
                        {
                            if ($"{pair.Key}".Contains(selectedBarcodeItem.ToString()))
                            {
                                //MessageBox.Show(data);
                                Public_Items.barcodeItemThatSelectedToRemove = $"{pair.Key}";
                                frmRemovingBarcodeItemCountConfirmation remove = new frmRemovingBarcodeItemCountConfirmation(this);
                                remove.ShowDialog();
                                break;

                            }

                        }

                    }



                }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void tbxSearchIncluded_Items_Click(object sender, EventArgs e)
        {
            tbxSearchIncluded_Items.Clear();
        }

        private void tbxSearchIncluded_Items_Leave(object sender, EventArgs e)
        {

            if(DialogResult.Yes == MessageBox.Show("Do you want to stop the process ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                tbxSearchIncluded_Items.Text = "Search";
                lbxIncluded_items_to_the_bill.Items.Clear();
                lbxIncluded_items_to_the_bill.Refresh();
                foreach (string listItems in Public_Items.non_barcodeItem_Names)
                {

                    if (!lbxIncluded_items_to_the_bill.Items.Contains(listItems))
                    {
                        lbxIncluded_items_to_the_bill.Items.Add(listItems);
                    }
                }
            }
           
        }

        private void tbxSearchIncluded_Items_TextChanged(object sender, EventArgs e)
        {
           

            if(tbxSearchIncluded_Items.Text == "Search")
            {
                foreach(string listItems in Public_Items.non_barcodeItem_Names)
                {
                    lbxIncluded_items_to_the_bill.Items.Add(listItems);
                }
            }
            else
            {
                lbxIncluded_items_to_the_bill.Items.Clear();
                lbxIncluded_items_to_the_bill.Refresh();
                foreach (string includedItems in Public_Items.non_barcodeItem_Names)
                {
                    //if (includedItems.IndexOf(tbxSearchIncluded_Items.Text,StringComparison.OrdinalIgnoreCase) >0 )
                    //{
                    //    lbxIncluded_items_to_the_bill.Items.Add(includedItems);
                    //}
                    if (tbxSearchIncluded_Items.Text == includedItems)
                    {
                        lbxIncluded_items_to_the_bill.Items.Add(includedItems);
                    }
                }
            }
        }

        private void tbxBarcode_TextChanged(object sender, EventArgs e)
        {
            

            //Step 01
            if (Program.ds.Tables["TblBarcode_Details_dst"] != null)
            {
                Program.ds.Tables["TblBarcode_Details_dst"].Clear();
            }

            Program.da = new SqlDataAdapter("SELECT Barcode,Price,ItemName FROM TblBarcode_Items WHERE Barcode='" + tbxBarcode.Text+"' ",Program.con);
            Program.da.Fill(Program.ds, "TblBarcode_Details_dst");

           

            if(Program.ds.Tables["TblBarcode_Details_dst"].Rows.Count > 0)
            {
                
                // step 02 || inserting values into the list
                Public_Items.barcode_item_names.Add(Program.ds.Tables["TblBarcode_Details_dst"].Rows[0]["ItemName"].ToString());
               

                Public_Items.barcode.Add(Convert.ToDouble( Program.ds.Tables["TblBarcode_Details_dst"].Rows[0]["Barcode"]));

                

                Public_Items.barcode_Item_price.Add(Convert.ToDouble(Program.ds.Tables["TblBarcode_Details_dst"].Rows[0]["Price"]));

               
            }

            //Step 02 || clearing text box
            if(ClearTextTimer !=  null)
            {
                ClearTextTimer.Stop(); //clearTextTimer is a variable name (check the top of this form)
            }
            else
            {
                ClearTextTimer = new Timer();
                ClearTextTimer.Interval = 1000;// 1 second
                ClearTextTimer.Tick += (s, args) =>
                {
                    tbxBarcode.Text = "";
                    ClearTextTimer.Stop();
                };

            }

            ClearTextTimer.Start();


            ///
            ///  Methods that we can use to play a sound
            ///  

            // Method 01 | In here only play .wav files 
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("beep.wav"); Put the sound location inside the paranthesis.
            //player.Play();

            // Method 02
            //System.Media.SystemSounds.Beep.Play("Sound location");



        }

        private void btnSumOfBarcodeItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxBarcode.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double existig_value_of_tbxTotal = 0;
                    //step 01 || calculating total of barcode items with existing total in tbxTotal
                    double sum = Public_Items.barcode_Item_price.Sum();
                    if (tbxTotal.Text != string.Empty)
                    {
                        existig_value_of_tbxTotal = Convert.ToDouble(tbxTotal.Text);
                    }


                    double total_of_both_val = sum + existig_value_of_tbxTotal;
                    tbxTotal.Text = total_of_both_val.ToString();


                    // step 02 || calculating qty (value of tbxQty with barcode items)
                    double existing_valueOf_tbxQty = 0;

                    if (tbxQty.Text != string.Empty)
                    {
                        existing_valueOf_tbxQty = Convert.ToDouble(tbxQty.Text);
                    }


                    double lenth = Public_Items.barcode_Item_price.Count();

                    double new_qty_count = existing_valueOf_tbxQty + lenth;
                    tbxQty.Text = new_qty_count.ToString();


                    /// inserting prices to permanet list
                    foreach (double prices in Public_Items.barcode_Item_price)
                    {
                        Public_Items.barcode_item_prices_02.Add(prices);
                    }

                    Public_Items.barcode_Item_price.Clear();


                    /// step 04 || inserting item names to the lbxIncluded_items_to_the_bill
                    foreach (string barcode_ItemNames in Public_Items.barcode_item_names)
                    {
                        if (!lbxIncluded_items_to_the_bill.Items.Contains(barcode_ItemNames))
                        {
                            lbxIncluded_items_to_the_bill.Items.Add(barcode_ItemNames);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double painAmount = 0;
                double total = 0;


                if (cmbPayment_method.Text == "Please select")
                {
                    MessageBox.Show("Please selecte a payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPayment_method.Focus();

                }
                else if (tbxPaidAmount.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the paind amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPaidAmount.Focus();
                }
                else if (Convert.ToDouble(tbxPaidAmount.Text) < Convert.ToDouble(tbxTotal.Text))
                {
                    MessageBox.Show("The paid amount is less than the bill amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPaidAmount.Focus();
                }
                else
                {

                    painAmount = Convert.ToDouble(tbxPaidAmount.Text);
                    total = Convert.ToDouble(tbxTotal.Text);

                    double balance = 0;
                    balance = painAmount - total;
                    tbxBalance.Text = balance.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           


        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            String date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();

            Graphics graphics = e.Graphics; // Retrieving page canvas 

            // Header area
            graphics.DrawString("POS Bill", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(/*X*/100,/*Y*/ 5));

            graphics.DrawString("Address", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(130, 35));

            graphics.DrawString("+94 77 203645", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(110, 55));

            graphics.DrawString(date, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 80));

            graphics.DrawString(time, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(75, 80));

            graphics.DrawString("Bill No:"+lblBill_No.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(220, 80));

            graphics.DrawString("-------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 95));

            // Body area (body area header)
            graphics.DrawString("Item", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 120));

            graphics.DrawString("Price", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, 120));

            graphics.DrawString("Qty", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, 120));

            graphics.DrawString("Amount", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, 120));

            graphics.DrawString("-------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 130));

            // Non barcode item names adding to the bill
            int initial_value_of_position = 145;

            foreach (string item in Public_Items.non_barcodeItem_Names)
            {
                graphics.DrawString(item, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, initial_value_of_position));
                initial_value_of_position = initial_value_of_position + 20;
            }


            // Non barcode item price adding to the bill
            int initial_value_of_position02 = 145;

            foreach (double item in Public_Items.non_barcodeItem_Price)
            {
                graphics.DrawString(item.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, initial_value_of_position02));
                initial_value_of_position02 = initial_value_of_position02 + 20;
            }

            // Non barcode item qty adding to the bill
            int initial_value_of_position03 = 145;

            foreach (double item in Public_Items.non_barcodeItem_qty)
            {
                graphics.DrawString(item.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, initial_value_of_position03));
                initial_value_of_position03 = initial_value_of_position03 + 20;
            }


            // Non barcode item amount adding to the bill
            int initial_value_of_position04 = 145;

            foreach (double item in Public_Items.Amount)
            {
                graphics.DrawString(item.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, initial_value_of_position04));
                initial_value_of_position04 = initial_value_of_position04 + 20;
            }

            ///
            /// Barcode item inserting section to the bill
            /// 

            // Inserting barcode item names
            //int initial_value_of_position05 = 145;

            //foreach (KeyValuePair<string,int> pair in Public_Items.Barcode_item_name_and_qty)
            //{
            //    graphics.DrawString($"{pair.Key}", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, initial_value_of_position));
            //    initial_value_of_position = initial_value_of_position + 20; // In here to calculate initial_value_of_position used tha same variable use in above non barcode section (name section)

            //}


            //// Inserting barcode item prices
            //foreach (double item in Public_Items.barcode_item_prices_02)
            //{
            //    graphics.DrawString(item.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, initial_value_of_position04));
            //    initial_value_of_position04 = initial_value_of_position04 + 20;
            //}


            ///
            /// Inserting barcode item details
            ///
            string itemName = "";
            List<double> Lst_barcode_item_prices = new List<double>();

            if (Program.ds.Tables["TblBarcode_Item_prices_dst"] != null)
            {
                Program.ds.Tables["TblBarcode_Item_prices_dst"].Clear();
            }

            // Retrieving one item price from database to insert bill
            foreach (KeyValuePair<string, int> pair in Public_Items.Barcode_item_name_and_qty)
            {
                itemName = pair.Key;
                Program.da = new SqlDataAdapter("SELECT Price FROM TblBarcode_Items WHERE ItemName='" + itemName + "' ", Program.con);
                Program.da.Fill(Program.ds, "TblBarcode_Item_prices_dst");

            }

            if (Program.ds.Tables["TblBarcode_Item_prices_dst"] != null)
            {
                foreach (DataRow prices in Program.ds.Tables["TblBarcode_Item_prices_dst"].Rows)
                {
                    Lst_barcode_item_prices.Add(Convert.ToDouble(prices["Price"]));
                }
            }

            //inserting barcode item names and qty into bill
            foreach (KeyValuePair<string, int> pair in Public_Items.Barcode_item_name_and_qty)
            {
                graphics.DrawString($"{pair.Key}", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, initial_value_of_position));
                initial_value_of_position = initial_value_of_position + 20; // In here to calculate initial_value_of_position used tha same variable use in above non barcode section (name section)

                graphics.DrawString($"{pair.Value}", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, initial_value_of_position03));
                initial_value_of_position03 = initial_value_of_position03 + 20;
            }

            // inserting barcode item prices
            foreach (double data in Lst_barcode_item_prices)
            {
                graphics.DrawString(data.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, initial_value_of_position02));
                initial_value_of_position02 = initial_value_of_position02 + 20;
            }

            ///
            /// Inserting amout (total)
            /// 

            // Purpose : calculating barcode item amout (single item)
            double one_item_price = 0;
            double total = 0;
            List<double> Lst_amouts = new List<double>();
            foreach(KeyValuePair<string,int> pair in Public_Items.Barcode_item_name_and_qty)
            {
                if (Program.ds.Tables["Tbl_barcode_Items_prices_dst"] != null)
                {
                    Program.ds.Tables["Tbl_barcode_Items_prices_dst"].Clear();
                }
                
                Program.da = new SqlDataAdapter("SELECT Price FROM TblBarcode_Items WHERE ItemName='"+ pair.Key + "' ",Program.con);
                Program.da.Fill(Program.ds, "Tbl_barcode_Items_prices_dst");

                one_item_price = Convert.ToDouble(Program.ds.Tables["Tbl_barcode_Items_prices_dst"].Rows[0]["Price"]);

                total = one_item_price * pair.Value;
                Lst_amouts.Add(total);
               
            }

            //Inserting values
            foreach (double item in Lst_amouts)
            {
                graphics.DrawString(item.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, initial_value_of_position04));
                initial_value_of_position04 = initial_value_of_position04 + 20;
            }


            ///
            /// Footer
            /// 

            graphics.DrawString("-------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black,new Point(0, initial_value_of_position04 + 20));

            graphics.DrawString("Developed by Ravidu Sandesh", new Font("Arial", 4, FontStyle.Regular), Brushes.Black, new Point(120, initial_value_of_position04 + 40));
            graphics.DrawString("Contact: 077 1634350", new Font("Arial", 3, FontStyle.Regular), Brushes.Black, new Point(137, initial_value_of_position04 + 50));

            ///
            /// clearing all variables and complete main form
            /// 
            Public_Items.non_barcodeItem_Names.Clear();
            Public_Items.non_barcodeItem_Price.Clear();
            Public_Items.non_barcodeItem_qty.Clear();
            Public_Items.Amount.Clear();
            Public_Items.ItemNames = "";

            Public_Items.barcode_item_names.Clear();
            Public_Items.barcode.Clear();
            Public_Items.barcode_Item_price.Clear();
            Public_Items.barcode_item_prices_02.Clear();
            Public_Items.Barcode_item_name_and_qty.Clear();

            Public_Items.Globale_index_of_selected_itemBarcode = 0;
            Public_Items.barcodeItemThatSelectedToRemove = "";

            lbxIncluded_items_to_the_bill.Items.Clear();
            tbxTotal.Text = "0";
            tbxQty.Text = "0";
            tbxBalance.Clear();
            tbxPaidAmount.Clear();
            cmbPayment_method.Text = "Please select";

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_FormClosing(object sender, FormClosingEventArgs e)
        {

            // step 01 || Display bill details in data grid view
            if (Program.ds.Tables["TblBills_dst"] != null)
            {
                Program.ds.Tables["TblBills_dst"].Clear();
                Dgv.Refresh();
            }


            Program.da = new SqlDataAdapter("SELECT * FROM TblBills", Program.con);
            Program.da.Fill(Program.ds, "TblBills_dst");

            Dgv.DataSource = Program.ds.Tables["TblBills_dst"];


            // step 02 || Bill no calculating

            if (Program.ds.Tables["TBLlast_bill_No_dst"] != null)
            {
                Program.ds.Tables["TBLlast_bill_No_dst"].Clear();
            }

            Program.da = new SqlDataAdapter("SELECT TOP 1 Bill_no FROM TblBills ORDER BY Bill_no DESC", Program.con);
            Program.da.Fill(Program.ds, "TBLlast_bill_No_dst");

            int Last_bill_No = 0;
            int Row_count = Program.ds.Tables["TBLlast_bill_No_dst"].Rows.Count;

            if (Row_count <= 0)
            {
                Last_bill_No++;
            }
            else
            {
                Last_bill_No = Convert.ToInt16(Program.ds.Tables["TBLlast_bill_No_dst"].Rows[0]["Bill_no"]);
                Last_bill_No = Last_bill_No + 1;

            }

            lblBill_No.Text = Last_bill_No.ToString();


        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            //printPreviewDialog1.Close();
        }
    }
}
