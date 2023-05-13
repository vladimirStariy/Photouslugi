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
    public partial class UslugaTypeEditor : Form
    {
        ManagerDbService db = new ManagerDbService();
        private int UslugaType_ID;
        private string mode;
        public UslugaTypeEditor(int id, string mode)
        {
            InitializeComponent();
            UslugaType_ID = id;
            this.mode = mode;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                db.CreateUslugaType
                (
                    NameBox.Text
                );
                this.DialogResult = DialogResult.OK;
            }
            if (mode == "edit")
            {
                db.UpdateUslugaType
                (
                    UslugaType_ID,
                    NameBox.Text
                );
                this.DialogResult = DialogResult.OK;
            }
        }

        private void UslugaTypeEditor_Load(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                DataTable dt = db.GetUslugaTypeById(UslugaType_ID);
                foreach (DataRow item in dt.Rows)
                {
                    NameBox.Text = item["UslugaTypeName"].ToString();
                }
            }
        }
    }
}
