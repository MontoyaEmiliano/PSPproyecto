namespace PSPproyecto
{
    partial class frmPagos
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
            this.bttnContinue = new System.Windows.Forms.Button();
            this.lblCodes = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtRecharge = new System.Windows.Forms.TextBox();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameSchool = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScholarCode = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.grpPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.lblBox);
            this.grpPersonalData.Controls.Add(this.label2);
            this.grpPersonalData.Controls.Add(this.bttnBack);
            this.grpPersonalData.Controls.Add(this.lblScholarCode);
            this.grpPersonalData.Controls.Add(this.label1);
            this.grpPersonalData.Controls.Add(this.lblNameSchool);
            this.grpPersonalData.Controls.Add(this.bttnContinue);
            this.grpPersonalData.Controls.Add(this.lblCodes);
            this.grpPersonalData.Controls.Add(this.lblFolio);
            this.grpPersonalData.Controls.Add(this.txtRecharge);
            this.grpPersonalData.Controls.Add(this.lblSurcharge);
            this.grpPersonalData.Controls.Add(this.lblClassName);
            this.grpPersonalData.Controls.Add(this.txtCourse);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalData.Location = new System.Drawing.Point(32, 12);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(729, 417);
            this.grpPersonalData.TabIndex = 1;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Datos Escolares";
            this.grpPersonalData.Enter += new System.EventHandler(this.grpPersonalData_Enter);
            // 
            // bttnContinue
            // 
            this.bttnContinue.Location = new System.Drawing.Point(589, 348);
            this.bttnContinue.Name = "bttnContinue";
            this.bttnContinue.Size = new System.Drawing.Size(102, 46);
            this.bttnContinue.TabIndex = 11;
            this.bttnContinue.Text = "Continuar";
            this.bttnContinue.UseVisualStyleBackColor = true;
            // 
            // lblCodes
            // 
            this.lblCodes.AutoSize = true;
            this.lblCodes.Location = new System.Drawing.Point(160, 239);
            this.lblCodes.Name = "lblCodes";
            this.lblCodes.Size = new System.Drawing.Size(128, 23);
            this.lblCodes.TabIndex = 9;
            this.lblCodes.Text = "Codigo de Escuela";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(160, 190);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(75, 23);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio pago";
            // 
            // txtRecharge
            // 
            this.txtRecharge.Location = new System.Drawing.Point(318, 128);
            this.txtRecharge.Name = "txtRecharge";
            this.txtRecharge.Size = new System.Drawing.Size(219, 30);
            this.txtRecharge.TabIndex = 6;
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.lblSurcharge.Location = new System.Drawing.Point(160, 134);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(68, 23);
            this.lblSurcharge.TabIndex = 5;
            this.lblSurcharge.Text = "Recargos";
            // 
            // lblClassName
            // 
            this.lblClassName.Location = new System.Drawing.Point(318, 74);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(219, 30);
            this.lblClassName.TabIndex = 4;
            // 
            // txtCourse
            // 
            this.txtCourse.AutoSize = true;
            this.txtCourse.Location = new System.Drawing.Point(160, 80);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(94, 23);
            this.txtCourse.TabIndex = 3;
            this.txtCourse.Text = "Ciclo Escolar";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(171, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblNameSchool
            // 
            this.lblNameSchool.AutoSize = true;
            this.lblNameSchool.Location = new System.Drawing.Point(373, 34);
            this.lblNameSchool.Name = "lblNameSchool";
            this.lblNameSchool.Size = new System.Drawing.Size(103, 23);
            this.lblNameSchool.TabIndex = 18;
            this.lblNameSchool.Text = "Benito Juarez";
            this.lblNameSchool.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "P0001";
            // 
            // lblScholarCode
            // 
            this.lblScholarCode.AutoSize = true;
            this.lblScholarCode.Location = new System.Drawing.Point(405, 239);
            this.lblScholarCode.Name = "lblScholarCode";
            this.lblScholarCode.Size = new System.Drawing.Size(50, 23);
            this.lblScholarCode.TabIndex = 20;
            this.lblScholarCode.Text = "XXXX";
            this.lblScholarCode.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(28, 348);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(94, 46);
            this.bttnBack.TabIndex = 21;
            this.bttnBack.Text = "Atras";
            this.bttnBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "$ XXXX";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Location = new System.Drawing.Point(160, 286);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(105, 23);
            this.lblBox.TabIndex = 23;
            this.lblBox.Text = "Fondo de Caja";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPersonalData);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.Button bttnContinue;
        private System.Windows.Forms.Label lblCodes;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtRecharge;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.TextBox lblClassName;
        private System.Windows.Forms.Label txtCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScholarCode;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Label label2;
    }
}