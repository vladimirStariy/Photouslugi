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
        public UslugaTypeEditor(int id, string mode)
        {
            InitializeComponent();
            UslugaType_ID = id;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.CreateUslugaType(
                NameBox.Text
            );
            this.DialogResult = DialogResult.OK;
        }
    }
}
