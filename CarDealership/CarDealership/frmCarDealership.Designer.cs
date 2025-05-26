namespace CarDealership
{
    partial class frmCarDealership
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvCarListings = new System.Windows.Forms.ListView();
            this.listingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilterBy = new System.Windows.Forms.Button();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUserListings = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCreateListing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCarListings
            // 
            this.lvCarListings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listingDate,
            this.carMake,
            this.carModel,
            this.carColor,
            this.carAge,
            this.carPrice});
            this.lvCarListings.HideSelection = false;
            this.lvCarListings.Location = new System.Drawing.Point(12, 39);
            this.lvCarListings.Name = "lvCarListings";
            this.lvCarListings.Size = new System.Drawing.Size(776, 185);
            this.lvCarListings.TabIndex = 1;
            this.lvCarListings.UseCompatibleStateImageBehavior = false;
            this.lvCarListings.View = System.Windows.Forms.View.Details;
            // 
            // listingDate
            // 
            this.listingDate.Text = "Listing Date";
            this.listingDate.Width = 110;
            // 
            // carMake
            // 
            this.carMake.Text = "Make";
            this.carMake.Width = 90;
            // 
            // carModel
            // 
            this.carModel.Text = "Model";
            this.carModel.Width = 90;
            // 
            // carColor
            // 
            this.carColor.Text = "Color";
            this.carColor.Width = 90;
            // 
            // carAge
            // 
            this.carAge.Text = "Age";
            this.carAge.Width = 90;
            // 
            // carPrice
            // 
            this.carPrice.Text = "Price";
            this.carPrice.Width = 100;
            // 
            // btnFilterBy
            // 
            this.btnFilterBy.Location = new System.Drawing.Point(12, 230);
            this.btnFilterBy.Name = "btnFilterBy";
            this.btnFilterBy.Size = new System.Drawing.Size(75, 23);
            this.btnFilterBy.TabIndex = 2;
            this.btnFilterBy.Text = "Filter";
            this.btnFilterBy.UseVisualStyleBackColor = true;
            this.btnFilterBy.Click += new System.EventHandler(this.btnFilterBy_Click);
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Location = new System.Drawing.Point(174, 235);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(98, 13);
            this.lblFilterType.TabIndex = 3;
            this.lblFilterType.Text = "Current Filter: None";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUserListings
            // 
            this.btnUserListings.Enabled = false;
            this.btnUserListings.Location = new System.Drawing.Point(629, 230);
            this.btnUserListings.Name = "btnUserListings";
            this.btnUserListings.Size = new System.Drawing.Size(75, 23);
            this.btnUserListings.TabIndex = 5;
            this.btnUserListings.Text = "Your Listings";
            this.btnUserListings.UseVisualStyleBackColor = true;
            this.btnUserListings.Click += new System.EventHandler(this.btnUserListings_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(548, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Please Log In To Add Or Delete Listings";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateListing
            // 
            this.btnCreateListing.Enabled = false;
            this.btnCreateListing.Location = new System.Drawing.Point(710, 230);
            this.btnCreateListing.Name = "btnCreateListing";
            this.btnCreateListing.Size = new System.Drawing.Size(75, 23);
            this.btnCreateListing.TabIndex = 8;
            this.btnCreateListing.Text = "New Listing";
            this.btnCreateListing.UseVisualStyleBackColor = true;
            this.btnCreateListing.Click += new System.EventHandler(this.btnCreateListing_Click);
            // 
            // frmCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 264);
            this.Controls.Add(this.btnCreateListing);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUserListings);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.btnFilterBy);
            this.Controls.Add(this.lvCarListings);
            this.Name = "frmCarDealership";
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.frmCarDealership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvCarListings;
        private System.Windows.Forms.ColumnHeader listingDate;
        private System.Windows.Forms.ColumnHeader carMake;
        private System.Windows.Forms.ColumnHeader carModel;
        private System.Windows.Forms.ColumnHeader carColor;
        private System.Windows.Forms.ColumnHeader carAge;
        private System.Windows.Forms.ColumnHeader carPrice;
        private System.Windows.Forms.Button btnFilterBy;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUserListings;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCreateListing;
    }
}

