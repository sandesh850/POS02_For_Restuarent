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
    public partial class frmAddLogin : Form
    {

        public frmAddLogin()
        {
            InitializeComponent();
        }

        private void frmAddLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbxNewPassword.Text != tbxConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirm password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(tbxNewUserName.Text == string.Empty)
            {
                MessageBox.Show("Please type a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNewUserName.Focus();
            }
            else if(tbxNewPassword.Text == string.Empty)
            {
                MessageBox.Show("Please type a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNewPassword.Focus();
            }
            else
            {
                using (SqlConnection con = SQLCon.GetConnection())
                {
                    var query = "INSERT INTO TblLogin_details VALUES(@UserName,@Password) ";

                    using(SqlCommand cmd = new SqlCommand(query,con))
                    {
                        cmd.Parameters.AddWithValue("@UserName",tbxNewUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", tbxNewPassword.Text);

                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }

                MessageBox.Show("Login details are successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxNewUserName.Clear();
                tbxConfirmPassword.Clear();
                tbxNewPassword.Clear();
            }
        }
    }
}
