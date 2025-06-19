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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Show Form2
            form1.Show();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text3 form3 = new text3();


            form3.Show();
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
