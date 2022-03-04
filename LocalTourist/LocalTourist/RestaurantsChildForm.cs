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
    public partial class RestaurantsChildForm : Form
    {
        public RestaurantsChildForm()
        {
            InitializeComponent();
        }

        private void restaurantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.restaurantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismDataSet);

        }

        private void RestaurantsChildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.tourismDataSet.Restaurants);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            restaurantsBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restaurantsBindingSource.MovePrevious();
        }
    }
}
