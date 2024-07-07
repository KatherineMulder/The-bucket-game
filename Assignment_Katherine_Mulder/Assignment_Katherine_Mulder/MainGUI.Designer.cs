namespace Assignment_Katherine_Mulder
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addCircleBtnL = new System.Windows.Forms.Button();
            this.introduction = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.drawLineBtn = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.addCircleR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // addCircleBtnL
            // 
            this.addCircleBtnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addCircleBtnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCircleBtnL.Location = new System.Drawing.Point(29, 216);
            this.addCircleBtnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCircleBtnL.Name = "addCircleBtnL";
            this.addCircleBtnL.Size = new System.Drawing.Size(159, 62);
            this.addCircleBtnL.TabIndex = 1;
            this.addCircleBtnL.Text = "Add Circle L";
            this.addCircleBtnL.UseVisualStyleBackColor = false;
            this.addCircleBtnL.Click += new System.EventHandler(this.addCircleBtn_Click_1);
            // 
            // introduction
            // 
            this.introduction.BackColor = System.Drawing.SystemColors.Menu;
            this.introduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.introduction.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introduction.Location = new System.Drawing.Point(12, 86);
            this.introduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.introduction.Multiline = true;
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(232, 126);
            this.introduction.TabIndex = 4;
            this.introduction.Text = "Add circle to start the game \r\nthen draw lines to support the shapes bounce into " +
    "the bucket.";
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(29, 14);
            this.score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.score.Multiline = true;
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(159, 56);
            this.score.TabIndex = 5;
            this.score.Text = "Score:";
            this.score.TextChanged += new System.EventHandler(this.score_TextChanged);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Location = new System.Drawing.Point(12, 544);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 58);
            this.pauseBtn.TabIndex = 6;
            this.pauseBtn.Text = "||";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(93, 543);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(75, 58);
            this.continueBtn.TabIndex = 7;
            this.continueBtn.Text = "▶";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(174, 543);
            this.restartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(117, 58);
            this.restartBtn.TabIndex = 8;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.BackColor = System.Drawing.Color.White;
            this.drawLineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLineBtn.Location = new System.Drawing.Point(29, 438);
            this.drawLineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(159, 60);
            this.drawLineBtn.TabIndex = 9;
            this.drawLineBtn.Text = "Draw Line";
            this.drawLineBtn.UseVisualStyleBackColor = false;
            this.drawLineBtn.Click += new System.EventHandler(this.drawLineBtn_Click);
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(321, 14);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(981, 626);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // addCircleR
            // 
            this.addCircleR.BackColor = System.Drawing.Color.Yellow;
            this.addCircleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCircleR.Location = new System.Drawing.Point(29, 321);
            this.addCircleR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCircleR.Name = "addCircleR";
            this.addCircleR.Size = new System.Drawing.Size(159, 62);
            this.addCircleR.TabIndex = 10;
            this.addCircleR.Text = "Add Circle R";
            this.addCircleR.UseVisualStyleBackColor = false;
            this.addCircleR.Click += new System.EventHandler(this.addCircleR_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 678);
            this.Controls.Add(this.addCircleR);
            this.Controls.Add(this.drawLineBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.score);
            this.Controls.Add(this.introduction);
            this.Controls.Add(this.addCircleBtnL);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addCircleBtnL;
        private System.Windows.Forms.TextBox introduction;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button drawLineBtn;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button addCircleR;
    }
}

