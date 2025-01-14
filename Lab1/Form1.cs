namespace Lab1
{
    public partial class Form1 : Form
    {
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            newx = e.X;
            newy = e.Y;

            Graphics g = panel1.CreateGraphics();

            Pen pen = new Pen(Color.Red, 3);

            g.DrawLine(pen, oldx, oldy, newx, newy);
        }
    }
}
