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
        public Car(string hangxe,string mausac,int sobanhxe)
        {
            HangXe = hangxe;
            MauSac = mausac;
            SoBanhXe = sobanhxe;
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
            Car xe1 = new Car("Toyota", "Do", 4);
            Car xe2 = new Car("Honda", "Xanh", 4);
            xe1.HienthiThongtin();
            Console.WriteLine("----------------------------------");
            xe2.HienthiThongtin();  
            Car xe3 = new Car("Ford", "Trang", -2); 
        }
    }
}
