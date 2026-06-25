using System;

namespace Lab3_OOP
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoTen, string chucVu, double luongCoBan, double heSoLuong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            LuongCoBan = luongCoBan;
            HeSoLuong = heSoLuong;
        }

        public double TinhLuong()
        {
            return LuongCoBan * HeSoLuong;
        }

        public double TinhPhuCap()
        {
            double phuCap = 0;
            switch (ChucVu.ToLower())
            {
                case "trưởng phòng":
                    phuCap = 2000000;
                    break;
                case "phó phòng":
                    phuCap = 1000000;
                    break;
                case "chủ tịch":
                    phuCap = 500000;
                    break;
            }
            return phuCap;
        }

        public double TinhTongThuNhap()
        {
            return TinhLuong() + TinhPhuCap();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("{0,-10} {1,-25} {2,-15} {3,15:N0} {4,10:N0} {5,15:N0}",
                MaNV, HoTen, ChucVu, LuongCoBan, HeSoLuong, TinhTongThuNhap());
        }
    }
}
