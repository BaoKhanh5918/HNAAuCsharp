using System;
// public class PhanSo
// {
//     public int TuSo { get; set; }
//     public int MauSo { get; set; }
//     public PhanSo()
//     {
//         TuSo = 0;
//         MauSo = 1;
//     }
//     public PhanSo(int tu, int mau)
//     {
//         this.TuSo = tu;
//         this.MauSo = mau;
//     }
//     public void NhapPhanSo()
//     {
//         while (true)
//         {
//             Console.Write("Nhập tử số: ");
//             if (int.TryParse(Console.ReadLine(), out int tuSo))
//             {
//                 TuSo = tuSo;
//                 break;
//             }
//             Console.WriteLine("Tử số không hợp lệ. Vui lòng nhập số nguyên.");
//         }

//         while (true)
//         {
//             Console.Write("Nhập mẫu số: ");
//             if (int.TryParse(Console.ReadLine(), out int mauSo) && mauSo != 0)
//             {
//                 MauSo = mauSo;
//                 break;
//             }
//             Console.WriteLine("Mẫu số phải là số nguyên khác 0.");
//         }
//     }
//     public void Xuat()
//     {
//         Console.WriteLine($"{TuSo}/{MauSo}");
//     }

//     private static int UCLN(int a, int b)
//     {
//         a = Math.Abs(a);
//         b = Math.Abs(b);
//         while (b != 0)
//         {
//             int r = a % b;
//             a = b;
//             b = r;
//         }
//         return a;
//     }

//     public void ChayMotPhanSo()
//     {
//         PhanSo ps = new PhanSo();
//         ps.NhapPhanSo();
//         Console.Write("Phân số vừa nhập: ");
//         ps.Xuat();
//     }
//     public void RutGon()
//     {
//         int ucln = UCLN(TuSo, MauSo);
//         TuSo /= ucln;
//         MauSo /= ucln;
//         if (MauSo < 0)
//         {
//             TuSo = -TuSo;
//             MauSo = -MauSo;
//         }
//     } 
//     public static PhanSo operator -(PhanSo a, PhanSo b)
//     {
//         PhanSo kq = new PhanSo();
//         kq.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
//         kq.MauSo = a.MauSo * b.MauSo;
//         kq.RutGon();
//         return kq;
//     }
//     public static PhanSo operator *(PhanSo a, PhanSo b)
//     {
//         PhanSo kq = new PhanSo();
//         kq.TuSo = a.TuSo * b.TuSo;
//         kq.MauSo = a.MauSo * b.MauSo;
//         kq.RutGon();
//         return kq;
//     }       
//     public static PhanSo operator /(PhanSo a, PhanSo b)
//     {
//         if (b.TuSo == 0 )
//         {
//             throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0! ");
//         }
//         PhanSo kq = new PhanSo();
//         kq.TuSo = a.TuSo * b.MauSo;
//         kq.MauSo = a.MauSo * b.TuSo;
//         kq.RutGon();
//         return kq;
//     }
//     public static double operator %(PhanSo a, PhanSo b)
//     {
//         double x = (double)a.TuSo / a.MauSo;
//         double y = (double)b.TuSo / b.MauSo;
//         return x % y;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         ThucHien();
//     }

//     static void ThucHien()
//     {
//         PhanSo ps1 = new PhanSo();
//         PhanSo ps2 = new PhanSo();
//         Console.WriteLine("Nhập phân số thứ nhất: ");
//         ps1.NhapPhanSo();
//         Console.WriteLine();
//         Console.WriteLine("Nhập phân số thứ hai: ");
//         ps2.NhapPhanSo();
//         Console.WriteLine();
//         Console.Write("Phân số 1: ");
//         ps1.Xuat();
//         Console.Write("Phân số 2: ");
//         ps2.Xuat();
//         Console.WriteLine();
//         PhanSo hieu = ps1 - ps2;
//         Console.Write("Hiệu = ");
//         hieu.Xuat();
//         PhanSo tich = ps1 * ps2;
//         Console.Write("Tích = ");
//         tich.Xuat();
//         PhanSo thuong = ps1 / ps2;
//         Console.Write("Thương = ");
//         thuong.Xuat();
//         double du = ps1 % ps2;
//         Console.WriteLine("Phần dư (%) = " + du);
//     }
// }
// Tọa độ 2D
// class ToaDo2D
// {
//     public int X;
//     public int Y;
//     public ToaDo2D(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
//     public static ToaDo2D operator +(ToaDo2D a, ToaDo2D b)
//     {
//         return new ToaDo2D(a.X + b.X, a.Y + b.Y);
//     }
//     public static ToaDo2D operator -(ToaDo2D a, ToaDo2D b)
//     {
//         return new ToaDo2D(a.X - b.X, a.Y - b.Y);
//     }
//     public override string ToString()
//     {
//         return"(" + X + ", " + Y + ")";
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         ToaDo2D td1 = new ToaDo2D(27, 5);
//         ToaDo2D td2 = new ToaDo2D(13, 1);
//         ToaDo2D tong = td1 + td2;
//         ToaDo2D hieu = td1 - td2;
//         Console.WriteLine("Tọa độ thứ nhất: " + td1);
//         Console.WriteLine("Tọa độ thứ hai: " + td2);
//         Console.WriteLine("Tổng: " + tong);
//         Console.WriteLine("Hiệu: " + hieu);
//         Console.ReadKey();
//     }
// }
// 
// 
   //Tiền tệ 
// class TienTe
// {
//     public double SoTien;
//     public TienTe(double soTien)
//     {
//         SoTien = soTien;
//     }
//     public static implicit operator TienTe(double x)
//     {
//         return new TienTe(x);
//     }
//     public static explicit operator double(TienTe t)
//     {
//         return t.SoTien;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         TienTe t = 50000.0;
//         Console.WriteLine("Số tiền là: " + t.SoTien);
//         double x = (double)t;
//         Console.WriteLine("Giá trị double là: " + x);
//         Console.ReadKey();
//     }
// }
      // Số phức 
// class SoPhuc
// {
//     public double Thuc;
//     public double Ao;
//     public SoPhuc(double thuc, double ao)
//     {
//         Thuc = thuc;
//         Ao = ao;
//     }
//     public static SoPhuc operator *(SoPhuc a, SoPhuc b)
//     {
//         double thuc = a.Thuc * b.Thuc - a.Ao * b.Ao;
//         double ao = a.Thuc * b.Ao + a.Ao * b.Thuc;
//         return new SoPhuc(thuc, ao);
//     }
//     public SoPhuc Multiply(SoPhuc sp)
//     {
//         return this * sp;
//     }
//     public override string ToString()
//     {
//         return Thuc + " + " + Ao + "i";
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         SoPhuc sp1 = new SoPhuc(2, 3);
//         SoPhuc sp2 = new SoPhuc(1, 4);
//         SoPhuc kq1 = sp1 * sp2;
//         SoPhuc kq2 = sp1.Multiply(sp2);
//         Console.WriteLine("Số phức 1: " + sp1);
//         Console.WriteLine("Số phức 2: " + sp2);
//         Console.WriteLine();
//         Console.WriteLine("Kết quả dùng * : " + kq1);
//         Console.WriteLine("Kết quả dùng Multiply(): " + kq2);
//         Console.ReadKey();
//     }
// }
   // Vector3D 
   class Vector3D
{
    public double X;
    public double Y;
    public double Z;
    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D( v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D( v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }
    public static double operator *(Vector3D v1, Vector3D v2)
    {
        return v1.X * v2.X
             + v1.Y * v2.Y
             + v1.Z * v2.Z;
    }
    public static bool operator ==(Vector3D v1, Vector3D v2)
    {
        return v1.X == v2.X &&
               v1.Y == v2.Y &&
               v1.Z == v2.Z;
    }
    public static bool operator !=(Vector3D v1, Vector3D v2)
    {
        return !(v1 == v2);
    }
    public static explicit operator double(Vector3D v)
    {
        return Math.Sqrt(
            v.X * v.X +
            v.Y * v.Y +
            v.Z * v.Z);
    }
    public override string ToString()
    {
        return "(" + X + ", " + Y + ", " + Z + ")";
    }
    public override bool Equals(object obj)
    {
        if (obj is Vector3D other)
            return this == other;
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }
}
class Program
{
    static void Main()
    {
        Vector3D v1 = new Vector3D(2, 3, 4);
        Vector3D v2 = new Vector3D(1, 5, 2);

        Vector3D tong = v1 + v2;
        Console.WriteLine("v1 + v2 = " + tong);

        Vector3D hieu = v1 - v2;
        Console.WriteLine("v1 - v2 = " + hieu);

        double tichVoHuong = v1 * v2;
        Console.WriteLine("Tích vô hướng = " + tichVoHuong);

        Console.WriteLine("v1 == v2 : " + (v1 == v2));
        Console.WriteLine("v1 != v2 : " + (v1 != v2));

        double doDai = (double)v1;
        Console.WriteLine("Độ dài v1 = " + doDai);
    }
}
