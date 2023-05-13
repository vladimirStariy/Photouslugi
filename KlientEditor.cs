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
        private string mode;
        public KlientEditor(int id, string mode)
        {
            InitializeComponent();
            Klient_ID = id;
            this.mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                db.CreateKlient
                (
                    FamBox.Text,
                    NameBox.Text,
                    PotBox.Text,
                    AdrBox.Text,
                    Convert.ToInt32(PhoneBox.Text)
                );
                this.DialogResult = DialogResult.OK;
            }
            if (mode == "edit")
            {
                db.UpdateKlient
                (
                    Klient_ID,
                    FamBox.Text,
                    NameBox.Text,
                    PotBox.Text,
                    AdrBox.Text,
                    Convert.ToInt32(PhoneBox.Text)
                );
                this.DialogResult = DialogResult.OK;
            }
        }

        private void KlientEditor_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                DataTable dt = db.GetKlientById(Klient_ID);
                foreach (DataRow item in dt.Rows)
                {
                    FamBox.Text = item["fam"].ToString();
                    NameBox.Text = item["nam"].ToString();
                    PotBox.Text = item["pot"].ToString();
                    AdrBox.Text = item["adr"].ToString();
                    PhoneBox.Text = item["tel"].ToString();
                }
            }
        }
    }
}
