namespace POS02_For_Restuarent
{
    partial class frmChoose_barcode_or_other_items_toRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoose_barcode_or_other_items_toRemove));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove_Remove_Non_barcode_items = new System.Windows.Forms.Button();
            this.btnRemove_barcode_items = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an action ";
            // 
            // btnRemove_Remove_Non_barcode_items
            // 
            this.btnRemove_Remove_Non_barcode_items.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove_Remove_Non_barcode_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove_Remove_Non_barcode_items.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove_Remove_Non_barcode_items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Remove_Non_barcode_items.Location = new System.Drawing.Point(411, 149);
            this.btnRemove_Remove_Non_barcode_items.Name = "btnRemove_Remove_Non_barcode_items";
            this.btnRemove_Remove_Non_barcode_items.Size = new System.Drawing.Size(180, 86);
            this.btnRemove_Remove_Non_barcode_items.TabIndex = 11;
            this.btnRemove_Remove_Non_barcode_items.Text = "Remove Non-Barcode Items";
            this.btnRemove_Remove_Non_barcode_items.UseVisualStyleBackColor = false;
            this.btnRemove_Remove_Non_barcode_items.Click += new System.EventHandler(this.btnRemove_other_items_Click);
            // 
            // btnRemove_barcode_items
            // 
            this.btnRemove_barcode_items.BackColor = System.Drawing.Color.Red;
            this.btnRemove_barcode_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove_barcode_items.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove_barcode_items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_barcode_items.Location = new System.Drawing.Point(96, 149);
            this.btnRemove_barcode_items.Name = "btnRemove_barcode_items";
            this.btnRemove_barcode_items.Size = new System.Drawing.Size(180, 86);
            this.btnRemove_barcode_items.TabIndex = 10;
            this.btnRemove_barcode_items.Text = "Remove barcode items";
            this.btnRemove_barcode_items.UseVisualStyleBackColor = false;
            this.btnRemove_barcode_items.Click += new System.EventHandler(this.btnRemove_barcode_items_Click);
            // 
            // frmChoose_barcode_or_other_items_toRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove_Remove_Non_barcode_items);
            this.Controls.Add(this.btnRemove_barcode_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChoose_barcode_or_other_items_toRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove_Remove_Non_barcode_items;
        private System.Windows.Forms.Button btnRemove_barcode_items;
    }
}