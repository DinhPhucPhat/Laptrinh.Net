using System;

namespace Lab3_OOP
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
                throw new Exception("Mẫu số không được bằng 0.");
            TuSo = tuSo;
            MauSo = mauSo;
            RutGon();
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public void RutGon()
        {
            int ucln = UCLN(TuSo, MauSo);
            TuSo = TuSo / ucln;
            MauSo = MauSo / ucln;

            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        public PhanSo Cong(PhanSo b)
        {
            int tu = TuSo * b.MauSo + b.TuSo * MauSo;
            int mau = MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo b)
        {
            int tu = TuSo * b.MauSo - b.TuSo * MauSo;
            int mau = MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public PhanSo Nhan(PhanSo b)
        {
            return new PhanSo(TuSo * b.TuSo, MauSo * b.MauSo);
        }

        public PhanSo Chia(PhanSo b)
        {
            if (b.TuSo == 0)
                throw new Exception("Không thể chia cho phân số có tử số bằng 0.");
            return new PhanSo(TuSo * b.MauSo, MauSo * b.TuSo);
        }

        public void HienThi()
        {
            Console.WriteLine(TuSo + "/" + MauSo);
        }
    }
}
