using System;

namespace Lab3_OOP
{
    class TamGiac
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TamGiac()
        {
            A = B = C = 0;
        }

        public TamGiac(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool KiemTraTamGiac()
        {
            return A > 0 && B > 0 && C > 0 &&
                   A + B > C &&
                   A + C > B &&
                   B + C > A;
        }

        public double TinhChuVi()
        {
            return A + B + C;
        }

        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public string LoaiTamGiac()
        {
            if (!KiemTraTamGiac())
                return "Không phải tam giác";

            if (A == B && B == C)
                return "Tam giác đều";

            if (A == B || A == C || B == C)
                return "Tam giác cân";

            if (A * A + B * B == C * C ||
                A * A + C * C == B * B ||
                B * B + C * C == A * A)
                return "Tam giác vuông";

            return "Tam giác thường";
        }
    }
}
