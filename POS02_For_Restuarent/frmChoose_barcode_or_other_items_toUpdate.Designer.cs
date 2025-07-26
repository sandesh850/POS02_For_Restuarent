namespace POS02_For_Restuarent
{
    partial class frmChoose_barcode_or_other_items_toUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoose_barcode_or_other_items_toUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate_other_items = new System.Windows.Forms.Button();
            this.btnUpdate_barcode_items = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select an action ";
            // 
            // btnUpdate_other_items
            // 
            this.btnUpdate_other_items.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnUpdate_other_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_other_items.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_other_items.Location = new System.Drawing.Point(408, 145);
            this.btnUpdate_other_items.Name = "btnUpdate_other_items";
            this.btnUpdate_other_items.Size = new System.Drawing.Size(180, 86);
            this.btnUpdate_other_items.TabIndex = 8;
            this.btnUpdate_other_items.Text = "Update Non-Barcode Items";
            this.btnUpdate_other_items.UseVisualStyleBackColor = false;
            this.btnUpdate_other_items.Click += new System.EventHandler(this.btnUpdate_other_items_Click);
            // 
            // btnUpdate_barcode_items
            // 
            this.btnUpdate_barcode_items.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdate_barcode_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_barcode_items.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_barcode_items.Location = new System.Drawing.Point(93, 145);
            this.btnUpdate_barcode_items.Name = "btnUpdate_barcode_items";
            this.btnUpdate_barcode_items.Size = new System.Drawing.Size(180, 86);
            this.btnUpdate_barcode_items.TabIndex = 7;
            this.btnUpdate_barcode_items.Text = "Update barcode items";
            this.btnUpdate_barcode_items.UseVisualStyleBackColor = false;
            this.btnUpdate_barcode_items.Click += new System.EventHandler(this.btnUpdate_barcode_items_Click);
            // 
            // frmChoose_barcode_or_other_items_toUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate_other_items);
            this.Controls.Add(this.btnUpdate_barcode_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChoose_barcode_or_other_items_toUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate_other_items;
        private System.Windows.Forms.Button btnUpdate_barcode_items;
    }
}