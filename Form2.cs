using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using ClosedXML;

namespace Фотоуслуги
{
    public partial class Form2 : Form
    {
        DatabaseService databaseService = new DatabaseService();

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            databaseService.LoadStaff(dataGridView1);
            databaseService.LoadOrder(dataGridView2);
            databaseService.loadMaterial(dataGridView4);
            databaseService.loadService(dataGridView5);
            databaseService.LoadMaterealOfWarehouse(dataGridView7);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            databaseService.AddStaffToList(new string[] { textBox14.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text });
            databaseService.LoadStaff(dataGridView1);
            groupBox1.Visible = false;
            toolStripButton8.Visible = true;
            toolStripButton9.Visible = true;
            toolStripButton2.Visible = true;
            textBox14.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            databaseService.DeleteStaffOfList(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            databaseService.LoadStaff(dataGridView1);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            databaseService.DeleteServiceOfList(int.Parse(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()));
            databaseService.loadService(dataGridView5);
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            databaseService.LoadServiseOfOrder(dataGridView3, int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseService.LoadMaterealOfService(dataGridView6, int.Parse(dataGridView5.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            databaseService.AddServiceToList(new string[] { textBox15.Text, textBox10.Text, textBox11.Text, textBox12.Text });
            databaseService.loadService(dataGridView5);
            groupBox5.Visible = false;
            toolStripButton1.Visible = true;
            toolStripButton12.Visible = true;
            toolStripButton13.Visible = true;
            textBox15.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            toolStripButton8.Visible = false;
            toolStripButton9.Visible = false;
            toolStripButton2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            toolStripButton8.Visible = true;
            toolStripButton9.Visible = true;
            toolStripButton2.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            groupBox5.Visible = true;
            toolStripButton12.Visible = false;
            toolStripButton13.Visible = false;
            toolStripButton1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            toolStripButton1.Visible = true;
            toolStripButton12.Visible = true;
            toolStripButton13.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseService.SearchOrder(dateTimePicker1.Value.Date,dateTimePicker2.Value.Date,dataGridView4);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
