using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        private string hangXe;
        private string mauSac;
        public string HangXe
        {
            get { return hangXe; }
            set { hangXe = value; }
        }
        public string MauSac
        {
            get { return mauSac; }
            set { mauSac = value; }
        }
        public Vehicle(string hangXe, string mauSac)
        {
            HangXe = hangXe;
            MauSac = mauSac;
        }
        public void HienThiThongTinChung()
        {
            Console.WriteLine("Hãng xe: " + HangXe);
            Console.WriteLine("Màu sắc: " + MauSac);
        }
    }
}
