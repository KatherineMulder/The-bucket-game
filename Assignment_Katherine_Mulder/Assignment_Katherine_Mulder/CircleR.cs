using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Katherine_Mulder
{
    internal class CircleR: Item
    {
        //Properities
        public int radius;

        //Constructors
        //Call base constructor (Shape constructor)
        public CircleR(int radius, SolidBrush color, Vector2 location) : base(2 * radius, 2 * radius, color, location)
        {
            this.radius = radius;
        }


        //Methods
        //Override the draw()
        public void draw(Graphics canvas)
        {
            canvas.FillEllipse(color, topLeft.X, topLeft.Y, width, height);
        }
    }
}
