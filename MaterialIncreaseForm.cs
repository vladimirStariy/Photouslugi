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
    public partial class MaterialIncreaseForm : Form
    {
        SkladDbService db = new SkladDbService();
        public int material_id;
        public MaterialIncreaseForm(int id)
        {
            InitializeComponent();
            material_id = id;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            db.IncreaseMaterialCount(Convert.ToInt32(CountBox.Text), 
                                     Convert.ToDouble(PriceBox.Text),
                                     material_id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
