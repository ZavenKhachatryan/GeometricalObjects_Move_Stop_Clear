using System.Drawing;

namespace GeometricalObjects
{
    class Circle : Shape
    {
        public Circle(Graphics graph)
        {
            this.graph = graph;
            W = H;
            Locate = new Point(rnd.Next(350, 600), rnd.Next(0, 650));
            brush = RandomColorBrush();
        }
        public override void Draw()
        {
            graph.FillEllipse(brush, Locate.X, Locate.Y, W, H);
        }
    }
}