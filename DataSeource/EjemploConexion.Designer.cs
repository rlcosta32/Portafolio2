namespace DataSeource
{
    partial class EjemploConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemploConexion));
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label contactTitleLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label faxLabel;
            this.northwindDataSet3 = new DataSeource.NorthwindDataSet();
            this.customersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter3 = new DataSeource.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager3 = new DataSeource.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersBindingSource3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.customersBindingSource3BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox2 = new System.Windows.Forms.TextBox();
            this.companyNameTextBox3 = new System.Windows.Forms.TextBox();
            this.contactNameTextBox3 = new System.Windows.Forms.TextBox();
            this.contactTitleTextBox3 = new System.Windows.Forms.TextBox();
            this.addressTextBox3 = new System.Windows.Forms.TextBox();
            this.cityTextBox3 = new System.Windows.Forms.TextBox();
            this.regionTextBox3 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox3 = new System.Windows.Forms.TextBox();
            this.countryTextBox3 = new System.Windows.Forms.TextBox();
            this.phoneTextBox3 = new System.Windows.Forms.TextBox();
            this.faxTextBox3 = new System.Windows.Forms.TextBox();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            contactTitleLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3BindingNavigator)).BeginInit();
            this.customersBindingSource3BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindDataSet3
            // 
            this.northwindDataSet3.DataSetName = "NorthwindDataSet";
            this.northwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource3
            // 
            this.customersBindingSource3.DataMember = "Customers";
            this.customersBindingSource3.DataSource = this.northwindDataSet3;
            // 
            // customersTableAdapter3
            // 
            this.customersTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.CustomersTableAdapter = this.customersTableAdapter3;
            this.tableAdapterManager3.UpdateOrder = DataSeource.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingSource3BindingNavigator
            // 
            this.customersBindingSource3BindingNavigator.AddNewItem = this.toolStripButton17;
            this.customersBindingSource3BindingNavigator.BindingSource = this.customersBindingSource3;
            this.customersBindingSource3BindingNavigator.CountItem = this.toolStripLabel3;
            this.customersBindingSource3BindingNavigator.DeleteItem = this.toolStripButton18;
            this.customersBindingSource3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator7,
            this.toolStripTextBox5,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripSeparator9,
            this.toolStripButton17,
            this.toolStripButton18,
            this.customersBindingSource3BindingNavigatorSaveItem,
            this.toolStripTextBox6});
            this.customersBindingSource3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingSource3BindingNavigator.MoveFirstItem = this.toolStripButton13;
            this.customersBindingSource3BindingNavigator.MoveLastItem = this.toolStripButton16;
            this.customersBindingSource3BindingNavigator.MoveNextItem = this.toolStripButton15;
            this.customersBindingSource3BindingNavigator.MovePreviousItem = this.toolStripButton14;
            this.customersBindingSource3BindingNavigator.Name = "customersBindingSource3BindingNavigator";
            this.customersBindingSource3BindingNavigator.PositionItem = this.toolStripTextBox5;
            this.customersBindingSource3BindingNavigator.Size = new System.Drawing.Size(559, 25);
            this.customersBindingSource3BindingNavigator.TabIndex = 0;
            this.customersBindingSource3BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Mover primero";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Mover anterior";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.AccessibleName = "Posición";
            this.toolStripTextBox5.AutoSize = false;
            this.toolStripTextBox5.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox5.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "Posición actual";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "bindingNavigatorCountItem";
            this.toolStripLabel3.Size = new System.Drawing.Size(37, 15);
            this.toolStripLabel3.Text = "de {0}";
            this.toolStripLabel3.ToolTipText = "Número total de elementos";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton15.Text = "Mover siguiente";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton16.Text = "Mover último";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Agregar nuevo";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton18.Text = "Eliminar";
            // 
            // customersBindingSource3BindingNavigatorSaveItem
            // 
            this.customersBindingSource3BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingSource3BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingSource3BindingNavigatorSaveItem.Image")));
            this.customersBindingSource3BindingNavigatorSaveItem.Name = "customersBindingSource3BindingNavigatorSaveItem";
            this.customersBindingSource3BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customersBindingSource3BindingNavigatorSaveItem.Text = "Guardar datos";
            this.customersBindingSource3BindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingSource3BindingNavigatorSaveItem_Click);
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(277, 82);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox2
            // 
            this.customerIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "CustomerID", true));
            this.customerIDTextBox2.Location = new System.Drawing.Point(368, 79);
            this.customerIDTextBox2.Name = "customerIDTextBox2";
            this.customerIDTextBox2.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox2.TabIndex = 2;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(277, 108);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 3;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameTextBox3
            // 
            this.companyNameTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "CompanyName", true));
            this.companyNameTextBox3.Location = new System.Drawing.Point(368, 105);
            this.companyNameTextBox3.Name = "companyNameTextBox3";
            this.companyNameTextBox3.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox3.TabIndex = 4;
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(277, 134);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(78, 13);
            contactNameLabel.TabIndex = 5;
            contactNameLabel.Text = "Contact Name:";
            // 
            // contactNameTextBox3
            // 
            this.contactNameTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "ContactName", true));
            this.contactNameTextBox3.Location = new System.Drawing.Point(368, 131);
            this.contactNameTextBox3.Name = "contactNameTextBox3";
            this.contactNameTextBox3.Size = new System.Drawing.Size(100, 20);
            this.contactNameTextBox3.TabIndex = 6;
            // 
            // contactTitleLabel
            // 
            contactTitleLabel.AutoSize = true;
            contactTitleLabel.Location = new System.Drawing.Point(277, 160);
            contactTitleLabel.Name = "contactTitleLabel";
            contactTitleLabel.Size = new System.Drawing.Size(70, 13);
            contactTitleLabel.TabIndex = 7;
            contactTitleLabel.Text = "Contact Title:";
            // 
            // contactTitleTextBox3
            // 
            this.contactTitleTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "ContactTitle", true));
            this.contactTitleTextBox3.Location = new System.Drawing.Point(368, 157);
            this.contactTitleTextBox3.Name = "contactTitleTextBox3";
            this.contactTitleTextBox3.Size = new System.Drawing.Size(100, 20);
            this.contactTitleTextBox3.TabIndex = 8;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(277, 186);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox3
            // 
            this.addressTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "Address", true));
            this.addressTextBox3.Location = new System.Drawing.Point(368, 183);
            this.addressTextBox3.Name = "addressTextBox3";
            this.addressTextBox3.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox3.TabIndex = 10;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(277, 212);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // cityTextBox3
            // 
            this.cityTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "City", true));
            this.cityTextBox3.Location = new System.Drawing.Point(368, 209);
            this.cityTextBox3.Name = "cityTextBox3";
            this.cityTextBox3.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox3.TabIndex = 12;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(277, 238);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(44, 13);
            regionLabel.TabIndex = 13;
            regionLabel.Text = "Region:";
            // 
            // regionTextBox3
            // 
            this.regionTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "Region", true));
            this.regionTextBox3.Location = new System.Drawing.Point(368, 235);
            this.regionTextBox3.Name = "regionTextBox3";
            this.regionTextBox3.Size = new System.Drawing.Size(100, 20);
            this.regionTextBox3.TabIndex = 14;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(277, 264);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 15;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox3
            // 
            this.postalCodeTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "PostalCode", true));
            this.postalCodeTextBox3.Location = new System.Drawing.Point(368, 261);
            this.postalCodeTextBox3.Name = "postalCodeTextBox3";
            this.postalCodeTextBox3.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox3.TabIndex = 16;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(277, 290);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox3
            // 
            this.countryTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "Country", true));
            this.countryTextBox3.Location = new System.Drawing.Point(368, 287);
            this.countryTextBox3.Name = "countryTextBox3";
            this.countryTextBox3.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox3.TabIndex = 18;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(277, 316);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox3
            // 
            this.phoneTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "Phone", true));
            this.phoneTextBox3.Location = new System.Drawing.Point(368, 313);
            this.phoneTextBox3.Name = "phoneTextBox3";
            this.phoneTextBox3.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox3.TabIndex = 20;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(277, 342);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 21;
            faxLabel.Text = "Fax:";
            // 
            // faxTextBox3
            // 
            this.faxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource3, "Fax", true));
            this.faxTextBox3.Location = new System.Drawing.Point(368, 339);
            this.faxTextBox3.Name = "faxTextBox3";
            this.faxTextBox3.Size = new System.Drawing.Size(100, 20);
            this.faxTextBox3.TabIndex = 22;
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox4_KeyPress);
            // 
            // EjemploConexion
            // 
            this.ClientSize = new System.Drawing.Size(559, 379);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox2);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox3);
            this.Controls.Add(contactNameLabel);
            this.Controls.Add(this.contactNameTextBox3);
            this.Controls.Add(contactTitleLabel);
            this.Controls.Add(this.contactTitleTextBox3);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox3);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox3);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox3);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox3);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox3);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox3);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox3);
            this.Controls.Add(this.customersBindingSource3BindingNavigator);
            this.Name = "EjemploConexion";
            this.Load += new System.EventHandler(this.EjemploConexion_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3BindingNavigator)).EndInit();
            this.customersBindingSource3BindingNavigator.ResumeLayout(false);
            this.customersBindingSource3BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripTextBox CajaTextoID;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator customersBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton customersBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox1;
        private System.Windows.Forms.TextBox contactNameTextBox1;
        private System.Windows.Forms.TextBox contactTitleTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.TextBox regionTextBox1;
        private System.Windows.Forms.TextBox postalCodeTextBox1;
        private System.Windows.Forms.TextBox countryTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox faxTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private NorthwindDataSet northwindDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter2;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator customersBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton customersBindingSource2BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.TextBox customerIDTextBox1;
        private System.Windows.Forms.TextBox companyNameTextBox2;
        private System.Windows.Forms.TextBox contactNameTextBox2;
        private System.Windows.Forms.TextBox contactTitleTextBox2;
        private System.Windows.Forms.TextBox addressTextBox2;
        private System.Windows.Forms.TextBox cityTextBox2;
        private System.Windows.Forms.TextBox regionTextBox2;
        private System.Windows.Forms.TextBox postalCodeTextBox2;
        private System.Windows.Forms.TextBox countryTextBox2;
        private System.Windows.Forms.TextBox phoneTextBox2;
        private System.Windows.Forms.TextBox faxTextBox2;
        private NorthwindDataSet northwindDataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource3;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter3;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.BindingNavigator customersBindingSource3BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton customersBindingSource3BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.TextBox customerIDTextBox2;
        private System.Windows.Forms.TextBox companyNameTextBox3;
        private System.Windows.Forms.TextBox contactNameTextBox3;
        private System.Windows.Forms.TextBox contactTitleTextBox3;
        private System.Windows.Forms.TextBox addressTextBox3;
        private System.Windows.Forms.TextBox cityTextBox3;
        private System.Windows.Forms.TextBox regionTextBox3;
        private System.Windows.Forms.TextBox postalCodeTextBox3;
        private System.Windows.Forms.TextBox countryTextBox3;
        private System.Windows.Forms.TextBox phoneTextBox3;
        private System.Windows.Forms.TextBox faxTextBox3;
    }
}