namespace POS02_For_Restuarent
{
    partial class frmUpdateOther_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateOther_items));
            this.tbxSearchByUsing_ItemName = new System.Windows.Forms.TextBox();
            this.lbxItemNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrice_of_a_single_item = new System.Windows.Forms.Label();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxItemPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearchByUsing_ItemName
            // 
            this.tbxSearchByUsing_ItemName.Location = new System.Drawing.Point(26, 113);
            this.tbxSearchByUsing_ItemName.Name = "tbxSearchByUsing_ItemName";
            this.tbxSearchByUsing_ItemName.Size = new System.Drawing.Size(189, 22);
            this.tbxSearchByUsing_ItemName.TabIndex = 0;
            this.tbxSearchByUsing_ItemName.Text = "Search";
            this.tbxSearchByUsing_ItemName.Click += new System.EventHandler(this.tbxSearchByUsingBarcode_Click);
            this.tbxSearchByUsing_ItemName.TextChanged += new System.EventHandler(this.tbxSearchByUsingBarcode_TextChanged);
            this.tbxSearchByUsing_ItemName.Leave += new System.EventHandler(this.tbxSearchByUsingBarcode_Leave);
            // 
            // lbxItemNames
            // 
            this.lbxItemNames.FormattingEnabled = true;
            this.lbxItemNames.ItemHeight = 16;
            this.lbxItemNames.Location = new System.Drawing.Point(26, 155);
            this.lbxItemNames.Name = "lbxItemNames";
            this.lbxItemNames.Size = new System.Drawing.Size(189, 244);
            this.lbxItemNames.TabIndex = 5;
            this.lbxItemNames.TabStop = false;
            this.lbxItemNames.SelectedIndexChanged += new System.EventHandler(this.lbxItemNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Non-Barcode Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrice_of_a_single_item);
            this.groupBox1.Controls.Add(this.btnUpdateItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxItemPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxItemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(233, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update other items";
            // 
            // lblPrice_of_a_single_item
            // 
            this.lblPrice_of_a_single_item.AutoSize = true;
            this.lblPrice_of_a_single_item.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice_of_a_single_item.ForeColor = System.Drawing.Color.Crimson;
            this.lblPrice_of_a_single_item.Location = new System.Drawing.Point(213, 189);
            this.lblPrice_of_a_single_item.Name = "lblPrice_of_a_single_item";
            this.lblPrice_of_a_single_item.Size = new System.Drawing.Size(205, 20);
            this.lblPrice_of_a_single_item.TabIndex = 16;
            this.lblPrice_of_a_single_item.Text = "( Price of a single item )";
            this.lblPrice_of_a_single_item.Visible = false;
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItems.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.Location = new System.Drawing.Point(371, 227);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(140, 39);
            this.btnUpdateItems.TabIndex = 3;
            this.btnUpdateItems.Text = "Update";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
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
            this.tbxItemPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxItemPrice.Location = new System.Drawing.Point(216, 143);
            this.tbxItemPrice.Name = "tbxItemPrice";
            this.tbxItemPrice.Size = new System.Drawing.Size(295, 30);
            this.tbxItemPrice.TabIndex = 2;
            this.tbxItemPrice.Click += new System.EventHandler(this.tbxItemPrice_Click);
            this.tbxItemPrice.TextChanged += new System.EventHandler(this.tbxItemPrice_TextChanged);
            this.tbxItemPrice.Leave += new System.EventHandler(this.tbxItemPrice_Leave);
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
            this.tbxItemName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxItemName.Location = new System.Drawing.Point(216, 65);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(295, 30);
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
            // frmUpdateOther_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(811, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxSearchByUsing_ItemName);
            this.Controls.Add(this.lbxItemNames);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpdateOther_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUpdateOther_items_Load);
            this.Click += new System.EventHandler(this.frmUpdateOther_items_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearchByUsing_ItemName;
        private System.Windows.Forms.ListBox lbxItemNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxItemPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Label lblPrice_of_a_single_item;
    }
}