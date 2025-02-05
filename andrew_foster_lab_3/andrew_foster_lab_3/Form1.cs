using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int state;

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);

            for (var x = 0; x < this.statesDataSet.States.Count; x++)
            {
                stateBox.Items.Add(this.statesDataSet.States[x].Name);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stateBox.SelectedIndex = -1;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stateBox.SelectedIndex > -1)
            {
                state = stateBox.SelectedIndex;                
                stateForm stateForm = new stateForm();
                stateForm.state1 = state;
                stateForm.ShowDialog();
            }
            
        }
    }
}
