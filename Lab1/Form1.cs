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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int oldx, oldy, newx, newy;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;
            oldy = e.Y;
        }

        private void drawColoredShape(Graphics g, Pen pen, int oldx, int oldy, int newx, int newy)
        {
            if (line)
            {
                g.DrawLine(pen, oldx, oldy, newx, newy);
            }
            else if (rect)
            {
                Rectangle rectangle = new Rectangle(oldx, oldy, newx - oldx, newy - oldy);
                g.DrawRectangle(pen, rectangle);
            }
            else if (ellip)
            {
                g.DrawEllipse(pen, oldx, oldy, newx - oldx, newy - oldy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            newx = e.X;
            newy = e.Y;

            Graphics g = panel1.CreateGraphics();

            Pen pen = new Pen(GetColor(), 3);
            drawColoredShape(g, pen, oldx, oldy, newx, newy);
        }

        public Color GetColor()
        {
            Color cc = Color.FromArgb(red, green, blue);
            return cc;
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

        }
    }
}
