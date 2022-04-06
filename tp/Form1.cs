using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp
{


    public partial class Form1 : Form

    {
        int leftbarwidth;
        Boolean xd = true;
        Form3 ff3;
        Point np1;
        Boolean zxd = true;
        Boolean lj = true;
        int ci = 0;
        int di = 0;
        int ei = 0;
        int fi = 0;
        int gi = 0;
        int hi = 0;
        int ji = 0;
        int cox = 128;
        int coy = 128;
        int cot = 128;
        Boolean zd = true;
        int blxs = 1;
        Form2 form2;
        Boolean ax = false;
        public jmjpg jmjpg1 = new jmjpg();
        public static Form1 form;
        public  jh jh1 = new jh();//原本是static的，form3加入后只能去掉
        public int mw = 980, mh = 600;
        public pp p1 = new pp();
        public pp pp2 = new pp();
        public pp pp3 = new pp();
        hhjm hh1 = new hhjm();
        public Boolean xq = false;
        Bitmap newb;
        public Point start, s1, s2;//画框的起始点
        Point end;//画框的结束点<br>bool blnDraw;//判断是否绘制<br>Rectangel rect;
        Boolean blnDraw = false;
        Rectangle rect;
        int zy = 0;
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Jpg 图片|*.jpg|Jpeg 图片|*.jpeg|Bmp 图片|*.bmp";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (panel2.Visible == true)
                {

                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    pictureBox1.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                    fileStream.Dispose();
                    //pictureBox1.ImageLocation = openFileDialog1.FileName;
                    
                        jh1.addone(openFileDialog1.FileName);
                    
                }
                else if (panel9.Visible == true)
                {


                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    pictureBox3.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                    fileStream.Dispose();

                   // pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox5.Image = pictureBox3.Image;
                    Application.DoEvents();
                    hh1.setraw1(pictureBox5.Image as Bitmap);
                    // pp4.rewrite(pictureBox3.Image as Bitmap);
                }
                else if (panel15.Visible == true)
                {
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    pictureBox6.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                    fileStream.Dispose();
                    //pictureBox6.Image = Image.FromFile(openFileDialog1.FileName);
                }
                
            }
            if (ci != 0)
            {
                ci=2;
                cgjmys(ci);
            }
            if (di != 0)
            {
                di=2;
                jbjmys(di);
            }
            if (ei != 0)
            {
                ei = 2;
                jbjmys2(ei);
            }
            if (fi != 0)
            {
                fi = 2;
                hhjmys(fi);
            }
            if (gi != 0)
            {
                gi = 2;
                hhjmys2(gi);
            }
            if (hi != 0)
            {
                hi = 2;
                kysjmys(hi);
            }
            if (ji != 0)
            {
                ji = 2;
                kysjmys2(ji);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            string localFilePath = saveFileDialog1.FileName.ToString(); //获得文件路径

            saveFileDialog1.Filter = "Bmp 图片|*.bmp|JPEG 图片|*.jpeg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    //saveFileDialog1.CheckPathExists = true;
                    if (panel2.Visible == true)
                    {
                        pp p = new pp();
                        Bitmap B;
                        p.rewrite(pictureBox1.Image as Bitmap);
                        B = p.rep();


                        B.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else if (panel9.Visible == true)
                    {
                        pictureBox3.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else if (panel15.Visible == true)
                    {
                        pictureBox8.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }

                }
                else
                {
                    //saveFileDialog1.CheckPathExists = true;
                    if (panel2.Visible == true)
                    {
                        pp p = new pp();
                        Bitmap B;
                        p.rewrite(pictureBox1.Image as Bitmap);
                        B = p.rep();


                        B.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (panel9.Visible == true)
                    {
                        pictureBox3.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (panel15.Visible == true)
                    {
                        pictureBox8.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }



                MessageBox.Show("保存成功");
            }
            if (ci != 0)
            {
                ci=4;
                cgjmys(ci);
            }
            if (di != 0)
            {
                di=6;
                jbjmys(di);
            }
            if (ei != 0)
            {
                ei = 6;
                jbjmys2(ei);
            }
            if (fi != 0)
            {
                fi = 5;
                hhjmys(fi);
            }
            if (gi != 0)
            {
                gi = 5;
                hhjmys2(gi);
            }
            if (hi != 0)
            {
                hi = 4;
                kysjmys(hi);
            }
            if (ji != 0)
            {
                ji = 4;
                kysjmys2(ji);
            }

        }

        private void 原始大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void 自动缩放ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.Text = panel1.Width.ToString();
            //button1.Text = panel1.Size.Width.ToString();
            /* if (panel1.Width == 54)
             {
                 //button1.Text = Form1.ActiveForm.Height.ToString();
                 timer1.Enabled = true;
             }*/


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width = (int)(panel1.Width * 0.8 + leftbarwidth * 3 * 0.2);
            panel2.Left = panel1.Left + panel1.Width + 3;
            panel9.Left = panel2.Left;
            panel15.Left = panel2.Left;
            panel18.Left = panel2.Left;
           
            // this.Width = mw + panel1.Width - 53;

            if (panel1.Width > leftbarwidth * 2.9)
            {
                panel1.Width = leftbarwidth * 3;
                panel2.Left = panel1.Left + panel1.Width + 3;
                panel9.Left = panel2.Left;
                panel15.Left = panel2.Left;
                panel18.Left = panel2.Left;
               
                // this.Width = mw + panel1.Width - 53;

                timer1.Enabled = false;

            }

        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Width = (int)(panel1.Width * 0.8 + leftbarwidth * 0.2);
            panel2.Left = panel1.Left + panel1.Width + 3;
            panel9.Left = panel2.Left;
            panel15.Left = panel2.Left;
            panel18.Left = panel2.Left;
           
            //this.Width = mw + panel1.Width - 53;
            if (panel1.Width < leftbarwidth * 1.1)
            {
                panel1.Width = leftbarwidth ;
                panel2.Left = panel1.Left + panel1.Width + 3;
                panel9.Left = panel2.Left;
                panel15.Left = panel2.Left;
                panel18.Left = panel2.Left;
               
                // this.Width = mw + panel1.Width - 53;
                timer2.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form = this;
            Form1.ActiveForm.Width = mw;
            Form1.ActiveForm.Height = mh;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel3.Width;
            pictureBox1.Height = panel3.Height;
            string s = Myapp.Default.my;
            char[] arr = s.ToCharArray();
            string sl = "";
            if (s != null)
            {

                for (int i = 0; i < s.Length; i++)
                {

                    // listBox1.Items.Add(sl);
                    if (arr[i] == '|')
                    {
                        //label8.Text = "hh";
                        listBox1.Items.Add(sl);
                        sl = "";
                    }
                    else
                    {
                        sl += arr[i];
                    }
                }

            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel3.Width;
            pictureBox1.Height = panel3.Height;
          




        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image != null)
            { if (timer3.Enabled == false)
                {
                    string s;
                    s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
                    progressBar1.Value = 0;
                    Bitmap bb = pictureBox1.Image as Bitmap;
                    jm jm1 = new jm();
                    jm1.getraw(bb);
                    jm1.runp(s);

            
                    pictureBox1.Image = jm1.setnew().Clone() as Image;
                    DateTime afterDT = System.DateTime.Now;
                    TimeSpan ts = afterDT.Subtract(beforDT);
                    label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
                    label1.Left = label2.Left + label2.Width;
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                }
                else
                {
                    string s;
                    s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
                    progressBar1.Value = 0;
                    Bitmap bb = pictureBox1.Image as Bitmap;
                    jm jm1 = new jm();
                    jm1.getraw2(bb);
                    jm1.runp(s);


                    pictureBox1.Image = jm1.setnew2().Clone() as Image;
                    DateTime afterDT = System.DateTime.Now;
                    TimeSpan ts = afterDT.Subtract(beforDT);
                    label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
                    label1.Left = label2.Left + label2.Width;
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;



                }
            if (textBox1.Text != null)
                {
                    Myapp.Default.my += "常规加密：" + textBox1.Text+"|";
                    listBox1.Items.Add("常规加密：" + textBox1.Text);

                }

            }
            if (ci != 0)
            {
                ci=3;
                cgjmys(ci);
            }
            if (di != 0)
            {
                di=5;
                jbjmys(di);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (timer3.Enabled == false)
                {
                    string s;
                    progressBar1.Value = 0;
                    s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
                    Bitmap bb = pictureBox1.Image as Bitmap;
                    jm jm1 = new jm();
                    jm1.getraw(bb);
                    jm1.runq(s);


                    pictureBox1.Image = jm1.setnew().Clone() as Image;
                    DateTime afterDT = System.DateTime.Now;
                    TimeSpan ts = afterDT.Subtract(beforDT);
                    label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
                    label1.Left = label2.Left + label2.Width;
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                }
                else
                {
                    string s;
                    progressBar1.Value = 0;
                    s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
                    Bitmap bb = pictureBox1.Image as Bitmap;
                    jm jm1 = new jm();
                    jm1.getraw2(bb);
                    jm1.runq(s);


                    pictureBox1.Image = jm1.setnew2().Clone() as Image;
                    DateTime afterDT = System.DateTime.Now;
                    TimeSpan ts = afterDT.Subtract(beforDT);
                    label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
                    label1.Left = label2.Left + label2.Width;
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                }
                if (textBox1.Text != null)
                {
                    Myapp.Default.my += "常规解密：" + textBox1.Text+"|";
                    listBox1.Items.Add("常规解密：" + textBox1.Text);

                }
            }
            if (ei != 0)
            {
                ei = 5;
                jbjmys2(ei);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Jpg 图片|*.jpg|Bmp 图片|*.bmp";
            openFileDialog2.FileName = "";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                foreach (String s in openFileDialog2.FileNames)
                {
                    jh1.addone(s);
                    if (jh1.sum == 1000) break;
                }

                pictureBox1.Image = jh1.tk[jh1.nowi].Image;
            }

        }
        public void tk_Click(object sender, EventArgs e)
        {

            int j = 0;
            foreach (kk i in jh1.tk)
            {
                if (i == ((kk)sender)) break; j++;
            }
            jh1.sle(j);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s;
            s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
            progressBar1.Value = 0;


            for (int j = 1; j <= jh1.sum; j++)
            {
                jh1.nowi = j;
                label3.Text = jh1.nowi.ToString() + "/" + jh1.sum.ToString();
                Application.DoEvents();
                pictureBox1.Image = jh1.tk[j].Image;
                Bitmap bb = pictureBox1.Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                jm1.runp(s);
                pictureBox1.Image = jm1.setnew().Clone() as Image;
                jh1.tk[j].Image = pictureBox1.Image;
            }
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
            label1.Left = label2.Left + label2.Width;
            jh1.sle(jh1.sum);
            if (textBox1.Text != null)
            {
                Myapp.Default.my += "批量加密：" + textBox1.Text+"|";
                listBox1.Items.Add("批量加密：" + textBox1.Text);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string s;
            s = textBox1.Text; DateTime beforDT = System.DateTime.Now;
            progressBar1.Value = 0;


            for (int j = 1; j <= jh1.sum; j++)
            {
                jh1.nowi = j;
                label3.Text = jh1.nowi.ToString() + "/" + jh1.sum.ToString();
                Application.DoEvents();
                pictureBox1.Image = jh1.tk[j].Image;
                Bitmap bb = pictureBox1.Image as Bitmap;
                jm jm1 = new jm();
                jm1.getraw(bb);
                jm1.runq(s);
                pictureBox1.Image = jm1.setnew().Clone() as Image;
                jh1.tk[j].Image = pictureBox1.Image;
            }
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            label1.Text = "用时：" + (((int)ts.TotalMilliseconds) / 1000.0).ToString() + "S";
            label1.Left = label2.Left + label2.Width;
            jh1.sle(jh1.sum);
            if (textBox1.Text != null)
            {
                Myapp.Default.my += "批量解密：" + textBox1.Text+"|";
                listBox1.Items.Add("批量解密：" + textBox1.Text);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //获得文件路径
            if (checkBox3.Checked == false)
            {
                saveFileDialog2.Filter = "Bmp 图片|*.bmp|JPEG 图片|*.jpeg";
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog2.FilterIndex == 1)
                    {
                        string localFilePath = saveFileDialog2.FileName.ToString();
                        String FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                        String fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                        for (int i = 1; i <= jh1.sum; i++)
                        {
                            pp p = new pp();
                            Bitmap B;
                            p.rewrite(jh1.tk[i].Image as Bitmap);
                            B = p.rep();
                            // textBox1.Text += FilePath + "\\" + fileNameExt;
                            B.Save(FilePath + "\\" + "(" + i.ToString() + ")" + fileNameExt, System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    else
                    {
                        string localFilePath = saveFileDialog2.FileName.ToString();
                        String FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                        String fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                        for (int i = 1; i <= jh1.sum; i++)
                        {
                            pp p = new pp();
                            Bitmap B;
                            p.rewrite(jh1.tk[i].Image as Bitmap);
                            B = p.rep();
                            // textBox1.Text += FilePath + "\\" + fileNameExt;
                            B.Save(FilePath + "\\" + "(" + i.ToString() + ")" + fileNameExt, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }


                    MessageBox.Show("保存成功");
                }
            }
            else
            {
                if (jh1.sum > 0)
                {
                    for (int i = 1; i <= jh1.sum; i++)
                    {
                        pp p = new pp();
                        Bitmap B;
                        p.rewrite(jh1.tk[i].Image as Bitmap);
                        B = p.rep();
                        // textBox1.Text += FilePath + "\\" + fileNameExt;
                        B.Save(jh1.tk[i].st, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    MessageBox.Show("已保存图片至原路径");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (jh1.nowi != 0)
            {
                jh1.moveone(jh1.nowi);
            }
            if (jh1.sum == 0)
            {
                pictureBox1.Image = null;
                label3.Text = "";
                label2.Text = "";
            }
            {
                timer3.Enabled = false;
                pictureBox1.Invalidate();
                Application.DoEvents();
                textBox2.Text = "";
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { if (xq == true)
            {
                start = e.Location;
                Invalidate();
                blnDraw = true;
                textBox2.Text = "";
            }
            else
            {
                blnDraw = true;
                start = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        { if (xq)
            {
                if (blnDraw)
                {
                    if (e.Button != MouseButtons.Left)//判断是否按下左键
                        return;
                    Point tempEndPoint = e.Location;//记录框的位置和大小
                    rect.Location = new Point(
                    Math.Min(start.X, tempEndPoint.X),
                    Math.Min(start.Y, tempEndPoint.Y));
                    rect.Size = new Size(
                    Math.Abs(start.X - tempEndPoint.X),
                    Math.Abs(start.Y - tempEndPoint.Y));
                    pictureBox1.Invalidate();
                }
            }
            else
            {
                if (blnDraw)
                {
                    Point now = e.Location;
                    pictureBox1.Left = pictureBox1.Left - start.X + now.X;
                    pictureBox1.Top = pictureBox1.Top - start.Y + now.Y;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (xq)
            {
                blnDraw = false;//结束绘制
                if (pictureBox1.Image != null)
                {
                    textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
                    timer3.Enabled = true;
                }
                if (di != 0)
                {
                    di=4;
                    jbjmys(di);
                }
            }
            else
            {
                blnDraw = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { if (xq)
            {
                if (blnDraw)
                {
                    if (pictureBox1.Image != null)
                    {
                        if (rect != null && rect.Width > 0 && rect.Height > 0)
                        {
                            e.Graphics.DrawRectangle(new Pen(Color.Red, 2), rect);//重新绘制颜色为红色
                                                                                  // p1.rewrite(pictureBox1.Image as Bitmap);
                            s1.X = rect.X; s1.Y = rect.Y;
                            s2.X = rect.X + rect.Width; s2.Y = rect.Y + rect.Height;
                            s1 = topi(s1);
                            s2 = topi(s2);
                            /* for (int i = s1.X; i <= s2.X; i++){
                               p1.setp(s1.Y, i, 65536);
                              }
                              for (int i = s1.X; i <= s2.X; i++)
                              {
                                  p1.setp(s2.Y, i, 65536);
                              }
                              for (int i = s1.Y; i <= s2.Y; i++)
                              {
                                  p1.setp(i, s1.X, 65536);
                              }
                              for (int i = s1.Y; i <= s2.Y; i++)
                              {
                                  p1.setp(i, s2.X, 65536);
                              }

                              textBox1.Text = s2.X.ToString();
                              pictureBox1.Image=p1.rep().Clone()as Image;*/
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pp smp = new pp();

                smp.rewrite(pictureBox1.Image as Bitmap);
                int w = smp.width;
                int h = smp.height;
                int[,] rc = new int[h + 1, w + 1];
                int[] wmax = new int[w + 1];
                int[] wwmax = new int[w + 1];
                int[] hmax = new int[h + 1];
                int[] hhmax = new int[h + 1];
                int sw = 1, sh = 1;
                int max = 1;
                int max2 = 1;
                int max3 = 1;
                int max4 = 1;
                if (timer3.Enabled == true)
                {
                    w = s2.X;
                    h = s2.Y;
                    sw = s1.X;
                    sh = s1.Y;
                    max = sw;
                    max2 = sw;
                    max3 = sh;
                    max4 = sh;
                }
                int nnum = 150;
                for (int i = sw; i <= w; i++)
                {
                    for (int j = sh; j <= h - 1; j++)
                    {
                        rc[j, i] = Math.Abs(smp.getr(j, i) - smp.getr(j + 1, i)) + Math.Abs(smp.getg(j, i) - smp.getg(j + 1, i)) + Math.Abs(smp.getb(j, i) - smp.getb(j + 1, i));
                    }
                }
                for (int i = sw; i <= w; i++)
                {
                    for (int j = sh; j <= h - 1; j++)
                    {
                        if (rc[j, i] > nnum) wmax[i]++;
                    }
                }
                for (int i = sw; i <= w - 1; i++)
                {
                    wwmax[i] = Math.Abs(wmax[i] - wmax[i + 1]);
                }
                for (int i = sw; i <= w - 1; i++)
                {
                    if (wwmax[i] > wwmax[max]) max = i;
                }
                for (int i = sw; i <= w - 1; i++)
                {
                    if (wwmax[i] > wwmax[max2] && i != max)
                    {
                        max2 = i;
                    }
                }
                if (max2 < max)
                {
                    int t;
                    t = max;
                    max = max2;
                    max2 = t;
                }
                max++;
                for (int i = sw; i <= w - 1; i++)
                {
                    for (int j = sh; j <= h; j++)
                    {
                        rc[j, i] = Math.Abs(smp.getr(j, i) - smp.getr(j, i + 1)) + Math.Abs(smp.getg(j, i) - smp.getg(j, i + 1)) + Math.Abs(smp.getb(j, i) - smp.getb(j, i + 1));
                    }
                }
                for (int i = sw; i <= w - 1; i++)
                {
                    for (int j = sh; j <= h; j++)
                    {
                        if (rc[j, i] > nnum) hmax[j]++;
                    }
                }
                for (int i = sh; i <= h - 1; i++)
                {
                    hhmax[i] = Math.Abs(hmax[i] - hmax[i + 1]);
                }
                for (int i = sh; i <= h - 1; i++)
                {
                    if (hhmax[i] > hhmax[max3]) max3 = i;
                }
                for (int i = sh; i <= h - 1; i++)
                {
                    if (hhmax[i] > hhmax[max4] && i != max3)
                    {
                        max4 = i;
                    }
                }
                if (max4 < max3)
                {
                    int t;
                    t = max3;
                    max3 = max4;
                    max4 = t;
                }
                max3++;






                smp.rep();
                s1.X = max;
                s1.Y = max3;
                s2.X = max2;
                s2.Y = max4;
                textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
                timer3.Enabled = true;
            }
            if (ei != 0)
            {
                ei = 4;
                jbjmys2(ei);
            }

        }

        private void timer3_Tick(object sender, EventArgs e)

        { if (pictureBox1.Image != null)
            {
                pictureBox1.Invalidate();
                Application.DoEvents();
              
                Graphics a = pictureBox1.CreateGraphics();
                Rectangle rr = new Rectangle();
                rect = rr;

                rr.X = itop(s1).X;
                rr.Y = itop(s1).Y;
                rr.Width = itop(s2).X - itop(s1).X;
                rr.Height = itop(s2).Y - itop(s1).Y;
                // textBox1.Text = rr.X.ToString() + " " + rr.Y.ToString() + " "+rr.Width.ToString()+" "+rr.Height.ToString();
                a.DrawRectangle(new Pen(Color.Red, 2), rr);
            }
            else
            {
                timer3.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
                timer3.Enabled = false;
                pictureBox1.Invalidate();
                Application.DoEvents();
                pictureBox1.Invalidate();
                textBox2.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
            {
                button13.Enabled = false;
                button14.Enabled = false;
                panel8.Visible = true;


                {
                    timer3.Enabled = false;
                    pictureBox1.Invalidate();
                    Application.DoEvents();
                    textBox2.Text = "";
                }

            }
            else
            {
                button13.Enabled = true;
                button14.Enabled = true;
                panel8.Visible = false;
            }
            zy = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            zy = 1;
            sx(0);



        }

        private void button17_Click(object sender, EventArgs e)
        {
            zy = 2;
            sx(0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sx(-1);
            textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sx(1);
            textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
        }

        public void sx(int anum)
        { if (pictureBox1.Image != null)
            {
                int numx = 0, numy = 0;
                if (zy != 0)
                {
                    pp2.rewrite(pictureBox1.Image as Bitmap);
                    newb = new Bitmap(53 * 7, 29 * 7, PixelFormat.Format24bppRgb);
                    pp3.rewrite(newb);
                    if (zy == 1)
                    {

                        s1.Y += anum;
                        if (s1.Y < 1) s1.Y = 1;
                        if (s1.Y > pp2.height) s1.Y = pp2.height;
                        for (int i = 1; i <= 29; i++)
                        {
                            for (int j = 1; j <= 53; j++)
                            {
                                numy = s1.Y - 14 + i - 1;
                                numx = s1.X - 26 + j - 1;
                                if (numy < 1) numy = 1;
                                if (numy > pp2.height) numy = pp2.height;
                                if (numx < 1) numx = 1;
                                if (numx > pp2.width) numx = pp2.width;



                                for (int ii = 1; ii <= 7; ii++)
                                {
                                    for (int jj = 1; jj <= 7; jj++)
                                    {


                                        pp3.setp((i - 1) * 7 + ii, (j - 1) * 7 + jj, pp2.getp(numy, numx));

                                    }
                                }


                            }
                        }



                    }
                    else if (zy == 2)
                    {
                        s2.Y += anum;
                        if (s2.Y < 1) s2.Y = 1;
                        if (s2.Y > pp2.height) s2.Y = pp2.height;
                        for (int i = 1; i <= 29; i++)
                        {
                            for (int j = 1; j <= 53; j++)
                            {
                                numy = s2.Y - 14 + i - 1;
                                numx = s2.X - 26 + j - 1;
                                if (numy < 1) numy = 1;
                                if (numy > pp2.height) numy = pp2.height;
                                if (numx < 1) numx = 1;
                                if (numx > pp2.width) numx = pp2.width;


                                for (int ii = 1; ii <= 7; ii++)
                                {
                                    for (int jj = 1; jj <= 7; jj++)
                                    {


                                        pp3.setp((i - 1) * 7 + ii, (j - 1) * 7 + jj, pp2.getp(numy, numx));

                                    }
                                }
                                //pp3.setp(i, j, pp2.getp(numy, numx));


                            }
                        }
                    }
                    for (int j = 1; j <= 7; j++)
                    {
                        for (int i = 1; i <= 29 * 7; i++)
                        {
                            pp3.setp(i, 26 * 7 + j, 255);
                        }
                        for (int i = 1; i <= 53 * 7; i++)
                        {
                            pp3.setp(14 * 7 + j, i, 255);
                        }
                    }
                    pictureBox2.Image = pp3.rep().Clone() as Image;
                    pp2.rep();

                    pictureBox1.Invalidate();
                    Application.DoEvents();
                    Graphics a = pictureBox1.CreateGraphics();
                    Rectangle rr = new Rectangle();
                    rect = rr;
                    rr.X = itop(s1).X;
                    rr.Y = itop(s1).Y;
                    rr.Width = itop(s2).X - itop(s1).X;
                    rr.Height = itop(s2).Y - itop(s1).Y;
                    // textBox1.Text = rr.X.ToString() + " " + rr.Y.ToString() + " "+rr.Width.ToString()+" "+rr.Height.ToString();
                    a.DrawRectangle(new Pen(Color.Red, 2), rr);


                }
            }
        }
        public void sx2(int anum)
        { if (pictureBox1.Image != null)
            {
                int numx = 0, numy = 0;
                if (zy != 0)
                {
                    pp2.rewrite(pictureBox1.Image as Bitmap);
                    newb = new Bitmap(53 * 7, 29 * 7, PixelFormat.Format24bppRgb);
                    pp3.rewrite(newb);
                    if (zy == 1)
                    {

                        s1.X += anum;
                        if (s1.X < 1) s1.X = 1;
                        if (s1.X > pp2.width) s1.X = pp2.width;
                        for (int i = 1; i <= 29; i++)
                        {
                            for (int j = 1; j <= 53; j++)
                            {
                                numy = s1.Y - 14 + i - 1;
                                numx = s1.X - 26 + j - 1;
                                if (numy < 1) numy = 1;
                                if (numy > pp2.height) numy = pp2.height;
                                if (numx < 1) numx = 1;
                                if (numx > pp2.width) numx = pp2.width;

                                for (int ii = 1; ii <= 7; ii++)
                                {
                                    for (int jj = 1; jj <= 7; jj++)
                                    {


                                        pp3.setp((i - 1) * 7 + ii, (j - 1) * 7 + jj, pp2.getp(numy, numx));

                                    }
                                }
                                //  pp3.setp(i, j, pp2.getp(numy, numx));
                            }
                        }



                    }
                    else if (zy == 2)
                    {
                        s2.X += anum;
                        if (s2.X < 1) s2.X = 1;
                        if (s2.X > pp2.width) s2.X = pp2.width;
                        for (int i = 1; i <= 29; i++)
                        {
                            for (int j = 1; j <= 53; j++)
                            {
                                numy = s2.Y - 14 + i - 1;
                                numx = s2.X - 26 + j - 1;
                                if (numy < 1) numy = 1;
                                if (numy > pp2.height) numy = pp2.height;
                                if (numx < 1) numx = 1;
                                if (numx > pp2.width) numx = pp2.width;

                                for (int ii = 1; ii <= 7; ii++)
                                {
                                    for (int jj = 1; jj <= 7; jj++)
                                    {


                                        pp3.setp((i - 1) * 7 + ii, (j - 1) * 7 + jj, pp2.getp(numy, numx));

                                    }
                                }
                                //pp3.setp(i, j, pp2.getp(numy, numx));
                            }
                        }
                    }

                    for (int j = 1; j <= 7; j++)
                    {
                        for (int i = 1; i <= 29 * 7; i++)
                        {
                            pp3.setp(i, 26 * 7 + j, 255);
                        }
                        for (int i = 1; i <= 53 * 7; i++)
                        {
                            pp3.setp(14 * 7 + j, i, 255);
                        }
                    }
                    pictureBox2.Image = pp3.rep().Clone() as Image;
                    pp2.rep();

                    pictureBox1.Invalidate();
                    Application.DoEvents();
                    Graphics a = pictureBox1.CreateGraphics();
                    Rectangle rr = new Rectangle();
                    rect = rr;
                    rr.X = itop(s1).X;
                    rr.Y = itop(s1).Y;
                    rr.Width = itop(s2).X - itop(s1).X;
                    rr.Height = itop(s2).Y - itop(s1).Y;
                    // textBox1.Text = rr.X.ToString() + " " + rr.Y.ToString() + " "+rr.Width.ToString()+" "+rr.Height.ToString();
                    a.DrawRectangle(new Pen(Color.Red, 2), rr);


                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sx2(-1);
            textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sx2(1);
            textBox2.Text = s1.X.ToString() + "*" + s1.Y.ToString() + "|" + s2.X.ToString() + "*" + s2.Y.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (s1.X < s2.X && s1.Y < s2.Y)
            {
                timer3.Enabled = true;
                panel8.Visible = false;
                button13.Enabled = true;
                button14.Enabled = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            
            if (xd == true)
            {
                button23.Text = "<<<<<<<<<<<<<<<<";
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
            else
            {
                button23.Text = ">>>";
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            xd = !xd;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (xq == false)
            {
                xq = true;
                button24.BackColor = Color.FromArgb(150, 150, 150);
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                if (di != 0)
                {
                    di=3;
                    jbjmys(di);
                }
                if (ei != 0)
                {
                    ei = 3;
                    jbjmys2(ei);
                }
            }
            else
            {
                xq = false;
                {
                    timer3.Enabled = false;
                    pictureBox1.Invalidate();
                    Application.DoEvents();
                    pictureBox1.Invalidate();
                    textBox2.Text = "";
                }
                panel8.Visible = false;
                button24.BackColor = Color.FromArgb(224, 224, 224);
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
            panel15.Visible = false;
            panel18.Visible = false;
            button26.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel15.Visible = false;
            panel9.Visible = true;
            panel18.Visible = false;
            button27.BackColor = Color.Silver;
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void button28_Click(object sender, EventArgs e)
        { double q = 1.5;
            if (pictureBox1.Width < panel3.Width * 6)
            {
                pictureBox1.Top = (int)(panel3.Height * 0.5 - (panel3.Height * 0.5 - pictureBox1.Top) * q);
                pictureBox1.Left = (int)(panel3.Width * 0.5 - (panel3.Width * 0.5 - pictureBox1.Left) * q);
                pictureBox1.Width = (int)(pictureBox1.Width * q);
                pictureBox1.Height = (int)(pictureBox1.Height * q);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double q = 0.667;
            if (pictureBox1.Height > 100)
            {
                pictureBox1.Top = (int)(panel3.Height * 0.5 - (panel3.Height * 0.5 - pictureBox1.Top) * q);
                pictureBox1.Left = (int)(panel3.Width * 0.5 - (panel3.Width * 0.5 - pictureBox1.Left) * q);
                pictureBox1.Width = (int)(pictureBox1.Width * q);
                pictureBox1.Height = (int)(pictureBox1.Height * q);
            }

        }

        private void button30_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel3.Width;
            pictureBox1.Height = panel3.Height;
        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button36_MouseDown(object sender, MouseEventArgs e)
        {
            ax = true;
            np1 = new Point(e.X, e.Y);
        }

        private void button36_MouseMove(object sender, MouseEventArgs e)
        {
            int xx1;
            xx1 = button36.Left;
            if (ax == true)
            {
                if (button36.Left >= 0 && button36.Left + button36.Width <= panel12.Width)
                {
                    xx1 = xx1 - np1.X + e.X;

                }
                if (xx1 < 0) xx1 = 0;
                if (xx1 + button36.Width > panel12.Width) xx1 = panel12.Width - button36.Width;
                button36.Left = xx1;
                blxs = (int)Math.Pow(2, (int)((1 - (double)button36.Left / (panel12.Width - button36.Width)) * 7));
                //button37.Text = "1/" + blxs.ToString();
                button36.Text = ((int)((1 - (double)button36.Left / (panel12.Width - button36.Width)) * 7) + 1).ToString();
            }
        }

        private void button36_MouseUp(object sender, MouseEventArgs e)
        {

            ax = false; double dxbl = 1;

            if (textBox3.Text != "")
            {
                dxbl = double.Parse(textBox3.Text);
            }
            if (pictureBox3.Image != null)
            {
                if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, blxs, zxd).Clone() as Bitmap;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "Jpg 图片|*.jpg|Jpeg 图片|*.jpeg|Bmp 图片|*.bmp";
            openFileDialog3.FileName = "";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog3.FileName);
                Application.DoEvents();
                hh1.setraw2(pictureBox4.Image as Bitmap);
                // pp5.rewrite(pictureBox4.Image as Bitmap);

            }
            if (fi != 0)
            {
                fi = 3;
                hhjmys(fi);
            }
            if (gi != 0)
            {
                gi = 3;
                hhjmys2(gi);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zxd = true;
            ax = false; double dxbl = 1;
            if (textBox3.Text != "")
            {
                dxbl = double.Parse(textBox3.Text);
            }
            if (pictureBox3.Image != null)
            {
                if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, blxs, zxd).Clone() as Bitmap;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            zxd = false;
            ax = false; double dxbl = 1;
            if (textBox3.Text != "")
            {
                dxbl = double.Parse(textBox3.Text);
            }
            if (pictureBox3.Image != null)
            {

                if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, blxs, zxd).Clone() as Bitmap;
            }
        }



        public class hhjm
        {
            pp pp4 = new pp();
            pp pp5 = new pp();
            int rw1, rw2, rh1, rh2;
            int[,,] rpoint;
            int[,,] rpoint2;
            int[,,] rpoint3;
            Bitmap rra;
            public void setraw1(Bitmap b)
            { if (b != null)
                {
                    rra = b;
                    pp4.rewrite(b);
                    rw1 = pp4.width;
                    rh1 = pp4.height;

                    rpoint = new int[rh1 + 1, rw1 + 1, 3];
                    rpoint3 = new int[rh1 + 1, rw1 + 1, 3];
                    for (int i = 1; i <= rh1; i++)
                    {
                        for (int j = 1; j <= rw1; j++)
                        {


                            rpoint[i, j, 0] = pp4.getr(i, j);
                            rpoint[i, j, 1] = pp4.getg(i, j);
                            rpoint[i, j, 2] = pp4.getb(i, j);

                        }
                    }
                    Array.Copy(rpoint, rpoint3, (rh1 + 1) * (rw1 + 1) * 3);
                    pp4.rep();
                    // Form1.form.button39.Text = "hh";
                }
            }
            public void setraw2(Bitmap b)
            { if (b != null)
                {
                    pp5.rewrite(b);
                    rw2 = pp5.width;
                    rh2 = pp5.height;

                    rpoint2 = new int[rh2 + 1, rw2 + 1, 3];
                    for (int i = 1; i <= rh2; i++)
                    {
                        for (int j = 1; j <= rw2; j++)
                        {
                            rpoint2[i, j, 0] = pp5.getr(i, j);
                            rpoint2[i, j, 1] = pp5.getg(i, j);
                            rpoint2[i, j, 2] = pp5.getb(i, j);
                        }
                    }
                    pp5.rep();
                    // Form1.form.button39.Text = "hh";
                }
            }
            public void yy()
            {
                Array.Copy(rpoint3, rpoint, (rh1 + 1) * (rw1 + 1) * 3);
            }
            public Bitmap jm(double k, double q, Boolean p)
            {
                pp pp6 = new pp();
                int xa, ya;
                pp6.rewrite(rra);
                if (p == true)
                {
                    for (int i = 1; i <= rh1; i++)
                    {
                        for (int j = 1; j <= rw1; j++)
                        {
                            xa = (int)((i * k - 1) % rh2 + 1);
                            ya = (int)((j * k - 1) % rw2 + 1);
                            rpoint3[i, j, 0] = (int)(rpoint[i, j, 0] * (1 / q)) + (int)((1 - 1 / q) * rpoint2[xa, ya, 0]);
                            rpoint3[i, j, 1] = (int)(rpoint[i, j, 1] * (1 / q)) + (int)((1 - 1 / q) * rpoint2[xa, ya, 1]);
                            rpoint3[i, j, 2] = (int)(rpoint[i, j, 2] * (1 / q)) + (int)((1 - 1 / q) * rpoint2[xa, ya, 2]);
                            pp6.setp(i, j, rpoint3[i, j, 0] + rpoint3[i, j, 1] * 256 + rpoint3[i, j, 2] * 65536);
                        }
                    }

                    return pp6.rep();
                }
                else
                {
                    for (int i = 1; i <= rh1; i++)
                    {
                        for (int j = 1; j <= rw1; j++)
                        {
                            xa = (int)((i * k - 1) % rh2 + 1);
                            ya = (int)((j * k - 1) % rw2 + 1);
                            rpoint3[i, j, 0] = (int)((rpoint[i, j, 0] - (int)((1 - 1 / q) * rpoint2[xa, ya, 0])) * q);
                            rpoint3[i, j, 1] = (int)((rpoint[i, j, 1] - (int)((1 - 1 / q) * rpoint2[xa, ya, 1])) * q);
                            rpoint3[i, j, 2] = (int)((rpoint[i, j, 2] - (int)((1 - 1 / q) * rpoint2[xa, ya, 2])) * q);
                            pp6.setp(i, j, rpoint3[i, j, 0] + rpoint3[i, j, 1] * 256 + rpoint3[i, j, 2] * 65536);
                        }
                    }

                    return pp6.rep();
                }


            }
            public Bitmap jm2(double k, double q, Boolean p)
            {
                pp pp6 = new pp();
                int xa, ya;
                pp6.rewrite(rra);
                if (p == true)
                {
                    for (int i = 1; i <= rh1; i++)
                    {
                        for (int j = 1; j <= rw1; j++)
                        {
                            xa = (int)((i * k - 1) % rh2 + 1);
                            ya = (int)((j * k - 1) % rw2 + 1);
                            rpoint3[i, j, 0] = ((int)(rpoint[i, j, 0] ) + (int)( rpoint2[xa, ya, 0])) % 256;
                            rpoint3[i, j, 1] = ((int)(rpoint[i, j, 1]) + (int)( rpoint2[xa, ya, 1])) % 256;
                            rpoint3[i, j, 2] = ((int)(rpoint[i, j, 2] ) + (int)( rpoint2[xa, ya, 2])) % 256;
                            pp6.setp(i, j, rpoint3[i, j, 0] + rpoint3[i, j, 1] * 256 + rpoint3[i, j, 2] * 65536);
                        }
                    }

                    return pp6.rep();
                }
                else
                {
                    for (int i = 1; i <= rh1; i++)
                    {
                        for (int j = 1; j <= rw1; j++)
                        {
                            xa = (int)((i * k - 1) % rh2 + 1);
                            ya = (int)((j * k - 1) % rw2 + 1);
                            rpoint3[i, j, 0] = (int)((rpoint[i, j, 0] - (int)( rpoint2[xa, ya, 0]+256))%256);
                            rpoint3[i, j, 1] = (int)((rpoint[i, j, 1] - (int)( rpoint2[xa, ya, 1]+256))%256);
                            rpoint3[i, j, 2] = (int)((rpoint[i, j, 2] - (int)( rpoint2[xa, ya, 2]+256)) %256);
                            pp6.setp(i, j, rpoint3[i, j, 0] + rpoint3[i, j, 1] * 256 + rpoint3[i, j, 2] * 65536);
                        }
                    }

                    return pp6.rep();
                }


            }


        }
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }






        private void button39_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                double dxbl = 1;
                if (textBox3.Text != "")
                {
                    dxbl = double.Parse(textBox3.Text);
                }
                if (pictureBox3.Image != null)
                {
                    if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, blxs, zxd).Clone() as Bitmap;
                }
                hh1.yy();
                pictureBox5.Image = pictureBox3.Image;
                if (zxd == true) {
                    textBox14.Text = dxbl.ToString() + "," + blxs.ToString() + "," + "1";
                     }
                else
                {
                    textBox14.Text = dxbl.ToString() + "," + blxs.ToString() + "," + "0";
                }
                hh1.setraw1(pictureBox5.Image as Bitmap);
                Myapp.Default.my += "混合加密：" + textBox14.Text + "|";
                listBox1.Items.Add("混合加密：" + textBox14.Text);
                MessageBox.Show("应用成功");
            }
            if (fi != 0)
            {
                fi =4;
                hhjmys(fi);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pp pa = new pp();
                pa.rewrite(pictureBox1.Image as Bitmap);
                int w = pa.width, h = pa.height; int t;
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= w / 2; j++)
                    {
                        t = pa.getp(i, j);
                        pa.setp(i, j, pa.getp(i, w - j + 1));
                        pa.setp(i, w - j + 1, t);
                    }


                }
                pictureBox1.Image = pa.rep() as Image;
                jh1.tk[jh1.nowi].Image = pictureBox1.Image;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pp pa = new pp();
                pa.rewrite(pictureBox1.Image as Bitmap);
                int w = pa.width, h = pa.height; int t;
                for (int i = 1; i <= h / 2; i++)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        t = pa.getp(i, j);
                        pa.setp(i, j, pa.getp(h - i + 1, j));
                        pa.setp(h - i + 1, j, t);
                    }


                }

                pictureBox1.Image = pa.rep() as Image;

                jh1.tk[jh1.nowi].Image = pictureBox1.Image;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pp p1 = new pp();
                p1.rewrite(pictureBox1.Image as Bitmap);
                int w = p1.width, h = p1.height;
                Bitmap b1 = new Bitmap(p1.height, p1.width, pictureBox1.Image.PixelFormat);
                pp p2 = new pp();
                p2.rewrite(b1);
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        p2.setp(j, h - i + 1, p1.getp(i, j));
                    }
                }
                pictureBox1.Image = p2.rep() as Image;
                p1.rep();
                jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                jh1.tk[jh1.nowi].reshape();
                for (int jj = jh1.nowi + 1; jj <= jh1.sum; jj++)
                {

                    jh1.tk[jj].Top = jh1.tk[jj - 1].Top + jh1.tk[jj - 1].Height + 5;

                }
                Form1.form.label2.Text = "图片大小:" + jh1.tk[jh1.nowi].Image.Width.ToString() + "*" + jh1.tk[jh1.nowi].Image.Height.ToString();
            }

        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pp p1 = new pp();
                p1.rewrite(pictureBox1.Image as Bitmap);
                int w = p1.width, h = p1.height;
                Bitmap b1 = new Bitmap(p1.height, p1.width, pictureBox1.Image.PixelFormat);
                pp p2 = new pp();
                p2.rewrite(b1);
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        p2.setp(w - j + 1, i, p1.getp(i, j));
                    }
                }
                pictureBox1.Image = p2.rep() as Image;
                p1.rep();
                jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                jh1.tk[jh1.nowi].reshape();
                for (int jj = jh1.nowi + 1; jj <= jh1.sum; jj++)
                {

                    jh1.tk[jj].Top = jh1.tk[jj - 1].Top + jh1.tk[jj - 1].Height + 5;

                }
                Form1.form.label2.Text = "图片大小:" + jh1.tk[jh1.nowi].Image.Width.ToString() + "*" + jh1.tk[jh1.nowi].Image.Height.ToString();
            }

        }

        private void button40_Click(object sender, EventArgs e)
        { if (timer3.Enabled == true) {
                if (pictureBox1.Image != null)
                {
                    Bitmap b1 = new Bitmap(s2.X - s1.X + 1, s2.Y - s1.Y + 1, pictureBox1.Image.PixelFormat);
                    pp p1 = new pp();
                    pp p2 = new pp();
                    p1.rewrite(pictureBox1.Image as Bitmap);
                    p2.rewrite(b1);
                    for (int i = 1; i <= s2.Y - s1.Y + 1; i++)
                    {
                        for (int j = 1; j <= s2.X - s1.X + 1; j++)
                        {
                            p2.setp(i, j, p1.getp(i + s1.Y - 1, j + s1.X - 1));
                        }
                    }
                    pictureBox1.Image = p2.rep();
                    p1.rep();
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                    jh1.tk[jh1.nowi].reshape();
                    for (int jj = jh1.nowi + 1; jj <= jh1.sum; jj++)
                    {

                        jh1.tk[jj].Top = jh1.tk[jj - 1].Top + jh1.tk[jj - 1].Height + 5;

                    }
                    {
                        timer3.Enabled = false;
                        pictureBox1.Invalidate();
                        Application.DoEvents();
                        pictureBox1.Invalidate();
                        textBox2.Text = "";
                        Form1.form.label2.Text = "图片大小:" + jh1.tk[jh1.nowi].Image.Width.ToString() + "*" + jh1.tk[jh1.nowi].Image.Height.ToString();
                    }

                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel2.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            button41.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                jmjpg1.getraw1(pictureBox6.Image as Bitmap, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                jmjpg1.jm(textBox6.Text);
                pictureBox8.Image = jmjpg1.getnew() as Image;


                textBox9.Text = "[" + pictureBox8.Image.Width.ToString() + "," + pictureBox8.Image.Height.ToString() + "," + textBox4.Text + "," + textBox5.Text + "]" + textBox6.Text;

                if (textBox6.Text != null)
                {
                    Myapp.Default.my += "抗压缩加密：" + textBox6.Text+"|";
                    listBox1.Items.Add("抗压缩加密：" + textBox6.Text);

                }
            }
            if (hi != 0)
            {
                hi = 3;
                kysjmys(hi);
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            /*if (panel1.Width != 53)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }*/
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                string s1 = textBox9.Text;
                int l = s1.Length;

                char[] arr = s1.ToCharArray();
                int cat = 0;
                string[] n = new string[5];
                for (int i = 0; i <= l - 1; i++)
                {
                    if (arr[i] == '[')
                    {
                        cat = 0;
                    }
                    else if (arr[i] == ']')
                    {
                        cat++;
                    }
                    else if (arr[i] == ',')
                    {
                        cat++;
                    }
                    else if (arr[i] >= '0' && arr[i] <= '9')
                    {
                        n[cat] += arr[i];
                    }
                }

                if (pictureBox6.Image.Width != int.Parse(n[0]) || pictureBox6.Image.Height != int.Parse(n[1]))
                {
                    pictureBox6.Image = cgsize(pictureBox6.Image as Bitmap, int.Parse(n[0]), int.Parse(n[1])) as Image;
                }

                jmjpg1.getraw2(pictureBox6.Image as Bitmap, int.Parse(n[2]), int.Parse(n[3]));

                jmjpg1.jm2(n[4]);

                pictureBox8.Image = jmjpg1.getnew2() as Image;
                //label7.Text = pictureBox6.Image.Width.ToString() + pictureBox6.Image.Height.ToString();

                if (textBox9.Text != null)
                {
                    Myapp.Default.my += "抗压缩解密：" + textBox9.Text+"|";
                    listBox1.Items.Add("抗压缩解密：" + textBox9.Text);

                }

            }
            if (ji != 0)
            {
                ji = 3;
                kysjmys2(ji);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox8.Image;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (jh1.nowi > 1) jh1.nowi--;
            jh1.sle(jh1.nowi);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (jh1.nowi < jh1.sum) jh1.nowi++;
            jh1.sle(jh1.nowi);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox8.Text) < 20) textBox8.Text = "20";
            if (jh1.sum > 0) {
                if (timer4.Enabled == false)
                {
                    if (textBox8.Text != null)
                    {
                        timer4.Interval = int.Parse(textBox8.Text);
                    }
                    button47.BackColor = Color.Gray;
                    timer4.Enabled = true;
                    jh1.nowi = 1;
                    jh1.sle(1);
                }
                else
                {
                    button47.BackColor = Color.Silver;
                    timer4.Enabled = false;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (jh1.nowi < jh1.sum)
            {
                jh1.nowi++;
                jh1.sle(jh1.nowi);
            }
            else
            {
                jh1.sle(jh1.nowi);
                if (checkBox1.Checked == true)
                {
                    jh1.nowi = 1;

                }
                else
                {
                    jh1.nowi =jh1.sum;
                    button47.BackColor = Color.Silver;
                    timer4.Enabled = false;
                }
               
            }
            Application.DoEvents();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel18.Visible = true;
            panel15.Visible = false;
            panel2.Visible = false;
            panel9.Visible = false;
            button25.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            foreach (Control label in Form1.form.Controls)
            {
                if (label.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    label.BackColor = Color.Red;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                toolTip1.SetToolTip(textBox1, "密钥长度："+textBox1.Text.Length.ToString());
                    }
            else
            {
                toolTip1.SetToolTip(textBox1, "密钥长度：0");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (Myapp.Default.mm == false||Myapp.Default.passw1==textBox7.Text)
            {
                panel21.Visible = true;
                MessageBox.Show("请重复输入两次新密钥，确保密钥一样");
            }
            else
            {
                MessageBox.Show("密码不正确");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == textBox11.Text)
            {
                Myapp.Default.passw1 = textBox12.Text;
                Myapp.Default.mm =true;
                panel21.Visible = false;
                MessageBox.Show("重设成功");
            }
            else
            {
                MessageBox.Show("密码两次不相同" );
            }
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            panel21.Visible = false;
            if (Myapp.Default.mm == false || Myapp.Default.passw1 == textBox7.Text)
            {
                listBox1.Visible = true;
                button51.Visible = true;
                panel20.Visible = false;
            }
            else
            {
                MessageBox.Show("密码不正确");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Myapp.Default.mm =false;
            Myapp.Default.passw1 = null;
            Myapp.Default.my = "";
            textBox7.Text = "";
            listBox1.Items.Clear();
      }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
           
            timer3.Enabled = false;
          
            if (checkBox2.Checked == false)
            {
                Myapp.Default.my = "";
            }
            Myapp.Default.bcmy = checkBox2.Checked;
            Myapp.Default.xhbf = checkBox1.Checked;
            Myapp.Default.jg = textBox8.Text;
            Myapp.Default.fg = checkBox3.Checked;
            Myapp.Default.qp = checkBox4.Checked;
            
            Myapp.Default.Save();
            
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            e.Cancel = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
           
            listBox1.Visible = false;
            panel20.Visible = true;
            button51.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            leftbarwidth = panel1.Width;
            form = this;
            CheckForIllegalCrossThreadCalls = false;
            form2 = new Form2();
            Form1.ActiveForm.Width = mw;
            Form1.ActiveForm.Height = mh;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel3.Width;
            pictureBox1.Height = panel3.Height;
             checkBox2.Checked= Myapp.Default.bcmy ;
          checkBox1.Checked = Myapp.Default.xhbf ;
            checkBox3.Checked = Myapp.Default.fg;
            checkBox4.Checked = Myapp.Default.qp;
          textBox8.Text = Myapp.Default.jg ;
            string s = Myapp.Default.my;

            char[] arr = s.ToCharArray();
            string sl = "";
            if (s != null)
            {

                for (int i = 0; i < s.Length; i++)
                {

                    // listBox1.Items.Add(sl);
                    if (arr[i] == '|')
                    {
                        //label8.Text = "hh";
                        listBox1.Items.Add(sl);
                        sl = "";
                    }
                    else
                    {
                        sl += arr[i];
                    }
                }

            }
            if (checkBox4.Checked == true)
            {
                Form1.form.SetVisibleCore(false);
                Form1.form.FormBorderStyle = FormBorderStyle.None;
                Form1.form.WindowState = FormWindowState.Maximized;
                Form1.form.SetVisibleCore(true);

            }
            else
            {
                Form1.form.SetVisibleCore(false);
                Form1.form.FormBorderStyle = FormBorderStyle.Sizable;
                Form1.form.WindowState = FormWindowState.Maximized;
                Form1.form.SetVisibleCore(true);

            }
            if (Myapp .Default.dyc == true)
            {
                form2.Visible = true;
                form2.button1.Focus();
                Form1.form.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                Form1.form.SetVisibleCore(false);
                Form1.form.FormBorderStyle = FormBorderStyle.None;
                Form1.form.WindowState = FormWindowState.Maximized;
                Form1.form.SetVisibleCore(true);

            }
            else
            {
                Form1.form.SetVisibleCore(false);
                Form1.form.FormBorderStyle = FormBorderStyle.Sizable;
                Form1.form.WindowState = FormWindowState.Maximized;
                Form1.form.SetVisibleCore(true);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (panel22.Visible == false)
                {
                    panel22.Visible = true;
                    textBox10.Text = pictureBox1.Image.Width.ToString();
                    textBox13.Text = pictureBox1.Image.Height.ToString();
                }
                else
                {
                    panel22.Visible = false;
                }
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {if (textBox10.Text != "" && textBox13.Text != "")
            {
                if (int.Parse(textBox10.Text) > 0 && int.Parse(textBox13.Text) > 0)
                {
                    pictureBox1.Image = cgsize(pictureBox1.Image as Bitmap, int.Parse(textBox10.Text), int.Parse(textBox13.Text)) as Image;
                    jh1.tk[jh1.nowi].Image = pictureBox1.Image;
                    panel22.Visible = false;
                    Form1.form.label2.Text = "图片大小:" + jh1.tk[jh1.nowi].Image.Width.ToString() + "*" + jh1.tk[jh1.nowi].Image.Height.ToString();
                    jh1.tk[jh1.nowi].reshape();
                    for (int jj = jh1.nowi + 1; jj <= jh1.sum; jj++)
                    {

                        jh1.tk[jj].Top = jh1.tk[jj - 1].Top + jh1.tk[jj - 1].Height + 5;

                    }
                }
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (lj == true)
            {
                button54.BackColor = Color.FromArgb(224, 224, 224);
                lj = false;
            }
            else
            {
                button54.BackColor = Color.Gray;
                lj = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {if (textBox10.Focused == true)
            {
                if (textBox10.Text != "")
                {
                    if (lj == true && int.Parse(textBox10.Text) > 0)
                    {
                        textBox13.Text = ((int)((double)pictureBox1.Image.Height / pictureBox1.Image.Width * int.Parse(textBox10.Text))).ToString();
                    }
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Focused == true)
            {
                if (textBox13.Text != "")
                {
                    if (lj == true && int.Parse(textBox13.Text) > 0)
                    {
                        textBox10.Text = ((int)((double)pictureBox1.Image.Width / pictureBox1.Image.Height * int.Parse(textBox13.Text))).ToString();
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
                pictureBox1.Top = (int)(panel3.Height * 0.25);
                pictureBox1.Left = (int)(panel3.Width * 0.25 );
                pictureBox1.Width = (int)(panel3.Width * 0.5);
                pictureBox1.Height = (int)(panel3.Height * 0.5);
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            pictureBox1.Width = panel3.Width;
            pictureBox1.Height = panel3.Height;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = (int)(-panel3.Height * 0.5);
            pictureBox1.Left = (int)(-panel3.Width * 0.5);
            pictureBox1.Width = (int)(panel3.Width * 2);
            pictureBox1.Height = (int)(panel3.Height * 2);
        }

        private void 使用混合加密打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel15.Visible = false;
            panel9.Visible = true;
            panel18.Visible = false;
            pictureBox3.Image = pictureBox1.Image.Clone() as Image;
            pictureBox5.Image = pictureBox1.Image.Clone() as Image;
            button27.BackColor = Color.Silver;
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            hh1.setraw1(pictureBox5.Image as Bitmap);
        }

        private void 使用抗压缩加密打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel2.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            pictureBox6.Image = pictureBox1.Image;
            button41.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void 作为混合模式密钥图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox1.Image;
            hh1.setraw2(pictureBox4.Image as Bitmap);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 更改图片大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (panel22.Visible == false)
                {
                    panel22.Visible = true;
                    textBox10.Text = pictureBox1.Image.Width.ToString();
                    textBox13.Text = pictureBox1.Image.Height.ToString();
                }
                else
                {
                    panel22.Visible = false;
                }
            }
        }

        private void 取消选区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button14.Enabled == true)
            {

                timer3.Enabled = false;
                pictureBox1.Invalidate();
                Application.DoEvents();
                pictureBox1.Invalidate();
                textBox2.Text = "";
            }
        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double q = 1.5;
            if (pictureBox1.Width < panel3.Width * 6)
            {
                pictureBox1.Top = (int)(panel3.Height * 0.5 - (panel3.Height * 0.5 - pictureBox1.Top) * q);
                pictureBox1.Left = (int)(panel3.Width * 0.5 - (panel3.Width * 0.5 - pictureBox1.Left) * q);
                pictureBox1.Width = (int)(pictureBox1.Width * q);
                pictureBox1.Height = (int)(pictureBox1.Height * q);
            }
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double q = 0.667;
            if (pictureBox1.Height > 100)
            {
                pictureBox1.Top = (int)(panel3.Height * 0.5 - (panel3.Height * 0.5 - pictureBox1.Top) * q);
                pictureBox1.Left = (int)(panel3.Width * 0.5 - (panel3.Width * 0.5 - pictureBox1.Left) * q);
                pictureBox1.Width = (int)(pictureBox1.Width * q);
                pictureBox1.Height = (int)(pictureBox1.Height * q);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != ""&& pictureBox3.Image!=null&&pictureBox4.Image!=null)
            {
               
                string s1 = textBox14.Text;
                int l = s1.Length;

                char[] arr = s1.ToCharArray();
                int cat = 0;
                string[] n = new string[3];
                for (int i = 0; i <= l - 1; i++)
                {
                    if (arr[i] == ',')
                    {
                        cat++;
                    }
                   
                    else if (arr[i] >= '0' && arr[i] <= '9'||arr[i]=='.')
                    {
                        n[cat] += arr[i];
                    }
                }

                double dxbl = double.Parse(n[0]);
                if (pictureBox3.Image != null)
                {
                    if (int.Parse( n[2]) == 1)
                    {

                        if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, int.Parse(n[1]), false).Clone() as Bitmap;
                    }
                    else
                    {
                        if (dxbl > 0 && dxbl <= 50) pictureBox3.Image = hh1.jm(dxbl, int.Parse(n[1]),true).Clone() as Bitmap;
                    }
                    pictureBox5.Image = pictureBox3.Image;
                    hh1.setraw1(pictureBox5.Image as Bitmap);
                }

            }
            if (gi != 0)
            {
                gi = 4;
                hhjmys2(gi);
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {




            form2.Visible = true;
            form2.button1.Focus();

        }

        private void button57_Click(object sender, EventArgs e)
        {
            Myapp.Default.dyc = true;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox8.Text = "1000";
            Myapp.Default.mm = false;
            Myapp.Default.passw1 = null;
            Myapp.Default.my = "";
            Myapp.Default.bcmy = true;
            Myapp.Default.xhbf = true;
            Myapp.Default.jg = "1000";
            Myapp.Default.fg = false;
            Myapp.Default.qp = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
         
        private void 反色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pp np = new pp();
            if (pictureBox1.Image != null)
            {
                np.rewrite(pictureBox1.Image as Bitmap);
                int w = np.width;
                int h = np.height;
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        np.setp(i, j, (255-np.getr(i, j)) + (255-np.getg(i, j))*256 + (255-np.getb(i, j)) * 65536);
                    }
                }
                pictureBox1.Image = np.rep() as Image;
                jh1.tk[jh1.nowi].Image = pictureBox1.Image;

            }
        }

        private void 删除图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jh1.nowi != 0)
            {
                jh1.moveone(jh1.nowi);
            }
            if (jh1.sum == 0)
            {
                pictureBox1.Image = null;
                label3.Text = "";
                label2.Text = "";
            }
            {
                timer3.Enabled = false;
                pictureBox1.Invalidate();
                Application.DoEvents();
                textBox2.Text = "";
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
            panel15.Visible = false;
            panel18.Visible = false;
            button26.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224); 
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
        
            ci = 1;
            cgjmys(ci);
         

        }
        public void cgjmys(int i)
        {
            button1.BackColor = panel1.BackColor;
            textBox1.BackColor = panel1.BackColor;
            button3.BackColor = Color.Silver;
            button2.BackColor = panel1.BackColor;
            switch (i) {
                    case 1:
                    
                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;
                    case 2:
                    
                    button1.BackColor = panel1.BackColor;
                    textBox1.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    MessageBox.Show("任意输入一定长度的字母作为你的加密密钥，然后点击加密");
                    break;
                    case 3:
                    
                    textBox1.BackColor = panel1.BackColor;
                    button3.BackColor =Color.Silver;
                    button2.BackColor = Color.Red;
                    MessageBox.Show("加密完成后，点击导出按钮以导出图片");
                    break;
                case 4:
                  

                    button1.BackColor = panel1.BackColor;
                    textBox1.BackColor = panel1.BackColor;
                    button3.BackColor = Color.Silver;
                    button2.BackColor = panel1.BackColor;

                    ci = 0;
                 
                    MessageBox.Show("已完成常规加密演示");
                    break;

            
            
            }

        }
        public void jbjmys(int i)
        {
            button1.BackColor = panel1.BackColor;
            textBox1.BackColor = panel1.BackColor;
            button3.BackColor = Color.Silver;
            button2.BackColor = panel1.BackColor;
            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;

                case 2:
                    button1.BackColor = panel1.BackColor;
                  button24.BackColor = Color.Red;
                    MessageBox.Show("打开选区功能");
                    break;
                case 3:
                  
                    button24.BackColor = Color.FromArgb(150, 150, 150);
                    MessageBox.Show("在图片上选择区域");
                    break;

                case 4:
                    
                    textBox1.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    MessageBox.Show("任意输入一定长度的字母作为你的加密密钥，然后点击加密");
                    break;
                case 5:
                    textBox1.BackColor = panel1.BackColor;
                    button3.BackColor = Color.Silver;
                    button2.BackColor = Color.Red;
                    MessageBox.Show("加密完成后，点击导出按钮以导出图片");
                    break;
                case 6:
                    button1.BackColor = panel1.BackColor;
                    textBox1.BackColor = panel1.BackColor;
                    button3.BackColor = Color.Silver;
                    button2.BackColor = panel1.BackColor;


                    di = 0;

                    MessageBox.Show("已完成局部加密演示");
                    break;



            }

        }
        public void jbjmys2(int i)
        {
            button1.BackColor = panel1.BackColor;
            textBox1.BackColor = panel1.BackColor;
            button4.BackColor = Color.Silver;
            button2.BackColor = panel1.BackColor;
            button13.BackColor = panel1.BackColor;
            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;

                case 2:
                    button1.BackColor = panel1.BackColor;
                    button24.BackColor = Color.Red;
                    MessageBox.Show("打开选区功能");
                    break;
                case 3:

                    button13.BackColor = Color.Red;
                    MessageBox.Show("点击扫描，自动选择已加密区域，若区域不正确，可以选区后微调");
                    break;

                case 4:

                    textBox1.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    MessageBox.Show("输入密钥，然后点击解密");
                    break;
                case 5:

                    button2.BackColor = Color.Red;
                    MessageBox.Show("解密完成后，点击导出按钮以导出图片");
                    break;
                case 6:
                   


                    ei = 0;

                    MessageBox.Show("已完成局部解密演示");
                    break;



            }

        }

        public void hhjmys(int i)
        {

            button1.BackColor = panel1.BackColor;
            button2.BackColor = panel1.BackColor;
            button35.BackColor = Color.Silver;
            button39.BackColor = Color.Silver;


            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;
                case 2:
                    button35.BackColor = Color.Red;
                    MessageBox.Show("按下导入密钥按钮，导入一张密钥图片");
                    break;
                case 3:
                    button39.BackColor = Color.Red;
                    MessageBox.Show("调节加密选项，然后点击应用");
                    break;
                case 4:
                    button2.BackColor = Color.Red;
                    MessageBox.Show("点击导出按钮以导出图片");
                    break;
                case 5:
                    fi = 0;
                    MessageBox.Show("已完成混合加密演示");
                    break;
            }

        }
        public void hhjmys2(int i)
        {

            button1.BackColor = panel1.BackColor;
            button2.BackColor = panel1.BackColor;
            button55.BackColor = Color.Silver;
            button35.BackColor = Color.Silver;
            textBox14.BackColor = Color.White;

            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;
                case 2:
                    button35.BackColor = Color.Red;
                    MessageBox.Show("按下导入密钥按钮，导入一张密钥图片");
                    break;
                case 3:
                    textBox14.BackColor = Color.Red;
                    button55.BackColor = Color.Red;
                    MessageBox.Show("输入加密时产生的密钥，然后点击解密");
                    break;
                case 4:
                    button2.BackColor = Color.Red;
                    MessageBox.Show("点击导出按钮以导出图片");
                    break;
                case 5:
                    gi = 0;
                    MessageBox.Show("已完成混合解密演示");
                    break;
            }

        }
        public void kysjmys(int i)
        {

            button1.BackColor = panel1.BackColor;
            button2.BackColor = panel1.BackColor;
            button42.BackColor = Color.Silver;
            
            textBox6.BackColor = Color.White;

            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;
                case 2:
                    textBox6.BackColor = Color.Red;
                    button42.BackColor = Color.Red;
                    MessageBox.Show("调节好加密参数后，输入一定长度的数字密钥，然后点击加密");
                    break;
              
                case 3:
                    button2.BackColor = Color.Red;
                    MessageBox.Show("点击导出按钮以导出图片");
                    break;
                case 4:
                    hi = 0;
                    MessageBox.Show("已完成抗压缩解密演示");
                    break;
            }

        }
        public void kysjmys2(int i)
        {

            button1.BackColor = panel1.BackColor;
            button2.BackColor = panel1.BackColor;
            button43.BackColor = Color.Silver;

            textBox9.BackColor = Color.White;

            switch (i)
            {
                case 1:

                    button1.BackColor = Color.Red;
                    MessageBox.Show("按下导入按钮，导入一张图片");
                    break;
                case 2:
                    textBox9.BackColor = Color.Red;
                    button43.BackColor = Color.Red;
                    MessageBox.Show("输入加密时产生的密钥，然后点击解密");
                    break;

                case 3:
                    button2.BackColor = Color.Red;
                    MessageBox.Show("点击导出按钮以导出图片");
                    break;
                case 4:
                    hi = 0;
                    MessageBox.Show("已完成抗压缩加密演示");
                    break;
            }

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            
        }

        private void button63_Click(object sender, EventArgs e)
        {
           
        }

        private void button59_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
            panel15.Visible = false;
            panel18.Visible = false;
            button26.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            di = 1;
            jbjmys(di);
        }

        private void button62_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel9.Visible = false;
            panel15.Visible = false;
            panel18.Visible = false;
            button26.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            ei = 1;
            jbjmys2(ei);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel15.Visible = false;
            panel9.Visible = true;
            panel18.Visible = false;
            button27.BackColor = Color.Silver;
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            fi = 1;
            hhjmys(fi);
        }

        private void button63_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel15.Visible = false;
            panel9.Visible = true;
            panel18.Visible = false;
            button27.BackColor = Color.Silver;
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button41.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            gi = 1;
            hhjmys2(gi);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel2.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            button41.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            hi = 1;
            kysjmys(hi);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel2.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            button41.BackColor = Color.Silver;
            button27.BackColor = Color.FromArgb(224, 224, 224);
            button26.BackColor = Color.FromArgb(224, 224, 224);
            button25.BackColor = Color.FromArgb(224, 224, 224);
            ji = 1;
            kysjmys2(ji);
        }

        private void panel19_MouseEnter(object sender, EventArgs e)
        {
           
           
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
          if (zd == true)
            {
                cot++;
            }
            else
            {
                cot--;

            }
          if (cot == 255)
            {
                zd = false;
            }
          if (cot == 0)
            {
                zd = true;
            }
            panel19.BackColor = Color.FromArgb(cox, coy, cot);
            label13.BackColor = panel19.BackColor;
            label14.BackColor = panel19.BackColor;
          
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel19_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer5.Enabled == false)
            {
                timer5.Enabled = true;
            }
            cox = 80 * e.X / panel19.Width+100;
            coy = 80 * e.Y  / panel19.Height+100;

        }

        private void panel19_MouseLeave(object sender, EventArgs e)
        {
            timer5.Enabled = false;
        }

        private void label14_MouseMove(object sender, MouseEventArgs e)
        {
            label14.ForeColor = Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.White;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            ff3 = new Form3();
            ff3.Owner=this;
            ff3.Show();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        public Bitmap cgsize(Bitmap b1, int w, int h)
        {
            int w1 = b1.Width;
            int h1 = b1.Height;
            double q1 = (double)w1 / w, q2 = (double)h1 / h;
            Bitmap b2 = new Bitmap(w, h, b1.PixelFormat);
            pp np = new pp();
            pp np2 = new pp();
            np.rewrite(b1);
            np2.rewrite(b2);
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= w; j++)
                {
                    np2.setp(i, j, np.getp((int)((i * q2 + h1 - 1) % h1 + 1), (int)((j * q1 + w1 - 1) % w1 + 1)));
                }
            }
            np.rep();
            return np2.rep();
        }




        public Point topi(Point ys)
        {
            Point ttt = new Point();
            double q1 = pictureBox1.Height / (double)pictureBox1.Width;
            double q2 = pictureBox1.Image.Height / (double)pictureBox1.Image.Width;
            if (q1 < q2)
            {
                ttt.Y = (int)((double)(ys.Y + 2) / pictureBox1.Height * pictureBox1.Image.Height);
                ttt.X = (int)((ys.X - (pictureBox1.Width - pictureBox1.Height / q2) / 2 + 2) / (pictureBox1.Height / q2) * pictureBox1.Image.Width);
                if (ttt.Y < 1) ttt.Y = 1;
                if (ttt.Y > pictureBox1.Image.Height) ttt.Y = pictureBox1.Image.Height;
                if (ttt.X < 1) ttt.X = 1;
                if (ttt.X > pictureBox1.Image.Width) ttt.X = pictureBox1.Image.Width;

            }
            else
            {
                ttt.X = (int)((double)(ys.X + 2) / pictureBox1.Width * pictureBox1.Image.Width);
                ttt.Y = (int)((ys.Y - (pictureBox1.Height - pictureBox1.Width * q2) / 2 + 2) / (pictureBox1.Width * q2) * pictureBox1.Image.Height);
                if (ttt.Y < 1) ttt.Y = 1;
                if (ttt.Y > pictureBox1.Image.Height) ttt.Y = pictureBox1.Image.Height;
                if (ttt.X < 1) ttt.X = 1;
                if (ttt.X > pictureBox1.Image.Width) ttt.X = pictureBox1.Image.Width;




            }
            return ttt;
        }

        public Point itop(Point ys)
        {
            Point ttt = new Point();
            double q1 = pictureBox1.Height / (double)pictureBox1.Width;
            double q2 = pictureBox1.Image.Height / (double)pictureBox1.Image.Width;
            if (q1 < q2)
            {
                ttt.Y = (int)((double)ys.Y / pictureBox1.Image.Height * pictureBox1.Height - 1);
                ttt.X = (int)((double)ys.X / pictureBox1.Image.Width * (pictureBox1.Height / q2) + (pictureBox1.Width - pictureBox1.Height / q2) / 2 - 1);


            }
            else
            {
                ttt.X = (int)((double)ys.X / pictureBox1.Image.Width * pictureBox1.Width - 1);
                ttt.Y = (int)((double)ys.Y / pictureBox1.Image.Height * (pictureBox1.Width * q2) + (pictureBox1.Height - pictureBox1.Width * q2) / 2 - 1);

            }
            return ttt;
        }

    }



    public class pp
    {
        public Bitmap newbitmap;
        public byte[] RGB;
        public int nw;
        public int width;
        public int height;
        BitmapData data;
        int length;
        System.IntPtr Scan0;
        System.Drawing.Imaging.BitmapData bmpdata;
        public void rewrite(Bitmap bitmap)
        {
            if (bitmap != null)

            {
                newbitmap = bitmap;
                width = newbitmap.Width;
                height = newbitmap.Height;


                GGgo:
                try
                {
                    data = newbitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, newbitmap.PixelFormat);
                }
                catch (System.InvalidOperationException)
                {
                    Thread.Sleep(1);
                    goto GGgo;
                }
                
                
                //data = newbitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, newbitmap.PixelFormat);
                length = data.Stride * data.Height;
                nw = data.Stride;
                RGB = new byte[length];
                Scan0 = data.Scan0;
                System.Runtime.InteropServices.Marshal.Copy(Scan0, RGB, 0, length);
            }

        }

        public int getp(int x, int y)
        {
            byte r, g, b; int l;
            l = (x - 1) * nw + (y - 1) * 3;
            b = RGB[l];
            g = RGB[l + 1];
            r = RGB[l + 2];
            return b * 65536 + g * 256 + r;
        }
        public void setp(int x, int y, int col)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;

            RGB[l] = (byte)(col / 65536);
            RGB[l + 1] = (byte)(col / 256 % 256);
            RGB[l + 2] = (byte)(col % 256);
        }

        public void setr(int x, int y, byte col)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            RGB[l + 2] = col;
        }
        public byte getr(int x, int y)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            return RGB[l + 2];
        }
        public void setg(int x, int y, byte col)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            RGB[l + 1] = col;
        }
        public byte getg(int x, int y)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            return RGB[l + 1];
        }
        public void setb(int x, int y, byte col)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            RGB[l] = col;
        }
        public byte getb(int x, int y)
        {
            int l;
            l = (x - 1) * nw + (y - 1) * 3;
            return RGB[l];
        } 


        public Bitmap rep()
        {
            System.Runtime.InteropServices.Marshal.Copy(RGB, 0, Scan0, length);

            newbitmap.UnlockBits(data);
            return newbitmap;
        }



    }
    
    public class jm
    { pp p2=new pp();
       
        Bitmap raw;
        int rw, rh;
       
       int[,]  rpoint;
        int[,] rpoint2;
        public int sc = 0;
        public void getraw(Bitmap bitp)
        {
            raw = bitp;
            rw = raw.Width;
            rh = raw.Height;
           
            rpoint = new int[rh+1,rw+1];
            rpoint2 = new int[rh + 1, rw + 1];
            p2.rewrite(bitp);
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rpoint[i, j] = p2.getp(i, j);
                    //rpoint2[i, j] = rpoint[i, j];
                }
            }
            Array.Copy(rpoint, rpoint2, (rh + 1) * (rw + 1));

        }
        public void getraw2(Bitmap bitp)
        {
            raw = bitp;
            
            Point ss1 = Form1.form.s1;
            Point ss2 = Form1.form.s2;
            rw = ss2.X - ss1.X+1;
            rh = ss2.Y - ss1.Y+1;
            rpoint = new int[rh + 1, rw + 1];
            rpoint2 = new int[rh + 1, rw + 1];
            p2.rewrite(bitp);
            for (int i = 1; i <= ss2.Y-ss1.Y+1; i++)
            {
                for (int j = 1; j <= ss2.X-ss1.X+1; j++)
                {
                    rpoint[i, j] = p2.getp(i+ss1.Y-1, j+ss1.X-1);
                    //rpoint2[i, j] = rpoint[i, j];
                }
            }
            Array.Copy(rpoint, rpoint2, (rh + 1) * (rw + 1));

        }
        public Bitmap setnew()
        {
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                   p2.setp(i,j,rpoint[i,j]);

                }
            }
            return p2.rep();

        }
        public Bitmap setnew2()
        {
            Point ss1 = Form1.form.s1;
            Point ss2 = Form1.form.s2;
            for (int i = 1; i <= ss2.Y - ss1.Y + 1; i++)
            {
                for (int j = 1; j <= ss2.X - ss1.X + 1; j++)
                {
                      p2.setp(i + ss1.Y - 1, j + ss1.X - 1, rpoint[i, j]);
                    //rpoint2[i, j] = rpoint[i, j];
                }
            }
            return p2.rep();

        }
        public void runp(string s)
        {
            int l = s.Length;
            s.ToLower();
            char[] arr = s.ToCharArray();
            int i;
          
            for (i = 0; i <= l - 1; i++)
            {
                Form1.form.progressBar1.Value = (i + 1) * 100 / l;
               // Application.DoEvents();
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    
                    switch (arr[i]){
                        case 'a':pa(); 
                            break;
                        case 'b':
                            pb();
                            break;
                        case 'c':
                            pc();
                            break;
                        case 'd':
                            pd();
                            break;
                        case 'e':
                            pe();
                            break;
                        case 'f':
                            pf();
                            break;
                        case 'g':
                            pg();
                            break;
                        case 'h':
                            ph();
                            break;
                        case 'i':
                            pi();
                            break;
                        case 'j':
                            pj();
                            break;
                        case 'k':
                            pk();
                            break;
                        case 'l':
                            pl();
                            break;
                        case 'm':
                            pm();
                            break;
                        case 'n':
                            pn();
                            break;
                        case 'o':
                            po();
                            break;
                        case 'p':
                            pp();
                            break;
                        case 'q':
                            pq();
                            break;
                        case 'r':
                            pr();
                            break;
                        case 's':
                            ps();
                            break;
                        case 't':
                            pt();
                            break;
                        case 'u':
                            pu();
                            break;
                        case 'v':
                            pv();
                            break;
                        case 'w':
                            pw();
                            break;
                        case 'x':
                            px();
                            break;
                        case 'y':
                            py();
                            break;
                        case 'z':
                            pz();
                            break;

                    }
                    Array.Copy(rpoint2, rpoint, (rh + 1) * (rw + 1));


                }
            }
            Form1.form.progressBar1.Value = 100;
            //Application.DoEvents();


        }
        public void runq(string s)
        {
            int l = s.Length;
            s.ToLower();
            char[] arr = s.ToCharArray();
            int i;

            for (i = l-1; i >=  0; i--)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    Form1.form.progressBar1.Value = (l-i) * 100 / l;
                  
                    switch (arr[i])
                    {
                        case 'a':
                            qa();
                            break;
                        case 'b':
                            qb();
                            break;
                        case 'c':
                            qc();
                            break;
                        case 'd':
                            qd();
                            break;
                        case 'e':
                            qe();
                            break;
                        case 'f':
                            qf();
                            break;
                        case 'g':
                            qg();
                            break;
                        case 'h':
                            qh();
                            break;
                        case 'i':
                            qi();
                            break;
                        case 'j':
                            qj();
                            break;
                        case 'k':
                            qk();
                            break;
                        case 'l':
                            ql();
                            break;
                        case 'm':
                            qm();
                            break;
                        case 'n':
                            qn();
                            break;
                        case 'o':
                            qo();
                            break;
                        case 'p':
                            qp();
                            break;
                        case 'q':
                            qq();
                            break;
                        case 'r':
                            qr();
                            break;
                        case 's':
                            qs();
                            break;
                        case 't':
                            qt();
                            break;
                        case 'u':
                            qu();
                            break;
                        case 'v':
                            qv();
                            break;
                        case 'w':
                            qw();
                            break;
                        case 'x':
                            qx();
                            break;
                        case 'y':
                            qy();
                            break;
                        case 'z':
                            qz();
                            break;


                    }
                    Array.Copy(rpoint2, rpoint, (rh + 1) * (rw + 1));


                }
            }

            Form1.form.progressBar1.Value = 100;
           

        }
        public void pa()
        {
            for (int i = 1; i <= rh; i++)
            {
                for(int j=1; j <= rw; j++)
                {
                    rpoint2[i, j] = rpoint[((j- 1) * rh + i-1) / rw+1, ((j - 1) * rh + i- 1) % rw + 1];

                }
            }

        }
        public void qa()
        {
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rpoint2[i, j] = rpoint[((i - 1) * rw + j - 1) % rh + 1, ((i - 1) * rw + j - 1) / rh + 1];

                }
            }

        }
        public void pb()
        {
            int w = rw - 1;int h = rh - 1;int j,num=1;
            int small;
            small = rw < rh ? rw : rh;
            for (int i = 1; i <= small/2; i++)
            {                
                for (j = i; j <= rw - i; j++)
                {
                    rpoint2[i, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = i; j <= rh - i; j++)
                {
                    rpoint2[j, rw - i + 1] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = rw - i + 1; j >= i + 1; j--)
                {
                    rpoint2[rh - i + 1, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = rh - i + 1; j >= i + 1; j--)
                {
                    rpoint2[j, i] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }

            }
            if(small % 2 == 1)
            {
                if (rh > rw)
                { int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rh - io+1; i++)
                    {
                        rpoint2[i,io]= rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rw - io + 1; i++)
                    {
                        rpoint2[io, i] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }
                }
            }



        }
        public void qb()
        {
            int w = rw - 1; int h = rh - 1; int j, num = 1;
            int small;
            small = rw < rh ? rw : rh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= rw - i; j++)
                {
                    rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[i, j] ;
                    num++;
                }
                for (j = i; j <= rh - i; j++)
                {
                    rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[j, rw - i + 1] ;
                    num++;
                }
                for (j = rw - i + 1; j >= i + 1; j--)
                {
                     rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]=rpoint[rh - i + 1, j] ;
                    num++;
                }
                for (j = rh - i + 1; j >= i + 1; j--)
                {
                     rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[j, i] ;
                    num++;
                }

            }
            if (small % 2 == 1)
            {
                if (rh > rw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rh - io + 1; i++)
                    {
                         rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[i, io] ;
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rw - io + 1; i++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[io, i] ;
                        num++;
                    }
                }
            }


        }
        public void pc()
        {
            int w = rw - 1; int h = rh - 1; int j, num = 1;
            int small;
            small = rw < rh ? rw : rh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= rh - i; j++)
                {
                    rpoint2[j, i] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = i; j <= rw - i; j++)
                {
                    rpoint2[rh - i + 1, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = rh - i + 1; j >= i + 1; j--)
                {
                    rpoint2[j, rw - i + 1] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                for (j = rw - i + 1; j >= i + 1; j--)
                {
                    rpoint2[i, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                    num++;
                }
                

            }
            if (small % 2 == 1)
            {
                if (rh > rw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rh - io + 1; i++)
                    {
                        rpoint2[i, io] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rw - io + 1; i++)
                    {
                        rpoint2[io, i] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }
                }
            }
        }
        public void qc()
        {
            int w = rw - 1; int h = rh - 1; int j, num = 1;
            int small;
            small = rw < rh ? rw : rh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= rh - i; j++)
                {
                    rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[j, i] ;
                    num++;
                }
                for (j = i; j <= rw - i; j++)
                {
                    rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[rh - i + 1, j] ;
                    num++;
                }
                for (j = rh - i + 1; j >= i + 1; j--)
                {
                     rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]=rpoint[j, rw - i + 1] ;
                    num++;
                }
                for (j = rw - i + 1; j >= i + 1; j--)
                {
                    rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[i, j] ;
                    num++;
                }


            }
            if (small % 2 == 1)
            {
                if (rh > rw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rh - io + 1; i++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[i, io];
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= rw - io + 1; i++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[io, i];
                        num++;
                    }
                }
            }
        }

        public void pd()
        { int num = 1;
           if (rw >= rh)
            {
                for (int i = 1; i <= rh; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        rpoint2[i-j+1,j]= rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;

                    }
                }
                for (int i = 1; i <= rw - rh ; i++)
                {
                    for (int j = 1; j <= rh; j++)
                    {
                        rpoint2[rh - j + 1, i + j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;

                    }
                }
                for (int i = 1; i <= rh - 1; i++)
                {
                    for (int j = 1; j <= rh - i; j++)
                    {
                        rpoint2[rh+1-j,rw-rh+i+j]= rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }
                }


            }
            else
            {
                for (int i = 1; i <= rw; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        rpoint2[i - j + 1, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;

                    }
                }
                for (int i = 1; i <= rh - rw; i++)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[rw - j + i + 1, j] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;

                    }
                }
                for (int i = 1; i <= rw - 1; i++)
                {
                    for (int j = 1; j <= rw - i; j++)
                    {
                        rpoint2[rh-j+1, i + j ] = rpoint[(num - 1) / rw + 1, (num - 1) % rw + 1];
                        num++;
                    }
                }


            }

        }
        public void qd()
        {
            int num = 1;
            if (rw >= rh)
            {
                for (int i = 1; i <= rh; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[i - j + 1, j] ;
                        num++;

                    }
                }
                for (int i = 1; i <= rw - rh; i++)
                {
                    for (int j = 1; j <= rh; j++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]=rpoint[rh - j + 1, i + j]  ;
                        num++;

                    }
                }
                for (int i = 1; i <= rh - 1; i++)
                {
                    for (int j = 1; j <= rh - i; j++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]=rpoint[rh + 1 - j, rw - rh + i + j ]  ;
                        num++;
                    }
                }


            }
            else
            {
                for (int i = 1; i <= rw; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]=rpoint[i - j + 1, j]  ;
                        num++;

                    }
                }
                for (int i = 1; i <= rh - rw; i++)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                         rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1]= rpoint[rw - j + i + 1, j] ;
                        num++;

                    }
                }
                for (int i = 1; i <= rw - 1; i++)
                {
                    for (int j = 1; j <= rw - i; j++)
                    {
                        rpoint2[(num - 1) / rw + 1, (num - 1) % rw + 1] = rpoint[rh - j + 1, i + j] ;
                        num++;
                    }
                }


            }

        }
        public void pe()
        {
            int m = rw / 20;
            if (m != 0)
            {
                for (int i = 1; i <= rw; i++)
                {
                    for (int j = 1; j <= rh; j++)
                    {
                        rpoint2[(j + i % m - 1) % rh + 1, i] = rpoint[j, i];


                    }
                }
            }
        }
        public void qe()
        {
            int m = rw / 20;
            if (m != 0)
            {
                for (int i = 1; i <= rw; i++)
                {
                    for (int j = 1; j <= rh; j++)
                    {
                        rpoint2[j, i] = rpoint[(j + i % m - 1) % rh + 1, i];


                    }
                }
            }

        }
        public void pf()
        {
            int m = rw / 20;
            if (m != 0)
            {
                for (int i = 1; i <= rh; i++)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, (j + i % m - 1) % rw + 1] = rpoint[i, j];


                    }
                }
            }

        }
        public void qf()
        {
            int m = rw / 20;
            if (m != 0)
            {
                for (int i = 1; i <= rh; i++)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, j] = rpoint[i, (j + i % m - 1) % rw + 1];


                    }
                }
            }

        }

        public void pg()
        {
            int num = rw * rh;
            int c1,c2;
            for (int i = 2; i <= num; i++)
            { c1 = rpoint[(i - 1) / rw + 1, (i - 1) % rw + 1];
                c2 = rpoint2[(i- 2) / rw + 1, (i - 2) % rw + 1];

                c1-=c2 ;
                if (c1 < 0)
                {
                    c1+= 16777216;
                }
             rpoint2[(i - 1) / rw + 1, (i - 1) % rw + 1] = c1 ;
            }


        }
        public void qg()
        {
            int num = rw * rh;
            int c1, c2;
            for (int i = num; i >= 2; i--)
            {
                c1 = rpoint[(i - 1) / rw + 1, (i - 1) % rw + 1];
                c2 = rpoint[(i - 2) / rw + 1, (i - 2) % rw + 1];

                c1 += c2;
                c1 = c1 % 16777216;
                rpoint2[(i - 1) / rw + 1, (i - 1) % rw + 1] = c1;
            }


        }
        public void ph()
        {
            int c1, c2;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = 2; i <= rh; i++)
                {
                    c1 = rpoint[i,j];
                    c2 = rpoint2[i-1,j];
                    c1 -= c2;
                    if (c1 < 0)
                    {
                        c1 += 16777216;
                    }
                    rpoint2[i, j] = c1;
                }

            }
        }
        public void qh()
        {

            int c1, c2;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = rh; i>=2; i--)
                {
                    c1 = rpoint[i, j];
                    c2 = rpoint2[i - 1, j];
                    c1 += c2;
                    c1 = c1 % 16777216;
                    rpoint2[i, j] = c1;
                }

            }
        }
        public void pi()
        {
            int c1, c2;
            for (int j = 2; j <= rw; j++)
            {
                for (int i = 1; i <= rh; i++)
                {
                    c1 = rpoint[i, j];
                    c2 = rpoint2[i , j-1];
                    c1 -= c2;
                    if (c1 < 0)
                    {
                        c1 += 16777216;
                    }
                    rpoint2[i, j] = c1;
                }

            }
        }
        public void qi()
        {
            int c1, c2;
            for (int j = rw; j >=2; j--)
            {
                for (int i=1;i<=rh ; i++)
                {
                    c1 = rpoint[i, j];
                    c2 = rpoint2[i , j-1];
                    c1 += c2;
                    c1 = c1 % 16777216;
                    rpoint2[i, j] = c1;
                }

            }
        }
        public void pj()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] - j * 5000 + i * 5000;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void qj()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + j * 5000 - i * 5000;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void pk()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + j * 5000 +i * 5000;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void qk()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] - j * 5000 - i * 5000;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void pl()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + (i % 201 - 100) * (i % 201 - 100) * 100 + (j % 201 - 100) * (j % 201 - 100) * 100;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void ql()
        {
            int num;
          
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] -(i % 201 - 100) * (i % 201 - 100) * 100 - (j % 201 - 100) * (j % 201 - 100) * 100;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void pm()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + (i % 201 - 100) * (i % 201 - 100) * 100 - (j % 201 - 100) * (j % 201 - 100) * 100;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void qm()
        {
            int num;

            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] - (i % 201 - 100) * (i % 201 - 100) * 100 + (j % 201 - 100) * (j % 201 - 100) * 100;
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }
            

        }
        public void pn()
        {
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    if (j % 2 == 1)
                    {
                        rpoint2[i, j] = rpoint[i, rw - j / 2];
                    }
                    else
                    {
                        rpoint2[i, j] = rpoint[i, j / 2];

                    }
                    
                  
                }
            }


        } 
        public void qn()
        {
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    if (j % 2 == 1)
                    {
                        rpoint2[i, rw - j / 2] = rpoint[i, j];
                    }
                    else
                    {
                        rpoint2[i, j / 2] = rpoint[i, j];

                    }

                }
            }

        }
        public void po()
        {
            for (int i = 1; i <= rh; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, j] = rpoint[rh-i/2,  j ];
                    }
                   
                }
                else
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, j] = rpoint[i/2, j];
                    }
                    
                }
                
            }


        }
        public void qo()
        {
            for (int i = 1; i <= rh; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[rh - i / 2, j] = rpoint[i, j] ;
                    }

                }
                else
                {
                    for (int j = 1; j <= rw; j++)
                    {
                         rpoint2[i / 2, j]= rpoint[i, j] ;
                    }

                }

            }


        }
        public void pp()
        {
           
            for (int i = 1; i <= rw; i++)
            {
                for (int j = 1; j <= rh; j++)
                {
                    rpoint2[(j + i  - 1) % rh + 1, i] = rpoint[j, i];


                }
            }

        }
        public void qp()
        {
            for (int i = 1; i <= rw; i++)
            {
                for (int j = 1; j <= rh; j++)
                {
                     rpoint2[j, i]= rpoint[(j + i - 1) % rh + 1, i] ;


                }
            }


        }
        public void pq()
        {
       
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rpoint2[i, (j + i  - 1) % rw + 1] = rpoint[i, j];


                }
            }

        }
        public void qq()
        {

            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                     rpoint2[i, j]= rpoint[i, (j + i - 1) % rw + 1] ;


                }
            }

        }
        public void pr()
        {
            
            
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rpoint2[i, j] += i * j;
                 
                    rpoint2[i,j]%= 16777216;
                    

                }
            }
        }
        public void qr()
        {
            int num = rw / 2;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rpoint2[i, j] -= i * j;

                    while (rpoint2[i, j] < 0)
                        { rpoint2[i, j] += 16777216; }

                }
            }
        }
        public void ps()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {if (i % 2 == 1)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, j] = rpoint[i, (j+rw/100)%rw+1];


                    }
                }
            else
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        num = j - rw / 100;
                        if (num < 1) num =num+rw;
                        rpoint2[i, j] = rpoint[i, num];


                    }
                }
            }
        }
        public void qs()
        {
            int num;
            for (int i = 1; i <= rh; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        rpoint2[i, (j + rw / 100) % rw + 1]= rpoint[i, j] ;


                    }
                }
                else
                {
                    for (int j = 1; j <= rw; j++)
                    {
                        num = j - rw / 100;
                        if (num < 1) num = num + rw ;
                       rpoint2[i, num] = rpoint[i, j] ;


                    }
                }
            }
        }
        public void pt()
        {
            int num;
            for (int j = 1; j <= rw; j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = 1; i <= rh; i++)
                    {
                        rpoint2[i, j] = rpoint[(i+rh/100)%rh+1, j];


                    }
                }
                else
                {
                    for (int i = 1; i<= rh; i++)
                    {
                        num = i - rh / 100;
                        if (num < 1) num = num + rh;
                        rpoint2[i, j] = rpoint[ num, j];


                    }
                }
            }
        }
        public void qt()
        {
            int num;
            for (int j = 1; j <= rw; j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = 1; i <= rh; i++)
                    {
                        rpoint2[(i + rh / 100) % rh + 1, j]= rpoint[i, j] ;


                    }
                }
                else
                {
                    for (int i = 1; i <= rh; i++)
                    {
                        num = i - rh / 100;
                        if (num < 1) num = num + rh;
                         rpoint2[num, j]= rpoint[i, j] ;


                    }
                }
            }
        }
       public void pu()
        {
            int ni;double ww = rw / 20.0;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = 1; i <= rh; i++)
                { ni = i + (int)(Math.Sin((j - 1) / ww * Math.PI)*ww);
                    while (ni < 1) ni += rh;
                    ni = (ni - 1) % rh+1;
                    rpoint2[ni,j]= rpoint[i, j];
                }
            }
        }
        public void qu()
        {
            int ni; double ww = rw / 20.0;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = 1; i <= rh; i++)
                {
                    ni = i + (int)(Math.Sin((j - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += rh;
                    ni = (ni - 1) % rh + 1;
                    rpoint2[i, j] = rpoint[ni, j] ;
                }
            }
        }
        public void pv()
        {
            int ni; double ww = rh/ 20.0;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j<= rw; j++)
                {
                    ni = j + (int)(Math.Sin((i - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += rw;
                    ni = (ni - 1) % rw + 1;
                    rpoint2[i, ni] = rpoint[i, j];
                }
            }
        }
        public void qv()
        {
            int ni; double ww = rh / 20.0;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    ni = j + (int)(Math.Sin((i - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += rw;
                    ni = (ni - 1) % rw + 1;
                     rpoint2[i, j]= rpoint[i, ni] ;
                }
            }
        }
        public void pw()
        {
            int ni; double ww = rw / 10.0;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = 1; i <= rh; i++)
                {
                    ni = i + (int)Math.Pow((j % ww), 2.0);
                    while (ni < 1) ni += rh;
                    ni = (ni - 1) % rh + 1;
                    rpoint2[ni, j] = rpoint[i, j];
                }
            }
        }
        public void qw()
        {
            int ni; double ww = rw / 10.0;
            for (int j = 1; j <= rw; j++)
            {
                for (int i = 1; i <= rh; i++)
                {
                    ni = i + (int)Math.Pow((j%ww),2.0);
                    while (ni < 1) ni += rh;
                    ni = (ni - 1) % rh + 1;
                     rpoint2[i, j]=rpoint[ni, j] ;
                }
            }
        }
        public void px()
        {
            int ni; double ww = rh / 20.0;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    ni = j + (int)Math.Pow((i % ww), 2.0);
                    while (ni < 1) ni += rw;
                    ni = (ni - 1) % rw + 1;
                    rpoint2[i, ni] = rpoint[i, j];
                }
            }
        }
        public void qx()
        {
            int ni; double ww = rh / 20.0;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    ni = j + (int)Math.Pow((i % ww), 2.0);
                    while (ni < 1) ni += rw;
                    ni = (ni - 1) % rw + 1;
                    rpoint2[i, j] = rpoint[i, ni];
                }
            }
        }
        public void py()
        {
           double nn = rw / 10.0;
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + (int)(Math.Sin(j/nn*Math.PI)*50000);
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void qy()
        {
            int num; double nn = rw / 10.0;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] - (int)(Math.Sin(j / nn * Math.PI) * 50000);
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }


        }
        public void pz()
        {
            double nn = rh / 10.0;
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] + (int)(Math.Sin(i / nn * Math.PI) * 50000);
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }

        }
        public void qz()
        {
            double nn = rh / 10.0;
            int num;
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    num = rpoint[i, j] - (int)(Math.Sin(i / nn * Math.PI) * 50000);
                    if (num < 0) num += 16777216;
                    num = num % 16777216;
                    rpoint2[i, j] = num;
                }
            }

        }
    }
    public class jmjpg
    {
        Bitmap b1;
        int[,] rp;
        int[,] rp2;
        int[,] rp3;
        int rw, rh;
        int nw, nh;
        int dx;
        int jg;
        public Bitmap cgsize(Bitmap b1, int w, int h)
        {
            int w1 = b1.Width;
            int h1 = b1.Height;
            double q1 = (double)w1 / w, q2 = (double)h1 / h;
            Bitmap b2 = new Bitmap(w, h, b1.PixelFormat);
            pp np = new pp();
            pp np2 = new pp();
            np.rewrite(b1);
            np2.rewrite(b2);
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= w; j++)
                {
                    np2.setp(i, j, np.getp((int)((i * q2+h1-1) % h1 + 1), (int)((j * q1+w1-1) % w1 + 1)));
                }
            }
            np.rep();
            return np2.rep();

        }
        public void getraw1(Bitmap b,int x,int y)
        {
            b1=cgsize(b,b.Width-b.Width%x,b.Height-b.Height%x);rw = b1.Width;rh = b1.Height;

            pp p1 = new pp();

            p1.rewrite(b1);
            rp = new int[rh+1, rw+1];
            rp2 = new int[rh + 1, rw + 1];
            dx = x;
            jg = y;
            
            nw = rw / dx;
            nh = rh / dx;
            rp3 = new int[rh + 1 + jg * (nh + 1), rw + 1 + jg * (nw + 1)];
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    rp[i, j] = p1.getp(i,j);
                    rp2[i, j] = rp[i, j];
                }
            }
            p1.rep();
        }
        public void getraw2(Bitmap b, int x, int y)
        {
            b1 = b; rw = b1.Width; rh = b1.Height;
            dx = x;
            jg = y;
            nw = (rw - y) / (dx + jg);
           nh = (rh - y) / (dx + jg);
            rw = nw * dx;
            rh = nh * dx;
            pp p1 = new pp();

            p1.rewrite(b1);
          
            
            rp = new int[nh * dx + 1, nw * dx + 1];
            rp2 = new int[nh * dx + 1, nw * dx + 1];
      
           // rp3 = new int[rh + 1 + jg * (nh + 1), rw + 1 + jg * (nw + 1)];
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {

                    for (int ii = 1; ii <= dx; ii++)
                    {
                        for (int jj = 1; jj <= dx; jj++)
                        {
                            rp[(i-1)*dx+ii, (j-1)*dx+jj] = p1.getp((i-1)*(dx+jg)+jg+ii, (j - 1) * (dx + jg) + jg + jj);
                        }
                    }
                  
                }
            }
            Array.Copy(rp, rp2, (rh + 1) * (rw + 1));
            p1.rep();
        }
        public  void movep(int x1, int y1, int x2, int y2)
        {
            for (int i = 1; i <= dx ; i++)
            {
                for (int j = 1; j <= dx ; j++)
                {
                    rp2[(x2-1)*dx + i, (y2-1)*dx + j] = rp[(x1-1)*dx + i, (y1-1)*dx + j];
                }
            }
        }
        public void moveq(int x2, int y2, int x1, int y1)
        {
            for (int i = 1; i <= dx; i++)
            {
                for (int j = 1; j <= dx; j++)
                {
                    rp2[(x2 - 1) * dx + i, (y2 - 1) * dx + j] = rp[(x1 - 1) * dx + i, (y1 - 1) * dx + j];
                }
            }
        }
        public void jm(String s)
        {
            int l = s.Length;
            s.ToLower();
            char[] arr = s.ToCharArray();
            int i;

            for (i = 0; i <= l - 1; i++)
            {

                if (arr[i] >= '0' && arr[i] <= '9')
                {

                    switch (arr[i])
                    {
                        case '1':
                            p1();
                            break;
                        case '2':
                            p2();
                            break;
                        case '3':
                            p3();
                            break;
                        case '4':
                            p4();
                            break;
                        case '5':
                            p5();
                            break;
                        case '6':
                            p6();
                            break;
                        case '7':
                            p7();
                            break;
                        case '8':
                            p8();
                            break;
                        case '9':
                            p9();
                            break;
                        case '0':
                            p0();
                            break;



                    }
                    Array.Copy(rp2, rp, (rh + 1) * (rw + 1));
                }
            }




        }
        public void jm2(String s)
        {
            if (s != null){

                int l = s.Length;
                s.ToLower();
                char[] arr = s.ToCharArray();
                int i;

                for (i = l - 1; i >= 0; i--)
                {

                    if (arr[i] >= '0' && arr[i] <= '9')
                    {

                        switch (arr[i])
                        {
                            case '1':
                                q1();
                                break;
                            case '2':
                                q2();
                                break;
                            case '3':
                                q3();
                                break;
                            case '4':
                                q4();
                                break;
                            case '5':
                                q5();
                                break;
                            case '6':
                                q6();
                                break;
                            case '7':
                                q7();
                                break;
                            case '8':
                                q8();
                                break;
                            case '9':
                                q9();
                                break;
                            case '0':
                                q0();
                                break;



                        }
                        Array.Copy(rp2, rp, (rh + 1) * (rw + 1));
                    }
                }


            }

        }
        public Bitmap getnew()
        {
            Bitmap b3 = new Bitmap(rw + jg * (nw + 1), rh + jg * (nh + 1) ,PixelFormat.Format24bppRgb);
            pp p3 = new pp();
            p3.rewrite(b3);
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    int pzsx = (j - 1) * (dx + jg) + jg + 1;
                    int pzsy = (i - 1) * (dx + jg) + jg + 1;
                   
                    for (int ii = 0; ii <= dx-1 ; ii++)
                    {
                        for (int jj = 1; jj <= jg/2; jj++)
                        {
                            rp3[pzsy - jj, pzsx + ii] = rp2[(i - 1) * dx + 1, (j - 1) * dx + ii+1];
                        }
                    }
                    for (int ii = 0; ii <= dx-1; ii++)
                    {
                        for (int jj = 1; jj <= jg / 2; jj++)
                        {
                            rp3[pzsy +dx+ jj-1, pzsx + ii] = rp2[i  * dx , (j - 1) * dx + ii+1];
                        }
                    }
                    for (int ii = 1; ii <= jg/2; ii++)
                    {
                        for (int jj = 0; jj <= dx-1; jj++)
                        {
                            rp3[pzsy + jj, pzsx - ii] = rp2[(i-1)*dx+jj+1, (j - 1) * dx + 1];
                        }
                    }
                    for (int ii = 1; ii <= jg/2; ii++)
                    {
                        for (int jj = 0; jj <= dx  -1; jj++)
                        {
                            rp3[pzsy + jj, pzsx + dx-1+ii] = rp2[(i - 1) * dx + jj+1, j  * dx];
                        }
                    }
                    for (int ii = 0; ii < dx; ii++)
                    {
                        for (int jj = 0; jj < dx; jj++)
                        {
                            rp3[pzsy + jj, pzsx + ii] = rp2[(i - 1) * dx + jj + 1, (j - 1) * dx + ii + 1];
                        }
                    }

                    for (int ii = 1; ii <= jg / 2; ii++)
                    {
                        for (int jj = 1; jj <= jg / 2; jj++)
                        {
                            rp3[pzsy - ii, pzsx - jj] = rp3[pzsy, pzsx];
                            rp3[pzsy +dx-1+ ii, pzsx+dx-1 + jj] = rp3[pzsy+dx-1, pzsx+dx-1];
                            rp3[pzsy + dx - 1 + ii, pzsx - jj] = rp3[pzsy + dx - 1, pzsx ];
                            rp3[pzsy - ii, pzsx + dx - 1 + jj] = rp3[pzsy , pzsx + dx - 1];
                        }
                    }

                   

                }
            }
            for (int i=1;i<= rw + jg * (nw + 1); i++)
            {
                for (int j=1;j<= rh + jg * (nh + 1); j++)
                {
                    p3.setp(j, i, rp3[j, i]);
                }
            }
            return p3.rep();





        }
        public Bitmap getnew2()
        {

            Bitmap b2 = new Bitmap(rw, rh, b1.PixelFormat);
            pp mp = new pp();
            mp.rewrite(b2);
            for (int i = 1; i <= rh; i++)
            {
                for (int j = 1; j <= rw; j++)
                {
                    mp.setp(i, j, rp[i, j]);
                }
            }
            return mp.rep();

        }
        void p1()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    //rp2[i, j] = rp[((j - 1) * rh + i - 1) / rw + 1, ((j - 1) * rh + i - 1) % rw + 1];
                    movep(((j - 1) * nh + i - 1) / nw + 1, ((j - 1) * nh + i - 1) % nw + 1, i, j);

                }
            }
        }
        void q1()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    //rp2[i, j] = rp[((j - 1) * rh + i - 1) / rw + 1, ((j - 1) * rh + i - 1) % rw + 1];
                    movep(i, j, ((j - 1) * nh + i - 1) / nw + 1, ((j - 1) * nh + i - 1) % nw + 1);

                }
            }
        }
        void p2()
        {
            int w = nw - 1; int h = nh - 1; int j, num = 1;
            int small;
            small = nw < nh ? nw : nh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= nw - i; j++)
                {
                    //rpoint2[i, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, i, j);
                    num++;
                }
                for (j = i; j <= nh - i; j++)
                {
                   // rpoint2[j, nw - i + 1] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, j, nw - i + 1);
                    num++;
                }
                for (j = nw - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[nh - i + 1, j] = rpoint[(num - 1) / nw + 1, (num - 1) %nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, nh - i + 1, j);
                    num++;
                }
                for (j = nh - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[j, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, j, i);
                    num++;
                }

            }
            if (small % 2 == 1)
            {
                if (nh > nw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nh - io + 1; i++)
                    {
                        //rpoint2[i, io] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        movep((num - 1) / nw + 1, (num - 1) % nw + 1, i, io);
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nw - io + 1; i++)
                    {
                        //rpoint2[io, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        movep((num - 1) / nw + 1, (num - 1) % nw + 1, io, i);
                        num++;
                    }
                }
            }



        }
        void q2()
        {
            int w = nw - 1; int h = nh - 1; int j, num = 1;
            int small;
            small = nw < nh ? nw : nh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= nw - i; j++)
                {
                    //rpoint2[i, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, i, j);
                    num++;
                }
                for (j = i; j <= nh - i; j++)
                {
                    // rpoint2[j, nw - i + 1] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, j, nw - i + 1);
                    num++;
                }
                for (j = nw - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[nh - i + 1, j] = rpoint[(num - 1) / nw + 1, (num - 1) %nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, nh - i + 1, j);
                    num++;
                }
                for (j = nh - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[j, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, j, i);
                    num++;
                }

            }
            if (small % 2 == 1)
            {
                if (nh > nw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nh - io + 1; i++)
                    {
                        //rpoint2[i, io] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        moveq((num - 1) / nw + 1, (num - 1) % nw + 1, i, io);
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nw - io + 1; i++)
                    {
                        //rpoint2[io, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        moveq((num - 1) / nw + 1, (num - 1) % nw + 1, io, i);
                        num++;
                    }
                }
            }



        }
        void p3()
        {
            int w = nw - 1; int h = nh - 1; int j, num = 1;
            int small;
            small = nw < nh ? nw : nh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= nh - i; j++)
                {
                    //rpoint2[j, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, j, i);
                    num++;
                }
                for (j = i; j <= nw - i; j++)
                {
                    //rpoint2[nh - i + 1, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, nh - i + 1, j);
                    num++;
                }
                for (j = nh - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[j, nw - i + 1] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, j, nw - i + 1);
                    num++;
                }
                for (j = nw - i + 1; j >= i + 1; j--)
                {
                   // rpoint2[i, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    movep((num - 1) / nw + 1, (num - 1) % nw + 1, i, j);
                    num++;
                }


            }
            if (small % 2 == 1)
            {
                if (nh > nw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nh - io + 1; i++)
                    {
                        //rpoint2[i, io] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        movep((num - 1) / nw + 1, (num - 1) % nw + 1, i, io);
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nw - io + 1; i++)
                    {
                        //rpoint2[io, i] = rpoint[(num - 1) / nw + 1, (num - 1) %nw + 1];
                        movep((num - 1) / nw + 1, (num - 1) % nw + 1, io, i);
                        num++;
                    }
                }
            }
        }
        void q3()
        {
            int w = nw - 1; int h = nh - 1; int j, num = 1;
            int small;
            small = nw < nh ? nw : nh;
            for (int i = 1; i <= small / 2; i++)
            {
                for (j = i; j <= nh - i; j++)
                {
                    //rpoint2[j, i] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, j, i);
                    num++;
                }
                for (j = i; j <= nw - i; j++)
                {
                    //rpoint2[nh - i + 1, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, nh - i + 1, j);
                    num++;
                }
                for (j = nh - i + 1; j >= i + 1; j--)
                {
                    //rpoint2[j, nw - i + 1] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, j, nw - i + 1);
                    num++;
                }
                for (j = nw - i + 1; j >= i + 1; j--)
                {
                    // rpoint2[i, j] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                    moveq((num - 1) / nw + 1, (num - 1) % nw + 1, i, j);
                    num++;
                }


            }
            if (small % 2 == 1)
            {
                if (nh > nw)
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nh - io + 1; i++)
                    {
                        //rpoint2[i, io] = rpoint[(num - 1) / nw + 1, (num - 1) % nw + 1];
                        moveq((num - 1) / nw + 1, (num - 1) % nw + 1, i, io);
                        num++;
                    }


                }
                else
                {
                    int io;
                    io = small / 2 + 1;
                    for (int i = io; i <= nw - io + 1; i++)
                    {
                        //rpoint2[io, i] = rpoint[(num - 1) / nw + 1, (num - 1) %nw + 1];
                        moveq((num - 1) / nw + 1, (num - 1) % nw + 1, io, i);
                        num++;
                    }
                }
            }
        }
        void p4()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    if (j % 2 == 1)
                    {
                       // rpoint2[i, j] = rpoint[i, nw - j / 2];
                        movep(i, nw - j / 2, i, j);
                    }
                    else
                    {
                       // rpoint2[i, j] = rpoint[i, j / 2];
                        movep(i, j / 2, i, j);

                    }


                }
            }
        }
        void q4()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    if (j % 2 == 1)
                    {
                        // rpoint2[i, j] = rpoint[i, nw - j / 2];
                        moveq(i, nw - j / 2, i, j);
                    }
                    else
                    {
                        // rpoint2[i, j] = rpoint[i, j / 2];
                        moveq(i, j / 2, i, j);

                    }


                }
            }
        }
        void p5()
        {
            for (int i = 1; i <= nh; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= nw; j++)
                    {
                       // rpoint2[i, j] = rpoint[nh - i / 2, j];
                        movep(nh - i / 2, j, i, j);
                    }

                }
                else
                {
                    for (int j = 1; j <= nw; j++)
                    {
                        //rpoint2[i, j] = rpoint[i / 2, j];
                        movep(i / 2, j, i, j);
                    }

                }

            }

        }
        void q5()
        {
            for (int i = 1; i <= nh; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= nw; j++)
                    {
                        // rpoint2[i, j] = rpoint[nh - i / 2, j];
                        moveq(nh - i / 2, j, i, j);
                    }

                }
                else
                {
                    for (int j = 1; j <= nw; j++)
                    {
                        //rpoint2[i, j] = rpoint[i / 2, j];
                        moveq(i / 2, j, i, j);
                    }

                }

            }

        }
        void p6()
        {
            for (int i = 1; i <= nw; i++)
            {
                for (int j = 1; j <= nh; j++)
                {
                   // rpoint2[(j + i - 1) % nh + 1, i] = rpoint[j, i];
                    movep(j, i, (j + i - 1) % nh + 1, i); 


                }
            }

        }
        void q6()
        {
            for (int i = 1; i <= nw; i++)
            {
                for (int j = 1; j <= nh; j++)
                {
                    // rpoint2[(j + i - 1) % nh + 1, i] = rpoint[j, i];
                    moveq(j, i, (j + i - 1) % nh + 1, i);


                }
            }

        }
        void p7()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    //rpoint2[i, (j + i - 1) % nw + 1] = rpoint[i, j];
                    movep(i, j, i, (j + i - 1) % nw + 1);


                }
            }
        }
        void q7()
        {
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    //rpoint2[i, (j + i - 1) % nw + 1] = rpoint[i, j];
                    moveq(i, j, i, (j + i - 1) % nw + 1);


                }
            }
        }
        void p8()
        {
            int ni; double ww = nw / 5.0;
            for (int j = 1; j <= nw; j++)
            {
                for (int i = 1; i <= nh; i++)
                {
                    ni = i + (int)(Math.Sin((j - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += nh;
                    ni = (ni - 1) % nh + 1;
                    //rpoint2[ni, j] = rpoint[i, j];
                    movep(i, j, ni, j);
                }
            }
        }
        void q8()
        {
            int ni; double ww = nw / 5.0;
            for (int j = 1; j <= nw; j++)
            {
                for (int i = 1; i <= nh; i++)
                {
                    ni = i + (int)(Math.Sin((j - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += nh;
                    ni = (ni - 1) % nh + 1;
                    //rpoint2[ni, j] = rpoint[i, j];
                    moveq(i, j, ni, j);
                }
            }
        }
        void p9()
        {
            int ni; double ww = nh / 5.0;
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    ni = j + (int)(Math.Sin((i - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += nw;
                    ni = (ni - 1) % nw + 1;
                    //rpoint2[i, ni] = rpoint[i, j];
                    movep(i, j, i, ni);
                }
            }

        }
        void q9()
        {
            int ni; double ww = nh / 5.0;
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    ni = j + (int)(Math.Sin((i - 1) / ww * Math.PI) * ww);
                    while (ni < 1) ni += nw;
                    ni = (ni - 1) % nw + 1;
                    //rpoint2[i, ni] = rpoint[i, j];
                    moveq(i, j, i, ni);
                }
            }

        }
        void p0()
        {
            int ni; double ww = nh / 5.0;
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    ni = j + (int)Math.Pow((i % ww), 2.0);
                    while (ni < 1) ni += nw;
                    ni = (ni - 1) % nw + 1;
                    //rpoint2[i, ni] = rpoint[i, j];
                    movep(i, j, i, ni);
                }
            }
        }
        void q0()
        {
            int ni; double ww = nh / 5.0;
            for (int i = 1; i <= nh; i++)
            {
                for (int j = 1; j <= nw; j++)
                {
                    ni = j + (int)Math.Pow((i % ww), 2.0);
                    while (ni < 1) ni += nw;
                    ni = (ni - 1) % nw + 1;
                    //rpoint2[i, ni] = rpoint[i, j];
                    moveq(i, j, i, ni);
                }
            }
        }
    }
    public class kk:PictureBox
    {
        public string st;
        public void setnew(String s)
        {
            st = s;
            //this.Image = Image.FromFile(s);
            FileStream fileStream = new FileStream(s, FileMode.Open, FileAccess.Read);
           
            this.Image = Image.FromStream(fileStream);
            fileStream.Close();
            fileStream.Dispose();


            double q = this.Image.Height / (double)this.Image.Width;
            
            this.Height = (int)((Form1.form.panel4.Width- SystemInformation.VerticalScrollBarWidth-12) * q);
            
            this.Left = 5;
            this.Width = (Form1.form.panel4.Width - SystemInformation.VerticalScrollBarWidth - 12);
           
            this.BackColor = Color.White;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BorderStyle = BorderStyle.FixedSingle;
          
        }
       public void reshape()
        {
            double q = this.Image.Height / (double)this.Image.Width;

            this.Height = (int)((Form1.form.panel4.Width - SystemInformation.VerticalScrollBarWidth - 12) * q);
        }
       
       

    }
    
    public class jh
    {
        public kk[] tk = new kk[1000];
       
        public int nowi = 0;
        public int sum = 0;
       

        public void addone(string s)
        {
            {
                Form1.form.timer3.Enabled = false;
                Form1.form.pictureBox1.Invalidate();
                Application.DoEvents();
               Form1.form.textBox2.Text = "";
            }
            sum++;
            tk[sum] = new kk();
            tk[sum].setnew(s);
            tk[sum].Visible = true;
            if (sum == 1) tk[1].Top = Form1.form.button12.Top+4;
            Application.DoEvents();

            if (sum >= 2)
            {
                tk[sum].Top = tk[sum - 1].Top + tk[sum - 1].Height + 5;
            }
            Form1.form.panel4.Controls.Add(tk[sum]);
           //tk[sum].ContextMenuStrip = Form1.form.contextMenuStrip2;
            tk[sum].Click += new System.EventHandler(Form1.form.tk_Click);
            sle(sum);
          
        }
        public void moveone(int j)
        {   if (sum > 0)
            {
                if (j < sum)
                {
                    for (int jj = j + 1; jj <= sum; jj++)
                    {
                        tk[jj - 1].Image = tk[jj].Image;
                        tk[jj - 1].reshape();
                        tk[jj].Top = tk[jj - 1].Top + tk[jj - 1].Height + 5;
                    
                    }

                }
                tk[sum].Visible = false;
                sum--;
                sle(1);
            }
        }
       public void sle(int jj)
        {   if (sum > 0)
            {

                {
                    Form1.form.timer3.Enabled = false;
                    Form1.form.pictureBox1.Invalidate();
                    Application.DoEvents();
                    Form1.form.textBox2.Text = "";
                }
                nowi = jj;
                Form1.form.label3.Text = nowi.ToString() + "/" + sum.ToString();
                Form1.form.pictureBox1.Image = tk[nowi].Image;
                Form1.form.label2.Text = "图片大小:" + tk[nowi].Image.Width.ToString() + "*" + tk[nowi].Image.Height.ToString();
            }
            
            }


    }

}
