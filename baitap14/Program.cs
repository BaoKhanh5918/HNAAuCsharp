using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList ds = new ArrayList();
        ds.Add("An");
        ds.Add(25);  
        ds.Insert(1, "Binh");
        ds.Remove("An"); 
        ds.RemoveAt(0); 
        ds.Add("Chau");
        string ten = (string)ds[0];
        Console.WriteLine("Tên lấy từ ArrayList: " + ten);
    }
}