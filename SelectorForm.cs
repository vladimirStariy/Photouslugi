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
    public partial class SelectorForm : Form
    {
        public int id;
        public string DisplayData;
        private string _mode;
        ManagerDbService db = new ManagerDbService();
        public SelectorForm(string mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(SelectorDataGrid.SelectedRows[0].Cells[0].Value);
            if (_mode == "klient")
                DisplayData = $"{SelectorDataGrid.SelectedRows[0].Cells[1].Value} {SelectorDataGrid.SelectedRows[0].Cells[2].Value}";
            if (_mode == "usluga")
                DisplayData = $"{SelectorDataGrid.SelectedRows[0].Cells[1].Value}";
            if (_mode == "material")
                DisplayData = $"{SelectorDataGrid.SelectedRows[0].Cells[1].Value}";
            this.DialogResult = DialogResult.OK;
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            if(_mode == "klient")
            {
                SelectorDataGrid.DataSource = db.GetKlientList();
                SelectorDataGrid.Columns[0].Visible = false;
            }
            if (_mode == "usluga")
            {
                SelectorDataGrid.DataSource = db.GetUslugaList();
                SelectorDataGrid.Columns[0].Visible = false;
            }
            if (_mode == "material")
            {
                SelectorDataGrid.DataSource = db.GetMaterials();
                SelectorDataGrid.Columns[0].Visible = false;
            }
        }
    }
}
