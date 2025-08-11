using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POS02_For_Restuarent
{
   
    internal static class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds = new DataSet();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                // Loading xml document
                xmlDoc.Load("ConnectionString.xml");
            }
            catch
            {

                MessageBox.Show("You need to register your device", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmXmlCreatingDatabaseConnection xmlDocCopy = new frmXmlCreatingDatabaseConnection();
                xmlDocCopy.ShowDialog();

            }


            // loading xml file
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load("ConnectionString.xml");
            XmlNodeList node = xmlDocument.GetElementsByTagName("Data");

            foreach(XmlNode data in node)
            {
                XmlDetails.DataSource = data["DataSource"].InnerText;
                XmlDetails.Initial_catelog = data["InitialCatelog"].InnerText;
                XmlDetails.UserID = data["UserID"].InnerText;
                XmlDetails.password = data["Password"].InnerText;
            }

            con = new SqlConnection($"Data Source={XmlDetails.DataSource};Initial Catalog={XmlDetails.Initial_catelog};User ID={XmlDetails.UserID};Password={XmlDetails.password};"); // Sub connection string (widly used)

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainLogin());
        }

        

    }

    public class XmlDetails
    {
        public static string DataSource = "";
        public static string Initial_catelog = "";
        public static string UserID = "";
        public static string password = "";
    }

    /// <summary>
    /// Our main connection string (my code)
    /// </summary>
    public static class SQLCon
    {
        private static readonly string con = $"Data Source={XmlDetails.DataSource};Initial Catalog={XmlDetails.Initial_catelog};User ID={XmlDetails.UserID};Password={XmlDetails.password}";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }

    }
}
