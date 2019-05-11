using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoolTableTask.Class;
namespace PoolTableTask
{
    public partial class formPoolTable : Form
    {
        public List<PoolBall> lstPoolBall { get; set; }
        public formPoolTable()
        {
            InitializeComponent();
        }

        private void formPoolTable_Load(object sender, EventArgs e)
        {
            rand = new Random();
            cmbWindowSize.SelectedIndex = 1;
            cmbTableColor.SelectedIndex = 0;
            cmbBlackBallSize.SelectedIndex = 0;
            cmbRedBallSize.SelectedIndex = 0;
            lstPoolBall = new List<PoolBall>(){
                new PoolBall{Border=picBorderPool,LeftMover=5,Timer=timerPoolBalls,UpMover=2,PicBall=picRedball,},
                new PoolBall{Border=picBorderPool,LeftMover=1,Timer=timerPoolBalls,UpMover=2,PicBall=picBlackBall,}
            };
            foreach (var poolBall in lstPoolBall)
            {
                poolBall.lstPoolBall = lstPoolBall;
                picBlackBall.Location = new Point(rand.Next(picBorderPool.Location.X, picBorderPool.Location.X + picBorderPool.Width-70),
                rand.Next(picBorderPool.Location.Y, picBorderPool.Location.Y + picBorderPool.Height-70));
                poolBall.LeftMover = rand.Next(-10, 10);
                poolBall.UpMover = rand.Next(-10, 10);
            }
            lstPoolBall[1].lstPoolBall = lstPoolBall;
            lstPoolBall[0].lstPoolBall = lstPoolBall;
            makeRoundPictureCorners();

        }

        private void makeRoundPictureCorners()
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picBlackBall.Width - 1, picBlackBall.Height - 1);
            Region rg = new Region(gp);
            picBlackBall.Region = rg;
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp2.AddEllipse(0, 0, picRedball.Width - 1, picRedball.Height - 1);
            Region rg2 = new Region(gp2);
            picRedball.Region = rg2;
        }


        public Random rand;
        public int leftMove = 10;
        public int upMove = 10;
        private void timerRedBall_Tick(object sender, EventArgs e)
        {
            foreach (var Ball in lstPoolBall)
            {
                Ball.HitBall();
            }

        }

        private void trackBallSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerPoolBalls.Interval = trackBallSpeed.Value;
        }



        private void cmbWindowSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sizingValue = 0;
            int slectedItem = cmbWindowSize.SelectedIndex;
            if (slectedItem == 0)
            {
                cmbBlackBallSize.SelectedIndex = 0;
                cmbRedBallSize.SelectedIndex = 0;
                picBorderPool.Location = new Point(30, 12);
                sizingValue = -200;
                cmbRedBallSize.Enabled = false;
                cmbBlackBallSize.Enabled = false;
            }
            else if (slectedItem == 1)
            {
                sizingValue = 0;
                picBorderPool.Location = new Point(43, 53);
                cmbRedBallSize.Enabled = true;
                cmbBlackBallSize.Enabled = true;
            }
            else if (slectedItem == 2)
            {
                picBorderPool.Location = new Point(64, 79);
                sizingValue = 200;
                cmbRedBallSize.Enabled = true;
                cmbBlackBallSize.Enabled = true;
            }
            else if (slectedItem == 3)
            {
                picBorderPool.Location = new Point(72, 97);
                sizingValue = 300;
                cmbRedBallSize.Enabled = true;
                cmbBlackBallSize.Enabled = true;
            }

            this.Width = 600 + sizingValue;
            this.Height = 500 + sizingValue;
            picBoxPoolTable.Height = 323 + sizingValue;
            picBoxPoolTable.Width = 584 + sizingValue;
            picBorderPool.Width = Convert.ToInt32((double)picBoxPoolTable.Width / 1.184);
            picBorderPool.Height = picBorderPool.Height = Convert.ToInt32((double)picBoxPoolTable.Height / 1.468);
        }

        private void cmbTableColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableColor.SelectedIndex == 0)
            {
                picBorderPool.Visible = false;
            }
            else
            {
                picBorderPool.Visible = true;
                string colorName = cmbTableColor.Text;
                picBorderPool.BackColor = Color.FromName(colorName);
            }
        }

        private void cmbRedBallSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ballSize = int.Parse(cmbRedBallSize.Text);
            picRedball.Width = ballSize;
            picRedball.Height = ballSize;
            makeRoundPictureCorners();
        }

        private void cmbBlackBallSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ballSize = int.Parse(cmbBlackBallSize.Text);
            picBlackBall.Width = ballSize;
            picBlackBall.Height = ballSize;
            makeRoundPictureCorners();
        }


    }
}
