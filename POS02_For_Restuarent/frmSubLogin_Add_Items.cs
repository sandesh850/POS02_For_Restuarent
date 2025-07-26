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
    public partial class frmSubLogin_Add_Items : Form
    {
        public frmSubLogin_Add_Items()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = SQLCon.GetConnection())
            {
               
                var selecting = "SELECT * FROM TblLogin_details";

                using (SqlCommand cmd = new SqlCommand(selecting, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) // initializing data reader to read the data)
                    {
                        if (reader.Read())
                        {
                            // capturing values
                            string username = reader["Username"].ToString();
                            string password = reader["password"].ToString();

                            // checking the login
                            if (username == tbxUserName.Text && password == tbxPassword.Text)
                            {

                                frmChoice_Barcode_or_other_items choice = new frmChoice_Barcode_or_other_items();
                                choice.ShowDialog();

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbxPassword.Clear();
                                tbxUserName.Clear();
                            }
                        }

                    }
                }

            }



        }
    }
}
