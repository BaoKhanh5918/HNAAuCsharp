using System;
namespace baitap01;

class Program
{
    static void Main()
    {
        NhapChanLe();
        NhapDiemTrungBinh();
        PhuongTrinhBacNhat();
        InRaCacNgayTrongTuan();
        CacNgayTrongThang();
        BangCuuChuong();
        NhapChieuCao();
    }

    static void NhapChanLe()
    {
        Console.WriteLine("Kiểm tra số nguyên chẵn hay lẻ ");
        Console.Write("Nhập số nguyên: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("n là số chẵn");
        }
        else
        {
            Console.WriteLine("n là số lẻ");
        }
    }

    static void NhapDiemTrungBinh()
    {
        Console.Write("Nhập điểm trung bình: ");
        double diemTB = Convert.ToDouble(Console.ReadLine());

        if (diemTB < 0 || diemTB > 10)
        {
            Console.WriteLine("Điểm nhập vào không hợp lệ!");
        }
        else if (diemTB < 5.0)
        {
            Console.WriteLine("Xếp loại: Yếu");
        }
        else if (diemTB < 6.5)
        {
            Console.WriteLine("Xếp loại: Trung bình");
        }
        else if (diemTB < 8.0)
        {
            Console.WriteLine("Xếp loại: Khá");
        }
        else
        {
            Console.WriteLine("Xếp loại: Giỏi");
        }
    }

    static void PhuongTrinhBacNhat()
    {
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình vô số nghiệm");
            else
                Console.WriteLine("Phương trình vô nghiệm");
        }
        else
        {
            Console.WriteLine($"Nghiệm x = {-b / a}");
        }
    }

    static void InRaCacNgayTrongTuan()
    {
        Console.Write("Nhập số từ 1 đến 7: ");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: Console.WriteLine("Thứ Hai"); break;
            case 2: Console.WriteLine("Thứ Ba"); break;
            case 3: Console.WriteLine("Thứ Tư"); break;
            case 4: Console.WriteLine("Thứ Năm"); break;
            case 5: Console.WriteLine("Thứ Sáu"); break;
            case 6: Console.WriteLine("Thứ Bảy"); break;
            case 7: Console.WriteLine("Chủ Nhật"); break;
            default: Console.WriteLine("Số không hợp lệ"); break;
        }
    }
    static void CacNgayTrongThang()
    {
        int thang = int.Parse(Console.ReadLine());
        int nam = int.Parse(Console.ReadLine());

        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("31 ngày");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30 ngày");
                break;
            case 2:
                if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                    Console.WriteLine("29 ngày");
                else
                    Console.WriteLine("28 ngày");
                break;
            default:
                Console.WriteLine("Tháng không hợp lệ");
                break;
        }
    }

    static void BangCuuChuong()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        else
        {
            Console.WriteLine("Số không hợp lệ!");
        }
    }
    static void NhapChieuCao()
    {
        Console.WriteLine("Nhập chiều cao h: ");
        int h = int.Parse(Console.ReadLine());
        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
