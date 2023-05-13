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
    public partial class FullOrderEditor : Form
    {
        private int order_id;
        private int klient_id;

        ManagerDbService db = new ManagerDbService();
        public FullOrderEditor(int order_id)
        {
            InitializeComponent();
            this.order_id = order_id;
        }

        private void FullOrderEditor_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetZakazById(order_id);
            DataTable klientDt = new DataTable();
            foreach (DataRow item in dt.Rows)
            {
                OrderDateLbl.Text = "Дата заказа: " + item["data_zayavki"].ToString();
                klientDt = db.GetKlientById(Convert.ToInt32(item["id_klienta"]));
                klient_id = Convert.ToInt32(item["id_klienta"]);
            }
            foreach (DataRow item in klientDt.Rows)
            {
                KlientBox.Text = item["fam"].ToString() + " " + item["nam"].ToString();
            }
            PriceLbl.Text = "Стоимость: " + db.GetOrderPrice(order_id);

            OrderDataGrid.DataSource = db.GetUslugaZakaza(order_id);
            OrderDataGrid.Columns[0].Visible = false;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void OrderUslugaAddButton_Click(object sender, EventArgs e)
        {
            OrderUslugaForm OUF = new OrderUslugaForm(order_id);
            if(OUF.ShowDialog() == DialogResult.OK)
            {
                OrderDataGrid.DataSource = db.GetUslugaZakaza(order_id);
                OrderDataGrid.Columns[0].Visible = false;
                PriceLbl.Text = "Стоимость: " + db.GetOrderPrice(order_id);
                OUF.Close();
            }
        }
    }
}
