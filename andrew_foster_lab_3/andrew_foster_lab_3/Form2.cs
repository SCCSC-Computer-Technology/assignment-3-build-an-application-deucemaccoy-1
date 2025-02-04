using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_lab_3
{
    public partial class stateForm : Form
    {
        public stateForm()
        {
            InitializeComponent();
        }

        public int state1;

        Form1 form1 = new Form1();

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(statesDataSet.States);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
