﻿class LineComparision
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the Co-ordinates of first line");

        Console.WriteLine("Enter Value X1");
        int X1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y1");
        int Y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value X2");
        int X2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y2");
        int Y2 = Convert.ToInt32(Console.ReadLine());

        double Length1 = Math.Sqrt((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2);
        Console.WriteLine("Length of first line is: " + Length1);

        Console.WriteLine("Enter the Co-ordinates of second line");

        Console.WriteLine("Enter Value X1");
        int A1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y1");
        int B1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value X2");
        int A2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value Y2");
        int B2 = Convert.ToInt32(Console.ReadLine());

        double Length2 = Math.Sqrt((A2 - A1) ^ 2 + (B2 - B1) ^ 2);
        Console.WriteLine("Length of second line is: " + Length2);

        if (Length1 > Length2)
        {
            Console.WriteLine("Length of first line is greater than second line");
        }
        else if (Length2 > Length1)
        {
            Console.WriteLine("Length of second line is greater than first line");
        }
        else
        {
            Console.WriteLine("Both the line are equal");
        }


    }


}
