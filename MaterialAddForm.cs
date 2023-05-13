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
    public partial class MaterialAddForm : Form
    {
        SkladDbService db = new SkladDbService();

        public MaterialAddForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.CreateMaterial(NaimBox.Text, 
                              Convert.ToInt32(CountBox.Text), 
                              Convert.ToDouble(PriceBox.Text), 
                              Convert.ToInt32(MaterialTypeBox.SelectedValue));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MaterialAddForm_Load(object sender, EventArgs e)
        {
            MaterialTypeBox.DataSource = db.GetMaterialTypes();
            MaterialTypeBox.DisplayMember = "Наименование";
            MaterialTypeBox.ValueMember = "Type_Id";
        }
    }
}
