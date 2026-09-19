using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car : Vehicle
    {
        private int soBanhXe;
        public int SoBanhXe
        {
            get { return soBanhXe; }
            set { 
                if(value<0)
                    Console.WriteLine("So banh xe khong am:");
                else
                    soBanhXe = value; }
        }
        public Car(string hangXe, string mauSac, int soBanhXe) : base(hangXe, mauSac)
        {
            SoBanhXe = soBanhXe;
        }
        public void HienThiThongTin()
        {
            HienThiThongTinChung();
            Console.WriteLine("Số bánh xe: " + SoBanhXe);
        }
    }
}
