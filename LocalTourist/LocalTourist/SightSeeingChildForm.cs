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
    public partial class SightSeeingChildForm : Form
    {
        public SightSeeingChildForm()
        {
            InitializeComponent();
        }

        private void sightSeeingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sightSeeingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismDataSet);

        }

        private void SightSeeingChildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDataSet.SightSeeing' table. You can move, or remove it, as needed.
            this.sightSeeingTableAdapter.Fill(this.tourismDataSet.SightSeeing);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            sightSeeingBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sightSeeingBindingSource.MovePrevious();
        }
    }
}
