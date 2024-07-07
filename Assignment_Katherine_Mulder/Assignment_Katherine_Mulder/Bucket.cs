using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Katherine_Mulder
{
    class Bucket : Item
    {
        //properties
        public Image image;

        //Call base constructor (Shape constructor)
        public Bucket(Image image, int width, int height, Vector2 location) :
            base(width, height, new SolidBrush(Color.Black), location)
        {
            this.image = image;
        }

        //Methods
        //Override the draw() method in parent class
        override public void draw(Graphics canvas)
        {
            canvas.DrawImage(this.image, topLeft.X, topLeft.Y, width, height);
        }

    }
}
