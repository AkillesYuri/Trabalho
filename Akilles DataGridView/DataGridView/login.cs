using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "joao" && textBox2.Text == "123")
            {
                Form1 form = new Form1();
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login Incorreto tente novamente");
            }
        }
    }
}
