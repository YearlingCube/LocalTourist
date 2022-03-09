using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalTourist
{
    public partial class SearchChildForm : Form
    {
        public SearchChildForm()
        {
            InitializeComponent();
        }
        private void SearchDataBase()
        {
            try
            {
                var searchHotelResults =
                   from c in tourismDataSet.Hotels
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price <= PriceSlider.Value 
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                var searchRestaurantsResults =
                   from c in tourismDataSet.Restaurants
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price == PriceSlider.Value
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                var searchPlaysResults =
                   from c in tourismDataSet.Plays
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price == PriceSlider.Value
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                var searchSightSeeingResults =
                   from c in tourismDataSet.SightSeeing
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price == PriceSlider.Value
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                var searchStoresResults =
                   from c in tourismDataSet.Stores
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price == PriceSlider.Value
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                var searchToursResults =
                   from c in tourismDataSet.Tours
                   where c.Name.ToLower().Contains(NameTextBox.Text.ToLower())
                   where c.Location.ToLower().Contains(StateTextBox.Text.ToLower())
                   where c.Price == PriceSlider.Value
                   where c.Pets == PetsCheckBox.Checked
                   where c.Children == ChildrenCheckBox.Checked
                   where c.TypeofAttraction.ToLower() == TOADropDown.SelectedItem.ToString().ToLower()
                   select c;
                hotelsBindingSource.DataSource = searchHotelResults.AsDataView();
                restaurantsBindingSource.DataSource = searchRestaurantsResults.AsDataView();
                toursBindingSource.DataSource = searchToursResults.AsDataView();
                storesBindingSource.DataSource = searchStoresResults.AsDataView();
                playsBindingSource.DataSource = searchPlaysResults.AsDataView();
                sightSeeingBindingSource.DataSource = searchSightSeeingResults.AsDataView();
                foreach (TourismDataSet.HotelsRow items in searchHotelResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
                foreach (TourismDataSet.RestaurantsRow items in searchRestaurantsResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
                foreach (TourismDataSet.ToursRow items in searchToursResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
                foreach (TourismDataSet.PlaysRow items in searchPlaysResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
                foreach (TourismDataSet.StoresRow items in searchStoresResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
                foreach (TourismDataSet.SightSeeingRow items in searchSightSeeingResults)
                {
                    nameTextBox1.Text = items.Name;
                    locationTextBox.Text = items.Location;
                    priceTextBox.Text = items.Price.ToString();
                    petsCheckBox1.Checked = items.Pets;
                    childrenCheckBox1.Checked = items.Children;
                    typeofAttractionTextBox.Text = items.TypeofAttraction;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PriceSlider_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = PriceSlider.Value.ToString();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchDataBase();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MoveNext();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MovePrevious();
        }

        private void SearchChildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDataSet.Tours' table. You can move, or remove it, as needed.
            this.toursTableAdapter.Fill(this.tourismDataSet.Tours);
            // TODO: This line of code loads data into the 'tourismDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.tourismDataSet.Stores);
            // TODO: This line of code loads data into the 'tourismDataSet.SightSeeing' table. You can move, or remove it, as needed.
            this.sightSeeingTableAdapter.Fill(this.tourismDataSet.SightSeeing);
            // TODO: This line of code loads data into the 'tourismDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.tourismDataSet.Restaurants);
            // TODO: This line of code loads data into the 'tourismDataSet.Plays' table. You can move, or remove it, as needed.
            this.playsTableAdapter.Fill(this.tourismDataSet.Plays);
            // TODO: This line of code loads data into the 'tourismDataSet.Hotels' table. You can move, or remove it, as needed.
            this.hotelsTableAdapter.Fill(this.tourismDataSet.Hotels);
            var searchHotelResults =
                  from c in tourismDataSet.Hotels
                  where c.Name == string.Empty
                  select c;
            hotelsBindingSource.DataSource = searchHotelResults.AsDataView();
            foreach (TourismDataSet.HotelsRow items in searchHotelResults)
            {
                nameTextBox1.Text = items.Name;
                locationTextBox.Text = items.Location;
                priceTextBox.Text = items.Price.ToString();
                petsCheckBox1.Checked = items.Pets;
                childrenCheckBox1.Checked = items.Children;
                typeofAttractionTextBox.Text = items.TypeofAttraction;
            }
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int textprice = 0;
            int.TryParse(textBox1.Text, out textprice);
            if (textprice <= PriceSlider.Maximum)
                PriceSlider.Value = textprice;
            else
                PriceSlider.Value = PriceSlider.Maximum;
        }

        private void CheckOnChildren_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOnChildren.Checked)
            {
                ChildrenCheckBox.Enabled = true;
            }
            else
            {
                ChildrenCheckBox.Checked = false;
                ChildrenCheckBox.Enabled = false;
            }
        }

        private void CheckOnPets_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOnPets.Checked)
            {
                PetsCheckBox.Enabled = true;
            }
            else
            {
                PetsCheckBox.Checked = false;
                PetsCheckBox.Enabled = false;
            }
        }
    }
}
