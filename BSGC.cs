//Title: BeSmart G-Cart Manager
//Description : An inventory system that will help user's to list down, update and delete products.
//Programmers
//Jocel Mangilimna
//Margarette Roque
//Wilyn Grace Yarte
//Date Submitted : 29/10/22


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSGC_MANAGER
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("PRODUCT CODE", Type.GetType("System.String"));
            table.Columns.Add("PRODUCT NAME", Type.GetType("System.String"));
            table.Columns.Add("CATEGORY", Type.GetType("System.String"));
            table.Columns.Add("QUANTITY", Type.GetType("System.String"));
            table.Columns.Add("PRICE", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = textBox1.Text;
            newData.Cells[1].Value = textBox2.Text;
            newData.Cells[2].Value = textBox3.Text;
            newData.Cells[3].Value = textBox4.Text;
            newData.Cells[4].Value = textBox5.Text;
            MessageBox.Show("Updated");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            MessageBox.Show("Deleted");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("Item Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
           
        }
    }
}
