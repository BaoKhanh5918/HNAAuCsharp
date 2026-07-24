using System;
class Program
// {
//     static void InMang(int[] arr)
//     {
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(arr[i] + " ");
//         }
//         Console.WriteLine();
//     }
//     static void SelectionSort(int[] arr)
//     {
//         for (int i = 0; i < arr.Length - 1; i++)
//         {
//             int viTriMin = i;
//             for (int j = i +  1; j < arr.Length; j++)
//             {
//                 if(arr[j] < arr[viTriMin])
//                 {
//                     viTriMin = j;
//                 }
//             }
//             int temp = arr[i];
//             arr[i] = arr[viTriMin];
//             arr[viTriMin] = temp;
//         }
//     }
//     static void Main(string[] arr)
//     {
//         int[] data = {64, 25,12, 22, 11};
//         Console.WriteLine("Mảng ban đầu: ");
//         InMang(data);
//         SelectionSort(data);
//         Console.WriteLine("Mảng sau khi sắp xếp: ");
//         InMang(data);
//     }
// }
{
    static void InMang(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void SelectionSortGiamDan(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int viTriMax = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[viTriMax])
                {
                    viTriMax = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[viTriMax];
            arr[viTriMax] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] data = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Mảng ban đầu:");
        InMang(data);
        SelectionSortGiamDan(data);
        Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
        InMang(data);
    }
}