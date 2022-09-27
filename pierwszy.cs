using System;

class Program
{

    static void Main()
    {
        int liczba = 0;
        liczba = Convert.ToInt32(Console.ReadLine());
        if (liczba > 0)
        {
            Console.WriteLine("Liczba dodatnia");
        }
        else
        {
            Console.WriteLine("Liczba ujemna");
        }
    }
}
