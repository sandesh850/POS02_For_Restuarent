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
    public partial class frmAddBarcode_Items : Form
    {
        public frmAddBarcode_Items()
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

        private void frmAddBarcode_Items_Load(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void frmAddBarcode_Items_Click(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void tbxQty_Click(object sender, EventArgs e)
        {
            lblTotal_Items.Visible = true;
        }

        private void tbxQty_TextChanged(object sender, EventArgs e)
        {
            lblTotal_Items.Visible = true;
        }

        private void tbxprice_TextChanged(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = true;
        }

        private void tbxQty_Leave(object sender, EventArgs e)
        {
            lblTotal_Items.Visible = false;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            /// The following code use to count the Barcode Item ID (BitemID)
            if (Program.ds.Tables["TblLastBitemID_dst"] != null)
            {
                Program.ds.Tables["TblLastBitemID_dst"].Clear();
            }

            Program.da = new SqlDataAdapter("SELECT TOP 1 BitemID FROM TblBarcode_Items ORDER BY BitemID DESC",Program.con);
            Program.da.Fill(Program.ds, "TblLastBitemID_dst");

            int BitemID = 0; 

            foreach (DataRow LastBitemID in Program.ds.Tables["TblLastBitemID_dst"].Rows)
            {
                BitemID = Convert.ToInt32(LastBitemID["BitemID"]);


            }

            BitemID = BitemID + 1;

           /// The following code use to store the data in database (TblBarcode_Items)
           if(tbxBarcode.Text != string.Empty && tbxQty.Text != string.Empty && tbxprice.Text != string.Empty)
           {
                try
                {
                    using (SqlConnection con = SQLCon.GetConnection())
                    {
                        var query = "INSERT INTO TblBarcode_Items VALUES(@Barcode,@BitemID,@Price,@Qty,@ItemName)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BitemID", BitemID);
                            cmd.Parameters.AddWithValue("@Barcode", tbxBarcode.Text);
                            cmd.Parameters.AddWithValue("@Price", tbxprice.Text);
                            cmd.Parameters.AddWithValue("@Qty", tbxItemName.Text);
                            cmd.Parameters.AddWithValue("@ItemName", tbxQty.Text);

                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();


                        }
                    }



                    MessageBox.Show("Details successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxBarcode.Clear();
                    tbxQty.Clear();
                    tbxprice.Clear();
                    tbxItemName.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
           }
           else
           {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

          
        }
    }
    
}
