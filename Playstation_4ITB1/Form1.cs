namespace Playstation_4ITB1
{
    public partial class Form1 : Form
    {
        Shape square, circle, triangle, cross;
        Shape[] shapes;
        public Form1()
        {
            InitializeComponent();
            canvas1.AddRequested += OnAddRequested;
            canvas1.RandomRequested += OnRandomRequested;

            square = new Square(button1, textBox1);
            circle = new Circle(button2, textBox2);
            cross = new Cross(button3, textBox3);
            triangle = new Triangle(button4, textBox4);

            shapes = new Shape[4] { square, circle, cross, triangle };
        }

        private void OnRandomRequested()
        {
            canvas1.SetShape(shapes[new Random().Next(0, shapes.Length)]);
        }

        private void OnAddRequested()
        {
            label1.Text += canvas1.Shape.Text + ", ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas1.SetShape(square);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canvas1.SetShape(circle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            canvas1.SetShape(cross);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            canvas1.SetShape(triangle);
        }
    }
}
