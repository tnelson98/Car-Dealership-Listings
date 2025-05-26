using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmCarDealership : Form
    {    
        public frmCarDealership()
        {
            InitializeComponent();
        }

        bool loggedIn;
        int userID;

        // Default load includes no make-specific information
        private void frmCarDealership_Load(object sender, EventArgs e)
        {
            List<Listing> listingsList;
            loggedIn = false;
            try
            {
                listingsList = ListingsDB.GetDefaultListings();
                if(listingsList.Count > 0)
                {
                    Listing listing;
                    for (int i = 0; i < listingsList.Count; i++)
                    {
                        listing = listingsList[i];
                        lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                        lvCarListings.Items[i].SubItems.Add(listing.car.Make.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Model.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Color.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        public void ResetColumns()
        {
            lvCarListings.Clear();
            lvCarListings.Columns.Add("Listing Date", 110, HorizontalAlignment.Left);
            lvCarListings.Columns.Add("Make", 90, HorizontalAlignment.Left);
            lvCarListings.Columns.Add("Model", 90, HorizontalAlignment.Left);
            lvCarListings.Columns.Add("Color", 90, HorizontalAlignment.Left);
            lvCarListings.Columns.Add("Age", 90, HorizontalAlignment.Left);
            lvCarListings.Columns.Add("Price", 100, HorizontalAlignment.Left);
        }

        private void btnFilterBy_Click(object sender, EventArgs e)
        {
            List<Listing> filteredListings;
            string filterType;
            string filterValue;

            frmFilterBy testForm = new frmFilterBy();
            var result = testForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                filterType = testForm.filterType;
                filterValue = testForm.filterValue;

                switch (filterType)
                {
                    case "Make":
                        filteredListings = ListingsDB.FilterByMake(filterValue);
                        FillListByMake(filteredListings, filterValue);
                        lblFilterType.Text = "Make: " + filterValue;
                        break;
                    case "Model":
                        filteredListings = ListingsDB.FilterByModel(filterValue);
                        FillListByModel(filteredListings);
                        lblFilterType.Text = "Model: " + filterValue;
                        break;
                    case "Color":
                        filteredListings = ListingsDB.FilterByColor(filterValue);
                        FillListByColor(filteredListings);
                        lblFilterType.Text = "Color: " + filterValue;
                        break;
                    case "Age":
                        filteredListings = ListingsDB.FilterByAgeOrPrice(filterValue);
                        FillListByAgeOrPrice(filteredListings);
                        lblFilterType.Text = "Age: " + filterValue;
                        break;
                    case "Price":
                        filteredListings = ListingsDB.FilterByAgeOrPrice(filterValue);
                        FillListByAgeOrPrice(filteredListings);
                        lblFilterType.Text = "Price " + filterValue;
                        break;
                }
            }
        }

        private void FillListByMake(List<Listing> listings, string filterValue)
        {
            ResetColumns();
            switch (filterValue)
            {
                case "Honda":
                    lvCarListings.Columns.Add("Battery Cap.", 100, HorizontalAlignment.Left);
                    break;
                case "Toyota":
                    lvCarListings.Columns.Add("Mileage", 100, HorizontalAlignment.Left);
                    break;
                case "BMW":
                    lvCarListings.Columns.Add("Engine", 100, HorizontalAlignment.Left);
                    break;
                case "Mercedes":
                    lvCarListings.Columns.Add("Horsepower", 100, HorizontalAlignment.Left);
                    break;
            }
            lvCarListings.Columns.RemoveAt(1);
            if(listings.Count > 0)
            {
                Listing listing;
                for (int i = 0; i  < listings.Count; i++)
                {
                    listing = listings[i];
                    lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                    lvCarListings.Items[i].SubItems.Add(listing.car.Model.ToString());
                    lvCarListings.Items[i].SubItems.Add(listing.car.Color.ToString());
                    lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                    lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
                    switch (filterValue)
                    {
                        case "Honda":
                            Honda tempHonda = (Honda)listing.car;
                            lvCarListings.Items[i].SubItems.Add(tempHonda.BatteryCap.ToString());
                            break;
                        case "Toyota":
                            Toyota tempToyota = (Toyota)listing.car;
                            lvCarListings.Items[i].SubItems.Add(tempToyota.Mileage.ToString());
                            break;
                        case "BMW":
                            BMW tempBMW = (BMW)listing.car;
                            lvCarListings.Items[i].SubItems.Add(tempBMW.Engine);
                            break;
                        case "Mercedes":
                            Mercedes tempMercedes = (Mercedes)listing.car;
                            lvCarListings.Items[i].SubItems.Add(tempMercedes.Horsepower.ToString());
                            break;
                    }
                }
            }
        }

        private void FillListByModel(List<Listing> listings)
        {
            ResetColumns();
            lvCarListings.Columns.RemoveAt(2);
            Listing listing;
            for(int i = 0; i < listings.Count; i++)
            {
                listing = listings[i];
                lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                lvCarListings.Items[i].SubItems.Add(listing.car.Make.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Color.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
            }
        }

        private void FillListByColor(List<Listing> listings)
        {
            ResetColumns();
            lvCarListings.Columns.RemoveAt(3);
            Listing listing;
            for (int i = 0; i < listings.Count; i++)
            {
                listing = listings[i];
                lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                lvCarListings.Items[i].SubItems.Add(listing.car.Make.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Model.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
            }
        }

        private void FillListByAgeOrPrice(List<Listing> listings)
        {
            ResetColumns();
            Listing listing;
            for (int i = 0; i < listings.Count; i++)
            {
                listing = listings[i];
                lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                lvCarListings.Items[i].SubItems.Add(listing.car.Make.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Model.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Color.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetColumns();
            lblFilterType.Text = "Current Filter: None";
            List<Listing> listingsList;
            try
            {
                listingsList = ListingsDB.GetDefaultListings();
                if (listingsList.Count > 0)
                {
                    Listing listing;
                    for (int i = 0; i < listingsList.Count; i++)
                    {
                        listing = listingsList[i];
                        lvCarListings.Items.Add(listing.listDate.ToString("MM/dd/yyyy"));
                        lvCarListings.Items[i].SubItems.Add(listing.car.Make.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Model.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Color.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Age.ToString());
                        lvCarListings.Items[i].SubItems.Add(listing.car.Price.ToString("c"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void btnUserListings_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                frmUserListings userListings = new frmUserListings();
                userListings.userID = userID;
                var result = userListings.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!loggedIn)
            {
                frmLogin loginForm = new frmLogin();
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    userID = loginForm.userID;
                    lblLogin.Text = "Welcome " + loginForm.username + "!";
                    btnUserListings.Enabled = true;
                    btnLogin.Enabled = false;
                    btnCreateListing.Enabled = true;
                    loggedIn = true;
                }
            }
        }

        private void btnCreateListing_Click(object sender, EventArgs e)
        {
            if(loggedIn)
            {
                frmNewListing newListingForm = new frmNewListing();
                newListingForm.sellerID = userID;
                var result = newListingForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    btnReset.PerformClick();
                }
            }
        }
    }
}
