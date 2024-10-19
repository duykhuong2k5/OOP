using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTienGiaoThong
{
    public class XETAI : PHUONGTIEN
    {
        private double trongTai;
        public double TrongTai { get => trongTai; set => trongTai = value; }
        public XETAI() { }
        public XETAI (string hangSX, int namSX, double giaBan, string mau,double trongTai) : base (hangSX,namSX,giaBan,mau)
        {
            TrongTai = trongTai;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so trong tai(Tan): ");
            TrongTai = double.Parse(Console.ReadLine());
        }
        public override string XuatThongTin()
        {
            string s = $"XETAI[{base.XuatThongTin()}, Trong Tai: {TrongTai} tan]";
            return s;
        }
    }
}
