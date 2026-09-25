using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private List<Shape> _shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            AShapeFactory factory = null;


            if (cmbShapeType.SelectedItem.ToString() == "Коло")
            {
                int x = int.Parse(numX.Text);
                int y = int.Parse(numY.Text);
                double radius = double.Parse(numRadius.Text);

                factory = new CircleFactory(x, y, Color.Red, radius);
            }

            else if (cmbShapeType.SelectedItem.ToString() == "Прямокутник")
            {
                int x = int.Parse(numX.Text);
                int y = int.Parse(numY.Text);
                int width = int.Parse(numWidth.Text);
                int height = int.Parse(numHeight.Text);

                factory = new RectangleFactory(x, y, Color.Blue, width, height);

            }

            else
            {
                int x = int.Parse(numX.Text);
                int y = int.Parse(numY.Text);
                int width = int.Parse(numWidth.Text);
                int height = int.Parse(numHeight.Text);

                factory = new TriangleFactory(x, y, Color.Blue, width, height);
            }

            if (factory != null)
            {
                Shape createdShape = factory.CreateShape();

                _shapes.Clear();
                _shapes.Add(createdShape);

                listBox1.Items.Add($"{createdShape.GetType().Name} — Площа: {createdShape.GetArea():F2}");
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pictureBox1.BackColor);
            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}
