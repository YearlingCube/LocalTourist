namespace LocalTourist
{
    partial class SearchChildForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label typeofAttractionLabel;
            System.Windows.Forms.Label childrenLabel;
            System.Windows.Forms.Label petsLabel;
            System.Windows.Forms.Label priceLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchChildForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.TOADropDown = new System.Windows.Forms.ComboBox();
            this.PriceSlider = new System.Windows.Forms.TrackBar();
            this.ChildrenCheckBox = new System.Windows.Forms.CheckBox();
            this.PetsCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.tourismDataSet = new LocalTourist.TourismDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petsCheckBox1 = new System.Windows.Forms.CheckBox();
            this.childrenCheckBox1 = new System.Windows.Forms.CheckBox();
            this.typeofAttractionTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.hotelsTableAdapter = new LocalTourist.TourismDataSetTableAdapters.HotelsTableAdapter();
            this.tableAdapterManager = new LocalTourist.TourismDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hotelsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.hotelsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playsTableAdapter = new LocalTourist.TourismDataSetTableAdapters.PlaysTableAdapter();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsTableAdapter = new LocalTourist.TourismDataSetTableAdapters.RestaurantsTableAdapter();
            this.sightSeeingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sightSeeingTableAdapter = new LocalTourist.TourismDataSetTableAdapters.SightSeeingTableAdapter();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter = new LocalTourist.TourismDataSetTableAdapters.StoresTableAdapter();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new LocalTourist.TourismDataSetTableAdapters.ToursTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckOnChildren = new System.Windows.Forms.CheckBox();
            this.CheckOnPets = new System.Windows.Forms.CheckBox();
            nameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            typeofAttractionLabel = new System.Windows.Forms.Label();
            childrenLabel = new System.Windows.Forms.Label();
            petsLabel = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingNavigator)).BeginInit();
            this.hotelsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightSeeingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 16);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(12, 75);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(62, 16);
            locationLabel.TabIndex = 14;
            locationLabel.Text = "Location:";
            // 
            // typeofAttractionLabel
            // 
            typeofAttractionLabel.AutoSize = true;
            typeofAttractionLabel.Location = new System.Drawing.Point(12, 121);
            typeofAttractionLabel.Name = "typeofAttractionLabel";
            typeofAttractionLabel.Size = new System.Drawing.Size(112, 16);
            typeofAttractionLabel.TabIndex = 15;
            typeofAttractionLabel.Text = "Typeof Attraction:";
            // 
            // childrenLabel
            // 
            childrenLabel.AutoSize = true;
            childrenLabel.Location = new System.Drawing.Point(12, 175);
            childrenLabel.Name = "childrenLabel";
            childrenLabel.Size = new System.Drawing.Size(60, 16);
            childrenLabel.TabIndex = 16;
            childrenLabel.Text = "Children:";
            // 
            // petsLabel
            // 
            petsLabel.AutoSize = true;
            petsLabel.Location = new System.Drawing.Point(12, 217);
            petsLabel.Name = "petsLabel";
            petsLabel.Size = new System.Drawing.Size(38, 16);
            petsLabel.TabIndex = 17;
            petsLabel.Text = "Pets:";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(12, 249);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(42, 16);
            priceLabel1.TabIndex = 18;
            priceLabel1.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(180, 107);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // StateTextBox
            // 
            this.StateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.StateTextBox.ForeColor = System.Drawing.Color.White;
            this.StateTextBox.Location = new System.Drawing.Point(356, 107);
            this.StateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(132, 22);
            this.StateTextBox.TabIndex = 2;
            // 
            // TOADropDown
            // 
            this.TOADropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.TOADropDown.ForeColor = System.Drawing.Color.White;
            this.TOADropDown.FormattingEnabled = true;
            this.TOADropDown.Items.AddRange(new object[] {
            "Restuarant",
            "Hotels",
            "Stores",
            "Plays",
            "Sight Seeing",
            "Tours"});
            this.TOADropDown.Location = new System.Drawing.Point(176, 238);
            this.TOADropDown.Margin = new System.Windows.Forms.Padding(4);
            this.TOADropDown.Name = "TOADropDown";
            this.TOADropDown.Size = new System.Drawing.Size(312, 24);
            this.TOADropDown.TabIndex = 3;
            // 
            // PriceSlider
            // 
            this.PriceSlider.LargeChange = 20;
            this.PriceSlider.Location = new System.Drawing.Point(175, 320);
            this.PriceSlider.Margin = new System.Windows.Forms.Padding(4);
            this.PriceSlider.Maximum = 10000;
            this.PriceSlider.Name = "PriceSlider";
            this.PriceSlider.Size = new System.Drawing.Size(315, 45);
            this.PriceSlider.TabIndex = 4;
            this.PriceSlider.TickFrequency = 500;
            this.PriceSlider.Scroll += new System.EventHandler(this.PriceSlider_Scroll);
            // 
            // ChildrenCheckBox
            // 
            this.ChildrenCheckBox.AutoSize = true;
            this.ChildrenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenCheckBox.ForeColor = System.Drawing.Color.White;
            this.ChildrenCheckBox.Location = new System.Drawing.Point(176, 404);
            this.ChildrenCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChildrenCheckBox.Name = "ChildrenCheckBox";
            this.ChildrenCheckBox.Size = new System.Drawing.Size(118, 20);
            this.ChildrenCheckBox.TabIndex = 5;
            this.ChildrenCheckBox.Text = "Allows Children";
            this.ChildrenCheckBox.UseVisualStyleBackColor = true;
            // 
            // PetsCheckBox
            // 
            this.PetsCheckBox.AutoSize = true;
            this.PetsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetsCheckBox.ForeColor = System.Drawing.Color.White;
            this.PetsCheckBox.Location = new System.Drawing.Point(176, 432);
            this.PetsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.PetsCheckBox.Name = "PetsCheckBox";
            this.PetsCheckBox.Size = new System.Drawing.Size(96, 20);
            this.PetsCheckBox.TabIndex = 6;
            this.PetsCheckBox.Text = "Allows Pets";
            this.PetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of Attraction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "County";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price / Per Person";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(274, 523);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(126, 41);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // tourismDataSet
            // 
            this.tourismDataSet.DataSetName = "TourismDataSet";
            this.tourismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(priceLabel1);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(petsLabel);
            this.groupBox1.Controls.Add(this.petsCheckBox1);
            this.groupBox1.Controls.Add(childrenLabel);
            this.groupBox1.Controls.Add(this.childrenCheckBox1);
            this.groupBox1.Controls.Add(typeofAttractionLabel);
            this.groupBox1.Controls.Add(this.typeofAttractionTextBox);
            this.groupBox1.Controls.Add(locationLabel);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(this.PreviousButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(590, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 431);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Results";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Price", true));
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.Location = new System.Drawing.Point(201, 243);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 19;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.tourismDataSet;
            // 
            // petsCheckBox1
            // 
            this.petsCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hotelsBindingSource, "Pets", true));
            this.petsCheckBox1.Location = new System.Drawing.Point(240, 209);
            this.petsCheckBox1.Name = "petsCheckBox1";
            this.petsCheckBox1.Size = new System.Drawing.Size(19, 24);
            this.petsCheckBox1.TabIndex = 18;
            this.petsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // childrenCheckBox1
            // 
            this.childrenCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hotelsBindingSource, "Children", true));
            this.childrenCheckBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.childrenCheckBox1.Location = new System.Drawing.Point(240, 172);
            this.childrenCheckBox1.Name = "childrenCheckBox1";
            this.childrenCheckBox1.Size = new System.Drawing.Size(19, 24);
            this.childrenCheckBox1.TabIndex = 17;
            this.childrenCheckBox1.UseVisualStyleBackColor = true;
            // 
            // typeofAttractionTextBox
            // 
            this.typeofAttractionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.typeofAttractionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "TypeofAttraction", true));
            this.typeofAttractionTextBox.ForeColor = System.Drawing.Color.White;
            this.typeofAttractionTextBox.Location = new System.Drawing.Point(201, 118);
            this.typeofAttractionTextBox.Name = "typeofAttractionTextBox";
            this.typeofAttractionTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeofAttractionTextBox.TabIndex = 16;
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Location", true));
            this.locationTextBox.ForeColor = System.Drawing.Color.White;
            this.locationTextBox.Location = new System.Drawing.Point(201, 69);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 22);
            this.locationTextBox.TabIndex = 15;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Name", true));
            this.nameTextBox1.ForeColor = System.Drawing.Color.White;
            this.nameTextBox1.Location = new System.Drawing.Point(201, 34);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 14;
            // 
            // PreviousButton
            // 
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Location = new System.Drawing.Point(21, 381);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 13;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(215, 381);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HotelsTableAdapter = this.hotelsTableAdapter;
            this.tableAdapterManager.PlaysTableAdapter = null;
            this.tableAdapterManager.RestaurantsTableAdapter = null;
            this.tableAdapterManager.SightSeeingTableAdapter = null;
            this.tableAdapterManager.StoresTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LocalTourist.TourismDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hotelsBindingNavigator
            // 
            this.hotelsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelsBindingNavigator.BindingSource = this.hotelsBindingSource;
            this.hotelsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hotelsBindingNavigatorSaveItem});
            this.hotelsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelsBindingNavigator.Name = "hotelsBindingNavigator";
            this.hotelsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelsBindingNavigator.Size = new System.Drawing.Size(1111, 25);
            this.hotelsBindingNavigator.TabIndex = 19;
            this.hotelsBindingNavigator.Text = "bindingNavigator1";
            this.hotelsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // hotelsBindingNavigatorSaveItem
            // 
            this.hotelsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelsBindingNavigatorSaveItem.Image")));
            this.hotelsBindingNavigatorSaveItem.Name = "hotelsBindingNavigatorSaveItem";
            this.hotelsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelsBindingNavigatorSaveItem.Text = "Save Data";
            this.hotelsBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelsBindingNavigatorSaveItem_Click);
            // 
            // playsBindingSource
            // 
            this.playsBindingSource.DataMember = "Plays";
            this.playsBindingSource.DataSource = this.tourismDataSet;
            // 
            // playsTableAdapter
            // 
            this.playsTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantsBindingSource
            // 
            this.restaurantsBindingSource.DataMember = "Restaurants";
            this.restaurantsBindingSource.DataSource = this.tourismDataSet;
            // 
            // restaurantsTableAdapter
            // 
            this.restaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // sightSeeingBindingSource
            // 
            this.sightSeeingBindingSource.DataMember = "SightSeeing";
            this.sightSeeingBindingSource.DataSource = this.tourismDataSet;
            // 
            // sightSeeingTableAdapter
            // 
            this.sightSeeingTableAdapter.ClearBeforeFill = true;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.tourismDataSet;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.tourismDataSet;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(440, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CheckOnChildren
            // 
            this.CheckOnChildren.AutoSize = true;
            this.CheckOnChildren.Checked = true;
            this.CheckOnChildren.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckOnChildren.Location = new System.Drawing.Point(301, 404);
            this.CheckOnChildren.Name = "CheckOnChildren";
            this.CheckOnChildren.Size = new System.Drawing.Size(64, 20);
            this.CheckOnChildren.TabIndex = 21;
            this.CheckOnChildren.Text = "On/Off";
            this.CheckOnChildren.UseVisualStyleBackColor = true;
            this.CheckOnChildren.CheckedChanged += new System.EventHandler(this.CheckOnChildren_CheckedChanged);
            // 
            // CheckOnPets
            // 
            this.CheckOnPets.AutoSize = true;
            this.CheckOnPets.Checked = true;
            this.CheckOnPets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckOnPets.Location = new System.Drawing.Point(279, 430);
            this.CheckOnPets.Name = "CheckOnPets";
            this.CheckOnPets.Size = new System.Drawing.Size(64, 20);
            this.CheckOnPets.TabIndex = 22;
            this.CheckOnPets.Text = "On/Off";
            this.CheckOnPets.UseVisualStyleBackColor = true;
            this.CheckOnPets.CheckedChanged += new System.EventHandler(this.CheckOnPets_CheckedChanged);
            // 
            // SearchChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1111, 665);
            this.Controls.Add(this.CheckOnPets);
            this.Controls.Add(this.CheckOnChildren);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hotelsBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PetsCheckBox);
            this.Controls.Add(this.ChildrenCheckBox);
            this.Controls.Add(this.PriceSlider);
            this.Controls.Add(this.TOADropDown);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(151, 71);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1111, 665);
            this.Name = "SearchChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SearchChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingNavigator)).EndInit();
            this.hotelsBindingNavigator.ResumeLayout(false);
            this.hotelsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sightSeeingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.ComboBox TOADropDown;
        private System.Windows.Forms.TrackBar PriceSlider;
        private System.Windows.Forms.CheckBox ChildrenCheckBox;
        private System.Windows.Forms.CheckBox PetsCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private TourismDataSet tourismDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private TourismDataSetTableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private TourismDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox petsCheckBox1;
        private System.Windows.Forms.CheckBox childrenCheckBox1;
        private System.Windows.Forms.TextBox typeofAttractionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton hotelsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator hotelsBindingNavigator;
        private System.Windows.Forms.BindingSource playsBindingSource;
        private TourismDataSetTableAdapters.PlaysTableAdapter playsTableAdapter;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private TourismDataSetTableAdapters.RestaurantsTableAdapter restaurantsTableAdapter;
        private System.Windows.Forms.BindingSource sightSeeingBindingSource;
        private TourismDataSetTableAdapters.SightSeeingTableAdapter sightSeeingTableAdapter;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private TourismDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private TourismDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CheckOnChildren;
        private System.Windows.Forms.CheckBox CheckOnPets;
    }
}