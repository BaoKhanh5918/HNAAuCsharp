// using System;
// class Program
// {
//     public static bool TimDiem(double[] diem)
//     {
//         for (int i = 0; i <diem.Length; i++)
//         {
//             if (diem[i] == 10.0)
//             {
//                 return true;
//             }
//         }
//         return false;
//     }
//     public static void Main(string[] args)
//     {
//         double[] diem = { 6.5, 7.0, 4.5, 9.0, 8.5};
//         bool ketQua = TimDiem(diem);
//         if (ketQua)
//         {
//             Console.WriteLine("Có học sinh đạt điểm 10.");
//         }
//         else
//         {
//             Console.WriteLine("Không có học sinh đạt điểm 10.");
//         }
//     }
// }
// 
// 
// 
using System;
using System.Collections.Generic;
class Program
{
    static List<int> TimKiemTatCa(int[] mang, int giaTri)
    {
        List<int> danhSachViTri = new List<int>();
        for (int i = 0; i < mang.Length; i++)
        {
            if (mang[i] == giaTri)
            {
                danhSachViTri.Add(i);
            }
        }
        return danhSachViTri;
    }
    static void Main(string[] args)
    {
        int[] arr = { 2, 5, 8, 5, 9, 5, 12 };
        Console.Write("Nhập giá trị cần tìm: ");
        int giaTri = Convert.ToInt32(Console.ReadLine());
        List<int> ketQua = TimKiemTatCa(arr, giaTri);
        if (ketQua.Count > 0)
        {
            Console.WriteLine("Các vị trí tìm thấy:");
            foreach (int viTri in ketQua)
            {
                Console.Write(viTri + " ");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy giá trị trong mảng.");
        }
    }
}