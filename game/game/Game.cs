using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Game : Form
    {
        private Bitmap sprite1;
        private Bitmap sprite2;
        private Bitmap backBuffer1;
        private Bitmap backBuffer2;
        public Graphics graphics;
        private int x;
        private Timer timer1;//di chuyen shuriken
        private Timer timer2;//them shuriken
        private int index1;
        private int index2=0;
        private int curFrameColumn;
        private int curFrameRow;
        private int num_shuriken=0;
        private int[,]shuriken=new int[5,100];//luu tru cac shuriken
        public Game()
        {
            x = 0;
            InitializeComponent();
            graphics = this.CreateGraphics();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            backBuffer1 = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            backBuffer2 = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            sprite1 = new Bitmap("ninja.png");
            sprite2 = new Bitmap("shuriken.png");
            for (int i = 0; i < 100; i++)
            {
                shuriken[0, i] = 1;
            }
            shuriken[0, 0] = 2;
            shuriken[1, 0] = 1;
            shuriken[2, 0] = 1;
            shuriken[3, 0] = 50;
            shuriken[4, 0] = 70;
            timer1 = new Timer();
            timer1.Enabled = true;
            timer1.Interval = 1200;
            timer1.Tick += new EventHandler(them_shuriken);
            timer2 = new Timer();
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer2.Tick += new EventHandler(shuriken_dichuyen);
          
        }
        private void shuriken_dichuyen(object sender, EventArgs e)
        {
            for(int i=0;i<100;i++)
            {
                if(shuriken[0,i]==2)
                {
                    shuriken_tao(ref shuriken[1, i], ref shuriken[2, i], ref shuriken[3, i], ref shuriken[4, i]);
                    graphics.DrawImageUnscaled(backBuffer2, 0, 0);
                }
            }
        }
        private void them_shuriken(object sender, EventArgs e)
        {
            Random rd = new Random();
            shuriken[0,num_shuriken] = 2;
            shuriken[1, num_shuriken] = rd.Next(1,2);
            shuriken[2, num_shuriken] = 1;
            shuriken[3, num_shuriken] = rd.Next(30, 720);
            shuriken[4, num_shuriken] = 70;
            num_shuriken++;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            btAgain.Hide();
            btThoat.Hide();
        }

        private void sangtrai()
        {

            for (index1 = 4; index1 < 8; index1++)
            {
                if (100 + 3 * x >= 25)
                {
                    x--;
                    nhanvat();
                    graphics.DrawImageUnscaled(backBuffer1, 0, 0);
                }
            }

        }
        private void sangphai()
        {
            for (index1 = 8; index1 < 12; index1++)
            {
                if (100 + 3 * x <= 752)
                {
                    x++;
                    nhanvat();
                    graphics.DrawImageUnscaled(backBuffer1, 0, 0);
                }
            }
        }
        private void nhanvat()
        {

            Graphics nhanvat = Graphics.FromImage(backBuffer1);
            nhanvat.SmoothingMode = SmoothingMode.AntiAlias;
            curFrameColumn = index1 % 4;
            curFrameRow = index1 / 4;
            nhanvat.DrawImage(sprite1, 100 + 3 * x, 310, new Rectangle(curFrameColumn * 32, curFrameRow * 48, 32, 48), GraphicsUnit.Pixel);
            nhanvat.Dispose();
        }
        private void shuriken_tao(ref int x1,ref int y1,ref int x2,ref int y2)
        {

            Graphics g = Graphics.FromImage(backBuffer2);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (x2 == 30||x2==740)
            {
                x1 = -x1;
            }
            if (y2==30||y2==300)
            {
                y1 = -y1;
            }
            x2 = x2 + x1;
            y2 = y2 + y1;
            g.DrawImage(sprite2, x2, y2, new Rectangle(49*index2, 0, 49, 49), GraphicsUnit.Pixel);
            g.Dispose();
            index2++;
            if(index2==3)
            {
                index2 = 0;
            }
        }

        //private void Game_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    if (e.KeyChar == 'a')
        //    {
        //        sangtrai();
        //    }
        //    if (e.KeyChar == 'd')
        //    {
        //        sangphai();
        //    }
        //}

        private void btPhai_Click(object sender, EventArgs e)
        {
            sangphai();
        }

        private void btTrai_Click(object sender, EventArgs e)
        {
            sangtrai();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics h = this.CreateGraphics();
            Pen p = new Pen(Color.Red);
            h.DrawLine(p, 20, 20, 20, 350);
            h.DrawLine(p, 20, 350, 780, 350);
            h.DrawLine(p, 780, 20, 780, 350);
            h.DrawLine(p, 20, 20, 780, 20);
            h.Dispose();
        }
    }

}


