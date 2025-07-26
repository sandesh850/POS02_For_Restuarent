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

namespace POS02_For_Restuarent
{
    public partial class frmUpdate_barcodeItems: Form
    {
        public frmUpdate_barcodeItems()
        {
            InitializeComponent();
        }

        private void tbxprice_Click(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = true;
        }

        private void tbxprice_Leave(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void frmUpdate_barcodeItems_Load(object sender, EventArgs e)
        {
            if (Program.ds.Tables["TblBarcodes_dst"] != null)
            {
                Program.ds.Tables["TblBarcodes_dst"].Clear();
            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT Barcode FROM TblBarcode_Items", Program.con);
            Program.da.Fill(Program.ds, "TblBarcodes_dst");

            foreach(DataRow Barcodes in Program.ds.Tables["TblBarcodes_dst"].Rows)
            {
                lbxBarcodes.Items.Add(Barcodes["Barcode"]);
            }
        }

        private void frmUpdate_barcodeItems_Click(object sender, EventArgs e)
        {
            
            lblPrice_of_a_single_item.Visible = false;
        }

        private void tbxSearchByUsingBarcode_Click(object sender, EventArgs e)
        {
            tbxSearchByUsingBarcode.Clear();
        }

        private void tbxSearchByUsingBarcode_Leave(object sender, EventArgs e)
        {
            tbxSearchByUsingBarcode.Text = "Search";
        }

        private void tbxSearchByUsingBarcode_TextChanged(object sender, EventArgs e)
        {

            if (Program.ds.Tables["TblBarcodes_dst"] != null)
            {
                Program.ds.Tables["TblBarcodes_dst"].Clear();
                lbxBarcodes.Items.Clear();
                lbxBarcodes.Refresh();

            }

            if (tbxSearchByUsingBarcode.Text != "Search")
            {

                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT Barcode FROM TblBarcode_Items WHERE Barcode LIKE '%" + tbxSearchByUsingBarcode.Text + "%' ", Program.con);
                Program.da.Fill(Program.ds, "TblBarcodes_dst");

                foreach (DataRow Barcodes in Program.ds.Tables["TblBarcodes_dst"].Rows)
                {
                    lbxBarcodes.Items.Add(Barcodes["Barcode"]);

                }
            }
            else if(tbxSearchByUsingBarcode.Text == "Search")
            {
                if (Program.ds.Tables["TblBarcodes_dst"] != null)
                {
                    Program.ds.Tables["TblBarcodes_dst"].Clear();
                }

                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT Barcode FROM TblBarcode_Items", Program.con);
                Program.da.Fill(Program.ds, "TblBarcodes_dst");

                foreach (DataRow Barcodes in Program.ds.Tables["TblBarcodes_dst"].Rows)
                {
                    lbxBarcodes.Items.Add(Barcodes["Barcode"]);
                }
            }

          

            
            
        }

        private void lbxBarcodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.ds.Tables["TblBarcode_Items_dst"] != null)
            {
                Program.ds.Tables["TblBarcode_Items_dst"].Clear();
                

            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TblBarcode_Items WHERE Barcode='"+lbxBarcodes.SelectedItem+"'  ", Program.con);
            Program.da.Fill(Program.ds, "TblBarcode_Items_dst");

            foreach(DataRow data in Program.ds.Tables["TblBarcode_Items_dst"].Rows)
            {
                tbxBarcode.Text = data["Barcode"].ToString();
                tbxQty.Text = data["Qty"].ToString();
                tbxprice.Text = data["Price"].ToString();
                tbxItemName.Text = data["ItemName"].ToString();
            }
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            if(tbxBarcode.Text != string.Empty)
            {

                try
                {
                    using (SqlConnection con = SQLCon.GetConnection())
                    {
                        var query = "UPDATE TblBarcode_Items SET Qty = @Qty,Price = @Price,ItemName = @Name WHERE Barcode = @Barcode ";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Qty", tbxQty.Text);
                            cmd.Parameters.AddWithValue("@Price", tbxprice.Text);
                            cmd.Parameters.AddWithValue("@Barcode", tbxBarcode.Text);
                            cmd.Parameters.AddWithValue("@Name",tbxItemName.Text);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbxBarcode.Clear();
                            tbxQty.Clear();
                            tbxprice.Clear();
                            tbxItemName.Clear();
                        }


                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               MessageBox.Show("Please select a item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxBarcode.Clear();
            tbxQty.Clear();
            tbxprice.Clear();
            tbxItemName.Clear();
        }
    }
}
