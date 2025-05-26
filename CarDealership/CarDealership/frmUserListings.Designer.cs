namespace CarDealership
{
    partial class frmUserListings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label engineLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label horsepowerLabel;
            System.Windows.Forms.Label batteryCapLabel;
            System.Windows.Forms.Label listingDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserListings));
            this.carsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtHorsepower = new System.Windows.Forms.TextBox();
            this.txtBatteryCap = new System.Windows.Forms.TextBox();
            this.txtListingDate = new System.Windows.Forms.TextBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDataSet = new CarDealership.CarDealershipDataSet();
            this.carsTableAdapter = new CarDealership.CarDealershipDataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            engineLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            horsepowerLabel = new System.Windows.Forms.Label();
            batteryCapLabel = new System.Windows.Forms.Label();
            listingDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).BeginInit();
            this.carsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(12, 69);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(215, 69);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 95);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "Color:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(188, 95);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "Age:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(279, 95);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // engineLabel
            // 
            engineLabel.AutoSize = true;
            engineLabel.Location = new System.Drawing.Point(12, 129);
            engineLabel.Name = "engineLabel";
            engineLabel.Size = new System.Drawing.Size(43, 13);
            engineLabel.TabIndex = 13;
            engineLabel.Text = "Engine:";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(233, 129);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 15;
            mileageLabel.Text = "Mileage:";
            // 
            // horsepowerLabel
            // 
            horsepowerLabel.AutoSize = true;
            horsepowerLabel.Location = new System.Drawing.Point(12, 160);
            horsepowerLabel.Name = "horsepowerLabel";
            horsepowerLabel.Size = new System.Drawing.Size(67, 13);
            horsepowerLabel.TabIndex = 17;
            horsepowerLabel.Text = "Horsepower:";
            // 
            // batteryCapLabel
            // 
            batteryCapLabel.AutoSize = true;
            batteryCapLabel.Location = new System.Drawing.Point(233, 160);
            batteryCapLabel.Name = "batteryCapLabel";
            batteryCapLabel.Size = new System.Drawing.Size(65, 13);
            batteryCapLabel.TabIndex = 19;
            batteryCapLabel.Text = "Battery Cap:";
            // 
            // listingDateLabel
            // 
            listingDateLabel.AutoSize = true;
            listingDateLabel.Location = new System.Drawing.Point(12, 43);
            listingDateLabel.Name = "listingDateLabel";
            listingDateLabel.Size = new System.Drawing.Size(66, 13);
            listingDateLabel.TabIndex = 20;
            listingDateLabel.Text = "Listing Date:";
            // 
            // carsBindingNavigator
            // 
            this.carsBindingNavigator.AddNewItem = null;
            this.carsBindingNavigator.BindingSource = this.carsBindingSource;
            this.carsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carsBindingNavigator.DeleteItem = null;
            this.carsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.deleteToolStripButton});
            this.carsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carsBindingNavigator.Name = "carsBindingNavigator";
            this.carsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carsBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.carsBindingNavigator.TabIndex = 0;
            this.carsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(84, 66);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(125, 20);
            this.txtMake.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(260, 66);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(163, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Color", true));
            this.txtColor.Location = new System.Drawing.Point(84, 92);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(98, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Age", true));
            this.txtAge.Location = new System.Drawing.Point(223, 92);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(50, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(319, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtEngine
            // 
            this.txtEngine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Engine", true));
            this.txtEngine.Location = new System.Drawing.Point(84, 126);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.ReadOnly = true;
            this.txtEngine.Size = new System.Drawing.Size(100, 20);
            this.txtEngine.TabIndex = 14;
            // 
            // txtMileage
            // 
            this.txtMileage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Mileage", true));
            this.txtMileage.Location = new System.Drawing.Point(319, 126);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.ReadOnly = true;
            this.txtMileage.Size = new System.Drawing.Size(124, 20);
            this.txtMileage.TabIndex = 16;
            // 
            // txtHorsepower
            // 
            this.txtHorsepower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Horsepower", true));
            this.txtHorsepower.Location = new System.Drawing.Point(84, 157);
            this.txtHorsepower.Name = "txtHorsepower";
            this.txtHorsepower.ReadOnly = true;
            this.txtHorsepower.Size = new System.Drawing.Size(100, 20);
            this.txtHorsepower.TabIndex = 18;
            // 
            // txtBatteryCap
            // 
            this.txtBatteryCap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "BatteryCap", true));
            this.txtBatteryCap.Location = new System.Drawing.Point(319, 157);
            this.txtBatteryCap.Name = "txtBatteryCap";
            this.txtBatteryCap.ReadOnly = true;
            this.txtBatteryCap.Size = new System.Drawing.Size(124, 20);
            this.txtBatteryCap.TabIndex = 20;
            // 
            // txtListingDate
            // 
            this.txtListingDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "ListingDate", true));
            this.txtListingDate.Location = new System.Drawing.Point(84, 40);
            this.txtListingDate.Name = "txtListingDate";
            this.txtListingDate.ReadOnly = true;
            this.txtListingDate.Size = new System.Drawing.Size(125, 20);
            this.txtListingDate.TabIndex = 21;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(82, 22);
            this.deleteToolStripButton.Text = "Delete Listing";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // frmUserListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 214);
            this.Controls.Add(listingDateLabel);
            this.Controls.Add(this.txtListingDate);
            this.Controls.Add(batteryCapLabel);
            this.Controls.Add(this.txtBatteryCap);
            this.Controls.Add(horsepowerLabel);
            this.Controls.Add(this.txtHorsepower);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(engineLabel);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.carsBindingNavigator);
            this.Name = "frmUserListings";
            this.Text = "frmUserListings";
            this.Load += new System.EventHandler(this.frmUserListings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).EndInit();
            this.carsBindingNavigator.ResumeLayout(false);
            this.carsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarDealershipDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private CarDealershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtHorsepower;
        private System.Windows.Forms.TextBox txtBatteryCap;
        private System.Windows.Forms.TextBox txtListingDate;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
    }
}