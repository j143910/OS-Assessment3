using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalLibrary;

namespace RentalRecordSystemGUI
{
    public partial class RentalRecordSystem : Form
    {
        List<Vehicle> Vehicles = new List<Vehicle>();

        public RentalRecordSystem()
        {
            InitializeComponent();
            // sets date time picker format select year only
            dtpAddVehicleMakeYear.CustomFormat = "yyyy";
        }

        private void fillComboBoxes()
        {
            AddItemsToComboBox(cmbAddFuelPurchaseVehicle);
            AddItemsToComboBox(cmbAddJourneyVehicle);
            AddItemsToComboBox(cmbAddPerDayRentalVehicle);
            AddItemsToComboBox(cmbAddPerKmRentalVehicle);
            AddItemsToComboBox(cmbAddServiceVehicle);
            AddItemsToComboBox(cmbViewVehicleRecords);
        }

        private void AddItemsToComboBox (ComboBox combo)
        {
            // clear combo box
            combo.Items.Clear();
            // add all vehicles to combo box
            foreach(Vehicle v in Vehicles )
            {
                combo.Items.Add(v.RegistrationNo);
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // check all input boxes for Add Vehicle group box
            if (!String.IsNullOrEmpty(txtBoxAddVehicleManufacturer.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxAddVehicleManufacturer.Text) &&
                !String.IsNullOrEmpty(txtBoxAddVehicleModel.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxAddVehicleModel.Text) &&
                !String.IsNullOrEmpty(txtBoxAddVehicleRegistrationNo.Text) &&
                !String.IsNullOrWhiteSpace(txtBoxAddVehicleRegistrationNo.Text))
            {
                // check if registration number is already in records
                if (!Vehicles.Exists(x => x.RegistrationNo == txtBoxAddVehicleRegistrationNo.Text))
                {
                     // add new Vehicle to record system
                    Vehicles.Add(new Vehicle(txtBoxAddVehicleManufacturer.Text, txtBoxAddVehicleModel.Text, dtpAddVehicleMakeYear.Value.Year, txtBoxAddVehicleRegistrationNo.Text));
                }
                else
                {
                    MessageBox.Show("Vehicle already registered");
                }
                // reset all input boxes for Add Vehicle group box
                txtBoxAddVehicleManufacturer.Text = null;
                txtBoxAddVehicleModel.Text = null;
                dtpAddVehicleMakeYear.Value = DateTime.Now;
                txtBoxAddVehicleRegistrationNo.Text = null;
                // Add vehicles to all combo boxes
                fillComboBoxes();
            }
            else
            {
                // requests completion of form
                MessageBox.Show("Please enter all fields");
            }
        }

        private void cmbViewVehicleRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViewVehicleRecords.SelectedIndex > -1)
            {
                // display selected vehicle records
                txtBoxViewVehicleRecord.Text = Vehicles[cmbViewVehicleRecords.SelectedIndex].PrintToScreen();
            }
            else
            {
                // clear vehicle record text box
                txtBoxViewVehicleRecord.Text = "";
            }
        }

        private void btnAddJourney_Click(object sender, EventArgs e)
        {
            if (cmbAddJourneyVehicle.SelectedIndex > -1 && nudAddJourneyDistanceTravelled.Value > 0)
            {
                // add a journey to selected vehicle
                Vehicles[cmbAddJourneyVehicle.SelectedIndex].AddJourney((double)nudAddJourneyDistanceTravelled.Value);
                // reset all inputs for group box
                cmbAddJourneyVehicle.SelectedIndex = -1;
                nudAddJourneyDistanceTravelled.Value = 0;
            }
        }

        private void btnAddFuelPurchase_Click(object sender, EventArgs e)
        {
            if (cmbAddFuelPurchaseVehicle.SelectedIndex > -1 && nudAddFuelPurchaseQuantity.Value > 0 && nudAddFuelPurchaseCost.Value > 0)
            {
                // add a FuelPurchase to selected vehicle
                Vehicles[cmbAddFuelPurchaseVehicle.SelectedIndex].AddFuelPurchase((double)nudAddFuelPurchaseQuantity.Value, (double)nudAddFuelPurchaseCost.Value);
                // reset all inputs for group box
                cmbAddFuelPurchaseVehicle.SelectedIndex = -1;
                nudAddFuelPurchaseQuantity.Value = 0;
                nudAddFuelPurchaseCost.Value = 0;
            }
        }

        private void btnAddPerKmRental_Click(object sender, EventArgs e)
        {
            if (cmbAddPerKmRentalVehicle.SelectedIndex > -1 && nudAddPerKmRentalKmTravelled.Value > 0)
            {
                // add a PerKmRental to selected vehicle
                Vehicles[cmbAddPerKmRentalVehicle.SelectedIndex].AddPerKmRental((double)nudAddPerKmRentalKmTravelled.Value);
                // reset all inputs for group box
                cmbAddPerKmRentalVehicle.SelectedIndex = -1;
                nudAddPerKmRentalKmTravelled.Value = 0;
            }
        }

        private void btnAddPerDayRental_Click(object sender, EventArgs e)
        {
            if (cmbAddPerDayRentalVehicle.SelectedIndex > -1 && nudAddPerDayRentalDaysRented.Value > 0)
            {
                // add a PerDayRental to selected vehicle
                Vehicles[cmbAddPerDayRentalVehicle.SelectedIndex].AddPerDayRental((int)nudAddPerDayRentalDaysRented.Value);
                // reset all inputs for group box
                cmbAddPerDayRentalVehicle.SelectedIndex = -1;
                nudAddPerDayRentalDaysRented.Value = 0;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cmbAddServiceVehicle.SelectedIndex > -1)
            {
                // add a Service to selected vehicle
                Vehicles[cmbAddServiceVehicle.SelectedIndex].AddService();
                // reset all inputs for group box
                cmbAddServiceVehicle.SelectedIndex = -1;
            }
        }

        private void btnViewRecordsRefresh_Click(object sender, EventArgs e)
        {
            if (cmbViewVehicleRecords.SelectedIndex > -1)
            {
                // display selected vehicle records
                txtBoxViewVehicleRecord.Text = Vehicles[cmbViewVehicleRecords.SelectedIndex].PrintToScreen();
            }
            else
            {
                // clear vehicle record text box
                txtBoxViewVehicleRecord.Text = "";
            }
        }
    }
}
