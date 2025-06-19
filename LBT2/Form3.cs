using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBT2
{
    public partial class text3 : Form
    {
        public text3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.Last' table. You can move, or remove it, as needed.
            this.lastTableAdapter.Fill(this.dataset1.Last);

        }

        private void lastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset1);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
