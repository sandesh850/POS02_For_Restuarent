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
    public partial class frmRemove_other_items: Form
    {
        public frmRemove_other_items()
        {
            InitializeComponent();
        }

        private void frmRemove_other_items_Load(object sender, EventArgs e)
        {
            if (Program.ds.Tables["TblItemNames_dst"] != null)
            {
                Program.ds.Tables["TblItemNames_dst"].Clear();
            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items",Program.con);
            Program.da.Fill(Program.ds, "TblItemNames_dst");

            foreach(DataRow itemNames in Program.ds.Tables["TblItemNames_dst"].Rows)
            {
                lbxItemNames.Items.Add(itemNames["ItemName"]);
            }
        }

        private void tbxSearchByUsingBarcode_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            tbxSearch.Text = "Search";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lbxItemNames.Items.Clear();
            lbxItemNames.Refresh();

            if (tbxSearch.Text == "Search")//Step 01
            {
                if (Program.ds.Tables["TblItemNames_dst"] != null)
                {
                    Program.ds.Tables["TblItemNames_dst"].Clear();
                    //lbxItemNames.Items.Clear();
                    //lbxItemNames.Refresh();
                }

                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items", Program.con);
                Program.da.Fill(Program.ds, "TblItemNames_dst");

                foreach (DataRow itemNames in Program.ds.Tables["TblItemNames_dst"].Rows)
                {
                    lbxItemNames.Items.Add(itemNames["ItemName"]);
                }
            }
            else
            {
              
                //Step 02
                if (Program.ds.Tables["TblItemNames_Search_dst"] != null)
                {
                    Program.ds.Tables["TblItemNames_Search_dst"].Clear();
                    //lbxItemNames.Items.Clear();
                    //lbxItemNames.Refresh();
                }

                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items WHERE ItemName LIKE '%" + tbxSearch.Text + "%' ", Program.con);
                Program.da.Fill(Program.ds, "TblItemNames_Search_dst");

                foreach (DataRow itemNames in Program.ds.Tables["TblItemNames_Search_dst"].Rows)
                {
                    lbxItemNames.Items.Add(itemNames["ItemName"]);
                }

            }


        }

        private void lbxItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.ds.Tables["TblOther_Items_dst"] != null)
                {
                    Program.ds.Tables["TblOther_Items_dst"].Clear();
                    //lbxItemNames.Items.Clear();
                    //lbxItemNames.Refresh();
                }


                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TblOther_Items WHERE ItemName='" + lbxItemNames.SelectedItem + "' ", Program.con);
                Program.da.Fill(Program.ds, "TblOther_Items_dst");

                tbxItemName.Text = Program.ds.Tables["TblOther_Items_dst"].Rows[0]["ItemName"].ToString();
                tbxItemPrice.Text = Program.ds.Tables["TblOther_Items_dst"].Rows[0]["Price"].ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Items_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxItemName.Text != string.Empty)//Step 01
                {
                    //Step 02
                    if (DialogResult.Yes == MessageBox.Show("Are you sure about this", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        using (SqlConnection con = SQLCon.GetConnection())
                        {
                            var query = "DELETE FROM TblOther_Items WHERE ItemName=@ItemNameCopy ";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@ItemNameCopy", tbxItemName.Text);
                                con.Open();
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tbxItemName.Clear();
                                tbxItemPrice.Clear();

                                // step 03
                                lbxItemNames.Items.Clear();
                                lbxItemNames.Refresh();
                                if (Program.ds.Tables["TblItemNames_dst"] != null)
                                {
                                    Program.ds.Tables["TblItemNames_dst"].Clear();
                                }

                                Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT ItemName FROM TblOther_Items", Program.con);
                                Program.da.Fill(Program.ds, "TblItemNames_dst");

                                foreach (DataRow itemNames in Program.ds.Tables["TblItemNames_dst"].Rows)
                                {
                                    lbxItemNames.Items.Add(itemNames["ItemName"]);
                                }
                            }
                        }
                    }
                }
                else//Step 04
                {
                    MessageBox.Show("Please select a Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
               
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
