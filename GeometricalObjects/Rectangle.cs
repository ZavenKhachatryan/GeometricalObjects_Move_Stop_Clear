using System.Drawing;

namespace GeometricalObjects
{
    class Rectangle : Shape
    {
        public Rectangle(Graphics graph)
        {
            this.graph = graph;
            Locate = new Point(rnd.Next(0, 300), rnd.Next(0, 650));
            brush = RandomColorBrush();
        }
        public override void Draw()
        {
            graph.FillRectangle(brush, Locate.X, Locate.Y, W, H);
        }
    }
}