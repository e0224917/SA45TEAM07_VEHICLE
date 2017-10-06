﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class EnquireVehicleStatusControl
    {
        private MainControl mainControl;
        private FormSearch searchUI;
        private FormVehicleDetails vehicleDetailUI;

        public EnquireVehicleStatusControl(MainControl mainControl)
        {
            this.mainControl = mainControl;
            this.searchUI = new FormSearch(this);
            searchUI.displaySearchUI(); 
        }

        public MainControl MainControl
        {
            get
            {
                return mainControl;
            }
        }


        public FormSearch SearchUI
        {
            get
            {
                return searchUI;
            }
        }


        public void retrieveVehicle(string plateNum)
        {
            vehicleDetailUI = new FormVehicleDetails(this);

            // if succesful
            if (true)
            {
                vehicleDetailUI.displayVehicleDetailUI();

            }
            else
            {
                // show
            }
        }


        public void close(BaseForm form)
        {
            form.Close();
        }

        public void closeUseCase()
        {
            mainControl.closeUseCase(this);
        }
    }
}
