using System.Drawing;

namespace GeometricalObjects
{
    class Triangle : Shape
    {
        Point point1;
        Point Down1;
        Point Down2;

        public Triangle(Graphics graph)
        {
            this.graph = graph;
            Locate = new Point(rnd.Next(650, 920), rnd.Next(0, 600));
            brush = RandomColorBrush();
        }
        public override void Draw()
        {
            graph.FillPolygon(brush, Points());
        }
        private Point[] Points()
        {
            point1 = new Point(Locate.X + W / 2, Locate.Y);
            Down1 = new Point(Locate.X, Locate.Y + H);
            Down2 = new Point(Locate.X + W, Locate.Y + H);

            return new Point[] { point1, Down1, Down2 };
        }
    }
}
