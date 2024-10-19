using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTienGiaoThong
{
    public class PHUONGTIEN
    {
        private string hangSX;
        private int namSX;
        private double giaBan;
        private string mau;
        public string HangSX { get =>  hangSX; set => hangSX = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public string Mau { get => mau; set => mau = value; }
        public PHUONGTIEN() { }
        public PHUONGTIEN(string hangSX, int namSX, double giaBan, string mau)
        {
            HangSX = hangSX;
            NamSX = namSX;
            GiaBan = giaBan;
            Mau = mau;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap hang san xuat: ");
            HangSX = Console.ReadLine();
            Console.Write("Nhap nam san xuat: ");
            NamSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban(VND): ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap mau phuong tien: ");
            Mau = Console.ReadLine();
        }
        public virtual string XuatThongTin()
        {
            string s =  $"Hang San Xuat: {HangSX}, Nam San Xuat: {NamSX}, Gia Ban: {GiaBan} VND, Mau: {Mau}";
            return s;
        }
    }
}
