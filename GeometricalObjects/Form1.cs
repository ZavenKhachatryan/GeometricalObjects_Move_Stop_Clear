using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace GeometricalObjects
{
    public partial class Form1 : Form
    {
        int i = -1;
        Graphics graph;
        bool isPaused = false;
        List<Shape> shapesList = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            graph = panel.CreateGraphics();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            i++;
            shapesList.Add(new Rectangle(graph));
            shapesList[i].Draw();
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            i++;
            shapesList.Add(new Triangle(graph));
            shapesList[i].Draw();
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            i++;
            shapesList.Add(new Circle(graph));
            shapesList[i].Draw();
        }
        private async void AsyncMovie_Click(object sender, EventArgs e)
        {
            isPaused = false;
            await Movie();
        }
        private Task Movie()
        {
            return Task.Run(() =>
            {
                while (!isPaused)
                {
                    Thread.Sleep(45);
                    Refresh();
                    foreach (Shape shape in shapesList)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            if (shape == shapesList[j])
                                continue;
                            shapesList[j].Movie(shape);
                        }
                    }
                }
            });
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.WhiteSmoke);
            shapesList.RemoveRange(0, i + 1);
            Pause_Click(sender, e);
            i = -1;
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (e.X <= shapesList[j].Locate.X + shapesList[j].W &&
                        e.Y <= shapesList[j].Locate.Y + shapesList[j].H &&
                        e.X >= shapesList[j].Locate.X &&
                        e.Y >= shapesList[j].Locate.Y)
                    {
                        shapesList[j].Locate = new Point(e.X - (shapesList[j].W / 2), e.Y - (shapesList[j].H / 2));
                        break;
                    }
                }

                Refresh();
                foreach (Shape shape in shapesList)
                    shape.Draw();
            }
        }
    }
}