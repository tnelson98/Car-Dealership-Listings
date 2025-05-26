using CarDealership.CarDealershipDataSetTableAdapters;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public int userID;
        public string username;

        private bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag.ToString() + " is a required field.", "Entry Error");
                return false;
            }
            else
                return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtUsername) && IsPresent(txtPassword))
            {
                username = txtUsername.Text;
                string password = txtPassword.Text;
                try
                {
                    // Check if a user with the username exists- passwords can be duplicates
                    int resultRows = this.usersTableAdapter.DoesUsernameExist(this.carDealershipDataSet.Users, username);

                    // If no existing user exists, create the new user and get its new userID (current identity value)
                    if (resultRows == 0)
                    {
                        this.usersTableAdapter.InsertNewUser(username, password);
                        int identity = (int)this.usersTableAdapter.GetLastIdentity();
                        userID = identity;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A user with that name already exists.", "Duplicate Username");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsPresent(txtUsername) && IsPresent(txtPassword))
            {
                username = txtUsername.Text;
                string password = txtPassword.Text;
                try
                {
                    // Verify that a user with the given username and password exists
                    int resultRows = this.usersTableAdapter.VerifyLogin(this.carDealershipDataSet.Users, username, password);
                    if (resultRows == 1)
                    {
                        // Perform a SELECT statement to get the user's ID
                        SqlConnection connection = ListingsDB.GetConnection();
                        string selectStatement =
                            "SELECT UserID FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                        connection.Open();
                        SqlDataReader reader = selectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            userID = (int)reader["UserID"];
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid login credentials.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
