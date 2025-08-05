using System.Windows.Forms;

namespace POS02_For_Restuarent
{
    partial class frmMainForm
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbxSearchIncluded_Items = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxIncluded_items_to_the_bill = new System.Windows.Forms.ListBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lbxNone_barcode_Items_search = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoginConfig = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBill_No = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbPayment_method = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPaidAmount = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSumOfBarcodeItems = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbxTesting = new System.Windows.Forms.ListBox();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Location = new System.Drawing.Point(14, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.tbxSearchIncluded_Items);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.btnRemove);
            this.panel10.Controls.Add(this.lbxIncluded_items_to_the_bill);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.btnEnter);
            this.panel10.Controls.Add(this.lbxNone_barcode_Items_search);
            this.panel10.Controls.Add(this.tbxSearch);
            this.panel10.Location = new System.Drawing.Point(1078, 143);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(280, 900);
            this.panel10.TabIndex = 2;
            // 
            // tbxSearchIncluded_Items
            // 
            this.tbxSearchIncluded_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchIncluded_Items.Location = new System.Drawing.Point(13, 508);
            this.tbxSearchIncluded_Items.Multiline = true;
            this.tbxSearchIncluded_Items.Name = "tbxSearchIncluded_Items";
            this.tbxSearchIncluded_Items.Size = new System.Drawing.Size(189, 22);
            this.tbxSearchIncluded_Items.TabIndex = 28;
            this.tbxSearchIncluded_Items.Text = "Search";
            this.tbxSearchIncluded_Items.Click += new System.EventHandler(this.tbxSearchIncluded_Items_Click);
            this.tbxSearchIncluded_Items.TextChanged += new System.EventHandler(this.tbxSearchIncluded_Items_TextChanged);
            this.tbxSearchIncluded_Items.Leave += new System.EventHandler(this.tbxSearchIncluded_Items_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 465);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 29);
            this.label17.TabIndex = 27;
            this.label17.Text = "Included items";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(117, 846);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 37);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxIncluded_items_to_the_bill
            // 
            this.lbxIncluded_items_to_the_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbxIncluded_items_to_the_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxIncluded_items_to_the_bill.FormattingEnabled = true;
            this.lbxIncluded_items_to_the_bill.ItemHeight = 20;
            this.lbxIncluded_items_to_the_bill.Location = new System.Drawing.Point(13, 536);
            this.lbxIncluded_items_to_the_bill.Name = "lbxIncluded_items_to_the_bill";
            this.lbxIncluded_items_to_the_bill.Size = new System.Drawing.Size(251, 304);
            this.lbxIncluded_items_to_the_bill.TabIndex = 4;
            this.lbxIncluded_items_to_the_bill.SelectedIndexChanged += new System.EventHandler(this.lbxIncluded_items_to_the_bill_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Turquoise;
            this.panel11.Location = new System.Drawing.Point(8, 454);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(256, 3);
            this.panel11.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(186, 16);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(73, 32);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbxNone_barcode_Items_search
            // 
            this.lbxNone_barcode_Items_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxNone_barcode_Items_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNone_barcode_Items_search.FormattingEnabled = true;
            this.lbxNone_barcode_Items_search.ItemHeight = 20;
            this.lbxNone_barcode_Items_search.Location = new System.Drawing.Point(8, 70);
            this.lbxNone_barcode_Items_search.Name = "lbxNone_barcode_Items_search";
            this.lbxNone_barcode_Items_search.Size = new System.Drawing.Size(251, 324);
            this.lbxNone_barcode_Items_search.TabIndex = 1;
            this.lbxNone_barcode_Items_search.SelectedIndexChanged += new System.EventHandler(this.lbxNone_barcode_Items_search_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(3, 26);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(172, 27);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.Text = "Search";
            this.tbxSearch.Click += new System.EventHandler(this.tbxSearch_Click);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(316, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurant name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(68, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 29);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1226, 54);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 29);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "Time";
            // 
            // Dgv
            // 
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.BackgroundColor = System.Drawing.Color.OldLace;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 261);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(1060, 783);
            this.Dgv.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnLoginConfig);
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 100);
            this.panel2.TabIndex = 31;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(834, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 56);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoginConfig
            // 
            this.btnLoginConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginConfig.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoginConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginConfig.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginConfig.Location = new System.Drawing.Point(18, 29);
            this.btnLoginConfig.Name = "btnLoginConfig";
            this.btnLoginConfig.Size = new System.Drawing.Size(207, 47);
            this.btnLoginConfig.TabIndex = 28;
            this.btnLoginConfig.Text = "Login Configurations";
            this.btnLoginConfig.UseVisualStyleBackColor = false;
            this.btnLoginConfig.Click += new System.EventHandler(this.btnLoginConfig_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(69, 45);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(143, 85);
            this.btnAddItems.TabIndex = 2;
            this.btnAddItems.Text = "Add items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItems.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.Location = new System.Drawing.Point(247, 45);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(143, 85);
            this.btnUpdateItems.TabIndex = 3;
            this.btnUpdateItems.Text = "Update items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoveItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItems.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(69, 147);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(321, 61);
            this.btnRemoveItems.TabIndex = 4;
            this.btnRemoveItems.Text = "Remove items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // tbxTotal
            // 
            this.tbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(236, 499);
            this.tbxTotal.Multiline = true;
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(200, 22);
            this.tbxTotal.TabIndex = 12;
            this.tbxTotal.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(236, 527);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bill No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 58);
            this.label9.TabIndex = 13;
            this.label9.Text = "Payment \r\nmethod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 693);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // lblBill_No
            // 
            this.lblBill_No.AutoSize = true;
            this.lblBill_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill_No.Location = new System.Drawing.Point(231, 303);
            this.lblBill_No.Name = "lblBill_No";
            this.lblBill_No.Size = new System.Drawing.Size(92, 29);
            this.lblBill_No.TabIndex = 15;
            this.lblBill_No.Text = "Bill No";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Turquoise;
            this.panel6.Location = new System.Drawing.Point(236, 719);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 15;
            // 
            // cmbPayment_method
            // 
            this.cmbPayment_method.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPayment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayment_method.ForeColor = System.Drawing.Color.Turquoise;
            this.cmbPayment_method.FormattingEnabled = true;
            this.cmbPayment_method.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPayment_method.Location = new System.Drawing.Point(236, 689);
            this.cmbPayment_method.Name = "cmbPayment_method";
            this.cmbPayment_method.Size = new System.Drawing.Size(200, 33);
            this.cmbPayment_method.TabIndex = 16;
            this.cmbPayment_method.Text = "Please select";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 785);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Paid amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 785);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = ":";
            // 
            // tbxPaidAmount
            // 
            this.tbxPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaidAmount.Location = new System.Drawing.Point(236, 783);
            this.tbxPaidAmount.Multiline = true;
            this.tbxPaidAmount.Name = "tbxPaidAmount";
            this.tbxPaidAmount.Size = new System.Drawing.Size(200, 22);
            this.tbxPaidAmount.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Turquoise;
            this.panel7.Location = new System.Drawing.Point(236, 811);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 849);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(192, 849);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = ":";
            // 
            // tbxBalance
            // 
            this.tbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBalance.Location = new System.Drawing.Point(236, 847);
            this.tbxBalance.Multiline = true;
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(200, 22);
            this.tbxBalance.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Turquoise;
            this.panel8.Location = new System.Drawing.Point(236, 875);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 3);
            this.panel8.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 29);
            this.label15.TabIndex = 23;
            this.label15.Text = "Barcode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(190, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 29);
            this.label14.TabIndex = 24;
            this.label14.Text = ":";
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBarcode.Location = new System.Drawing.Point(236, 366);
            this.tbxBarcode.Multiline = true;
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(200, 22);
            this.tbxBarcode.TabIndex = 9;
            this.tbxBarcode.TextChanged += new System.EventHandler(this.tbxBarcode_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Turquoise;
            this.panel9.Location = new System.Drawing.Point(236, 394);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 3);
            this.panel9.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(132, 623);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(201, 29);
            this.label16.TabIndex = 25;
            this.label16.Text = "Payment Details";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Turquoise;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(294, 906);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 45);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Qty ";
            // 
            // tbxQty
            // 
            this.tbxQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQty.Location = new System.Drawing.Point(237, 437);
            this.tbxQty.Multiline = true;
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(200, 22);
            this.tbxQty.TabIndex = 33;
            this.tbxQty.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.Location = new System.Drawing.Point(237, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = ":";
            // 
            // btnSumOfBarcodeItems
            // 
            this.btnSumOfBarcodeItems.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSumOfBarcodeItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumOfBarcodeItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumOfBarcodeItems.Location = new System.Drawing.Point(30, 235);
            this.btnSumOfBarcodeItems.Name = "btnSumOfBarcodeItems";
            this.btnSumOfBarcodeItems.Size = new System.Drawing.Size(406, 40);
            this.btnSumOfBarcodeItems.TabIndex = 29;
            this.btnSumOfBarcodeItems.Text = "Sum of Barcode Items";
            this.btnSumOfBarcodeItems.UseVisualStyleBackColor = false;
            this.btnSumOfBarcodeItems.Click += new System.EventHandler(this.btnSumOfBarcodeItems_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSumOfBarcodeItems);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tbxQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.tbxBarcode);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.tbxBalance);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.tbxPaidAmount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbPayment_method);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblBill_No);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tbxTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Location = new System.Drawing.Point(1362, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 1042);
            this.panel1.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbxTesting
            // 
            this.lbxTesting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTesting.FormattingEnabled = true;
            this.lbxTesting.ItemHeight = 20;
            this.lbxTesting.Location = new System.Drawing.Point(747, 290);
            this.lbxTesting.Name = "lbxTesting";
            this.lbxTesting.Size = new System.Drawing.Size(251, 324);
            this.lbxTesting.TabIndex = 32;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1838, 1055);
            this.Controls.Add(this.lbxTesting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.Text = "Main form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListBox lbxNone_barcode_Items_search;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.ListBox lbxIncluded_items_to_the_bill;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoginConfig;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxSearchIncluded_Items;
        private Button btnAddItems;
        private Button btnUpdateItems;
        private Button btnRemoveItems;
        private Label label3;
        private Label label5;
        public TextBox tbxTotal;
        private Panel panel5;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label lblBill_No;
        private Panel panel6;
        private ComboBox cmbPayment_method;
        private Label label11;
        private Label label10;
        private TextBox tbxPaidAmount;
        private Panel panel7;
        private Label label13;
        private Label label12;
        private TextBox tbxBalance;
        private Panel panel8;
        private Label label15;
        private Label label14;
        private TextBox tbxBarcode;
        private Panel panel9;
        private Label label16;
        private Button btnOK;
        private Label label2;
        public TextBox tbxQty;
        private Panel panel4;
        private Label label4;
        private Button btnSumOfBarcodeItems;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ListBox lbxTesting;
    }
}

