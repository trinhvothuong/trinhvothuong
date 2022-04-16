using System;

class TestClass
{

    static void Main(string[] data)
    {
        Console.WriteLine("hello cites");
        HttpClient caller = new HttpClient();
        caller.GetAsync("https://localhost:7236/weatherforecast").GetAwaiter

        Console.Read();

    }

}