using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmNewListing : Form
    {
        public frmNewListing()
        {
            InitializeComponent();
        }

        public int sellerID;

        private void frmNewListing_Load(object sender, EventArgs e)
        {
            cboMake.Items.Add("Honda");
            cboMake.Items.Add("Toyota");
            cboMake.Items.Add("BMW");
            cboMake.Items.Add("Mercedes");
            cboMake.SelectedIndex = 0;
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMake = cboMake.Text;
            switch (selectedMake)
            {
                case "Honda":
                    lblMakeSpecific.Text = "Battery Cap:";
                    lblMakeSpecific.Tag = "Battery Cap";
                    break;
                case "Toyota":
                    lblMakeSpecific.Text = "Mileage:";
                    lblMakeSpecific.Tag = "Mileage";
                    break;
                case "BMW":
                    lblMakeSpecific.Text = "Engine:";
                    lblMakeSpecific.Tag = "Engine";
                    break;
                case "Mercedes":
                    lblMakeSpecific.Text = "Horsepower:";
                    lblMakeSpecific.Tag = "Horsepower";
                    break;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SqlConnection connection = ListingsDB.GetConnection();

                // Construction of the INSERT statement
                string insertStatement =
                    "INSERT INTO Cars (SellerID, ListingDate, Make, Model, Color, Age, Price, ";
                switch(cboMake.Text)
                {
                    case "Honda":
                        insertStatement += "BatteryCap) ";
                        break;
                    case "Toyota":
                        insertStatement += "Mileage) ";
                        break;
                    case "BMW":
                        insertStatement += "Engine) ";
                        break;
                    case "Mercedes":
                        insertStatement += "Horsepower) ";
                        break;
                }
                insertStatement += "VALUES (" + sellerID.ToString() + ", GETDATE(), " +
                    "'" + cboMake.Text + "', " +
                    "'" + txtModel.Text + "', " +
                    "'" + txtColor.Text + "', " +
                    txtAge.Text + ", " +
                    txtPrice.Text + "," +
                    "'" + txtMakeSpecific.Text + "')";
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                try
                {
                    connection.Open();
                    int result = insertCommand.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error creating listing.");
                    }

                    else
                    {
                        MessageBox.Show("Listing successfully added.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                finally
                {
                    connection.Close();
                }
                this.Close();
            }
        }

        private void ClearTextBoxes()
        {
            txtModel.Clear();
            txtColor.Clear();
            txtAge.Clear();
            txtPrice.Clear();
            txtMakeSpecific.Clear();
        }

        private bool IsValidData()
        {
            if (!IsPresent(txtModel) ||
                !IsPresent(txtColor) ||
                !IsPresent(txtAge) ||
                !IsPresent(txtPrice) ||
                !IsPresent(txtMakeSpecific))
            {
                return false;
            }

            if(!IsInt32(txtAge))
                return false;

            if (!IsDecimal(txtPrice))
                return false;

            if(cboMake.Text == "Toyota" && !IsInt32(txtMakeSpecific))
                return false;

            if(cboMake.Text == "Mercedes" && !IsInt32(txtMakeSpecific))
                return false;

            if(cboMake.Text == "Honda" && !IsDecimal(txtMakeSpecific))
                return false;

            return true;
        }

        private bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required value.", "Entry Error");
                return false;
            }
            else
                return true;
        }

        private bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(textBox.Tag + " must be an integer value.");
                return false;
            }
        }

        private bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.");
                return false;
            }
        }      
    }
}
