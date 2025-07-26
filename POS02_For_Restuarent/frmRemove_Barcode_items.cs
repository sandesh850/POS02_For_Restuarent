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
    public partial class frmRemove_Barcode_items: Form
    {
        public frmRemove_Barcode_items()
        {
            InitializeComponent();
        }

        private void frmRemove_Barcode_items_Load(object sender, EventArgs e)
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
            else if (tbxSearchByUsingBarcode.Text == "Search")
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

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TblBarcode_Items WHERE Barcode='" + lbxBarcodes.SelectedItem + "'  ", Program.con);
            Program.da.Fill(Program.ds, "TblBarcode_Items_dst");

            foreach (DataRow data in Program.ds.Tables["TblBarcode_Items_dst"].Rows)
            {
                tbxBarcode.Text = data["Barcode"].ToString();
                tbxQty.Text = data["Qty"].ToString();
                tbxprice.Text = data["Price"].ToString();
            }
        }

        private void btnRemove_Items_Click(object sender, EventArgs e)
        {
            //string yesNo = "";

            // Step 01
            if(DialogResult.Yes == MessageBox.Show("Are you sure about this","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                try
                {
                    // Step 02
                    using (SqlConnection con = SQLCon.GetConnection())
                    {
                        var query = "DELETE FROM TblBarcode_Items WHERE Barcode = @Barcode ";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Barcode", tbxBarcode.Text);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxBarcode.Clear();
                            tbxQty.Clear();
                            tbxprice.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Step 03
                lbxBarcodes.Items.Clear();
                lbxBarcodes.Refresh();

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

          
    }
}
