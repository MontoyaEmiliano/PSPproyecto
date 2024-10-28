namespace PSPproyecto
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFinalAmount = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblScolarship = new System.Windows.Forms.Label();
            this.bttPayment = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttRemove = new System.Windows.Forms.Button();
            this.bttStop = new System.Windows.Forms.Button();
            this.lblNumberOfPayments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttStop);
            this.groupBox1.Controls.Add(this.bttRemove);
            this.groupBox1.Controls.Add(this.bttEdit);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.bttPayment);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Pago";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(6, 16);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(28, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Id: 0";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(6, 31);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(73, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Nombre: Juan";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha: 2024/08/19";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elementos para pagar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 98);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Location = new System.Drawing.Point(6, 44);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(74, 13);
            this.lblFinalAmount.TabIndex = 3;
            this.lblFinalAmount.Text = "Monto Final: 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStudentId);
            this.groupBox4.Controls.Add(this.lblStudentSurname);
            this.groupBox4.Controls.Add(this.lblStudentName);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Estudiante";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(6, 44);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(78, 13);
            this.lblStudentSurname.TabIndex = 2;
            this.lblStudentSurname.Text = "Apellidos: Juan";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblNumberOfPayments);
            this.groupBox5.Controls.Add(this.lblScolarship);
            this.groupBox5.Controls.Add(this.lblFinalAmount);
            this.groupBox5.Controls.Add(this.lblDate);
            this.groupBox5.Location = new System.Drawing.Point(262, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Pago";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lblScolarship
            // 
            this.lblScolarship.AutoSize = true;
            this.lblScolarship.Location = new System.Drawing.Point(113, 16);
            this.lblScolarship.Name = "lblScolarship";
            this.lblScolarship.Size = new System.Drawing.Size(127, 13);
            this.lblScolarship.TabIndex = 4;
            this.lblScolarship.Text = "Porcentaje de Beca: 10%";
            // 
            // bttPayment
            // 
            this.bttPayment.Location = new System.Drawing.Point(629, 397);
            this.bttPayment.Name = "bttPayment";
            this.bttPayment.Size = new System.Drawing.Size(109, 23);
            this.bttPayment.TabIndex = 5;
            this.bttPayment.Text = "Realizar Pago";
            this.bttPayment.UseVisualStyleBackColor = true;
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(6, 397);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(109, 23);
            this.bttAdd.TabIndex = 6;
            this.bttAdd.Text = "Añadir Concepto";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(121, 397);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(109, 23);
            this.bttEdit.TabIndex = 7;
            this.bttEdit.Text = "Editar Concepto";
            this.bttEdit.UseVisualStyleBackColor = true;
            // 
            // bttRemove
            // 
            this.bttRemove.Location = new System.Drawing.Point(236, 397);
            this.bttRemove.Name = "bttRemove";
            this.bttRemove.Size = new System.Drawing.Size(109, 23);
            this.bttRemove.TabIndex = 8;
            this.bttRemove.Text = "Eliminar Concepto";
            this.bttRemove.UseVisualStyleBackColor = true;
            // 
            // bttStop
            // 
            this.bttStop.Location = new System.Drawing.Point(351, 397);
            this.bttStop.Name = "bttStop";
            this.bttStop.Size = new System.Drawing.Size(109, 23);
            this.bttStop.TabIndex = 9;
            this.bttStop.Text = "Finalizar Acción";
            this.bttStop.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfPayments
            // 
            this.lblNumberOfPayments.AutoSize = true;
            this.lblNumberOfPayments.Location = new System.Drawing.Point(246, 16);
            this.lblNumberOfPayments.Name = "lblNumberOfPayments";
            this.lblNumberOfPayments.Size = new System.Drawing.Size(130, 13);
            this.lblNumberOfPayments.TabIndex = 5;
            this.lblNumberOfPayments.Text = "Cantidad de Conceptos: 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de pago: Vario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FolioV:  0";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPayment";
            this.Text = "  Generar Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblScolarship;
        private System.Windows.Forms.Button bttPayment;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttStop;
        private System.Windows.Forms.Button bttRemove;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfPayments;
        private System.Windows.Forms.Label label1;
    }
}