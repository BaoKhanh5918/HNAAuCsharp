using System;
class Program
{
    static void Main()
    {
        // Toán tử số học và 
        Console.Write("Nhập số giây: ");
        int tongGiay = int.Parse(Console.ReadLine());
        int gio = tongGiay / 3600;
        int giayConLai = tongGiay % 3600;
        int phut = giayConLai / 60;
        int giay = giayConLai % 60;
        Console.WriteLine($"{gio} giờ {phut} phút {giay} giây");
    }
    // Tiền tố và hậu tố 
    static void Maiṇ̣()
    {
        int a = 5;
        int b = a++ + ++a;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
    // Toán tử logic và so sánh
    static void Main()
    {
        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        Console.WriteLine(isLeapYear);
    }
    // Toán tử 3 ngôi
    static void Main()
    {
        Console.WriteLine("Nhập x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập y: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập z: ");
        int z = int.Parse(Console.ReadLine());
        int max = (x > y) ? ((x > z) ? x : z) : ((y > z) ? y : z);
        Console.WriteLine("Số lớn nhất là: " + max);
    }
}