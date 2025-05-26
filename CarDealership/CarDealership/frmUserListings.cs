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
    public partial class frmUserListings : Form
    {
        public frmUserListings()
        {
            InitializeComponent();
        }

        public int userID;

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealershipDataSet);

        }

        private void carsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealershipDataSet);

        }

        private void frmUserListings_Load(object sender, EventArgs e)
        {
            this.carsTableAdapter.FillBySellerID(this.carDealershipDataSet.Cars, userID);
            if(carsBindingSource.Count == 0)
            {
                MessageBox.Show("You have not posted any listings.", "No Listings Found");
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this listing?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    this.carsTableAdapter.DeleteListing(Convert.ToInt32(bindingNavigatorPositionItem.Text));
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtListingDate.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtAge.Clear();
            txtPrice.Clear();
            txtEngine.Clear();
            txtBatteryCap.Clear();
            txtHorsepower.Clear();
            txtMileage.Clear();
        }
    }
}
