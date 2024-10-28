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
<<<<<<< HEAD
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
=======
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.bttnInsert = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
<<<<<<< HEAD
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
=======
            this.grpPersonalData.Controls.Add(this.pctPhoto);
            this.grpPersonalData.Controls.Add(this.bttnLoad);
            this.grpPersonalData.Controls.Add(this.bttnInsert);
            this.grpPersonalData.Controls.Add(this.bttnCancel);
            this.grpPersonalData.Controls.Add(this.bttnDelete);
            this.grpPersonalData.Controls.Add(this.bttnUpdate);
            this.grpPersonalData.Controls.Add(this.bttnSave);
            this.grpPersonalData.Controls.Add(this.txtAdress);
            this.grpPersonalData.Controls.Add(this.lblAdress);
            this.grpPersonalData.Controls.Add(this.txtPhoneNumber);
            this.grpPersonalData.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalData.Controls.Add(this.txtEmail);
            this.grpPersonalData.Controls.Add(this.lblEmail);
            this.grpPersonalData.Controls.Add(this.lblClassName);
            this.grpPersonalData.Controls.Add(this.txtClassName);
            this.grpPersonalData.Controls.Add(this.txtName);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Location = new System.Drawing.Point(48, 22);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(704, 407);
            this.grpPersonalData.TabIndex = 1;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Datos personales";
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(497, 99);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(162, 126);
            this.pctPhoto.TabIndex = 17;
            this.pctPhoto.TabStop = false;
            // 
            // bttnLoad
            // 
            this.bttnLoad.Location = new System.Drawing.Point(367, 201);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(75, 24);
            this.bttnLoad.TabIndex = 16;
            this.bttnLoad.Text = "Cargar";
            this.bttnLoad.UseVisualStyleBackColor = true;
            // 
            // bttnInsert
            // 
            this.bttnInsert.Location = new System.Drawing.Point(367, 99);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(75, 23);
            this.bttnInsert.TabIndex = 15;
            this.bttnInsert.Text = "Nuevo";
            this.bttnInsert.UseVisualStyleBackColor = true;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(349, 344);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 14;
            this.bttnCancel.Text = "Cancelar";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(244, 344);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 13;
            this.bttnDelete.Text = "Eliminar";
            this.bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(139, 344);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(75, 23);
            this.bttnUpdate.TabIndex = 12;
            this.bttnUpdate.Text = "Modificar";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(35, 344);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 11;
            this.bttnSave.Text = "Guardar";
            this.bttnSave.UseVisualStyleBackColor = true;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(100, 234);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(219, 22);
            this.txtAdress.TabIndex = 10;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(32, 240);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(64, 16);
            this.lblAdress.TabIndex = 9;
            this.lblAdress.Text = "Dirección";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(100, 176);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(32, 182);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(61, 16);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblClassName
            // 
            this.lblClassName.Location = new System.Drawing.Point(100, 69);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(219, 22);
            this.lblClassName.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.AutoSize = true;
            this.txtClassName.Location = new System.Drawing.Point(32, 72);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(64, 16);
            this.txtClassName.TabIndex = 3;
            this.txtClassName.Text = "Apellidos";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 2;
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
<<<<<<< HEAD
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
=======
            this.lblName.Location = new System.Drawing.Point(32, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.LightSteelBlue;
=======
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPersonalData);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
<<<<<<< HEAD
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
=======
        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox lblClassName;
        private System.Windows.Forms.Label txtClassName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
>>>>>>> 979fdfb47f19cfc1673cac31fd5b5c750efe25d1
    }
}