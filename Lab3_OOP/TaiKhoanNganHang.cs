using System;

namespace Lab3_OOP
{
    class TaiKhoanNganHang
    {
        public string SoTaiKhoan { get; set; }
        public string ChuTaiKhoan { get; set; }
        public double SoDu { get; private set; }

        public TaiKhoanNganHang()
        {
            SoDu = 0;
        }

        public TaiKhoanNganHang(string soTaiKhoan, string chuTaiKhoan, double soDu)
        {
            SoTaiKhoan = soTaiKhoan;
            ChuTaiKhoan = chuTaiKhoan;
            SoDu = soDu;
        }

        public void NapTien(double soTien)
        {
            if (soTien > 0)
                SoDu += soTien;
            else
                throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");
        }

        public void RutTien(double soTien)
        {
            if (soTien > 0 && soTien <= SoDu)
                SoDu -= soTien;
            else
                throw new ArgumentException("Số tiền rút không hợp lệ.");
        }

        public void ChuyenTien(TaiKhoanNganHang tkKhac, double soTien)
        {
            RutTien(soTien);
            tkKhac.NapTien(soTien);
        }

        public void HienThiSoDu()
        {
            Console.WriteLine("Tài khoản: {0}", SoTaiKhoan);
            Console.WriteLine("Chủ tài khoản: {0}", ChuTaiKhoan);
            Console.WriteLine("Số dư: {0:N0}", SoDu);
        }
    }
}
