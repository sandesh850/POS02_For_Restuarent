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
    public partial class frmUpdateLogin : Form
    {
        public frmUpdateLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            // use to stop the data repetition
            if (Program.ds.Tables["TblLogin_details_dst"] != null)
            {
                Program.ds.Tables["TblLogin_details_dst"].Clear();
            }

            // retrieving data
            Program.da = new SqlDataAdapter ("SELECT * FROM TblLogin_details", Program.con);
            Program.da.Fill(Program.ds, "TblLogin_details_dst");

            foreach(DataRow data in Program.ds.Tables["TblLogin_details_dst"].Rows)
            {
               username = data["Username"].ToString();
               password = data["password"].ToString();
            }

            // use to check the logins
            if(tbxCurrentUserName.Text == username && tbxCurrentPassword.Text == password)
            {
                grbNewLogins.Enabled = true;
                btnSave.Enabled = true;

                tbxCurrentUserName.Clear();
                tbxCurrentPassword.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCurrentUserName.Clear();
                tbxCurrentPassword.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbxNewUsername.Text != string.Empty && tbxNewpassword.Text != string.Empty)
            {
                Program.cmd.Connection = Program.con;
                Program.con.Open();
                Program.cmd.CommandText = "UPDATE TblLogin_details SET Username='" + tbxNewUsername.Text + "',password = '" + tbxNewpassword.Text + "' ";
                Program.cmd.ExecuteNonQuery();
                Program.con.Close();

                MessageBox.Show("Successfully updated", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tbxNewUsername.Clear();
                tbxNewpassword.Clear();
                grbNewLogins.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }
    }
}
