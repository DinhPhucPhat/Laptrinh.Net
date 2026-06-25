using System;

namespace Lab3_OOP
{
    class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem()
        {
            X = 0;
            Y = 0;
        }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double TinhKhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(d.X - X, 2) + Math.Pow(d.Y - Y, 2));
        }

        public void HienThi()
        {
            Console.WriteLine("({0}, {1})", X, Y);
        }
    }
}
