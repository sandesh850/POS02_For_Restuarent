namespace POS02_For_Restuarent
{
    partial class frmRemove_other_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemove_other_items));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove_Items = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxItemPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxItemNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove_Items);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxItemPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxItemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(234, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 271);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // btnRemove_Items
            // 
            this.btnRemove_Items.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove_Items.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Items.Location = new System.Drawing.Point(371, 210);
            this.btnRemove_Items.Name = "btnRemove_Items";
            this.btnRemove_Items.Size = new System.Drawing.Size(140, 39);
            this.btnRemove_Items.TabIndex = 3;
            this.btnRemove_Items.Text = "Remove";
            this.btnRemove_Items.UseVisualStyleBackColor = false;
            this.btnRemove_Items.Click += new System.EventHandler(this.btnRemove_Items_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // tbxItemPrice
            // 
            this.tbxItemPrice.Enabled = false;
            this.tbxItemPrice.Location = new System.Drawing.Point(216, 143);
            this.tbxItemPrice.Name = "tbxItemPrice";
            this.tbxItemPrice.Size = new System.Drawing.Size(295, 26);
            this.tbxItemPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // tbxItemName
            // 
            this.tbxItemName.Enabled = false;
            this.tbxItemName.Location = new System.Drawing.Point(216, 65);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(295, 26);
            this.tbxItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item name";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(27, 116);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(189, 22);
            this.tbxSearch.TabIndex = 16;
            this.tbxSearch.Text = "Search";
            this.tbxSearch.Click += new System.EventHandler(this.tbxSearchByUsingBarcode_Click);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // lbxItemNames
            // 
            this.lbxItemNames.FormattingEnabled = true;
            this.lbxItemNames.ItemHeight = 16;
            this.lbxItemNames.Location = new System.Drawing.Point(27, 158);
            this.lbxItemNames.Name = "lbxItemNames";
            this.lbxItemNames.Size = new System.Drawing.Size(189, 228);
            this.lbxItemNames.TabIndex = 17;
            this.lbxItemNames.TabStop = false;
            this.lbxItemNames.SelectedIndexChanged += new System.EventHandler(this.lbxItemNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Remove Non-Barcode Items";
            // 
            // frmRemove_other_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(811, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxItemNames);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemove_other_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRemove_other_items_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove_Items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxItemPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxItemNames;
        private System.Windows.Forms.Label label1;
    }
}