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
    public partial class frmMainLogin : Form
    {
        public frmMainLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-5S8MLAI;Initial Catalog=Dbs_POS02_Restaurant;User ID=sa;Password=12;")

            using (SqlConnection con = SQLCon.GetConnection() )
            {
               // Program.cmd.Connection = Program.con;
                var selecting = "SELECT * FROM TblLogin_details";

                using (SqlCommand cmd = new SqlCommand(selecting,con))
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
                                this.Hide();
                                frmMainForm main = new frmMainForm();
                                main.ShowDialog();

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

               // Program.con.Close();


            }

           
           
        }

        private void frmMainLogin_Load(object sender, EventArgs e)
        {
            int rowCont = 0;
           
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-2249HJB;Initial Catalog=Dbs_POS02_Restaurant;User ID=sa;Password=12;"))
            {
                var query = "SELECT * FROM TblLogin_details";

                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            rowCont++;
                        }
                    }

                    if(rowCont == 0)
                    {
                        frmAddLogin add = new frmAddLogin();
                        add.ShowDialog();
                    }
                }
            }
        }
    }
}
