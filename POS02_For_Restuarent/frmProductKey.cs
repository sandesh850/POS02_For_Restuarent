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
    public partial class frmProductKey : Form
    {
        public frmProductKey()
        {
            InitializeComponent();
        }

        private void frmProductKey_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Step 01
            double ProductKey = 0;
            int no01 = 20020105;
            int no02 = 20041206;

            if (Program.ds.Tables["TblWarning_dst"] != null)
            {
                Program.ds.Tables["TblWarning_dst"].Clear();
            }

            Program.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM warning",Program.con);
            Program.da.Fill(Program.ds, "TblWarning_dst");

            int rowCount = 0;
            rowCount = Program.ds.Tables["TblWarning_dst"].Rows.Count;

            // Step 02 | Initial step (calculating key when first running of the software)
            if(rowCount <= 0)
            {
                ProductKey = no01 + no02;

                double user_entered_key = 0;
                user_entered_key = Convert.ToDouble(tbxProductKey.Text);
               
                if (user_entered_key == ProductKey)
                {
                    Program.cmd.Connection = Program.con;
                    Program.con.Open();
                    Program.cmd.CommandText = "INSERT INTO warning VALUES('" + user_entered_key + "') ";
                    Program.cmd.ExecuteNonQuery();
                    Program.con.Close();

                    Program.cmd.Connection = Program.con;
                    Program.con.Open();
                    Program.cmd.CommandText = "DELETE FROM Tbltracking";
                    Program.cmd.ExecuteNonQuery();
                    Program.con.Close();

                    MessageBox.Show("Login Success");
                    Application.Exit();
                }

            }
            else// Step 03 | calculating key after intial step
            {
                double user_entered_key = 0;
                user_entered_key = Convert.ToDouble(tbxProductKey.Text);

                double productKey_from_database =0;
                productKey_from_database = Convert.ToDouble( Program.ds.Tables["TblWarning_dst"].Rows[0]["errorNumber"]);
                ProductKey = productKey_from_database * 56;

                if(user_entered_key == ProductKey)
                {
                    Program.cmd.Connection = Program.con;
                    Program.con.Open();
                    Program.cmd.CommandText = "UPDATE warning SET errorNumber= '" + user_entered_key + "'  ";
                    Program.cmd.ExecuteNonQuery();
                    Program.con.Close();

                    Program.cmd.Connection = Program.con;
                    Program.con.Open();
                    Program.cmd.CommandText = "DELETE FROM Tbltracking";
                    Program.cmd.ExecuteNonQuery();
                    Program.con.Close();


                    MessageBox.Show("Authentication Success");
                    MessageBox.Show("Please reopen the software");
                    Application.Exit();
                }

               
            }


        }
    }
}
