using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTienGiaoThong
{
    public class QuanLyPhuongTien
    {
        private List<PHUONGTIEN> ds_phuongtien = new List<PHUONGTIEN>();
        public void NhapDanhSach()
        {
            Console.WriteLine("Nhap so luong phuong tien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap loai phuong tien(1.Oto, 2.Xemay, 3.Xetai): ");
                int loai_xe = int.Parse(Console.ReadLine());

                if(loai_xe == 1)
                {
                    OTO oto = new OTO();
                    Console.WriteLine("OTO");
                    oto.Nhap();
                    ds_phuongtien.Add(oto);
                }
                else if(loai_xe == 2)
                {
                    XEMAY xemay = new XEMAY();
                    Console.WriteLine("XE MAY");
                    xemay.Nhap();
                    ds_phuongtien.Add(xemay);
                }
                else if (loai_xe == 3)
                {
                    XETAI xetai = new XETAI();
                    Console.WriteLine("XE TAI");
                    xetai.Nhap();
                    ds_phuongtien.Add(xetai);
                }
            }
        }
        public void XuatDanhSach()
        {
            foreach (var x in ds_phuongtien)
            {
                Console.WriteLine(x.XuatThongTin());
            }
        }
        public void SearchColor()
        {
            Console.WriteLine("Nhap mau xe can tim: ");
            string color = Console.ReadLine();
            foreach (var vehicle in ds_phuongtien)
            {
                if (vehicle.Mau.Equals(color, StringComparison.OrdinalIgnoreCase))  //Được sử dụng để so sánh chuỗi không phân biệt hoa thường.
                {
                    Console.WriteLine(vehicle.XuatThongTin());
                }
            }
        }
        public void SearchByYear()
        {
            Console.WriteLine("Nhap nam de tim phuong tien san xuat truoc do: ");
            int year = int.Parse(Console.ReadLine());
            foreach (var vehicle in ds_phuongtien)
            {
                if(vehicle.NamSX < year)
                {
                    Console.WriteLine(vehicle.XuatThongTin());
                }
            }
        }
    }
}
