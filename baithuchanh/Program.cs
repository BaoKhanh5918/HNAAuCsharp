using System;
using System.Text;
namespace BaiThucHanh
{
    class TamGiac
    {
        public double a;
        public double b;
        public double c;
        public bool KiemTraTamGiac()
        {
            return a + b > c && a + c > b && b + c > a;
        }
        public double TinhChuVi()
        {
            return a + b + c;
        }
        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class HocSinh
    {
        public string HoTen = string.Empty;
        public double DiemToan;
        public double DiemLy;
        public double DiemHoa;
        public double TinhDiemTrungBinh()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Chon;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("          BÀI THỰC HÀNH       ");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Bài 1 - Tam Giác");
                Console.WriteLine("2. Bài 2 - Học Sinh");
                Console.WriteLine("3. Bài 3 - Mảng");
                Console.WriteLine("4. Bài 4 - Thêm/Xóa phần tử");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                Chon = int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case 1: Bai1(); break;
                    case 2: Bai2(); break;
                    case 3: Bai3(); break;
                    case 4: Bai4(); break;
                }
            } while (Chon != 0);
        }
        static void Bai1()
        {
            TamGiac tg = new TamGiac();
            Console.Write("Nhập cạnh a: ");
            tg.a = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            tg.b = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            tg.c = double.Parse(Console.ReadLine());
            if (tg.KiemTraTamGiac())
            {
                Console.WriteLine("Chu vi : " + tg.TinhChuVi());
                Console.WriteLine("Diện tích: " + tg.TinhDienTich());
            }
            else
            {
                Console.WriteLine("Không phải là tam giác.");
            }
            Console.WriteLine("\n Nhấn phím Enter để quay lại.");
            Console.ReadKey();
        }  
        static void Bai2()
        {
            HocSinh hs = new HocSinh();
            Console.Write("Nhập họ tên: ");
            hs.HoTen = Console.ReadLine();
            Console.Write("Điểm Toán: ");
            hs.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            hs.DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            hs.DiemHoa = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Họ tên: " + hs.HoTen);
            Console.WriteLine("Điểm trung bình: " + hs.TinhDiemTrungBinh());
            Console.WriteLine("\n Nhấn phím Enter để quay lại.");
            Console.ReadKey();
        }
        static void Bai3()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n Mảng vừa nhập: ");
            for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            Console.WriteLine("\n Mảng sau khi sắp xếp: ");
            for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
            Console.Write("\n Nhập số cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            bool timThay = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("Tìm thấy tại vị trí " + i);
                    timThay = true; 
                    break;
                }
            }
            if (!timThay)
            Console.WriteLine("Không tìm thấy.");
            Console.WriteLine("\n Nhấn phím Enter để quay lại.");
            Console.ReadLine();
        }
        static void Bai4()
        {
            int [] a = new int[100];
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhập số cần thêm: ");
            int x = int.Parse(Console.ReadLine());
            a[n] = x;
            n++;
            Console.WriteLine("\n Danh sách sau khi thêm: ");
            for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
            Console.Write("\n Nhập vị trí cần xóa: ");
            int vt = int.Parse(Console.ReadLine());
            if (vt >= 0 && vt < n)
            {
                for (int i = vt; i < n - 1; i++)
                {
                    a[i] = a[i + 1];
                }
                n--;
            }
            Console.WriteLine("\n Danh sách sau khi xóa: ");
            for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
            Console.Write("\n Nhập vị trí cần xem: ");
            int index= int.Parse(Console.ReadLine());
            if (index >= 0 && index < n)
            Console.WriteLine("Giá trị: " + a[index]);
            else
            Console.WriteLine("Vị trí không hợp lệ.");
            Console.WriteLine("\n Nhấn phím Enter để quay lại.");
            Console.ReadKey();
        }
    }
}         