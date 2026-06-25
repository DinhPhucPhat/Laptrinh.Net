using System;

namespace Lab3_OOP
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemTin { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string maSV, string hoTen, string lop,
                        double diemToan, double diemLy, double diemTin)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Lop = lop;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemTin = diemTin;
        }

        public double TinhDiemTrungBinh()
        {
            return (DiemToan + DiemLy + DiemTin) / 3;
        }

        public string XepLoai()
        {
            double dtb = TinhDiemTrungBinh();

            if (dtb >= 8.5)
                return "Giỏi";
            if (dtb >= 7.0)
                return "Khá";
            if (dtb >= 5.0)
                return "Trung bình";
            return "Yếu";
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("{0,-10} {1,-25} {2,-12} {3,8:F2} {4,12}",
                MaSV, HoTen, Lop, TinhDiemTrungBinh(), XepLoai());
        }
    }
}
