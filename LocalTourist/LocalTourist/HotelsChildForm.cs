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
    public partial class HotelsChildForm : Form
    {
        public HotelsChildForm()
        {
            InitializeComponent();
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismDataSet);

        }

        private void HotelsChildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismDataSet.Hotels' table. You can move, or remove it, as needed.
            this.hotelsTableAdapter.Fill(this.tourismDataSet.Hotels);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MovePrevious();
        }
    }
}
