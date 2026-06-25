using System;

namespace Lab3_OOP
{
    class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public double GiaBan { get; set; }

        public Sach()
        {
        }

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NamXuatBan = namXuatBan;
            GiaBan = giaBan;
        }

        public bool KiemTraSachMoi()
        {
            return NamXuatBan >= 2020;
        }

        public double GiamGia(double phanTram)
        {
            return GiaBan * (1 - phanTram / 100);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("{0,-10} {1,-30} {2,-20} {3,8} {4,15:N0} {5,10}",
                MaSach, TenSach, TacGia, NamXuatBan, GiaBan, KiemTraSachMoi() ? "Mới" : "Cũ");
        }
    }
}
