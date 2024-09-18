using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playstation_4ITB1
{
    public partial class Canvas : UserControl
    {
        public event Action AddRequested;
        public event Action RandomRequested;

        Shape shape;
        internal Shape Shape => shape;

        public Canvas()
        {
            InitializeComponent();
        }

        internal void SetShape(Shape shape)
        {
            if(this.shape != null)
            {
                this.shape.Highlight(false);
            }
            this.shape = shape;
            this.shape.Highlight(true);
            Invalidate();
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(shape != null)
                    AddRequested?.Invoke();
            } else if(e.Button == MouseButtons.Right)
            {
                RandomRequested?.Invoke();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (shape == null) return;
            shape.Draw(e.Graphics, Width, Height);
        }
    }
}
