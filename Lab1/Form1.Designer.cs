﻿namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectangleButton = new Button();
            greenBar = new TrackBar();
            panel1 = new Panel();
            lineButton = new Button();
            blueBar = new TrackBar();
            redBar = new TrackBar();
            ellipseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)greenBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redBar).BeginInit();
            SuspendLayout();
            // 
            // rectangleButton
            // 
            rectangleButton.Location = new Point(137, 16);
            rectangleButton.Margin = new Padding(2);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(108, 47);
            rectangleButton.TabIndex = 1;
            rectangleButton.Text = "Rectangle";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += rectangleButton_Click;
            // 
            // greenBar
            // 
            greenBar.BackColor = Color.Green;
            greenBar.Location = new Point(604, 17);
            greenBar.Margin = new Padding(2);
            greenBar.Maximum = 255;
            greenBar.Name = "greenBar";
            greenBar.Size = new Size(125, 56);
            greenBar.TabIndex = 2;
            greenBar.Scroll += green_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(10, 77);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 387);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // lineButton
            // 
            lineButton.Location = new Point(22, 16);
            lineButton.Margin = new Padding(2);
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(100, 47);
            lineButton.TabIndex = 4;
            lineButton.Text = "Line";
            lineButton.UseVisualStyleBackColor = true;
            lineButton.Click += lineButton_Click;
            // 
            // blueBar
            // 
            blueBar.BackColor = Color.Blue;
            blueBar.Location = new Point(778, 17);
            blueBar.Margin = new Padding(2);
            blueBar.Maximum = 255;
            blueBar.Name = "blueBar";
            blueBar.Size = new Size(125, 56);
            blueBar.TabIndex = 5;
            blueBar.Scroll += blue_Scroll;
            // 
            // redBar
            // 
            redBar.BackColor = Color.Red;
            redBar.Location = new Point(434, 17);
            redBar.Margin = new Padding(2);
            redBar.Maximum = 255;
            redBar.Name = "redBar";
            redBar.Size = new Size(125, 56);
            redBar.TabIndex = 6;
            redBar.Scroll += red_Scroll;
            // 
            // ellipseButton
            // 
            ellipseButton.AutoEllipsis = true;
            ellipseButton.Location = new Point(266, 16);
            ellipseButton.Margin = new Padding(2);
            ellipseButton.Name = "ellipseButton";
            ellipseButton.Size = new Size(113, 47);
            ellipseButton.TabIndex = 7;
            ellipseButton.Text = "Ellipse";
            ellipseButton.UseVisualStyleBackColor = true;
            ellipseButton.Click += ellipseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 474);
            Controls.Add(ellipseButton);
            Controls.Add(redBar);
            Controls.Add(blueBar);
            Controls.Add(lineButton);
            Controls.Add(panel1);
            Controls.Add(greenBar);
            Controls.Add(rectangleButton);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)greenBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)redBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button rectangleButton;
        private TrackBar greenBar;
        private Panel panel1;
        private Button lineButton;
        private TrackBar blueBar;
        private TrackBar redBar;
        private Button ellipseButton;
    }
}
