using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Katherine_Mulder
{
    internal class Circle : Item
    {
        public int radius;

        // Constructors
        public Circle(int radius, SolidBrush color, Vector2 location) : base(2 * radius, 2 * radius, color, location)
        {
            this.radius = radius;
        }

        // Methods
        public void draw(Graphics canvas)
        {
            canvas.FillEllipse(color, topLeft.X, topLeft.Y, width, height);
        }

        public bool CheckCollision(DrawLine line)
        {
            float circleCenterX = topLeft.X + radius;
            float circleCenterY = topLeft.Y + radius;

            float lineStartX = line.startPoint.X;
            float lineStartY = line.startPoint.Y;
            float lineEndX = line.endPoint.X;
            float lineEndY = line.endPoint.Y;

            float distance = Math.Abs(
                (lineEndY - lineStartY) * circleCenterX -
                (lineEndX - lineStartX) * circleCenterY +
                lineEndX * lineStartY - lineEndY * lineStartX
            ) / (float)Math.Sqrt(Math.Pow(lineEndY - lineStartY, 2) + Math.Pow(lineEndX - lineStartX, 2));

            return distance <= radius;
        }
    }
}
