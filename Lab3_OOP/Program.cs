using System;

namespace Lab3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== CHƯƠNG TRÌNH LAB 3 - LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG ===");
                Console.WriteLine("1. Bài tập 1: Lớp Số");
                Console.WriteLine("2. Bài tập 2: Lớp Tam giác");
                Console.WriteLine("3. Bài tập 3: Lớp Sinh viên");
                Console.WriteLine("4. Bài tập 4: Lớp Điểm");
                Console.WriteLine("5. Bài tập 5: Lớp Phân số");
                Console.WriteLine("6. Bài tập 6: Lớp Hình tròn");
                Console.WriteLine("7. Bài tập 7: Lớp Nhân viên");
                Console.WriteLine("8. Bài tập 8: Lớp Tài khoản ngân hàng");
                Console.WriteLine("9. Bài tập 9: Lớp Sách");
                Console.WriteLine("10. Bài tập 10: Lớp Lớp học và Sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài tập: ");

                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            BaiTap1();
                            break;
                        case "2":
                            BaiTap2();
                            break;
                        case "3":
                            BaiTap3();
                            break;
                        case "4":
                            BaiTap4();
                            break;
                        case "5":
                            BaiTap5();
                            break;
                        case "6":
                            BaiTap6();
                            break;
                        case "7":
                            BaiTap7();
                            break;
                        case "8":
                            BaiTap8();
                            break;
                        case "9":
                            BaiTap9();
                            break;
                        case "10":
                            BaiTap10();
                            break;
                        case "0":
                            Console.WriteLine("Tạm biệt!");
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        static void BaiTap1()
        {
            Console.WriteLine("\n=== BÀI TẬP 1: LỚP SỐ ===");
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            So so1 = new So(a);
            So so2 = new So(b);

            Console.WriteLine("\nTổng: " + so1.Cong(so2));
            Console.WriteLine("Hiệu: " + so1.Tru(so2));
            Console.WriteLine("Tích: " + so1.Nhan(so2));
            try
            {
                Console.WriteLine("Thương: " + so1.Chia(so2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        static void BaiTap2()
        {
            Console.WriteLine("\n=== BÀI TẬP 2: LỚP TAM GIÁC ===");
            Console.Write("Nhập cạnh a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            TamGiac tg = new TamGiac(a, b, c);

            if (tg.KiemTraTamGiac())
            {
                Console.WriteLine("\nĐây là tam giác hợp lệ!");
                Console.WriteLine("Loại tam giác: " + tg.LoaiTamGiac());
                Console.WriteLine("Chu vi: " + tg.TinhChuVi());
                Console.WriteLine("Diện tích: " + tg.TinhDienTich());
            }
            else
            {
                Console.WriteLine("\nBa cạnh không tạo thành tam giác.");
            }
        }

        static void BaiTap3()
        {
            Console.WriteLine("\n=== BÀI TẬP 3: LỚP SINH VIÊN ===");
            Console.Write("Nhập mã sinh viên: ");
            string maSV = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập lớp: ");
            string lop = Console.ReadLine();
            Console.Write("Nhập điểm Toán: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Tin: ");
            double tin = double.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(maSV, hoTen, lop, toan, ly, tin);

            Console.WriteLine("\nDANH SÁCH SINH VIÊN:");
            Console.WriteLine("{0,-10} {1,-25} {2,-12} {3,8} {4,12}",
                "Mã SV", "Họ tên", "Lớp", "ĐTB", "Xếp loại");
            Console.WriteLine(new string('-', 70));
            sv.HienThiThongTin();
        }

        static void BaiTap4()
        {
            Console.WriteLine("\n=== BÀI TẬP 4: LỚP ĐIỂM ===");
            Console.WriteLine("Nhập điểm thứ nhất:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNhập điểm thứ hai:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Diem d1 = new Diem(x1, y1);
            Diem d2 = new Diem(x2, y2);

            Console.Write("\nĐiểm thứ nhất: ");
            d1.HienThi();
            Console.Write("Điểm thứ hai: ");
            d2.HienThi();
            Console.WriteLine("Khoảng cách giữa hai điểm: " + d1.TinhKhoangCach(d2));
        }

        static void BaiTap5()
        {
            Console.WriteLine("\n=== BÀI TẬP 5: LỚP PHÂN SỐ ===");
            Console.WriteLine("Nhập phân số thứ nhất:");
            Console.Write("Tử số: ");
            int tu1 = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            int mau1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNhập phân số thứ hai:");
            Console.Write("Tử số: ");
            int tu2 = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            int mau2 = int.Parse(Console.ReadLine());

            PhanSo ps1 = new PhanSo(tu1, mau1);
            PhanSo ps2 = new PhanSo(tu2, mau2);

            Console.Write("\nPhân số 1: ");
            ps1.HienThi();
            Console.Write("Phân số 2: ");
            ps2.HienThi();

            Console.Write("\nTổng: ");
            ps1.Cong(ps2).HienThi();
            Console.Write("Hiệu: ");
            ps1.Tru(ps2).HienThi();
            Console.Write("Tích: ");
            ps1.Nhan(ps2).HienThi();
            try
            {
                Console.Write("Thương: ");
                ps1.Chia(ps2).HienThi();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        static void BaiTap6()
        {
            Console.WriteLine("\n=== BÀI TẬP 6: LỚP HÌNH TRÒN ===");
            try
            {
                Console.Write("Nhập bán kính: ");
                double r = double.Parse(Console.ReadLine());
                HinhTron ht = new HinhTron(r);
                ht.HienThiThongTin();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        static void BaiTap7()
        {
            Console.WriteLine("\n=== BÀI TẬP 7: LỚP NHÂN VIÊN ===");
            Console.Write("Nhập mã nhân viên: ");
            string maNV = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập chức vụ (Trưởng phòng/Phó phòng/Chủ tịch): ");
            string chucVu = Console.ReadLine();
            Console.Write("Nhập lương cơ bản: ");
            double luongCB = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số lương: ");
            double heSo = double.Parse(Console.ReadLine());

            NhanVien nv = new NhanVien(maNV, hoTen, chucVu, luongCB, heSo);

            Console.WriteLine("\nTHÔNG TIN NHÂN VIÊN:");
            Console.WriteLine("{0,-10} {1,-25} {2,-15} {3,15} {4,10} {5,15}",
                "Mã NV", "Họ tên", "Chức vụ", "Lương CB", "Hệ số", "Tổng TN");
            Console.WriteLine(new string('-', 95));
            nv.HienThiThongTin();
        }

        static void BaiTap8()
        {
            Console.WriteLine("\n=== BÀI TẬP 8: LỚP TÀI KHOẢN NGÂN HÀNG ===");
            Console.WriteLine("Tạo tài khoản 1:");
            Console.Write("Số tài khoản: ");
            string stk1 = Console.ReadLine();
            Console.Write("Chủ tài khoản: ");
            string ctk1 = Console.ReadLine();
            Console.Write("Số dư ban đầu: ");
            double du1 = double.Parse(Console.ReadLine());
            TaiKhoanNganHang tk1 = new TaiKhoanNganHang(stk1, ctk1, du1);

            Console.WriteLine("\nTạo tài khoản 2:");
            Console.Write("Số tài khoản: ");
            string stk2 = Console.ReadLine();
            Console.Write("Chủ tài khoản: ");
            string ctk2 = Console.ReadLine();
            Console.Write("Số dư ban đầu: ");
            double du2 = double.Parse(Console.ReadLine());
            TaiKhoanNganHang tk2 = new TaiKhoanNganHang(stk2, ctk2, du2);

            Console.WriteLine("\n--- THÔNG TIN TÀI KHOẢN ---");
            tk1.HienThiSoDu();
            Console.WriteLine();
            tk2.HienThiSoDu();

            try
            {
                Console.Write("\nNhập số tiền muốn nạp vào tài khoản 1: ");
                double nap = double.Parse(Console.ReadLine());
                tk1.NapTien(nap);

                Console.Write("Nhập số tiền muốn rút từ tài khoản 2: ");
                double rut = double.Parse(Console.ReadLine());
                tk2.RutTien(rut);

                Console.Write("Nhập số tiền muốn chuyển từ tk1 sang tk2: ");
                double chuyen = double.Parse(Console.ReadLine());
                tk1.ChuyenTien(tk2, chuyen);

                Console.WriteLine("\n--- THÔNG TIN SAU GIAO DỊCH ---");
                tk1.HienThiSoDu();
                Console.WriteLine();
                tk2.HienThiSoDu();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        static void BaiTap9()
        {
            Console.WriteLine("\n=== BÀI TẬP 9: LỚP SÁCH ===");
            Console.Write("Nhập mã sách: ");
            string maSach = Console.ReadLine();
            Console.Write("Nhập tên sách: ");
            string tenSach = Console.ReadLine();
            Console.Write("Nhập tác giả: ");
            string tacGia = Console.ReadLine();
            Console.Write("Nhập năm xuất bản: ");
            int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá bán: ");
            double gia = double.Parse(Console.ReadLine());

            Sach sach = new Sach(maSach, tenSach, tacGia, nam, gia);

            Console.WriteLine("\nTHÔNG TIN SÁCH:");
            Console.WriteLine("{0,-10} {1,-30} {2,-20} {3,8} {4,15} {5,10}",
                "Mã sách", "Tên sách", "Tác giả", "Năm XB", "Giá bán", "Tình trạng");
            Console.WriteLine(new string('-', 100));
            sach.HienThiThongTin();

            Console.Write("\nNhập phần trăm giảm giá (%): ");
            double giam = double.Parse(Console.ReadLine());
            Console.WriteLine("Giá sau khi giảm giá {0}%: {1:N0}", giam, sach.GiamGia(giam));
        }

        static void BaiTap10()
        {
            Console.WriteLine("\n=== BÀI TẬP 10: LỚP LỚP HỌC ===");
            LopHoc lop = new LopHoc("IT142");

            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin sinh viên {i + 1}:");
                Console.Write("Mã SV: ");
                string maSV = Console.ReadLine();
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Lớp: ");
                string lopSV = Console.ReadLine();
                Console.Write("Điểm Toán: ");
                double toan = double.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                double ly = double.Parse(Console.ReadLine());
                Console.Write("Điểm Tin: ");
                double tin = double.Parse(Console.ReadLine());

                lop.ThemSinhVien(new SinhVien(maSV, hoTen, lopSV, toan, ly, tin));
            }

            Console.WriteLine();
            lop.HienThiDanhSach();

            Console.WriteLine($"\nĐiểm trung bình của lớp: {lop.TinhDiemTrungBinhLop():F2}");

            SinhVien svCaoNhat = lop.TimSinhVienDiemCaoNhat();
            if (svCaoNhat != null)
            {
                Console.WriteLine("\nSinh viên có điểm trung bình cao nhất:");
                Console.WriteLine("{0,-10} {1,-25} {2,-12} {3,8} {4,12}",
                    "Mã SV", "Họ tên", "Lớp", "ĐTB", "Xếp loại");
                Console.WriteLine(new string('-', 70));
                svCaoNhat.HienThiThongTin();
            }

            Console.Write("\nNhập mã sinh viên cần tìm: ");
            string maTim = Console.ReadLine();
            SinhVien svTim = lop.TimSinhVienTheoMa(maTim);
            if (svTim != null)
            {
                Console.WriteLine("\nTìm thấy sinh viên:");
                Console.WriteLine("{0,-10} {1,-25} {2,-12} {3,8} {4,12}",
                    "Mã SV", "Họ tên", "Lớp", "ĐTB", "Xếp loại");
                Console.WriteLine(new string('-', 70));
                svTim.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy sinh viên có mã: " + maTim);
            }
        }
    }
}
