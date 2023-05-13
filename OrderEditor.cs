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
    public partial class OrderEditor : Form
    {
        private int user_id;
        ManagerDbService db = new ManagerDbService();
        private int klient_id;
        public OrderEditor(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.AddZakaz(CompleteDateBox.Value, user_id, klient_id);
            this.DialogResult = DialogResult.OK;
        }

        private void KlientSlcBtn_Click(object sender, EventArgs e)
        {
            SelectorForm SF = new SelectorForm("klient");
            if(SF.ShowDialog() == DialogResult.OK)
            {
                KlientBox.Text = SF.DisplayData;
                klient_id = SF.id;
                SF.Close();
            }
        }
    }
}
