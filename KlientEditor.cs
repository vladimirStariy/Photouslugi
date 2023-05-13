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
    public partial class KlientEditor : Form
    {
        ManagerDbService db = new ManagerDbService();
        private int Klient_ID;
        public KlientEditor(int id, string mode)
        {
            InitializeComponent();
            Klient_ID = id;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.CreateKlient(
                FamBox.Text,
                NameBox.Text,
                PotBox.Text,
                AdrBox.Text,
                Convert.ToInt32(PhoneBox.Text)
            );
            this.DialogResult = DialogResult.OK;
        }
    }
}
