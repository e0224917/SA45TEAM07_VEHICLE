﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM07_VEHICLE
{
    public partial class FormVehicleDetails : BaseForm
    {
        private EnquireVehicleStatusControl enquiryControl;

        public FormVehicleDetails()
        {
            InitializeComponent();
        }

        public FormVehicleDetails(EnquireVehicleStatusControl enquiryControl) : this()
        {
            this.enquiryControl = enquiryControl;
        }

        public void displayVehicleDetailUI()
        {
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enquiryControl.close(this);
        }
    }
}
