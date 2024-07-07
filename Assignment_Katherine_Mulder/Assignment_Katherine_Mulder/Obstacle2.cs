using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Katherine_Mulder
{
    internal class Obstacle2: Item
    {
        public Image imageObstacle2;


        public Obstacle2(Image image, int width, int height, Vector2 location) :
            base(width, height, new SolidBrush(Color.Black), location)
        {
            this.imageObstacle2 = image;
        }

        //Methods
        //Override the draw() method in parent class
        override public void draw(Graphics canvas)
        {
            canvas.DrawImage(this.imageObstacle2, topLeft.X, topLeft.Y, width, height);


        }
    }
}
