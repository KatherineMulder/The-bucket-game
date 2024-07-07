using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Assignment_Katherine_Mulder
{
    internal class Framework
    {
        //Properties
        public List<Circle> listOfCircles = new List<Circle>();
        public List<CircleR> listOfCirclesR = new List<CircleR>();
        public List<DrawLine> listOfLines = new List<DrawLine>();
        public Bucket scoreBucket;
        public Obstacle1 obstacle;
        public Obstacle2 obstacle2;
        bool bucketTouched = false;
        public int score = 0;
        private int blockWidth = 400;


        //Locations of object generators
        public Vector2 circleGenerator = new Vector2(0, 50);
        public Vector2 circleGenerator2 = new Vector2(100, 0);



        //Constructor
        public Framework()

        {
            //bucket
            System.Drawing.Image image = Properties.Resources.bucket1;
            scoreBucket = new Bucket(image, 100, 130, new Vector2(0, 0));


            //obstacle 
            System.Drawing.Image imageObstacle = Properties.Resources.obstacle1;
            obstacle = new Obstacle1(imageObstacle, 200, 40, new Vector2(120, 250));

            //second obstacle
            System.Drawing.Image imageObstacle2 = Properties.Resources.obstacle2;
            obstacle2 = new Obstacle2(imageObstacle2, 220, 60, new Vector2(120, 230));


        }

        //Methods

        public void addCircleL()
        {
            //Create radom colour circle at the generator block

            Random random = new Random();
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);
            Color randomColor = Color.FromArgb(red, green, blue);
            Circle circle = new Circle(20, new SolidBrush(randomColor),
                           new Vector2(circleGenerator.X, circleGenerator.Y));

            //add this new object to the list
            listOfCircles.Add(circle);
        }
        public void addCircleR()
        {
            // Create a random colored circle at the right generator block
            Random random = new Random();
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);
            Color randomColor = Color.FromArgb(red, green, blue);

            // Adjust the X-coordinate to be outside the right block
            int circleRX = (int)circleGenerator2.X + blockWidth;

            CircleR circleR = new CircleR(20, new SolidBrush(randomColor),
                                          new Vector2(circleRX, circleGenerator2.Y));

            // Add this new object to the list
            listOfCirclesR.Add(circleR);
        }

        public Vector2 Reflect(Vector2 incident, Vector2 normal)
        {
            Vector2 reflected = incident - 2 * Vector2.Dot(incident, normal) * normal;
            return reflected;
        }


        //------------------------------------check collision------------------------------------------- 
        public bool checkCollision(Circle obj1, Bucket obj2)
        {
            //Calculate the center coordinate of 2 object boxes
            int obj1CenterX = (int)obj1.topLeft.X + (obj1.width / 2);
            int obj1CenterY = (int)obj1.topLeft.Y + (obj1.height / 2);

            int obj2CenterX = (int)obj2.topLeft.X + (obj2.width / 2);
            int obj2CenterY = (int)obj2.topLeft.Y + (obj2.height / 2);

            //Calculate the distance between the central points of two object boxes
            int centralDistanceX = Math.Abs(obj1CenterX - obj2CenterX);
            int centralDistanceY = Math.Abs(obj1CenterY - obj2CenterY);

            //Check two collision conditions:
            if (centralDistanceX <= (obj1.width / 2 + obj2.width / 2)
                                && centralDistanceY <= (obj1.height / 2 + obj2.height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkCollision(Circle obj1, Obstacle2 obj2) //
        {
            //Calculate the center coordinate of 2 object boxes
            int obj1CenterX = (int)obj1.topLeft.X + (obj1.width / 2);
            int obj1CenterY = (int)obj1.topLeft.Y + (obj1.height / 2);

            int obj2CenterX = (int)obj2.topLeft.X + (obj2.width / 2);
            int obj2CenterY = (int)obj2.topLeft.Y + (obj2.height / 2);

            //Calculate the distance between the central points of two object boxes
            int centralDistanceX = Math.Abs(obj1CenterX - obj2CenterX);
            int centralDistanceY = Math.Abs(obj1CenterY - obj2CenterY);

            //Check two collision conditions:
            if (centralDistanceX <= (obj1.width / 2 + obj2.width / 2)
                 && centralDistanceY <= (obj1.height / 2 + obj2.height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckCollision(Circle obj1, DrawLine obj2)
        {
            float circleCenterX = obj1.topLeft.X + obj1.width / 2;
            float circleCenterY = obj1.topLeft.Y + obj1.height / 2;

            float lineStartX = obj2.startPoint.X;
            float lineStartY = obj2.startPoint.Y;
            float lineEndX = obj2.endPoint.X;
            float lineEndY = obj2.endPoint.Y;

            float distance = Math.Abs(
                (lineEndY - lineStartY) * circleCenterX -
                (lineEndX - lineStartX) * circleCenterY +
                lineEndX * lineStartY - lineEndY * lineStartX
            ) / (float)Math.Sqrt(Math.Pow(lineEndY - lineStartY, 2) + Math.Pow(lineEndX - lineStartX, 2));

            return distance <= obj1.radius;
        }




        public bool checkCollision(CircleR obj1, Bucket obj2)
        {
            //Calculate the center coordinate of 2 object boxes
            int obj1CenterX = (int)obj1.topLeft.X + (obj1.width / 2);
            int obj1CenterY = (int)obj1.topLeft.Y + (obj1.height / 2);

            int obj2CenterX = (int)obj2.topLeft.X + (obj2.width / 2);
            int obj2CenterY = (int)obj2.topLeft.Y + (obj2.height / 2);

            //Calculate the distance between the central points of two object boxes
            int centralDistanceX = Math.Abs(obj1CenterX - obj2CenterX);
            int centralDistanceY = Math.Abs(obj1CenterY - obj2CenterY);

            //Check two collision conditions:
            if (centralDistanceX <= (obj1.width / 2 + obj2.width / 2)
                                && centralDistanceY <= (obj1.height / 2 + obj2.height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkCollision(CircleR obj1, Obstacle1 obj2) //
        {
            //Calculate the center coordinate of 2 object boxes
            int obj1CenterX = (int)obj1.topLeft.X + (obj1.width / 2);
            int obj1CenterY = (int)obj1.topLeft.Y + (obj1.height / 2);

            int obj2CenterX = (int)obj2.topLeft.X + (obj2.width / 2);
            int obj2CenterY = (int)obj2.topLeft.Y + (obj2.height / 2);

            //Calculate the distance between the central points of two object boxes
            int centralDistanceX = Math.Abs(obj1CenterX - obj2CenterX);
            int centralDistanceY = Math.Abs(obj1CenterY - obj2CenterY);

            //Check two collision conditions:
            if (centralDistanceX <= (obj1.width / 2 + obj2.width / 2)
                 && centralDistanceY <= (obj1.height / 2 + obj2.height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkCollision(CircleR obj1, DrawLine obj2)
        {
            Point circleCenter = new Point((int)(obj1.topLeft.X + obj1.width / 2), (int)(obj1.topLeft.Y + obj1.height / 2));

            float dx = obj2.endPoint.X - obj2.startPoint.X;
            float dy = obj2.endPoint.Y - obj2.startPoint.Y;

            float t = ((circleCenter.X - obj2.startPoint.X) * dx + (circleCenter.Y - obj2.startPoint.Y) * dy) / (dx * dx + dy * dy);

            float closestX, closestY;

            if (t < 0)
            {
                closestX = obj2.startPoint.X;
                closestY = obj2.startPoint.Y;
            }
            else if (t > 1)
            {
                closestX = obj2.endPoint.X;
                closestY = obj2.endPoint.Y;
            }
            else
            {
                closestX = obj2.startPoint.X + t * dx;
                closestY = obj2.startPoint.Y + t * dy;
            }

            float distance = (float)Math.Sqrt(Math.Pow(circleCenter.X - closestX, 2) + Math.Pow(circleCenter.Y - closestY, 2));

            return distance <= obj1.radius;
        }

        public bool checkCollision(Circle obj1, DrawLine obj2)
        {
            Point circleCenter = new Point((int)(obj1.topLeft.X + obj1.width / 2), (int)(obj1.topLeft.Y + obj1.height / 2));

            float dx = obj2.endPoint.X - obj2.startPoint.X;
            float dy = obj2.endPoint.Y - obj2.startPoint.Y;

            float t = ((circleCenter.X - obj2.startPoint.X) * dx + (circleCenter.Y - obj2.startPoint.Y) * dy) / (dx * dx + dy * dy);

            float closestX, closestY;

            if (t < 0)
            {
                closestX = obj2.startPoint.X;
                closestY = obj2.startPoint.Y;
            }
            else if (t > 1)
            {
                closestX = obj2.endPoint.X;
                closestY = obj2.endPoint.Y;
            }
            else
            {
                closestX = obj2.startPoint.X + t * dx;
                closestY = obj2.startPoint.Y + t * dy;
            }

            float distance = (float)Math.Sqrt(Math.Pow(circleCenter.X - closestX, 2) + Math.Pow(circleCenter.Y - closestY, 2));

            return distance <= obj1.radius;
        }

        ////find the distance between the center of the circle and the line-----------------------
        //----------------check all collision------------
        public void checkAllCollision()
        {
            // Create lists to store circles that need to be removed
            List<Circle> circlesToRemove = new List<Circle>();
            List<CircleR> circlesRToRemove = new List<CircleR>();

            // Check collision between circles and obstacle2
            foreach (Circle circle in listOfCircles)
            {
                if (checkCollision(circle, obstacle2))
                {
                    // Change the velocity of the circle to make it move to the right
                    circle.velocity.Y = 0;
                    circle.velocity.X = 4;
                }
                else
                {
                    // Check if the circle touches the bottom line or not. If not, move downward. If yes, mark it for removal
                    if (circle.topLeft.Y + circle.height > Item.boundaryH)
                    {
                        circlesToRemove.Add(circle);
                    }
                    else
                    {
                        // Change the velocity of the circle to make it move downward
                        circle.velocity.X = 0;
                        circle.velocity.Y = 5;
                    }
                }

                // Check if the circle touches the bucket, then mark it for removal
                if (checkCollision(circle, scoreBucket))
                {
                    bucketTouched = true;
                    circlesToRemove.Add(circle);
                    score++;
                }

                // Check if the circle touches any line, then adjust its velocity for bouncing
                foreach (DrawLine line in listOfLines)
                {
                    if (CheckCollision(circle, line))
                    {
                        // Calculate the reflection vector
                        Vector2 reflection = Reflect(circle.velocity, line.GetNormal());

                        // Adjust the circle's velocity
                        circle.velocity = reflection;
                    }
                }

            }

            // Check collision between circlesR and obstacle
            foreach (CircleR circleR in listOfCirclesR)
            {
                if (checkCollision(circleR, obstacle))
                {
                    // Change the velocity of the circleR to make it move to the left
                    circleR.velocity.Y = 0;
                    circleR.velocity.X = -4;
                }
                else
                {
                    // Check if the circleR touches the bottom line or not. If not, move downward. If yes, mark it for removal
                    if (circleR.topLeft.Y + circleR.height > Item.boundaryH)
                    {
                        circlesRToRemove.Add(circleR);
                    }
                    else
                    {
                        // Change the velocity of the circleR to make it move downward
                        circleR.velocity.X = 0;
                        circleR.velocity.Y = 5;
                    }
                }

                // Check if the circleR touches the bucket, then mark it for removal
                if (checkCollision(circleR, scoreBucket))
                {
                    bucketTouched = true;
                    circlesRToRemove.Add(circleR);
                    score++;
                }

                // Check if the circleR touches any line, then adjust its velocity for bouncing
                foreach (DrawLine line in listOfLines)
                {
                    if (checkCollision(circleR, line))
                    {
                        // Calculate the reflection vector
                        Vector2 reflection = Reflect(circleR.velocity, line.GetNormal());

                        // Adjust the circleR's velocity
                        circleR.velocity = reflection;
                    }
                }

            }

            // Remove circles that need to be removed
            foreach (Circle circle in circlesToRemove)
            {
                listOfCircles.Remove(circle);
            }

            // Remove circlesR that need to be removed
            foreach (CircleR circleR in circlesRToRemove)
            {
                listOfCirclesR.Remove(circleR);
            }
        }


    }
}

