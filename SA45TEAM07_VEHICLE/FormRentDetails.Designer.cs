﻿namespace SA45TEAM07_VEHICLE
{
    partial class FormRentDetails
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbCusName = new System.Windows.Forms.TextBox();
            this.txbNRIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerRent = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStripRentRecordStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRentalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRentInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStripRentRecordStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbPhone);
            this.groupBox1.Controls.Add(this.txbCusName);
            this.groupBox1.Controls.Add(this.txbNRIC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(630, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(435, 46);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(94, 28);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(246, 203);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(282, 27);
            this.txbEmail.TabIndex = 15;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(246, 152);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(282, 27);
            this.txbPhone.TabIndex = 14;
            // 
            // txbCusName
            // 
            this.txbCusName.Location = new System.Drawing.Point(246, 100);
            this.txbCusName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.ReadOnly = true;
            this.txbCusName.Size = new System.Drawing.Size(282, 27);
            this.txbCusName.TabIndex = 13;
            this.txbCusName.TextChanged += new System.EventHandler(this.txbCusName_TextChanged);
            // 
            // txbNRIC
            // 
            this.txbNRIC.Location = new System.Drawing.Point(246, 44);
            this.txbNRIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNRIC.Name = "txbNRIC";
            this.txbNRIC.Size = new System.Drawing.Size(175, 27);
            this.txbNRIC.TabIndex = 12;
            this.txbNRIC.TextChanged += new System.EventHandler(this.txbNRIC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "NRIC/FIN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePickerDue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePickerRent);
            this.groupBox2.Location = new System.Drawing.Point(49, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(630, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Return Date:";
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDue.Location = new System.Drawing.Point(246, 102);
            this.dateTimePickerDue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDue.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerDue.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rent Date:";
            // 
            // dateTimePickerRent
            // 
            this.dateTimePickerRent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRent.Location = new System.Drawing.Point(246, 53);
            this.dateTimePickerRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRent.MinDate = new System.DateTime(1980, 2, 23, 0, 0, 0, 0);
            this.dateTimePickerRent.Name = "dateTimePickerRent";
            this.dateTimePickerRent.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerRent.TabIndex = 0;
            this.dateTimePickerRent.ValueChanged += new System.EventHandler(this.dateTimePickerRent_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(180, 516);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(132, 37);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 516);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStripRentRecordStatus
            // 
            this.statusStripRentRecordStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripRentRecordStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRentalStatus,
            this.toolStripStatusLabelRentInfo});
            this.statusStripRentRecordStatus.Location = new System.Drawing.Point(0, 590);
            this.statusStripRentRecordStatus.Name = "statusStripRentRecordStatus";
            this.statusStripRentRecordStatus.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStripRentRecordStatus.Size = new System.Drawing.Size(732, 22);
            this.statusStripRentRecordStatus.TabIndex = 11;
            this.statusStripRentRecordStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRentalStatus
            // 
            this.toolStripStatusLabelRentalStatus.Name = "toolStripStatusLabelRentalStatus";
            this.toolStripStatusLabelRentalStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelRentInfo
            // 
            this.toolStripStatusLabelRentInfo.Name = "toolStripStatusLabelRentInfo";
            this.toolStripStatusLabelRentInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // FormRentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 612);
            this.Controls.Add(this.statusStripRentRecordStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormRentDetails";
            this.Text = "Rent Details";
            this.Load += new System.EventHandler(this.FormRentDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStripRentRecordStatus.ResumeLayout(false);
            this.statusStripRentRecordStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbCusName;
        private System.Windows.Forms.TextBox txbNRIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerRent;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStripRentRecordStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRentalStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRentInfo;
    }
}