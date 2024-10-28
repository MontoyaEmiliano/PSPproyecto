namespace PSPproyecto
{
    partial class frmCatalog
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
            this.grpCatalog = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpCatalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCatalog
            // 
            this.grpCatalog.Controls.Add(this.lblId);
            this.grpCatalog.Controls.Add(this.txtCategory);
            this.grpCatalog.Controls.Add(this.lblCategory);
            this.grpCatalog.Controls.Add(this.txtAmount);
            this.grpCatalog.Controls.Add(this.lblAmount);
            this.grpCatalog.Controls.Add(this.txtDescription);
            this.grpCatalog.Controls.Add(this.lblDescription);
            this.grpCatalog.Location = new System.Drawing.Point(12, 12);
            this.grpCatalog.Name = "grpCatalog";
            this.grpCatalog.Size = new System.Drawing.Size(272, 143);
            this.grpCatalog.TabIndex = 0;
            this.grpCatalog.TabStop = false;
            this.grpCatalog.Text = "Catálogo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(68, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id: 0";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(93, 103);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(167, 20);
            this.txtCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Categoría:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 78);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(167, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(47, 81);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(40, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Monto:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(93, 52);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripción:";
            this.lblDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 167);
            this.Controls.Add(this.grpCatalog);
            this.MaximumSize = new System.Drawing.Size(310, 206);
            this.MinimumSize = new System.Drawing.Size(310, 206);
            this.Name = "frmCatalog";
            this.Text = "frmCatalog";
            this.grpCatalog.ResumeLayout(false);
            this.grpCatalog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCatalog;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}