using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POS02_For_Restuarent
{
    public partial class frmXmlCreatingDatabaseConnection : Form
    {
        public frmXmlCreatingDatabaseConnection()
        {
            InitializeComponent();
        }

        private void tbxdataSource_Click(object sender, EventArgs e)
        {
            lblYourDeviceName.Visible = true;

            if (lblDatabaseName.Visible == true)
            {
                lblDatabaseName.Visible = false;
            }
            else if (lblDatabaseUserID.Visible == true)
            {
                lblDatabaseUserID.Visible = false;
            }
            else if (lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxdataSource_TextChanged(object sender, EventArgs e)
        {
            lblYourDeviceName.Visible = true;

            if (lblDatabaseName.Visible == true)
            {
                lblDatabaseName.Visible = false;
            }
            else if (lblDatabaseUserID.Visible == true)
            { 
                lblDatabaseUserID.Visible = false;
            }
            else if(lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxInitial_Catalog_Click(object sender, EventArgs e)
        {
            lblYourDeviceName.Visible = false;
            lblDatabaseName.Visible = true;

            if (lblYourDeviceName.Visible == true)
            {
                lblYourDeviceName.Visible = false;
            }
            else if (lblDatabaseUserID.Visible == true)
            {
                lblDatabaseUserID.Visible = false;
            }
            else if (lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxInitial_Catalog_TextChanged(object sender, EventArgs e)
        {
            lblYourDeviceName.Visible = false;
            lblDatabaseName.Visible = true;

            if (lblYourDeviceName.Visible == true)
            {
                lblYourDeviceName.Visible = false;
            }
            else if (lblDatabaseUserID.Visible == true)
            {
                lblDatabaseUserID.Visible = false;
            }
            else if (lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxUserId_Click(object sender, EventArgs e)
        {
            lblDatabaseName.Visible = false;
            lblDatabaseUserID.Visible = true;

            if (lblYourDeviceName.Visible == true)
            {
                lblYourDeviceName.Visible = false;
            }
            else if (lblDatabaseName.Visible == true)
            {
                lblDatabaseName.Visible = false;
            }
            else if (lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxUserId_TextChanged(object sender, EventArgs e)
        {
            lblDatabaseName.Visible = false;
            lblDatabaseUserID.Visible = true;

            if (lblYourDeviceName.Visible == true)
            {
                lblYourDeviceName.Visible = false;
            }
            else if (lblDatabaseName.Visible == true)
            {
                lblDatabaseName.Visible = false;
            }
            else if (lblDatabasePassword.Visible == true)
            {
                lblDatabasePassword.Visible = false;
            }
        }

        private void tbxpassword_Click(object sender, EventArgs e)
        {
            lblDatabaseUserID.Visible = false;
            lblDatabasePassword.Visible = true;

            if (lblYourDeviceName.Visible == true)
            {
                lblYourDeviceName.Visible = false;
            }
            else if (lblDatabaseName.Visible == true)
            {
                lblDatabaseName.Visible = false;
            }
            else if (lblDatabaseUserID.Visible == true)
            {
                lblDatabaseUserID.Visible = false;
            }
        }

        private void tbxpassword_TextChanged(object sender, EventArgs e)
        {
            lblDatabaseUserID.Visible = false;
            lblDatabasePassword.Visible = true;
        }

        private void frmXmlCreatingDatabaseConnection_Load(object sender, EventArgs e)
        {
            lblYourDeviceName.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // creating xml document
            XmlDocument xmlDocument = new XmlDocument();

            XmlElement RootElement = xmlDocument.CreateElement("ConnectionStringDetails");
            xmlDocument.AppendChild(RootElement);

            // sub element
            XmlElement SubElement = xmlDocument.CreateElement("Data");

            // chiled element
            XmlElement DataSource = xmlDocument.CreateElement("DataSource");
            DataSource.InnerText = tbxdataSource.Text;
            SubElement.AppendChild(DataSource);

            XmlElement initial_catelog = xmlDocument.CreateElement("InitialCatelog");
            initial_catelog.InnerText = tbxInitial_Catalog.Text;
            SubElement.AppendChild(initial_catelog);


            XmlElement userID = xmlDocument.CreateElement("UserID");
            userID.InnerText = tbxUserId.Text;
            SubElement.AppendChild(userID);

            XmlElement password = xmlDocument.CreateElement("Password");
            password.InnerText = tbxpassword.Text;
            SubElement.AppendChild(password);

            RootElement.AppendChild(SubElement);

            xmlDocument.Save("ConnectionString.xml");

            MessageBox.Show("Data saved successfully", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);


            tbxdataSource.Clear();
            tbxInitial_Catalog.Clear();
            tbxUserId.Clear();
            tbxpassword.Clear();

            MessageBox.Show("Please reopen the software","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
