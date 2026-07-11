using System;
class Program
// {
//     static void DemNguoc(int n)
//     {
//         if (n == 0)
//         {
//             Console.WriteLine("Bắt đầu!");
//             return;
//         }
//         Console.WriteLine(n);
//         DemNguoc(n - 1);
//     }
//     static void Main()
//     {
//         Console.Write("Nhập n: ");
//         int n = int.Parse(Console.ReadLine());
//         DemNguoc(n);
//     }
// }
// {
//     static void ToMau(int[,] map, int x, int y)
//     {
//         if (x < 0 || x >= map.GetLength(0) || y < 0 || y >= map.GetLength(1))
//         {
//             return;
//         }
//         if (map[x, y] == 1 || map[x, y] == 2)
//         {
//             return;
//         }
//         map[x, y] = 2;
//         ToMau(map, x - 1, y);
//         ToMau(map, x + 1, y);
//         ToMau(map, x, y - 1);
//         ToMau(map, x, y + 1);
//     }

//     static void InMap(int[,] map)
//     {
//         for (int i = 0; i < map.GetLength(0); i++)
//         {
//             for (int j = 0; j < map.GetLength(1); j++)
//             {
//                 Console.Write(map[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     static void Main()
//     {
//         int[,] map =
//         {
//             {0,0,1,0,0},
//             {0,1,1,0,0},
//             {0,0,0,1,0},
//             {1,1,0,0,0},
//             {0,0,0,1,0}
//         };
//         Console.WriteLine("Ma trận ban đầu:");
//         InMap(map);
//         Console.WriteLine("\nTô màu từ vị trí (0,0):");
//         ToMau(map, 0, 0);
//         InMap(map);
//     }
// }

// {
//     static void Ping(int n)
//     {
//         if (n == 0)
//         {
//             Console.WriteLine("Kết thúc!");
//             return;
//         }
//         Console.WriteLine("Ping: " + n);

//         Pong(n - 1);
//     }
//     static void Pong(int n)
//     {
//         if (n == 0)
//         {
//             Console.WriteLine("Kết thúc!");
//             return;
//         }
//         Console.WriteLine("Pong: " + n);
//         Ping(n - 1);
//     }
//     static void Main()
//     {
//         Console.Write("Nhập n: ");
//         int n = int.Parse(Console.ReadLine());
//         Ping(n);
//     }
// }

// {
//     static int TimMax(int[] arr, int left, int right)
//     {
//         if (left == right)
//         {
//             return arr[left];
//         }
//         int mid = (left + right) / 2;
//         int maxLeft = TimMax(arr, left, mid);
//         int maxRight = TimMax(arr, mid + 1, right);
//         return Math.Max(maxLeft, maxRight);
//     }

//     static void Main()
//     {
//         int[] arr = { 8, 3, 15, 6, 12, 20, 5, 9 };
//         int max = TimMax(arr, 0, arr.Length - 1);
//         Console.WriteLine("Giá trị lớn nhất là: " + max);
//     }
// }
{
    static int GiaiThuaDuoi(int n, int acc = 1)
    {
        // Base case
        if (n == 0)
            return acc;

        // Tail Recursion
        return GiaiThuaDuoi(n - 1, acc * n);
    }

    static void Main()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n}! = {GiaiThuaDuoi(n)}");
    }
}