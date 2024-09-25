using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShaolinMatadorDePorco
{
    public partial class Form2 : Form
    {

        int MsgX, MsgY;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void TimerMSG_Tick(object sender, EventArgs e)
        {
            MsgY -= 10;
            this.Location = new Point(MsgX, MsgY);
            if (MsgY <= 668)
            {
                TimerMSG.Stop();
                timerTchauMSG.Start();
            }
        }
        int y = 100;
        private void timerTchauMSG_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                MsgY += 1;
                this.Location = new Point(MsgX, MsgY += 10);
                if (MsgY > 800)
                {
                    timerTchauMSG.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            MsgX = ScreenWidth - this.Width -5;
            MsgY = ScreenHeight - this.Height +70;
            
            this.Location = new Point(MsgX, MsgY);
        }
    }
}
