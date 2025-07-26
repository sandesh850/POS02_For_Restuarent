using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS02_For_Restuarent
{
    internal static class Program
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-2249HJB;Initial Catalog=Dbs_POS02_Restaurant;User ID=sa;Password=12;"); // Sub connection string
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds = new DataSet();

       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainForm());

           
        }
    }

    /// <summary>
    /// Our main connection string (my code)
    /// </summary>
    public static class SQLCon
    {
        private static readonly string con = "Data Source=DESKTOP-2249HJB;Initial Catalog=Dbs_POS02_Restaurant;User ID=sa;Password=12;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }

    }
}
