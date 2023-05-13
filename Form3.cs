using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фотоуслуги.Services;

namespace Фотоуслуги
{
    public partial class Form3 : Form
    {
        ManagerDbService db = new ManagerDbService();
        private int user_id;
        public Form3(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OrderDataGrid.DataSource = db.GetZakazList();
            OrderDataGrid.Columns[0].Visible = false;

            UslugaDataGrid.DataSource = db.GetUslugaList();
            UslugaDataGrid.Columns[0].Visible = false;

            KlientDataGrid.DataSource = db.GetKlientList();
            KlientDataGrid.Columns[0].Visible = false;

            UslugaTypeDataGrid.DataSource = db.GetUslugaTypes();
            UslugaTypeDataGrid.Columns[0].Visible = false;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UslugaTypeAddButton_Click(object sender, EventArgs e)
        {
            UslugaTypeEditor UTE = new UslugaTypeEditor(0, "add");
            if(UTE.ShowDialog() == DialogResult.OK)
            {
                UslugaTypeDataGrid.DataSource = db.GetUslugaTypes();
                UslugaTypeDataGrid.Columns[0].Visible = false;
            }
        }

        private void ClientAddButton_Click(object sender, EventArgs e)
        {
            KlientEditor KE = new KlientEditor(0, "add");
            if(KE.ShowDialog() == DialogResult.OK)
            {
                KlientDataGrid.DataSource = db.GetKlientList();
                KlientDataGrid.Columns[0].Visible = false;
            }
        }

        private void UslugaAddButton_Click(object sender, EventArgs e)
        {
            UslugaEditor UE = new UslugaEditor(0, "add");
            if(UE.ShowDialog() == DialogResult.OK)
            {
                UslugaDataGrid.DataSource = db.GetUslugaList();
                UslugaDataGrid.Columns[0].Visible = false;
            }
        }

        private void OrderAddButton_Click(object sender, EventArgs e)
        {
            OrderEditor OE = new OrderEditor(db.GetWorkerIdByUserId(user_id));
            if(OE.ShowDialog() == DialogResult.OK)
            {
                FullOrderEditor FUO = new FullOrderEditor(db.GetMaxOrderId());
                OrderDataGrid.DataSource = db.GetZakazList();
                OrderDataGrid.Columns[0].Visible = false;
                FUO.ShowDialog();
            }
        }

        private void OrderUpdateButton_Click(object sender, EventArgs e)
        {
            FullOrderEditor FOE = new FullOrderEditor(Convert.ToInt32(OrderDataGrid.SelectedRows[0].Cells[0].Value));
            if(FOE.ShowDialog() == DialogResult.OK)
            {
                OrderDataGrid.DataSource = db.GetZakazList();
                OrderDataGrid.Columns[0].Visible = false;
                FOE.Close();
            }
        }
    }
}
