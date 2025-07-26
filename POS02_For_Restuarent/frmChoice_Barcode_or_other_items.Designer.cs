namespace POS02_For_Restuarent
{
    partial class frmChoice_Barcode_or_other_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoice_Barcode_or_other_items));
            this.btnAdd_barcode_items = new System.Windows.Forms.Button();
            this.btnAdd_non_barcode_items = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd_barcode_items
            // 
            this.btnAdd_barcode_items.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdd_barcode_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_barcode_items.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_barcode_items.Location = new System.Drawing.Point(103, 138);
            this.btnAdd_barcode_items.Name = "btnAdd_barcode_items";
            this.btnAdd_barcode_items.Size = new System.Drawing.Size(180, 86);
            this.btnAdd_barcode_items.TabIndex = 4;
            this.btnAdd_barcode_items.Text = "Add barcode items";
            this.btnAdd_barcode_items.UseVisualStyleBackColor = false;
            this.btnAdd_barcode_items.Click += new System.EventHandler(this.btnAdd_barcode_items_Click);
            // 
            // btnAdd_non_barcode_items
            // 
            this.btnAdd_non_barcode_items.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAdd_non_barcode_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_non_barcode_items.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_non_barcode_items.Location = new System.Drawing.Point(418, 138);
            this.btnAdd_non_barcode_items.Name = "btnAdd_non_barcode_items";
            this.btnAdd_non_barcode_items.Size = new System.Drawing.Size(180, 86);
            this.btnAdd_non_barcode_items.TabIndex = 5;
            this.btnAdd_non_barcode_items.Text = "Add Non-Barcode Items";
            this.btnAdd_non_barcode_items.UseVisualStyleBackColor = false;
            this.btnAdd_non_barcode_items.Click += new System.EventHandler(this.btnAdd_other_items_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select an action ";
            // 
            // frmChoice_Barcode_or_other_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd_non_barcode_items);
            this.Controls.Add(this.btnAdd_barcode_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChoice_Barcode_or_other_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_barcode_items;
        private System.Windows.Forms.Button btnAdd_non_barcode_items;
        private System.Windows.Forms.Label label1;
    }
}