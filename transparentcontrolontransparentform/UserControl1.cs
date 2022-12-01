using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace transparentcontrolontransparentform
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public int ismd = 0;

        public Brush brush0 = new SolidBrush(Color.Black);
        public Graphics g;
           
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
                  

        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {

            if (ismd == 1)
            {
                Left += e.X+1;
                Top += e.Y+1;
                g.FillEllipse(brush0, 5, 5, 30, 30);
            }
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {

            ismd = 1;
            this.BringToFront();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            g.FillEllipse(brush0, 5, 5, 30, 30);
        }
    }
}
