using System;

namespace Lab1_ConsoleBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== CHUONG TRINH LAB 1 - CONSOLE BASIC ===");
                Console.WriteLine("1. Bai thuc hanh 1: Thong tin sinh vien");
                Console.WriteLine("2. Bai thuc hanh 2: Hello .NET");
                Console.WriteLine("3. Bai thuc hanh 3: Ram Thang Giang");
                Console.WriteLine("4. Bai thuc hanh 4: Tinh chu vi & dien tich hinh tron");
                Console.WriteLine("5. Bai thuc hanh 5: Tinh chu vi & dien tich hinh chu nhat");
                Console.WriteLine("0. Thoat");
                Console.Write("Lua chon cua ban: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BaiThucHanh1();
                        break;
                    case "2":
                        BaiThucHanh2();
                        break;
                    case "3":
                        BaiThucHanh3();
                        break;
                    case "4":
                        BaiThucHanh4();
                        break;
                    case "5":
                        BaiThucHanh5();
                        break;
                    case "0":
                        Console.WriteLine("Cam on ban da su dung!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                Console.ReadKey();
            }
        }

        static void BaiThucHanh1()
        {
            Console.WriteLine("\n=== BAI THUC HANH 1 ===");
            Console.WriteLine("TRUONG DAI HOC CONG NGHE DONG A");
            Console.WriteLine("KHOA CONG NGHE THONG TIN");
            Console.WriteLine("MON HOC: LAP TRINH .NET");
            Console.WriteLine("LAB 1 - TONG QUAN .NET VA C# CONSOLE");
            Console.WriteLine();
            Console.WriteLine("Ho ten sinh vien: DINH PHUC PHAT");
            Console.WriteLine("Ma sinh vien: 20230814");
            Console.WriteLine("Lop: CNTT14.2");
        }

        static void BaiThucHanh2()
        {
            Console.WriteLine("\n=== BAI THUC HANH 2 ===");
            Console.WriteLine("Xin chao!");
            Console.WriteLine("Xin chao ngay lap trinh C#");
            Console.WriteLine("Day la chuong trinh Console dau tien cua toi");
            Console.WriteLine();
            Console.Write("Ho ten: ");
            string? hoTen = Console.ReadLine();
            Console.Write("Ma sinh vien: ");
            string? maSV = Console.ReadLine();
            Console.Write("Ngay thuc hanh: ");
            string? ngaySinh = Console.ReadLine();

            Console.WriteLine($"\nThong tin cua ban:");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Ma sinh vien: {maSV}");
            Console.WriteLine($"Ngay thuc hanh: {ngaySinh}");
        }

        static void BaiThucHanh3()
        {
            Console.WriteLine("\n=== BAI THUC HANH 3 ===");
            Console.WriteLine("    Rằm Tháng Riêng");
            Console.WriteLine();
            Console.WriteLine("Rằm xuân lồng lộng trăng soi,");
            Console.WriteLine("Sông xuân nước lẫn màu trời thêm xuân.");
            Console.WriteLine("Giữa dòng bàn bạc việc quân,");
            Console.WriteLine("Khuya về bát ngát trăng ngân đầy thuyền.");
            Console.WriteLine();
            Console.WriteLine("    Hồ Chí Minh");
        }

        static void BaiThucHanh4()
        {
            Console.WriteLine("\n=== BAI THUC HANH 4 ===");
            const double PI = 3.14159;

            while (true)
            {
                Console.Write("Nhap ban kinh hinh tron r = ");
                string? input = Console.ReadLine();

                if (double.TryParse(input, out double r) && r > 0)
                {
                    double chuVi = 2 * PI * r;
                    double dienTich = PI * r * r;

                    Console.WriteLine($"Chu vi hinh tron = {chuVi:F2}");
                    Console.WriteLine($"Dien tich hinh tron = {dienTich:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ban kinh phai la so duong! Vui long nhap lai.");
                }
            }
        }

        static void BaiThucHanh5()
        {
            Console.WriteLine("\n=== BAI THUC HANH 5 ===");

            double chieuDai, chieuRong;

            while (true)
            {
                Console.Write("Nhap chieu dai hinh chu nhat = ");
                string? inputDai = Console.ReadLine();

                if (double.TryParse(inputDai, out chieuDai) && chieuDai > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Chieu dai phai la so duong! Vui long nhap lai.");
                }
            }

            while (true)
            {
                Console.Write("Nhap chieu rong hinh chu nhat = ");
                string? inputRong = Console.ReadLine();

                if (double.TryParse(inputRong, out chieuRong) && chieuRong > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Chieu rong phai la so duong! Vui long nhap lai.");
                }
            }

            double chuVi = 2 * (chieuDai + chieuRong);
            double dienTich = chieuDai * chieuRong;

            Console.WriteLine($"Chu vi hinh chu nhat = {chuVi:F2}");
            Console.WriteLine($"Dien tich hinh chu nhat = {dienTich:F2}");
        }
    }
}
