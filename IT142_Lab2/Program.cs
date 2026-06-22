﻿using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        while (true)
        {
            Console.WriteLine("\n=== LAB 2: LẬP TRÌNH CONSOLE C# ===");
            Console.WriteLine("1. Bài tập 1 - Tính tổng các số chẵn từ 2 đến n");
            Console.WriteLine("2. Bài tập 2 - Tính tổng nghịch đảo");
            Console.WriteLine("3. Bài tập 3 - Kiểm tra số nguyên tố");
            Console.WriteLine("4. Bài tập 4 - Kiểm tra tam giác và tính chu vi, diện tích");
            Console.WriteLine("5. Bài tập 5 - Hiển thị dãy Fibonacci");
            Console.WriteLine("6. Bài tập 6 - Tổng các số chia hết cho 3 hoặc 5");
            Console.WriteLine("7. Bài tập 7 - Đếm số chữ số");
            Console.WriteLine("8. Bài tập 8 - Tổng các chữ số");
            Console.WriteLine("9. Bài tập 9 - Kiểm tra số hoàn hảo");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài tập: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Exercise1();
                    break;
                case "2":
                    Exercise2();
                    break;
                case "3":
                    Exercise3();
                    break;
                case "4":
                    Exercise4();
                    break;
                case "5":
                    Exercise5();
                    break;
                case "6":
                    Exercise6();
                    break;
                case "7":
                    Exercise7();
                    break;
                case "8":
                    Exercise8();
                    break;
                case "9":
                    Exercise9();
                    break;
                case "0":
                    Console.WriteLine("Tạm biệt!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void Exercise1()
    {
        Console.WriteLine("\n--- Bài tập 1: Tính tổng các số chẵn từ 2 đến n ---");
        int n;
        while (true)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập n > 0!");
            }
            else
            {
                break;
            }
        }

        int s = 0;
        int i = 2;
        while (i <= n)
        {
            s += i;
            i += 2;
        }

        Console.WriteLine("Tong cac so chan tu 2 den {0} la: {1}", n, s);
    }

    static void Exercise2()
    {
        Console.WriteLine("\n--- Bài tập 2: Tính tổng nghịch đảo ---");
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += 1.0 / i;
        }

        Console.WriteLine("Tong S = {0:F2}", s);
        Console.WriteLine("So sanh khi dung 1/i (khong lam tron): {0}", s);
    }

    static void Exercise3()
    {
        Console.WriteLine("\n--- Bài tập 3: Kiểm tra số nguyên tố ---");
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        bool laNguyenTo = true;

        if (n < 2)
        {
            laNguyenTo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laNguyenTo = false;
                    break;
                }
            }
        }

        if (laNguyenTo)
            Console.WriteLine("{0} la so nguyen to", n);
        else
            Console.WriteLine("{0} khong phai la so nguyen to", n);

        Console.WriteLine("\nCac so nguyen to tu 2 den {0}:", n);
        int dem = 0;
        for (int num = 2; num <= n; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write(num + " ");
                dem++;
            }
        }
        Console.WriteLine("\nTong so nguyen to: {0}", dem);
    }

    static void Exercise4()
    {
        Console.WriteLine("\n--- Bài tập 4: Kiểm tra tam giác ---");
        Console.Write("Nhap canh a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap canh b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap canh c: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Day la mot tam giac.");

            if (a == b && b == c)
                Console.WriteLine("Tam giac deu.");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Tam giac can.");
            else if (a * a + b * b == c * c || 
                     a * a + c * c == b * b || 
                     b * b + c * c == a * a)
                Console.WriteLine("Tam giac vuong.");
            else
                Console.WriteLine("Tam giac thuong.");

            double chuVi = a + b + c;
            double p = chuVi / 2;
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Chu vi tam giac: {0}", chuVi);
            Console.WriteLine("Dien tich tam giac (Heron): {0:F2}", dienTich);
        }
        else
        {
            Console.WriteLine("Ba so vua nhap khong phai la ba canh cua tam giac.");
        }
    }

    static void Exercise5()
    {
        Console.WriteLine("\n--- Bài tập 5: Dãy Fibonacci ---");
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int f1 = 0;
        int f2 = 1;
        int sum = 0;

        Console.Write("Day Fibonacci: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(f1 + " ");
            sum += f1;
            int f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        Console.WriteLine("\nTong {0} so Fibonacci dau tien: {1}", n, sum);

        Console.Write("\nNhap so can kiem tra co thuoc day Fibonacci khong: ");
        int checkNum = int.Parse(Console.ReadLine());
        bool isFibonacci = IsFibonacci(checkNum);
        if (isFibonacci)
            Console.WriteLine("{0} thuoc day Fibonacci.", checkNum);
        else
            Console.WriteLine("{0} khong thuoc day Fibonacci.", checkNum);
    }

    static bool IsFibonacci(int num)
    {
        if (num < 0) return false;
        int a = 0, b = 1;
        while (a < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == num;
    }

    static void Exercise6()
    {
        Console.WriteLine("\n--- Bài tập 6: Tổng các số chia hết cho 3 hoặc 5 ---");
        int n;
        while (true)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
                break;
            Console.WriteLine("Vui long nhap n > 0!");
        }

        int sum = 0;
        Console.Write("Cac so chia het cho 3 hoac 5 tu 1 den {0}: ", n);
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.WriteLine("\nTong = {0}", sum);
    }

    static void Exercise7()
    {
        Console.WriteLine("\n--- Bài tập 7: Đếm số chữ số ---");
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("So {0} co 1 chu so.", n);
            return;
        }

        int count = 0;
        int temp = n;
        while (temp > 0)
        {
            temp = temp / 10;
            count++;
        }
        Console.WriteLine("So {0} co {1} chu so.", n, count);
    }

    static void Exercise8()
    {
        Console.WriteLine("\n--- Bài tập 8: Tổng các chữ số ---");
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = n;
        while (temp > 0)
        {
            sum += temp % 10;
            temp = temp / 10;
        }
        Console.WriteLine("Tong cac chu so cua {0} la: {1}", n, sum);
    }

    static void Exercise9()
    {
        Console.WriteLine("\n--- Bài tập 9: Kiểm tra số hoàn hảo ---");
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        Console.Write("Cac uoc so nho hon {0}: ", n);
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }

        Console.WriteLine("\nTong cac uoc so: {0}", sum);
        if (sum == n)
            Console.WriteLine("{0} la so hoan hao.", n);
        else
            Console.WriteLine("{0} khong phai la so hoan hao.", n);
    }
}
