using System;
// struct ThoiGian
// {
//     public int Gio;
//     public int Phut;
//     public int Giay;
// }
// class Program
// {
//     static void Main()
//     {
//         ThoiGian tg;
//         tg.Gio = 9;
//         tg.Phut = 03;
//         tg.Giay = 49;
//         Console.WriteLine("Thời gian là : ");
//         Console.WriteLine9($"{tg.Gio}:{tg.Phut}:{tg.Giay}");
//     }
// }
        // Diem2D
// struct Diem2D
// {
//     public double X;
//     public double Y;
//     public Diem2D(double x, double y)
//     {
//         X = x;
//         Y = y;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Diem2D diem1 = new Diem2D();
//         Diem2D diem2 = new Diem2D(3.5, 4.2);
//         Console.WriteLine("Thông tin các điểm: ");
//         Console.WriteLine($"Điểm 1: ({diem1.X}, {diem1.Y})");
//         Console.WriteLine($"Điểm 2: ({diem2.X}, {diem2.Y})");
//     }
// }
         //Hình chữ nhật 
// struct HinhChuNhat
// {
//     public double ChieuDai;
//     public double ChieuRong;
//     public double TinhDienTich()
//     {
//         return ChieuDai* ChieuRong;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         HinhChuNhat hcn = new HinhChuNhat();
//         hcn.ChieuDai = 27;
//         hcn.ChieuRong = 10;
//         Console.WriteLine("Chiều dài: " + hcn.ChieuDai);
//         Console.WriteLine("Chiều rộng: " + hcn.ChieuRong);
//         Console.WriteLine("Diện tích = " + hcn.TinhDienTich());
//     }
// }
    //Nhân viên
// struct NhanVien
// {
//     public int Luong;
// }
// class Program
// {
//     static void TangLuong(NhanVien nv)
//     {
//         nv.Luong += 1000;
//         Console.WriteLine("Lương trong hàm: " + nv.Luong);
//     }
//     static void Main()
//     {
//         NhanVien nv = new NhanVien();
//         nv.Luong = 5000;
//         Console.WriteLine("Lương trước khi gọi hàm: " + nv.Luong);
//         TangLuong(nv);
//         Console.WriteLine("Lương sau khi gọi hàm: " + nv.Luong);
//     }
// }
       // Nhân Viên
       struct SinhVien
{
    public string MaSo;
    public string HoTen;
    public double DiemToan;
    public double DiemVan;
}

class Program
{
    static void Main()
    {
        // Tạo mảng gồm 2 sinh viên
        SinhVien[] ds = new SinhVien[2];

        // Sinh viên thứ nhất
        ds[0].MaSo = "SV001";
        ds[0].HoTen = "Nguyễn Văn A";
        ds[0].DiemToan = 8.5;
        ds[0].DiemVan = 7.5;

        // Sinh viên thứ hai
        ds[1].MaSo = "SV002";
        ds[1].HoTen = "Trần Thị B";
        ds[1].DiemToan = 9.0;
        ds[1].DiemVan = 8.0;

        // In thông tin
        for (int i = 0; i < ds.Length; i++)
        {
            double diemTB = (ds[i].DiemToan + ds[i].DiemVan) / 2;

            Console.WriteLine("Sinh viên thứ " + (i + 1));
            Console.WriteLine("Mã số: " + ds[i].MaSo);
            Console.WriteLine("Họ tên: " + ds[i].HoTen);
            Console.WriteLine("Điểm Toán: " + ds[i].DiemToan);
            Console.WriteLine("Điểm Văn: " + ds[i].DiemVan);
            Console.WriteLine("Điểm trung bình: " + diemTB);

            Console.WriteLine("---------------------------");
        }
    }
}
