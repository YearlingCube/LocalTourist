namespace LocalTourist
{
    partial class RestaurantsChildForm
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
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantsChildForm));
            this.tourismDataSet = new LocalTourist.TourismDataSet();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsTableAdapter = new LocalTourist.TourismDataSetTableAdapters.RestaurantsTableAdapter();
            this.tableAdapterManager = new LocalTourist.TourismDataSetTableAdapters.TableAdapterManager();
            this.restaurantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.typeofAttractionTextBox = new System.Windows.Forms.TextBox();
            this.childrenCheckBox = new System.Windows.Forms.CheckBox();
            this.petsCheckBox = new System.Windows.Forms.CheckBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            typeofAttractionLabel = new System.Windows.Forms.Label();
            childrenLabel = new System.Windows.Forms.Label();
            petsLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingNavigator)).BeginInit();
            this.restaurantsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(46, 212);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 18);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(29, 319);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(69, 18);
            locationLabel.TabIndex = 3;
            locationLabel.Text = "Location:";
            // 
            // typeofAttractionLabel
            // 
            typeofAttractionLabel.AutoSize = true;
            typeofAttractionLabel.Location = new System.Drawing.Point(408, 209);
            typeofAttractionLabel.Name = "typeofAttractionLabel";
            typeofAttractionLabel.Size = new System.Drawing.Size(123, 18);
            typeofAttractionLabel.TabIndex = 5;
            typeofAttractionLabel.Text = "Typeof Attraction:";
            // 
            // childrenLabel
            // 
            childrenLabel.AutoSize = true;
            childrenLabel.Location = new System.Drawing.Point(465, 266);
            childrenLabel.Name = "childrenLabel";
            childrenLabel.Size = new System.Drawing.Size(66, 18);
            childrenLabel.TabIndex = 7;
            childrenLabel.Text = "Children:";
            // 
            // petsLabel
            // 
            petsLabel.AutoSize = true;
            petsLabel.Location = new System.Drawing.Point(489, 318);
            petsLabel.Name = "petsLabel";
            petsLabel.Size = new System.Drawing.Size(42, 18);
            petsLabel.TabIndex = 9;
            petsLabel.Text = "Pets:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(52, 267);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(46, 18);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // tourismDataSet
            // 
            this.tourismDataSet.DataSetName = "TourismDataSet";
            this.tourismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HotelsTableAdapter = null;
            this.tableAdapterManager.PlaysTableAdapter = null;
            this.tableAdapterManager.RestaurantsTableAdapter = this.restaurantsTableAdapter;
            this.tableAdapterManager.SightSeeingTableAdapter = null;
            this.tableAdapterManager.StoresTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LocalTourist.TourismDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restaurantsBindingNavigator
            // 
            this.restaurantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.restaurantsBindingNavigator.BindingSource = this.restaurantsBindingSource;
            this.restaurantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.restaurantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.restaurantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.restaurantsBindingNavigatorSaveItem});
            this.restaurantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.restaurantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.restaurantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.restaurantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.restaurantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.restaurantsBindingNavigator.Name = "restaurantsBindingNavigator";
            this.restaurantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.restaurantsBindingNavigator.Size = new System.Drawing.Size(1200, 25);
            this.restaurantsBindingNavigator.TabIndex = 0;
            this.restaurantsBindingNavigator.Text = "bindingNavigator1";
            this.restaurantsBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // restaurantsBindingNavigatorSaveItem
            // 
            this.restaurantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restaurantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("restaurantsBindingNavigatorSaveItem.Image")));
            this.restaurantsBindingNavigatorSaveItem.Name = "restaurantsBindingNavigatorSaveItem";
            this.restaurantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.restaurantsBindingNavigatorSaveItem.Text = "Save Data";
            this.restaurantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.restaurantsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantsBindingSource, "Name", true));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(104, 209);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 24);
            this.nameTextBox.TabIndex = 2;
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantsBindingSource, "Location", true));
            this.locationTextBox.ForeColor = System.Drawing.Color.White;
            this.locationTextBox.Location = new System.Drawing.Point(104, 316);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(262, 24);
            this.locationTextBox.TabIndex = 4;
            // 
            // typeofAttractionTextBox
            // 
            this.typeofAttractionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.typeofAttractionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantsBindingSource, "TypeofAttraction", true));
            this.typeofAttractionTextBox.ForeColor = System.Drawing.Color.White;
            this.typeofAttractionTextBox.Location = new System.Drawing.Point(537, 206);
            this.typeofAttractionTextBox.Name = "typeofAttractionTextBox";
            this.typeofAttractionTextBox.Size = new System.Drawing.Size(222, 24);
            this.typeofAttractionTextBox.TabIndex = 6;
            // 
            // childrenCheckBox
            // 
            this.childrenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.restaurantsBindingSource, "Children", true));
            this.childrenCheckBox.Location = new System.Drawing.Point(537, 261);
            this.childrenCheckBox.Name = "childrenCheckBox";
            this.childrenCheckBox.Size = new System.Drawing.Size(104, 24);
            this.childrenCheckBox.TabIndex = 8;
            this.childrenCheckBox.UseVisualStyleBackColor = true;
            // 
            // petsCheckBox
            // 
            this.petsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.restaurantsBindingSource, "Pets", true));
            this.petsCheckBox.Location = new System.Drawing.Point(537, 313);
            this.petsCheckBox.Name = "petsCheckBox";
            this.petsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.petsCheckBox.TabIndex = 10;
            this.petsCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.restaurantsBindingSource, "Price", true));
            this.priceTextBox.ForeColor = System.Drawing.Color.White;
            this.priceTextBox.Location = new System.Drawing.Point(104, 264);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 24);
            this.priceTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Restaurants";
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(319, 416);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(85, 30);
            this.NextButton.TabIndex = 17;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(185, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestaurantsChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(petsLabel);
            this.Controls.Add(this.petsCheckBox);
            this.Controls.Add(childrenLabel);
            this.Controls.Add(this.childrenCheckBox);
            this.Controls.Add(typeofAttractionLabel);
            this.Controls.Add(this.typeofAttractionTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.restaurantsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RestaurantsChildForm";
            this.Text = "RestaurantsChildForm";
            this.Load += new System.EventHandler(this.RestaurantsChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingNavigator)).EndInit();
            this.restaurantsBindingNavigator.ResumeLayout(false);
            this.restaurantsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TourismDataSet tourismDataSet;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private TourismDataSetTableAdapters.RestaurantsTableAdapter restaurantsTableAdapter;
        private TourismDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator restaurantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton restaurantsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox typeofAttractionTextBox;
        private System.Windows.Forms.CheckBox childrenCheckBox;
        private System.Windows.Forms.CheckBox petsCheckBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button button1;
    }
}