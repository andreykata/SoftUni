using Nakov.TurtleGraphics;
using System;

using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 100;

            for (int i = 1; i < 50; i++)
            {
                Nakov.TurtleGraphics.Turtle.Rotate(60 + i);
                Nakov.TurtleGraphics.Turtle.Forward(5 * i);
            }
            
           


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Reset();
        }

        private void buttonHideTurtle_Click(object sender, EventArgs e)
        {
            if (Nakov.TurtleGraphics.Turtle.ShowTurtle)
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = false;
                this.buttonHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = true;
                this.buttonHideTurtle.Text = "Hide Turtle";
            }

        }
    }
}
