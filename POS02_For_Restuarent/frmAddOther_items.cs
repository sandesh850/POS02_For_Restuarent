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
    public partial class frmAddOther_items : Form
    {
        public frmAddOther_items()
        {
            InitializeComponent();
        }

        private void tbxItemPrice_Click(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = true;
        }

        private void tbxItemPrice_Leave(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void frmAddOther_items_Click(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void tbxItemPrice_TextChanged(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = true;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //The following code is use to calculate the Non barcode item id(other item id/OItemID)
            if (Program.ds.Tables["TblOItemID_dst"] != null)
            {
                Program.ds.Tables["TblOItemID_dst"].Clear();
            }

            int OItemID = 0;
            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT TOP 1 OItem_id FROM TblOther_Items ORDER BY OItem_id DESC ",Program.con);
            Program.da.Fill(Program.ds, "TblOItemID_dst");

            if (Program.ds.Tables["TblOItemID_dst"].Rows.Count > 0)
            {
                OItemID = Convert.ToInt32(Program.ds.Tables["TblOItemID_dst"].Rows[0]["OItem_id"]);
                OItemID++;
            }
            else
            {
                OItemID++;
            }

            //tbxItemName.Text = OItemID.ToString();

            // The following code is use to insert the data into the database (TblOther_Items)

            if(tbxItemName.Text != string.Empty && tbxItemPrice.Text != string.Empty)
            {
                try
                {
                    using (SqlConnection con = SQLCon.GetConnection())
                    {
                        var query = "INSERT INTO TblOther_Items VALUES(@OItem_id,@ItemName,@Price)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@OItem_id", OItemID);
                            cmd.Parameters.AddWithValue("@ItemName", tbxItemName.Text);
                            cmd.Parameters.AddWithValue("@Price", tbxItemPrice.Text);

                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Details successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxItemName.Clear();
                            tbxItemPrice.Clear();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
               
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
