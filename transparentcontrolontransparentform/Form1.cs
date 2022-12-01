using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace transparentcontrolontransparentform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void invalidateallcontrols()
        { 
            foreach(Control a in this.Controls)
            {
                a.Invalidate(); 
            }
        }

        private void userControl11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl21_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // invalidateallcontrols();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        

       
    }
}
