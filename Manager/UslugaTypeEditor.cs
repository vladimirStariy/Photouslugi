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

namespace Фотоуслуги.Manager
{
    public partial class UslugaTypeEditor : Form
    {
        ManagerDbService db = new ManagerDbService();
        public int type_id;

        public UslugaTypeEditor(int id)
        {
            InitializeComponent();
            type_id = id;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
