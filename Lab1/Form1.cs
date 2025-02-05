using System.Drawing.Drawing2D;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public byte red = 0;
        public byte green = 0;
        public byte blue = 0;

        public bool line = true;
        public bool rect = false;
        public bool ellip = false;

        private bool isDrawing = false;
        private int previewNewX, previewNewY;

        private Bitmap offScreenBitmap;
        private Graphics offScreenGraphics;

        public Form1()
        {
            InitializeComponent();
            InitializeDoubleBuffering();
        }

        private void InitializeDoubleBuffering()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            offScreenBitmap = new Bitmap(screenWidth, screenHeight);
            Console.WriteLine("Screen Width: " + screenWidth + " Screen Height: " + screenHeight);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            offScreenGraphics.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int oldx, oldy, newx, newy;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;
            oldy = e.Y;
            isDrawing = true;
        }


        private void drawColoredShape(Graphics g, Pen pen, int oldx, int oldy, int newx, int newy)
        {
            if (line)
            {
                g.DrawLine(pen, oldx, oldy, newx, newy);
            }
            else if (rect)
            {
                Rectangle rectangle = new Rectangle(Math.Min(oldx, newx), Math.Min(oldy, newy), Math.Abs(newx - oldx), Math.Abs(newy - oldy));
                g.DrawRectangle(pen, rectangle);
            }
            else if (ellip)
            {
                Rectangle ellipse = new Rectangle(Math.Min(oldx, newx), Math.Min(oldy, newy), Math.Abs(newx - oldx), Math.Abs(newy - oldy));
                g.DrawEllipse(pen, ellipse);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            newx = e.X;
            newy = e.Y;

            Pen pen = new Pen(GetColor(), 3);

            drawColoredShape(offScreenGraphics, pen, oldx, oldy, newx, newy);

            panel1.Invalidate();
        }

        public Color GetColor()
        {
            return Color.FromArgb(red, green, blue);
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            line = true;
            rect = false;
            ellip = false;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            line = false;
            rect = true;
            ellip = false;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            line = false;
            rect = false;
            ellip = true;
        }

        private void red_Scroll(object sender, EventArgs e)
        {
            red = (byte)redBar.Value;
        }

        private void green_Scroll(object sender, EventArgs e)
        {
            green = (byte)greenBar.Value;
        }

        private void blue_Scroll(object sender, EventArgs e)
        {
            blue = (byte)blueBar.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(offScreenBitmap, 0, 0);

            if (isDrawing)
            {
                Pen preview = new Pen(GetColor(), 3) { DashStyle = DashStyle.Dash };
                drawColoredShape(e.Graphics, preview, oldx, oldy, previewNewX, previewNewY);
            }
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                previewNewX = e.X;
                previewNewY = e.Y;

                panel1.Invalidate();
            }
        }
    }

}
