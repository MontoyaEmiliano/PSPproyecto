namespace PSPproyecto
{
    partial class frmStudent
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
            this.grpAlumno = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.bttCertificate = new System.Windows.Forms.Button();
            this.bttAddCertificate = new System.Windows.Forms.Button();
            this.bttAddPhoto = new System.Windows.Forms.Button();
            this.bttModify = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.txtExternalKey = new System.Windows.Forms.TextBox();
            this.lblExternalKey = new System.Windows.Forms.Label();
            this.txtPaymentPlan = new System.Windows.Forms.TextBox();
            this.lblPaymentPlan = new System.Windows.Forms.Label();
            this.txtScolarship = new System.Windows.Forms.TextBox();
            this.lblScolarship = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.grpAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAlumno
            // 
            this.grpAlumno.Controls.Add(this.lblId);
            this.grpAlumno.Controls.Add(this.bttCertificate);
            this.grpAlumno.Controls.Add(this.bttAddCertificate);
            this.grpAlumno.Controls.Add(this.bttAddPhoto);
            this.grpAlumno.Controls.Add(this.bttModify);
            this.grpAlumno.Controls.Add(this.bttNew);
            this.grpAlumno.Controls.Add(this.bttSave);
            this.grpAlumno.Controls.Add(this.txtExternalKey);
            this.grpAlumno.Controls.Add(this.lblExternalKey);
            this.grpAlumno.Controls.Add(this.txtPaymentPlan);
            this.grpAlumno.Controls.Add(this.lblPaymentPlan);
            this.grpAlumno.Controls.Add(this.txtScolarship);
            this.grpAlumno.Controls.Add(this.lblScolarship);
            this.grpAlumno.Controls.Add(this.txtAddress);
            this.grpAlumno.Controls.Add(this.lblAddress);
            this.grpAlumno.Controls.Add(this.txtTelephone);
            this.grpAlumno.Controls.Add(this.lblTelephone);
            this.grpAlumno.Controls.Add(this.txtSection);
            this.grpAlumno.Controls.Add(this.lblSection);
            this.grpAlumno.Controls.Add(this.txtGrade);
            this.grpAlumno.Controls.Add(this.lblGrade);
            this.grpAlumno.Controls.Add(this.txtLastName);
            this.grpAlumno.Controls.Add(this.lblLastName);
            this.grpAlumno.Controls.Add(this.txtName);
            this.grpAlumno.Controls.Add(this.lblName);
            this.grpAlumno.Controls.Add(this.pctPhoto);
            this.grpAlumno.Location = new System.Drawing.Point(12, 12);
            this.grpAlumno.Name = "grpAlumno";
            this.grpAlumno.Size = new System.Drawing.Size(605, 287);
            this.grpAlumno.TabIndex = 0;
            this.grpAlumno.TabStop = false;
            this.grpAlumno.Text = "Datos Alumno";
            this.grpAlumno.Enter += new System.EventHandler(this.grpAlumno_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(63, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 13);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id: 0";
            // 
            // bttCertificate
            // 
            this.bttCertificate.Location = new System.Drawing.Point(368, 212);
            this.bttCertificate.Name = "bttCertificate";
            this.bttCertificate.Size = new System.Drawing.Size(131, 45);
            this.bttCertificate.TabIndex = 24;
            this.bttCertificate.Text = "Certificado";
            this.bttCertificate.UseVisualStyleBackColor = true;
            // 
            // bttAddCertificate
            // 
            this.bttAddCertificate.Location = new System.Drawing.Point(505, 161);
            this.bttAddCertificate.Name = "bttAddCertificate";
            this.bttAddCertificate.Size = new System.Drawing.Size(75, 37);
            this.bttAddCertificate.TabIndex = 23;
            this.bttAddCertificate.Text = "Nuevo Cerficado";
            this.bttAddCertificate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttAddCertificate.UseVisualStyleBackColor = true;
            // 
            // bttAddPhoto
            // 
            this.bttAddPhoto.Location = new System.Drawing.Point(505, 132);
            this.bttAddPhoto.Name = "bttAddPhoto";
            this.bttAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.bttAddPhoto.TabIndex = 22;
            this.bttAddPhoto.Text = "Nueva foto";
            this.bttAddPhoto.UseVisualStyleBackColor = true;
            // 
            // bttModify
            // 
            this.bttModify.Location = new System.Drawing.Point(505, 103);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(75, 23);
            this.bttModify.TabIndex = 21;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = true;
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(505, 43);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(75, 23);
            this.bttNew.TabIndex = 20;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = true;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(505, 74);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 19;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // txtExternalKey
            // 
            this.txtExternalKey.Location = new System.Drawing.Point(90, 251);
            this.txtExternalKey.Name = "txtExternalKey";
            this.txtExternalKey.Size = new System.Drawing.Size(272, 20);
            this.txtExternalKey.TabIndex = 18;
            // 
            // lblExternalKey
            // 
            this.lblExternalKey.AutoSize = true;
            this.lblExternalKey.Location = new System.Drawing.Point(9, 254);
            this.lblExternalKey.Name = "lblExternalKey";
            this.lblExternalKey.Size = new System.Drawing.Size(75, 13);
            this.lblExternalKey.TabIndex = 17;
            this.lblExternalKey.Text = "Clave externa:";
            // 
            // txtPaymentPlan
            // 
            this.txtPaymentPlan.Location = new System.Drawing.Point(90, 225);
            this.txtPaymentPlan.Name = "txtPaymentPlan";
            this.txtPaymentPlan.Size = new System.Drawing.Size(272, 20);
            this.txtPaymentPlan.TabIndex = 16;
            // 
            // lblPaymentPlan
            // 
            this.lblPaymentPlan.AutoSize = true;
            this.lblPaymentPlan.Location = new System.Drawing.Point(20, 228);
            this.lblPaymentPlan.Name = "lblPaymentPlan";
            this.lblPaymentPlan.Size = new System.Drawing.Size(64, 13);
            this.lblPaymentPlan.TabIndex = 15;
            this.lblPaymentPlan.Text = "Plan Pagos:";
            // 
            // txtScolarship
            // 
            this.txtScolarship.Location = new System.Drawing.Point(90, 199);
            this.txtScolarship.Name = "txtScolarship";
            this.txtScolarship.Size = new System.Drawing.Size(272, 20);
            this.txtScolarship.TabIndex = 14;
            // 
            // lblScolarship
            // 
            this.lblScolarship.AutoSize = true;
            this.lblScolarship.Location = new System.Drawing.Point(49, 202);
            this.lblScolarship.Name = "lblScolarship";
            this.lblScolarship.Size = new System.Drawing.Size(35, 13);
            this.lblScolarship.TabIndex = 13;
            this.lblScolarship.Text = "Beca:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 173);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 176);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(90, 147);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(272, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(8, 150);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(76, 13);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "Teléfono tutor:";
            this.lblTelephone.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(90, 121);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(272, 20);
            this.txtSection.TabIndex = 8;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(35, 124);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(49, 13);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Sección:";
            this.lblSection.Click += new System.EventHandler(this.lblSection_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(90, 95);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(272, 20);
            this.txtGrade.TabIndex = 6;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(45, 98);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grado:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(272, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(32, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(52, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellidos:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(368, 43);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(131, 153);
            this.pctPhoto.TabIndex = 0;
            this.pctPhoto.TabStop = false;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 311);
            this.Controls.Add(this.grpAlumno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(657, 350);
            this.MinimumSize = new System.Drawing.Size(657, 350);
            this.Name = "frmStudent";
            this.Text = "Datos Alumno";
            this.Load += new System.EventHandler(this.FrmAlumo_Load);
            this.grpAlumno.ResumeLayout(false);
            this.grpAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlumno;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtScolarship;
        private System.Windows.Forms.Label lblScolarship;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button bttCertificate;
        private System.Windows.Forms.Button bttAddCertificate;
        private System.Windows.Forms.Button bttAddPhoto;
        private System.Windows.Forms.Button bttModify;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.TextBox txtExternalKey;
        private System.Windows.Forms.Label lblExternalKey;
        private System.Windows.Forms.TextBox txtPaymentPlan;
        private System.Windows.Forms.Label lblPaymentPlan;
        private System.Windows.Forms.Label lblId;
    }
}