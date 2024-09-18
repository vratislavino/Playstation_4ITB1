using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation_4ITB1
{
    internal abstract class Shape
    {
        protected Pen pen = new Pen(Color.Black, 20);
        protected int padding = 40;

        Button button;
        TextBox textbox;

        bool isHighlighted = false;

        public string Text => textbox.Text;

        public Shape(Button btn, TextBox txtbx) {
            button = btn;
            textbox = txtbx;
        }

        public void Highlight(bool highlight)
        {
            isHighlighted = highlight;
            button.BackColor = isHighlighted ? Color.Red : Color.White;
        }
        
        public abstract void Draw(Graphics g, int w, int h);
    }

    internal class Square : Shape
    {
        public Square(Button btn, TextBox txtbx) : base(btn, txtbx)
        {
            pen.Color = Color.DarkMagenta;
        }

        public override void Draw(Graphics g, int w, int h)
        {
            g.DrawRectangle(pen, padding, padding, w - 2 * padding, h - 2 * padding);
        }
    }

    internal class Circle : Shape
    {
        public Circle(Button btn, TextBox txtbx) : base(btn, txtbx)
        {
            pen.Color = Color.Red;
        }

        public override void Draw(Graphics g, int w, int h)
        {
            g.DrawEllipse(pen, padding, padding, w - 2 * padding, h - 2 * padding);
        }
    }

    internal class Cross : Shape
    {
        public Cross(Button btn, TextBox txtbx) : base(btn, txtbx)
        {
            pen.Color = Color.Blue;
        }

        public override void Draw(Graphics g, int w, int h)
        {
            g.DrawLine(pen, padding, padding, w - padding, h - padding);
            g.DrawLine(pen, padding, h - padding, w - padding, padding);
        }
    }

    internal class Triangle : Shape
    {
        public Triangle(Button btn, TextBox txtbx) : base(btn, txtbx)
        {
            pen.Color = Color.Green;
        }

        public override void Draw(Graphics g, int w, int h)
        {
            g.DrawPolygon(pen, new Point[]
            {
                new Point(w / 2, padding),
                new Point(padding, h - padding),
                new Point(w - padding, h - padding)
            });
        }
    }
}
