using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Myapp.Default.dyc == true)
            {
                this.Visible = false;
                MessageBox.Show("这是你第一次打开程序，你可以在设置界面使用演示功能来更快地熟悉和使用本程序");
                Form1.form.Visible = true;
                Myapp.Default.dyc = false;
               
            }
            else
            {
                this.Visible = false;
            }
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Myapp.Default.dyc == true)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
