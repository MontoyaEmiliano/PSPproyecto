﻿namespace PSPproyecto
{
    partial class frmColegiatura
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
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.bttnContinue2 = new System.Windows.Forms.Button();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.grpPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.txtAmount2);
            this.grpPersonalData.Controls.Add(this.dateTimePicker1);
            this.grpPersonalData.Controls.Add(this.bttnMenu);
            this.grpPersonalData.Controls.Add(this.bttnContinue2);
            this.grpPersonalData.Controls.Add(this.lblAmount2);
            this.grpPersonalData.Controls.Add(this.txtAmount);
            this.grpPersonalData.Controls.Add(this.lblSection);
            this.grpPersonalData.Controls.Add(this.lblDescription);
            this.grpPersonalData.Controls.Add(this.txtPlan);
            this.grpPersonalData.Controls.Add(this.lblMonth);
            this.grpPersonalData.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalData.Location = new System.Drawing.Point(35, 12);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(729, 417);
            this.grpPersonalData.TabIndex = 3;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Generar Colegiatura";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 30);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // bttnMenu
            // 
            this.bttnMenu.Location = new System.Drawing.Point(28, 348);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Size = new System.Drawing.Size(94, 46);
            this.bttnMenu.TabIndex = 21;
            this.bttnMenu.Text = "Menú";
            this.bttnMenu.UseVisualStyleBackColor = true;
            // 
            // bttnContinue2
            // 
            this.bttnContinue2.Location = new System.Drawing.Point(589, 348);
            this.bttnContinue2.Name = "bttnContinue2";
            this.bttnContinue2.Size = new System.Drawing.Size(102, 46);
            this.bttnContinue2.TabIndex = 11;
            this.bttnContinue2.Text = "Continuar";
            this.bttnContinue2.UseVisualStyleBackColor = true;
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Location = new System.Drawing.Point(160, 230);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(51, 23);
            this.lblAmount2.TabIndex = 7;
            this.lblAmount2.Text = "Monto";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(318, 168);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(219, 30);
            this.txtAmount.TabIndex = 6;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(160, 174);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(59, 23);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Sección";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(318, 114);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(219, 30);
            this.lblDescription.TabIndex = 4;
            // 
            // txtPlan
            // 
            this.txtPlan.AutoSize = true;
            this.txtPlan.Location = new System.Drawing.Point(166, 121);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(40, 23);
            this.txtPlan.TabIndex = 3;
            this.txtPlan.Text = "Plan";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(171, 74);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(35, 23);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Mes";
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(318, 223);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(219, 30);
            this.txtAmount2.TabIndex = 28;
            // 
            // frmColegiatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPersonalData);
            this.Name = "frmColegiatura";
            this.Text = "Colegiatura";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.Button bttnMenu;
        private System.Windows.Forms.Button bttnContinue2;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox lblDescription;
        private System.Windows.Forms.Label txtPlan;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAmount2;
    }
}