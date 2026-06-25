using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_OOP
{
    class LopHoc
    {
        public string TenLop { get; set; }
        public List<SinhVien> DanhSachSinhVien { get; set; }

        public LopHoc()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }

        public LopHoc(string tenLop)
        {
            TenLop = tenLop;
            DanhSachSinhVien = new List<SinhVien>();
        }

        public void ThemSinhVien(SinhVien sv)
        {
            DanhSachSinhVien.Add(sv);
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("DANH SÁCH SINH VIÊN LỚP {0}", TenLop);
            Console.WriteLine("{0,-10} {1,-25} {2,-12} {3,8} {4,12}",
                "Mã SV", "Họ tên", "Lớp", "ĐTB", "Xếp loại");
            Console.WriteLine(new string('-', 70));
            foreach (var sv in DanhSachSinhVien)
            {
                sv.HienThiThongTin();
            }
        }

        public SinhVien TimSinhVienTheoMa(string maSV)
        {
            return DanhSachSinhVien.FirstOrDefault(sv => sv.MaSV == maSV);
        }

        public double TinhDiemTrungBinhLop()
        {
            if (DanhSachSinhVien.Count == 0)
                return 0;
            return DanhSachSinhVien.Average(sv => sv.TinhDiemTrungBinh());
        }

        public SinhVien TimSinhVienDiemCaoNhat()
        {
            if (DanhSachSinhVien.Count == 0)
                return null;
            return DanhSachSinhVien.OrderByDescending(sv => sv.TinhDiemTrungBinh()).First();
        }
    }
}
