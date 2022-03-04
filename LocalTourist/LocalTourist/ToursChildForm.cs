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
    public partial class ToursChildForm : Form
    {
        public ToursChildForm()
        {
            InitializeComponent();
        }

        private void toursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismDataSet);

        }

        private void ToursChildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDataSet.Tours' table. You can move, or remove it, as needed.
            this.toursTableAdapter.Fill(this.tourismDataSet.Tours);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            toursBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toursBindingSource.MovePrevious();
        }
    }
}
