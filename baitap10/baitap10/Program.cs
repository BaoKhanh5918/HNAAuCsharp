using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        string str = "";
        for (int i = 0; i < 10000; i++)
        {
            str += "*";
        }
        sw1.Stop();
        Console.WriteLine("Dùng dấu +: " + sw1.ElapsedMilliseconds + " ms");
        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("*");
        }
        string ketQua = sb.ToString();
        sw2.Stop();
        Console.WriteLine("Dùng StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
        Console.ReadKey();
    }
}