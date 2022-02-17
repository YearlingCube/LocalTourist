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
            ((System.ComponentModel.ISupportInitialize)(this.PriceSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(180, 107);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(356, 107);
            this.StateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(132, 22);
            this.StateTextBox.TabIndex = 2;
            // 
            // TOADropDown
            // 
            this.TOADropDown.FormattingEnabled = true;
            this.TOADropDown.Items.AddRange(new object[] {
            "Restuarant",
            "Hotels",
            "Stores",
            "Plays",
            "Sight Seeing",
            "Tours"});
            this.TOADropDown.Location = new System.Drawing.Point(176, 238);
            this.TOADropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TOADropDown.Name = "TOADropDown";
            this.TOADropDown.Size = new System.Drawing.Size(312, 24);
            this.TOADropDown.TabIndex = 3;
            // 
            // PriceSlider
            // 
            this.PriceSlider.Location = new System.Drawing.Point(175, 320);
            this.PriceSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceSlider.Name = "PriceSlider";
            this.PriceSlider.Size = new System.Drawing.Size(315, 45);
            this.PriceSlider.TabIndex = 4;
            // 
            // ChildrenCheckBox
            // 
            this.ChildrenCheckBox.AutoSize = true;
            this.ChildrenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenCheckBox.ForeColor = System.Drawing.Color.White;
            this.ChildrenCheckBox.Location = new System.Drawing.Point(176, 404);
            this.ChildrenCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.PetsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "State";
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
            this.SearchButton.Location = new System.Drawing.Point(545, 421);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(126, 41);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1111, 665);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1111, 665);
            this.Name = "SearchChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PriceSlider)).EndInit();
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
    }
}