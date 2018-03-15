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

            contracts = velibService.GetContracts();

            CitiesList.Items.AddRange(contracts);
        }

        private void CitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationsList.Items.Clear();
            Contract contract = (Contract)CitiesList.SelectedItem;
            lastSearchedStations = velibService.GetStations(contract.Name);
            StationsList.Items.AddRange(lastSearchedStations);
        }

        private void StationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station station = (Station)StationsList.SelectedItem;
            this.AvailableBikesLabel.Text = station.Available_bikes + "";
            this.TotalBikesLabel.Text = station.Bike_stands + "";
        }
    }
}
