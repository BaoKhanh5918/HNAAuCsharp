using System;
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.Write("Nhập năm sinh: ");
//             int namSinh = int.Parse(Console.ReadLine());
//             Console.WriteLine("Năm sinh của bạn là : " + namSinh);
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Vui lòng chỉ nhập số! ");
//         }
//         Console.ReadKey();
//     }
// }
// static void Main()
//     {
//         int [] mang = { 1, 2, 3 };
//         try
//         {
//             Console.Write("Nhập vị trí cần xem (0-2): ");
//             int index = int.Parse(Console.ReadLine());
//             Console.Write("Nhập số Chia: ");
//             int soChia = int.Parse(Console.ReadLine());
//             int ketQua = mang[index] / soChia;
//             Console.WriteLine("Kết quả = " + ketQua);
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Lỗi: Vui lòng chỉ nhập số! ");
//         }
//         catch (IndexOutOfRangeException)
//         {
//             Console.WriteLine("Lỗi: Vị trí nằm ngoài phạm vi của mảng! ");
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Lỗi: Không thể chia cho 0! ");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Đã xảy ra một lỗi không xác định! ");
//         }
//         Console.ReadKey();
//     }
// }
// 
// 
class SoDuKhongDuException : Exception
{
    public SoDuKhongDuException(string message) : base(message)
    {
    }
}
class TaiKhoanNganHang
{
    public double SoDu;
    public TaiKhoanNganHang(double soDu)
    {
        SoDu = soDu;
    }
    public void RutTien(double soTienCanRut)
    {
        if (soTienCanRut > SoDu)
        {
            throw new SoDuKhongDuException("Số dư không đủ để thực hiện giao dịch");
        }
        SoDu = SoDu - soTienCanRut;
        Console.WriteLine("Rút tiền thành công!");
        Console.WriteLine("Số dư còn lại: " + SoDu);
    }
}
class Program
{
    static void Main(string[] args)
    {
        TaiKhoanNganHang taiKhoan = new TaiKhoanNganHang(5000000);
        try
        {
            Console.Write("Nhập số tiền cần rút: ");
            double soTien = double.Parse(Console.ReadLine());
            taiKhoan.RutTien(soTien);
        }
        catch (SoDuKhongDuException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}
