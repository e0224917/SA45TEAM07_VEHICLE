﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class MainControl
    {
        private EnquireVehicleStatusControl enquiryControl;
        private RentVehicleControl rentControl;
        private frmMain portalUI;

        public MainControl()
        {
            if (PortalUI == null)
            {
                PortalUI = new frmMain(this);
                PortalUI.ShowDialog();
            }
        }

        public frmMain PortalUI
        {
            get
            {
                return portalUI;
            }
            set
            {
                portalUI = value;
            }
        }

        public EnquireVehicleStatusControl EnquiryControl
        {
            get
            {
                return enquiryControl;
            }
        }

        public RentVehicleControl RentControl
        {
            get
            {
                return rentControl;
            }
            set
            {
                rentControl = value;
            }
        }

        public void initialiseEnquiryControl()
        {
            this.enquiryControl = new EnquireVehicleStatusControl(this);
        }

    }
}
