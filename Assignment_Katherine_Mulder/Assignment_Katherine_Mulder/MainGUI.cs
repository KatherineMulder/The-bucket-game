using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_Katherine_Mulder
{
    public partial class MainGUI : Form
    {
        //Add global objects, variables
        Framework framework = new Framework();

        private List<DrawLine> listOfLines = new List<DrawLine>();
        private bool isDrawing = false;
        private bool mouseDown = false;
        private Point startPoint;
        private Point endPoint;
        // Add a timer object
        private Timer timer;


        //Locations of object generators
        Vector2 circleGenerator = new Vector2(0, 50);
        Vector2 circleGenerator2 = new Vector2(100, 0);
    

        public MainGUI()
        {
            InitializeComponent();

            // shared info among objects
            Item.boundaryW = canvas.Width;
            Item.boundaryH = canvas.Height;

            // postion of the Bucket
            framework.scoreBucket.topLeft = new Vector2(circleGenerator2.X + 180,
                                    Item.boundaryH - framework.scoreBucket.height);


            //postion of the obstacle 
            framework.obstacle.topLeft = new Vector2(Item.boundaryW - framework.obstacle.width -100, Item.boundaryH - framework.obstacle.height - 300);

            //postion of the obstacle2
            framework.obstacle2.topLeft = new Vector2(Item.boundaryW - framework.obstacle2.width  -500, Item.boundaryH - framework.obstacle2.height - 280);
            
            // Create a new timer object
            timer = new Timer();

            // Set the interval (in milliseconds) between timer ticks
            timer.Interval = 100; // Adjust this value to change the interval

            // Subscribe to the Tick event of the timer
            timer.Tick += Timer_Tick;

            //score 
            score.Text = "0";

        }
        
        private void MainGUI_Load(object sender, EventArgs e)
        {

            // Start the timer
            timer.Start();

        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
        
            // Refresh the canvas
            canvas.Invalidate();
            score.Text = framework.score.ToString();
           
        }

        private void canvas_Paint(object sender, PaintEventArgs e)

        {
            //bucket
            framework.scoreBucket.draw(e.Graphics);

            //obsticle
            framework.obstacle.draw(e.Graphics);

            //obsticle 2
            framework.obstacle2.draw(e.Graphics);


            // Draw blocks on the top of picture box
            int blockWidth = 100;
            int blockHeight = 30;
            int spacing = 500;

            // Calculate the positions for the blocks with spacing
            int xLeft = (int)circleGenerator.X;
            int xRight = (int)circleGenerator2.X + ((int)circleGenerator.X - (int)circleGenerator2.X - blockWidth) + blockWidth + spacing;

            int y = 0;

            e.Graphics.FillRectangle(new SolidBrush(Color.Orange), xLeft, y, blockWidth, blockHeight);
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), xRight, y, blockWidth, blockHeight);

            //Draw all circle in the list 
            foreach (Circle circle in framework.listOfCircles)
            {
                circle.move();
                circle.draw(e.Graphics);
            }

            //Draw all circle in the list 
            foreach (CircleR circleR in framework.listOfCirclesR)
            {
                circleR.move();
                circleR.draw(e.Graphics);
            }

            //Check collision
            framework.checkAllCollision();

            foreach (DrawLine line in listOfLines)
            {
                line.draw(e.Graphics);
            }

            
        }

        //-------------------Add objects to the framework-------------------

        private void addCircleBtn_Click_1(object sender, EventArgs e)
        {
            framework.addCircleL();
        }
        private void addCircleR_Click(object sender, EventArgs e)
        {
            framework.addCircleR();
        }

        private void drawLineBtn_Click(object sender, EventArgs e)   
        {

            // Change Button backgroundColor
            isDrawing = true;
            drawLineBtn.Tag = 1;
            drawLineBtn.BackColor = Color.Pink;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)  
        {
            mouseDown = true;
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                listOfLines.Add(new DrawLine(startPoint, endPoint));
                canvas.Invalidate(); // Refresh the canvas to show the final line
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            // Reset the necessary variables and clear lists
            listOfLines.Clear();
            framework.listOfCircles.Clear();
            // Refresh the canvas
            canvas.Invalidate();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            // Stop any ongoing timers or animations
            timer.Stop();
            
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            // Restart the timers or resume any animations
            timer.Start();
        }

        private void score_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}

