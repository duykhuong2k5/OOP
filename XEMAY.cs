using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTienGiaoThong
{
    public class XEMAY : PHUONGTIEN
    {
        private double congSuat;
        public double CongSuat { get => congSuat; set => congSuat = value; }
        public XEMAY() { }
        public XEMAY(string hangSX, int namSX, double giaBan, string mau,double congSuat) : base (hangSX,namSX,giaBan,mau)
        {
            CongSuat = congSuat;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong suat: ");
            CongSuat = double.Parse(Console.ReadLine());
        }
        public override string XuatThongTin()
        {
            string s = $"XEMAY[{base.XuatThongTin()}, Cong Suat: {CongSuat}]";
            return s;
        }
    }
}
