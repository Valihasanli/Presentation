using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        Console.WriteLine("axtardigin ededi daxil et:");
        int b=Convert.ToInt32(Console.ReadLine());
        int start = 0;
        int end = a.Length - 1;
        int mid;
        bool check = false;
        for (int i = start; i <= end; i++)
        {
            mid = (start + end) / 2;
            if (b == a[mid])
            {
                Console.WriteLine($"axtarilan eded tapildi indexi {mid}");
                check = true;
                break;
            }
            else if (a[mid] > b) { end = mid - 1; }
            else { start = mid + 1; }
        }
        if (!check) { Console.WriteLine("eded tapilmadi"); }
        
    }
}