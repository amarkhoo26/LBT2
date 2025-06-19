using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBT2


{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataset1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.dataset1.Author);
            // TODO: This line of code loads data into the 'dataset1.Book' table. You can move, or remove it, as needed.
     
            // TODO: This line of code loads data into the 'dataset1.Table' table. You can move, or remove it, as needed.
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();


            form2.Show();
        }

        
       
        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text3 form3 = new text3();


            form3.Show();
       
        
        }
    }
}