using System;

namespace ConsoleApp2
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car xe1 = new Car("Toyota", "Red", 4);
            xe1.HienThiThongTin();
            MotoBike xe2 = new MotoBike("Honda", "Blue", 150);
            xe2.HienThiThongTin();
        }
    }
}
