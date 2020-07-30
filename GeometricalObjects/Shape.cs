using System;
using System.Drawing;

namespace GeometricalObjects
{
    abstract class Shape
    {
        public int H { get; set; }
        public int W { get; set; }
        public Point Locate { get; set; }

        protected Graphics graph;
        protected SolidBrush brush;
        protected Random rnd = new Random();
        private bool[] sides;
        private Point left, down, right, up;

        public Shape()
        {
            H = rnd.Next(25, 75);
            W = rnd.Next(25, 75);
            sides = new bool[8];
        }
        public abstract void Draw();
        public SolidBrush RandomColorBrush()
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            brush = new SolidBrush(Color.FromArgb(r, g, b));
            return brush;
        }
        public void Movie(Shape shape)
        {
            if (!IsCollision(shape))
                Locate = new Point(Locate.X + 1, Locate.Y + 1);
            Draw();
        }

        private void SetSideValue(int x)
        {
            for (int i = 0; i < sides.Length; i++)
                if (i == x)
                    sides[i] = true;
                else
                    sides[i] = false;
        }
        private void GetObjectSides(Shape shape)
        {
            shape.left = new Point(shape.Locate.X, shape.Locate.Y);
            shape.down = new Point(shape.Locate.X, shape.Locate.Y + H);
            shape.right = new Point(shape.Locate.X + W, shape.Locate.Y + H);
            shape.up = new Point(shape.Locate.X + W, shape.Locate.Y);
        }
        private bool IsCollision(Shape shape)
        {
            GetObjectSides(this);
            GetObjectSides(shape);

            if (right.X >= 940)
                SetSideValue(0);
            else if (down.Y >= 660)
                SetSideValue(1);
            else if (left.X <= 0)
                SetSideValue(2);
            else if (up.Y <= 0)
                SetSideValue(3);
            else if (left.X >= shape.left.X && left.X <= shape.up.X && left.Y >= shape.left.Y && left.Y <= shape.down.Y)
                SetSideValue(4);
            else if (down.X >= shape.left.X && down.X <= shape.up.X && down.Y >= shape.left.Y && down.Y <= shape.down.Y)
                SetSideValue(5);
            else if (right.X >= shape.left.X && right.X <= shape.up.X && right.Y >= shape.left.Y && right.Y <= shape.down.Y)
                SetSideValue(6);
            else if (up.X >= shape.left.X && up.X <= shape.up.X && up.Y >= shape.left.Y && up.Y <= shape.down.Y)
                SetSideValue(7);

            if (sides[0])
                Locate = new Point(Locate.X - 1, Locate.Y - 1);
            else if (sides[1])
                Locate = new Point(Locate.X + 1, Locate.Y - 1);
            else if (sides[2])
                Locate = new Point(Locate.X + 1, Locate.Y + 1);
            else if (sides[3])
                Locate = new Point(Locate.X - 1, Locate.Y + 1);
            else if (sides[4])
                Locate = new Point(Locate.X + 2, Locate.Y + 1);
            else if (sides[5])
                Locate = new Point(Locate.X + 1, Locate.Y - 2);
            else if (sides[6])
                Locate = new Point(Locate.X - 2, Locate.Y - 1);
            else if (sides[7])
                Locate = new Point(Locate.X - 1, Locate.Y + 2);

            foreach (bool side in sides)
                if (side == true)
                    return true;

            return false;
        }
    }
}
#region Collision V2
//bool isObjectUp1, isObjectDown1, isObjectRight1, isObjectLeft1;
//sides = new bool[] { isRight, isDown, isLeft, isUp, isObjectLeft, isObjectLeft1, isObjectDown, isObjectDown1, isObjectRight, isObjectRight1, isObjectUp, isObjectUp1};

//else if (left.X >= shape.left.X && left.X <= shape.up.X && left.Y >= shape.up.Y && left.Y <= shape.right.Y)
//    SetSideValue(4);
//else if (down.X >= shape.left.X && down.X <= shape.up.X && down.Y >= shape.up.Y && down.Y <= shape.right.Y)
//    SetSideValue(5);

//else if (left.Y >= shape.up.Y && left.Y <= shape.right.Y && left.X >= shape.down.X && left.X <= shape.right.X)
//    SetSideValue(10);
//else if (up.Y >= shape.up.Y && up.Y <= shape.right.Y && up.X >= shape.down.X && up.X <= shape.right.X)
//    SetSideValue(11);

//else if (up.X >= shape.down.X && up.X <= shape.right.X && up.Y >= shape.left.Y && up.Y <= shape.down.Y)
//    SetSideValue(8);
//else if (right.X >= shape.down.X && right.X <= shape.right.X && right.Y >= shape.left.Y && right.Y <= shape.down.Y)
//    SetSideValue(9);

//else if (right.Y >= shape.left.Y && right.Y <= shape.down.Y && right.X >= shape.left.X && right.X <= shape.up.X)
//    SetSideValue(6);
//else if (down.Y >= shape.left.Y && down.Y <= shape.down.Y && down.X >= shape.left.X && down.X <= shape.up.X)
//    SetSideValue(7);

//else if (sides[4] || sides[5])
//    Locate = new Point(Locate.X + 1, Locate.Y);
//else if (sides[10] || sides[11])
//    Locate = new Point(Locate.X, Locate.Y + 1);
//else if (sides[8] || sides[9])
//    Locate = new Point(Locate.X - 1, Locate.Y);
//else if (sides[6] || sides[7])
//    Locate = new Point(Locate.X, Locate.Y - 1);
#endregion