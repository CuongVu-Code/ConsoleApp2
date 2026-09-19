using System;

namespace ConsoleApp2
{
    class Car
    {
        private string hangxe;
        private string mausac;
        private int sobanhxe;
        public string HangXe
        {   
            get { return hangxe; }
            set { hangxe = value; }
        }

        public string MauSac
        {
            get { return mausac; }
            set { mausac = value; }
        }
        public int SoBanhXe
        {
            get { return sobanhxe; }
            set {
                if (value < 0)
                    Console.WriteLine("So banh xe khong duoc am");                
                else          
                    sobanhxe = value;     
            }

        }

        public void HienthiThongtin()
        {
            Console.WriteLine("Hang xe: " + HangXe);
            Console.WriteLine("Mau sac: " + MauSac);
            Console.WriteLine("So banh xe: " + SoBanhXe);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car xe1 = new Car();
            xe1.HangXe = "Toyota";
            xe1.MauSac = "Do";
            xe1.SoBanhXe = -3;
            Car xe2 = new Car();
            xe2.HangXe = "Honda";
            xe2.MauSac = "Xanh";
            xe2.SoBanhXe = 4;
            xe1.HienthiThongtin();
            Console.WriteLine("----------------------------------");
            xe2.HienthiThongtin();  
        }
    }
}
