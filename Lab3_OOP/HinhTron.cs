using System;

namespace Lab3_OOP
{
    class HinhTron
    {
        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set
            {
                if (value > 0)
                    _banKinh = value;
                else
                    throw new ArgumentException("Bán kính phải lớn hơn 0.");
            }
        }

        public HinhTron()
        {
            _banKinh = 1;
        }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Hình tròn có bán kính: {0}", BanKinh);
            Console.WriteLine("Chu vi: {0:F2}", TinhChuVi());
            Console.WriteLine("Diện tích: {0:F2}", TinhDienTich());
        }
    }
}
