using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class MaterialTypeForm : Form
    {
        private int materialType_id;
        private string mode;
        SkladDbService db = new SkladDbService();
        public MaterialTypeForm(int materialType_id, string mode)
        {
            InitializeComponent();
            this.materialType_id = materialType_id;
            this.mode = mode;
        }

        private void MaterialTypeForm_Load(object sender, EventArgs e)
        {
            if(mode == "edit")
            {
                DataTable dt = db.GetMaterialTypeById(materialType_id);
                foreach (DataRow item in dt.Rows)
                {
                    MaterialTypeBox.Text = item["TypeName"].ToString();
                }
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                db.CreateType(MaterialTypeBox.Text);
                this.DialogResult = DialogResult.OK;
            } 
            if(mode == "edit")
            {
                db.UpdateType(materialType_id, MaterialTypeBox.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
