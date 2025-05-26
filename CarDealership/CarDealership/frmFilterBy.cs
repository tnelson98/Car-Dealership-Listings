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
    public partial class frmFilterBy : Form
    {
        public frmFilterBy()
        {
            InitializeComponent();
        }

        public string filterType;
        public string filterValue;

        private void frmFilterBy_Load(object sender, EventArgs e)
        {
            cboFilterType.Items.Add("Make");
            cboFilterType.Items.Add("Model");
            cboFilterType.Items.Add("Color");
            cboFilterType.Items.Add("Age");
            cboFilterType.Items.Add("Price");
            cboFilterType.SelectedIndex = 0;
        }

        private void cboFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterValue.Items.Clear();
            filterType = cboFilterType.SelectedItem.ToString();

            // Age and Price filter options should be set ranges, regardless of database
            if (filterType == "Age")
            {
                cboFilterValue.Items.Add("Under 10");
                cboFilterValue.Items.Add("10 to 25");
                cboFilterValue.Items.Add("26 to 50");
                cboFilterValue.Items.Add("Over 50");
            }

            else if (filterType == "Price")
            {
                cboFilterValue.Items.Add("Under $5000");
                cboFilterValue.Items.Add("$5000 to $10000");
                cboFilterValue.Items.Add("Over $10000");
            }

            // Make, Model, and Color filter options should create
            // options based on what exists in the database
            else
            {
                SqlConnection connection = ListingsDB.GetConnection();
                string selectStatement =
                    "SELECT DISTINCT " + filterType + " FROM Cars";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        cboFilterValue.Items.Add(reader[filterType]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (IsPresent(cboFilterValue))
            {
                filterValue = cboFilterValue.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool IsPresent(ComboBox comboBox)
        {
            if (comboBox.Text == "")
            {
                MessageBox.Show("Please select a property to filter by.");
                return false;
            }
            else
                return true;
        }
    }
}
