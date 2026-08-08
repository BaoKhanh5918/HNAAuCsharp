using System;
using System.Collections.Generic;
class Program
{
    // static void Main(string[] args)
    // {
    //     LinkedList<int> danhSach = new LinkedList<int>();
    //     danhSach.AddLast(2);
    //     danhSach.AddLast(4);
    //     danhSach.AddLast(6);
    //     danhSach.AddLast(8);
    //     danhSach.AddLast(10);
    //     Console.WriteLine("Các số chẵn từ 2 đến 10 là:");
    //     foreach (int so in danhSach)
    //     {
    //         Console.Write(so + " ");
    //     }
    //     Console.WriteLine();
    // }
    // {
    //     LinkedList<string> danhSachCho = new LinkedList<string>();
    //     if (danhSachCho.Count == 0)
    //     {
    //         Console.WriteLine("Danh sách đang trống.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Danh sách không trống.");
    //     }
    //     danhSachCho.AddLast("Hùng");
    //     danhSachCho.AddFirst("Lan");
    //     Console.WriteLine("\nDanh sách chờ khám:");
    //     foreach (string benhNhan in danhSachCho)
    //     {
    //         Console.WriteLine(benhNhan);
    //     }
    // }

    
    // static void HienThiDanhSach(LinkedList<string> danhSach)
    // {
    //     Console.WriteLine("Các câu lệnh hiện có:");
    //     foreach (string cauLenh in danhSach)
    //     {
    //         Console.WriteLine("- " + cauLenh);
    //     }
    // }
    // static void ThemCauLenh(LinkedList<string> danhSach, string cauLenh)
    // {
    //     danhSach.AddLast(cauLenh);
    // }
    // static void Undo(LinkedList<string> danhSach)
    // {
    //     if (danhSach.Count > 0)
    //     {
    //         Console.WriteLine("Undo: " + danhSach.Last.Value);
    //         danhSach.RemoveLast();
    //     }
    //     else
    //     {
    //         Console.WriteLine("Danh sách không còn câu lệnh để Undo.");
    //     }
    // }
    // static void Main(string[] args)
    // {
    //     LinkedList<string> danhSach = new LinkedList<string>();
    //     ThemCauLenh(danhSach, "Chào bạn");
    //     ThemCauLenh(danhSach, "Hôm nay trời đẹp");
    //     ThemCauLenh(danhSach, "Học C# rất vui");
    //     Console.WriteLine("Danh sách ban đầu:");
    //     HienThiDanhSach(danhSach);
    //     Console.WriteLine("\nThực hiện Undo 2 lần:");
    //     Undo(danhSach);
    //     Undo(danhSach);
    //     Console.WriteLine("\nDanh sách sau khi Undo:");
    //     HienThiDanhSach(danhSach);
    // }

    static void HienThiDanhSach(LinkedList<int> danhSach)
    {
        foreach (int so in danhSach)
        {
            Console.Write(so + " ");
        }
        Console.WriteLine();
    }
    static void XoaSoChan(LinkedList<int> danhSach)
    {
        LinkedListNode<int> node = danhSach.First;
        while (node != null)
        {
            LinkedListNode<int> nodeTiepTheo = node.Next;
            if (node.Value % 2 == 0)
            {
                danhSach.Remove(node);
            }
            node = nodeTiepTheo;
        }
    }
    static void Main(string[] args)
    {
        LinkedList<int> danhSach = new LinkedList<int>();
        danhSach.AddLast(5);
        danhSach.AddLast(8);
        danhSach.AddLast(3);
        danhSach.AddLast(12);
        danhSach.AddLast(7);
        danhSach.AddLast(10);
        danhSach.AddLast(15);
        danhSach.AddLast(2);
        danhSach.AddLast(9);
        danhSach.AddLast(6);
        Console.WriteLine("Danh sách ban đầu:");
        HienThiDanhSach(danhSach);
        XoaSoChan(danhSach);
        Console.WriteLine("\nDanh sách sau khi xóa các số chẵn:");
        HienThiDanhSach(danhSach);
    }
}
