using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PoolTableTask.Class
{
    public class PoolBall
    {
        public Timer Timer { get; set; }
        public PictureBox PicBall { get; set; }
        public PictureBox Border { get; set; }
        public int LeftMover { get; set; }
        public int UpMover { get; set; }
        public Random rand { get; set; }
        public List<PoolBall> lstPoolBall { get; set; }
        public PoolBall()
        {
            rand = new Random();
        }
        public void HitBall()
        {

            PicBall.Location = new Point(PicBall.Location.X + LeftMover, PicBall.Location.Y + UpMover);

            colidCheckWithPoolBorders();
            int i = 0;
            foreach (var poolBall in lstPoolBall)
            {

                if (!this.Equals(poolBall))
                {
                    checkcColisionBetweenBalls(poolBall.PicBall, i);
                }
                i++;
            }
            checkIfBallIsPocketed();

        }

        private void checkIfBallIsPocketed()
        {
            int thisBallRightX = PicBall.Location.X + PicBall.Width;
            int thisBallBottomCornerY = PicBall.Location.Y + PicBall.Height;
            int pocketRightX = Border.Location.X + Border.Width;
            int pocketBottomY = Border.Location.Y + Border.Height;
            int howFarCanTheBallBeFromPocket = 5;
            //leftUpPocket
            if (PicBall.Location.X < Border.Location.X + howFarCanTheBallBeFromPocket && PicBall.Location.Y < Border.Location.Y + howFarCanTheBallBeFromPocket)
            {
                changeBallLocationAndMovment();
            }
            //rightUPPocket
            if(thisBallRightX+howFarCanTheBallBeFromPocket>pocketRightX&& Border.Location.Y+howFarCanTheBallBeFromPocket>PicBall.Location.Y)
            {
                changeBallLocationAndMovment();
            }
            //BottomLeftPocket
            if (PicBall.Location.X < Border.Location.X + howFarCanTheBallBeFromPocket && pocketBottomY < thisBallBottomCornerY + howFarCanTheBallBeFromPocket)
            {
                changeBallLocationAndMovment();   
            }
            //BottomRightCorner
            if (thisBallRightX+howFarCanTheBallBeFromPocket>pocketRightX && thisBallBottomCornerY+howFarCanTheBallBeFromPocket>pocketBottomY)
            {
                changeBallLocationAndMovment();
            }
        }

        private void changeBallLocationAndMovment()
        {
            PicBall.Location = new Point(rand.Next(Border.Location.X, Border.Location.X + Border.Width-70),
        rand.Next(Border.Location.Y, Border.Location.Y + Border.Height-70));
            LeftMover = rand.Next(-10, 10);
            UpMover = rand.Next(-10, 10);

        }

        private void colidCheckWithPoolBorders()
        {

            if (PicBall.Location.X + PicBall.Width > Border.Width + Border.Location.X)
            {
                LeftMover = -rand.Next(10);
            }
            else if (PicBall.Location.X < Border.Location.X)
            {
                LeftMover = rand.Next(10);

            }
            else if (PicBall.Location.Y < Border.Location.Y)
            {
                UpMover = rand.Next(10);

            }
            else if (PicBall.Location.Y + PicBall.Height > Border.Location.Y + Border.Height)
            {
                UpMover = -rand.Next(10);

            }
        }

        private void checkcColisionBetweenBalls(PictureBox colidingBall, int index)
        {

            int thisBallRightUpCornerX = PicBall.Location.X + PicBall.Width;
            int thisBallRightBottomCornerY = PicBall.Location.Y + PicBall.Height;
            int collidingBallBottomLeftY = colidingBall.Location.Y + colidingBall.Height;
            int colidingBallUpRightCornerX = colidingBall.Location.X + colidingBall.Width;
            //colide with |_ corners with this ball on bottom
            if (thisBallRightUpCornerX -5> colidingBall.Location.X && colidingBallUpRightCornerX > thisBallRightUpCornerX && PicBall.Location.Y < collidingBallBottomLeftY-5 && colidingBall.Location.Y < PicBall.Location.Y)
            {
                LeftMover = -rand.Next(10);
                UpMover = rand.Next(10);
                lstPoolBall[index].LeftMover = rand.Next(10);
                lstPoolBall[index].UpMover = -rand.Next(10);
            }
            else if (colidingBallUpRightCornerX-5 > PicBall.Location.X && colidingBallUpRightCornerX < thisBallRightUpCornerX && PicBall.Location.Y < colidingBall.Location.Y && thisBallRightBottomCornerY-5 > colidingBall.Location.Y)
            {
                LeftMover = rand.Next(10);
                UpMover = -rand.Next(10);
                lstPoolBall[index].LeftMover = -rand.Next(10);
                lstPoolBall[index].UpMover = rand.Next(10);
            }


        }


    }

}
