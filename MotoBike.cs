using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MotoBike : Vehicle
    {
        private int phanKhoi;
        public int PhanKhoi
        {
            get { return phanKhoi; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Phân khối không âm:");
                else
                    phanKhoi = value;
            }
        }        
        public MotoBike(string hangXe, string mauSac, int phanKhoi) : base(hangXe, mauSac)
        {
            PhanKhoi  = phanKhoi;
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Phân khối: " + PhanKhoi);
        }
    }
}