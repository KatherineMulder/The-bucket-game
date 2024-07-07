using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace Assignment_Katherine_Mulder
{
   
        public class DrawLine
        {
            public Point startPoint;
            public Point endPoint;
            private Pen pen;

            public DrawLine(Point startPoint, Point endPoint)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
                this.pen = new Pen(Color.Black, 5f);
            }
        public Vector2 GetNormal()
            {
            Vector2 direction = new Vector2(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            float length = (float)Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            Vector2 normal = new Vector2(-direction.Y / length, direction.X / length);
            return normal;
            }
        public void draw(Graphics canvas)
            {
                canvas.DrawLine(pen, startPoint, endPoint);
            }
        
        }

}
