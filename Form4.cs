﻿using System;
using System.Windows.Forms;
using Фотоуслуги.Services;

namespace Фотоуслуги
{
    public partial class Form4 : Form
    {
        SkladDbService db = new SkladDbService();
        private int user_id;
        public Form4(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        public void UpdateTables()
        {
            MaterialDataGrid.DataSource = db.GetMaterials();
            MaterialDataGrid.Columns[0].Visible = false;
            MaterialMovementDataGrid.DataSource = db.GetMaterialMovements();
            MaterialMovementDataGrid.Columns[0].Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MaterialDataGrid.DataSource = db.GetMaterials();
            MaterialDataGrid.Columns[0].Visible = false;

            MaterialTypeDataGrid.DataSource = db.GetMaterialTypes();
            MaterialTypeDataGrid.Columns[0].Visible = false;

            MaterialMovementDataGrid.DataSource = db.GetMaterialMovements();
            MaterialMovementDataGrid.Columns[0].Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialAddButton_Click(object sender, EventArgs e)
        {
            MaterialAddForm MAF = new MaterialAddForm();
            if(MAF.ShowDialog() == DialogResult.OK)
            {
                UpdateTables();
            }
        }

        private void MaterialPostButton_Click(object sender, EventArgs e)
        {
            MaterialIncreaseForm MIF = new MaterialIncreaseForm(Convert.ToInt32(MaterialDataGrid.SelectedRows[0].Cells[0].Value));
            if(MIF.ShowDialog() == DialogResult.OK)
            {
                UpdateTables();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MaterialDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteMaterial(Convert.ToInt32(MaterialDataGrid.SelectedRows[0].Cells[0].Value));
            }
            catch
            {
                MessageBox.Show("Невозможно удалить эту запись.");
            }
            UpdateTables();
        }

        private void MaterialTypeEditButton_Click(object sender, EventArgs e)
        {
            MaterialTypeForm MTF = new MaterialTypeForm(Convert.ToInt32(MaterialTypeDataGrid.SelectedRows[0].Cells[0].Value), "edit");
            if (MTF.ShowDialog() == DialogResult.OK)
            {
                MaterialTypeDataGrid.DataSource = db.GetMaterialTypes();
                MaterialTypeDataGrid.Columns[0].Visible = false;
                MTF.Close();
            }
        }

        private void MaterialTypeAddButton_Click(object sender, EventArgs e)
        {
            MaterialTypeForm MTF = new MaterialTypeForm(0, "add");
            if(MTF.ShowDialog() == DialogResult.OK)
            {
                MaterialTypeDataGrid.DataSource = db.GetMaterialTypes();
                MaterialTypeDataGrid.Columns[0].Visible = false;
                MTF.Close();
            }
        }

        private void MaterialTypeDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteType(Convert.ToInt32(MaterialTypeDataGrid.SelectedRows[0].Cells[0].Value));
            }
            catch
            {
                MessageBox.Show("Невозможно удалить эту запись.");
            }
            UpdateTables();
        }
    }
}
