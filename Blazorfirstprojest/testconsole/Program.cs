using System;

class TestClass
{

    static void Main(string[] data)
    {

        //string FirstNumber = null;
        //string FirstNumber = null;
        //Console.WriteLine("Enter your firstnumber:" );

        //FirstNumber =    Console.ReadLine();

        //Console.WriteLine("Enter your secondnumber:");

        //SecondNumber = Console.ReadLine();

        //Console.Write("Your two number is: ");
        //Console.Write(FirstNumber + " " + SecondNumber );

        //// Console.Read();

        int FirstNumber = 0;
        int SecondNumber = 0;
        int TotalNumber = 0;
        string temp = null;

        Console.WriteLine("Enter your firstnumber:");
        temp = Console.ReadLine();
        FirstNumber = int.Parse(temp);

        Console.WriteLine("Enter your secondnumber:");
        temp = Console.ReadLine();
        SecondNumber = int.Parse(temp);

        Console.Write("Your two number enter is: ");
        Console.WriteLine(FirstNumber + " " + SecondNumber);


        TotalNumber = FirstNumber + SecondNumber;
        Console.Write("Your total is: ");
        Console.Write(TotalNumber);




        Console.Read();

    }

}