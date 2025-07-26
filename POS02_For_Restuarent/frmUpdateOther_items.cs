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
    public partial class frmUpdateOther_items: Form
    {
        // The following variable is used to identify the item from the table
        int OtherItem_ID = 0; // use to update the other items (Non barcode items)

        public frmUpdateOther_items()
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

        private void frmUpdateOther_items_Click(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = false;
        }

        private void tbxSearchByUsingBarcode_Click(object sender, EventArgs e)
        {
            tbxSearchByUsing_ItemName.Clear();
        }

        private void tbxSearchByUsingBarcode_TextChanged(object sender, EventArgs e)
        {
            lbxItemNames.Items.Clear();
            lbxItemNames.Refresh();

            if (Program.ds.Tables["Tbl_ItemNames_dst"] != null)
            {
                Program.ds.Tables["Tbl_ItemNames_dst"].Clear();
                lbxItemNames.Items.Clear();
                lbxItemNames.Refresh();
            }

            if (tbxSearchByUsing_ItemName.Text != "Search")
            {

                
                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items WHERE ItemName LIKE '%" + tbxSearchByUsing_ItemName.Text + "%' ", Program.con);
                Program.da.Fill(Program.ds, "Tbl_ItemNames_dst");

                foreach (DataRow item_Nmes in Program.ds.Tables["Tbl_ItemNames_dst"].Rows)
                {
                    lbxItemNames.Items.Add(item_Nmes["ItemName"]);
                }
            }
            else if(tbxSearchByUsing_ItemName.Text == "Search")
            {
                if (Program.ds.Tables["TblItemNames_Dst"] != null)
                {
                    Program.ds.Tables["TblItemNames_Dst"].Clear();
                    lbxItemNames.Items.Clear();
                    lbxItemNames.Refresh();
                }

                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items ", Program.con);
                Program.da.Fill(Program.ds, "TblItemNames_Dst");

                foreach (DataRow itemName in Program.ds.Tables["TblItemNames_Dst"].Rows)
                {
                    lbxItemNames.Items.Add(itemName["ItemName"]);
                }
            }


        }

        private void tbxSearchByUsingBarcode_Leave(object sender, EventArgs e)
        {
            tbxSearchByUsing_ItemName.Text = "Search";
        }

        private void frmUpdateOther_items_Load(object sender, EventArgs e)
        {
            if (Program.ds.Tables["TblItemNames_Dst"] != null)
            {
                Program.ds.Tables["TblItemNames_Dst"].Clear();

            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items ",Program.con);
            Program.da.Fill(Program.ds, "TblItemNames_Dst");

            foreach (DataRow itemName in Program.ds.Tables["TblItemNames_Dst"].Rows)
            {
                lbxItemNames.Items.Add(itemName["ItemName"]);
            }
        }

        private void lbxItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.ds.Tables["TblOther_Items_dst"] != null)
            {
                Program.ds.Tables["TblOther_Items_dst"].Clear();

            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TblOther_Items WHERE ItemName='" + lbxItemNames.SelectedItem + "' ", Program.con);
            Program.da.Fill(Program.ds, "TblOther_Items_dst");

            foreach(DataRow data in Program.ds.Tables["TblOther_Items_dst"].Rows)
            {
                OtherItem_ID = Convert.ToInt32(data["OItem_id"]);
                tbxItemName.Text = data["ItemName"].ToString();
                tbxItemPrice.Text = data["Price"].ToString();
            }

            //MessageBox.Show(OtherItem_ID.ToString());
        }

        private void tbxItemPrice_TextChanged(object sender, EventArgs e)
        {
            lblPrice_of_a_single_item.Visible = true;
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection con = SQLCon.GetConnection())
                {
                    var query = "UPDATE TblOther_Items SET ItemName =@ItemName, Price = @Price WHERE OItem_id = @OItem_id ";

                    using(SqlCommand cmd = new SqlCommand(query,con))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", tbxItemName.Text);
                        cmd.Parameters.AddWithValue("@Price",tbxItemPrice.Text);
                        cmd.Parameters.AddWithValue("@OItem_id", OtherItem_ID);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data updated successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
