using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibClientGUI.VelibService;

namespace VelibClientGUI
{
    public partial class VelibGUI : Form
    {
        private VelibServiceClient velibService;
        private Contract[] contracts;
        private Station[] lastSearchedStations;

        public VelibGUI()
        {
            InitializeComponent();
            velibService = new VelibServiceClient();

            //Get different contracts to display available cities
            contracts = velibService.GetContracts();
            CitiesList.Items.AddRange(contracts);
        }

        private void CitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the user changes the selected city, we have to change the stations list
            StationsList.Items.Clear();
            Contract contract = (Contract)CitiesList.SelectedItem;
            lastSearchedStations = velibService.GetStations(contract.Name);
            StationsList.Items.AddRange(lastSearchedStations);
        }

        private void StationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the user changes the selected station, we have to change:
            // * the number of available bikes
            // * the number of total bikes
            //both according to selected station information
            Station station = (Station)StationsList.SelectedItem;
            this.AvailableBikesLabel.Text = station.Available_bikes + "";
            this.TotalBikesLabel.Text = station.Bike_stands + "";
        }
    }
}
