using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фотоуслуги;
using Фотоуслуги.Services;

namespace Фотоуслуги
{
    public partial class Form1 : Form
    {
        AuthDbService db = new AuthDbService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(db.Login(textBox1.Text, textBox2.Text) == "director")
            {
                
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else 
            if(db.Login(textBox1.Text, textBox2.Text) == "manager")
            {
                this.Hide();
                Form3 f = new Form3(db.GetIdByLogin(textBox1.Text));
                f.Show();
            }
            else
            if(db.Login(textBox1.Text, textBox2.Text) == "sklad")
            {
                this.Hide();
                Form4 f = new Form4(db.GetIdByLogin(textBox1.Text));
                f.Show();
            }
            else
            { 
                MessageBox.Show("Ошибка! Проверьте правильность ввода логина или пароля!"); 
            }
        }
    }
}
