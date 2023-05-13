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
    public partial class UslugaEditor : Form
    {
        ManagerDbService db = new ManagerDbService();
        private int Usluga_ID;
        private string _mode;
        public UslugaEditor(int id, string mode)
        {
            InitializeComponent();
            Usluga_ID = id;
            _mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_mode == "edit")
            {
                db.UpdateUsluga(
                    Usluga_ID,
                    NameBox.Text,
                    Convert.ToInt32(UslugaTypeBox.SelectedValue),
                    Convert.ToDouble(StoimBox.Text)
                );
                this.DialogResult = DialogResult.OK;
            }
            else
            { 
                db.CreateUsluga(
                    NameBox.Text,
                    Convert.ToInt32(UslugaTypeBox.SelectedValue),
                    Convert.ToDouble(StoimBox.Text)
                );
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void UslugaEditor_Load(object sender, EventArgs e)
        {
            UslugaTypeBox.DataSource = db.GetUslugaTypes();
            UslugaTypeBox.DisplayMember = "Наименование";
            UslugaTypeBox.ValueMember = "UslugaType_Id";
            if(_mode == "edit")
            {
                DataTable dt = db.GetUslugaById(Usluga_ID);
                foreach (DataRow item in dt.Rows)
                {
                    NameBox.Text = item["nazv"].ToString();
                    UslugaTypeBox.SelectedValue = Convert.ToInt32(item["vid"]);
                    StoimBox.Text = item["stoim"].ToString();
                }
            }
        }
    }
}
