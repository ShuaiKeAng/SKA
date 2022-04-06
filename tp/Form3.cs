using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp
{
    public partial class Form3 : Form
    {
        public  Form1 f1;
        string s;
        Boolean jm;
        DateTime beforDT1;
        int ne = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            f1 = (Form1)this.Owner;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ne = 0;jm = true;
           beforDT1 = System.DateTime.Now;
            s = textBox1.Text;
            Thread mythread, mythread2, mythread3, mythread4,mythread5;
            mythread = new Thread(new ThreadStart(twi));
            mythread2 = new Thread(new ThreadStart(twi2));
            mythread3 = new Thread(new ThreadStart(twi3));
            mythread4 = new Thread(new ThreadStart(twi4));
            mythread5 = new Thread(new ThreadStart(twi5));
            mythread.Start();
            mythread2.Start();

            mythread3.Start();
            mythread4.Start();
            mythread5.Start();
          
            /*string s;
            s = textBox1.Text; DateTime beforDT = System.DateTime.Now;

            for (int j = 1; j <= f1.jh1.sum; j++)
            {
                f1.jh1.nowi = j;

                Application.DoEvents();
                f1.pictureBox1.Image = f1.jh1.tk[j].Image;
                Bitmap bb = f1.pictureBox1.Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                jm1.runp(s);
                f1.pictureBox1.Image = jm1.setnew().Clone() as Image;
                f1.jh1.tk[j].Image = f1.pictureBox1.Image;
            }

            f1.jh1.sle(f1.jh1.sum);
            if (textBox1.Text != null)
            {
                Myapp.Default.my += "批量加密：" + textBox1.Text + "|";
                f1.listBox1.Items.Add("批量加密：" + textBox1.Text);

            }
            */

        }
        public void fin()
        {
            if (ne == 5)
            {
                listBox1.Items.Add("全部完成");
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT1);
                listBox1.Items.Add("一共用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;
                f1.jh1.sle(f1.jh1.sum);
            }
        }
        public void twi()
        {
            for (int j = 1; j <= f1.jh1.sum; j+=5)
            {

                DateTime beforDT = System.DateTime.Now;
                Application.DoEvents();
            
                Bitmap bb = f1.jh1.tk[j].Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                if (jm == true)
                {
                    jm1.runp(s);
                }
                else
                {
                    jm1.runq(s);
                }
                f1.jh1.tk[j].Image = jm1.setnew().Clone() as Image;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                listBox1.Items.Add("第"+j.ToString()+ "张完成，用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;

            }
            ne++;
            fin();
        }
        public void twi2()
        {
            for (int j = 2; j <= f1.jh1.sum; j += 5)
            {
                DateTime beforDT = System.DateTime.Now;

                Application.DoEvents();

                Bitmap bb = f1.jh1.tk[j].Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                if (jm == true)
                {
                    jm1.runp(s);
                }
                else
                {
                    jm1.runq(s);
                }
                f1.jh1.tk[j].Image = jm1.setnew().Clone() as Image;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                listBox1.Items.Add("第" + j.ToString() + "张完成，用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            ne++; fin();
        }
        public void twi3()
        {
            for (int j = 3; j <= f1.jh1.sum; j += 5)
            {
                DateTime beforDT = System.DateTime.Now;

                Application.DoEvents();

                Bitmap bb = f1.jh1.tk[j].Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                if (jm == true)
                {
                    jm1.runp(s);
                }
                else
                {
                    jm1.runq(s);
                }
                f1.jh1.tk[j].Image = jm1.setnew().Clone() as Image;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                listBox1.Items.Add("第" + j.ToString() + "张完成，用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            ne++; fin();
        }

        public void twi4()
        {
            for (int j = 4; j <= f1.jh1.sum; j += 5)
            {
                DateTime beforDT = System.DateTime.Now;
                Application.DoEvents();

                Bitmap bb = f1.jh1.tk[j].Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                if (jm == true)
                {
                    jm1.runp(s);
                }
                else
                {
                    jm1.runq(s);
                }
                f1.jh1.tk[j].Image = jm1.setnew().Clone() as Image;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                listBox1.Items.Add("第" + j.ToString() + "张完成，用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            ne++; fin();
        }
        public void twi5()
        {
            for (int j = 5; j <= f1.jh1.sum; j += 5)
            {
                DateTime beforDT = System.DateTime.Now;

                Application.DoEvents();

                Bitmap bb = f1.jh1.tk[j].Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                if (jm == true)
                {
                    jm1.runp(s);
                }
                else
                {
                    jm1.runq(s);
                }
                f1.jh1.tk[j].Image = jm1.setnew().Clone() as Image;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT);
                listBox1.Items.Add("第" + j.ToString() + "张完成，用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            ne++; fin();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            ne = 0;jm = false;
            beforDT1 = System.DateTime.Now;
            s = textBox1.Text;
            Thread mythread, mythread2, mythread3, mythread4, mythread5;
            mythread = new Thread(new ThreadStart(twi));
            mythread2 = new Thread(new ThreadStart(twi2));
            mythread3 = new Thread(new ThreadStart(twi3));
            mythread4 = new Thread(new ThreadStart(twi4));
            mythread5 = new Thread(new ThreadStart(twi5));
            mythread.Start();
            mythread2.Start();

            mythread3.Start();
            mythread4.Start();
            mythread5.Start();
          
        }
    }
    

}
