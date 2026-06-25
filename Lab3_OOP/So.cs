using System;

namespace Lab3_OOP
{
    class So
    {
        public double GiaTri { get; set; }

        public So()
        {
            GiaTri = 0;
        }

        public So(double giaTri)
        {
            GiaTri = giaTri;
        }

        public double Cong(So b)
        {
            return GiaTri + b.GiaTri;
        }

        public double Tru(So b)
        {
            return GiaTri - b.GiaTri;
        }

        public double Nhan(So b)
        {
            return GiaTri * b.GiaTri;
        }

        public double Chia(So b)
        {
            if (b.GiaTri == 0)
                throw new DivideByZeroException("Không thể chia cho 0.");
            return GiaTri / b.GiaTri;
        }
    }
}
