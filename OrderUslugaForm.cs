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
    public partial class OrderUslugaForm : Form
    {
        private int _order_id;
        private int usluga_id;
        private int material_id;
        ManagerDbService db = new ManagerDbService();
        public OrderUslugaForm(int order_id)
        {
            InitializeComponent();
            _order_id = order_id;
        }

        private void UslugaSlcBtn_Click(object sender, EventArgs e)
        {
            SelectorForm SF = new SelectorForm("usluga");
            if (SF.ShowDialog() == DialogResult.OK)
            {
                UslugaBox.Text = SF.DisplayData;
                usluga_id = SF.id;
                SF.Close();
            }
        }

        private void MaterialSlcBtn_Click(object sender, EventArgs e)
        {
            SelectorForm SF = new SelectorForm("material");
            if (SF.ShowDialog() == DialogResult.OK)
            {
                MaterialZakaza.Text = SF.DisplayData;
                material_id = SF.id;
                SF.Close();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.AddUslugaZakaza(_order_id, usluga_id, material_id, Convert.ToInt32(CountBox.Text));
            this.DialogResult = DialogResult.OK;
        }
    }
}
