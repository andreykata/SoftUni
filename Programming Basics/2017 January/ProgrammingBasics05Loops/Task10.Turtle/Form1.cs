using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Task10.Turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            for (int i = 0; i < 6; i++)
            {
                Nakov.TurtleGraphics.Turtle.Rotate(60);
                Nakov.TurtleGraphics.Turtle.Forward(100);
            }

            //// Draw a equilateral triangle
            //Nakov.TurtleGraphics.Turtle.Rotate(30);
            //Nakov.TurtleGraphics.Turtle.Forward(200);
            //Nakov.TurtleGraphics.Turtle.Rotate(120);
            //Nakov.TurtleGraphics.Turtle.Forward(200);
            //Nakov.TurtleGraphics.Turtle.Rotate(120);
            //Nakov.TurtleGraphics.Turtle.Forward(200);

            //// Draw a line in the triangle
            //Nakov.TurtleGraphics.Turtle.Rotate(-30);
            //Nakov.TurtleGraphics.Turtle.PenUp();
            //Nakov.TurtleGraphics.Turtle.Backward(50);
            //Nakov.TurtleGraphics.Turtle.PenDown();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Nakov.TurtleGraphics.Turtle.ShowTurtle)
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = false;
                this.buttonHide.Text = "Show Turtle";
            }
            else
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = true;
                this.buttonHide.Text = "Hide Turtle";
            }

        }
    }
}
