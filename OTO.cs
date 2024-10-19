using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTienGiaoThong
{
    public class OTO : PHUONGTIEN
    {
        private int soChoNgoi;
        private string kieuDongCo;
        public int SoChoNgoi {  get =>  soChoNgoi; set => soChoNgoi = value;}
        public string KieuDongCo { get => kieuDongCo; set => kieuDongCo = value;}
        public OTO() { }
        public OTO (string hangSX, int namSX, double giaBan, string mau, int soChoNgoi, string kieuDongCo) : base (hangSX, namSX, giaBan, mau)
        {
            SoChoNgoi = soChoNgoi;
            KieuDongCo = kieuDongCo;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap kieu dong co: ");
            KieuDongCo = Console.ReadLine();
        }
        public override string XuatThongTin()
        {
            string s =  $"OTO[{base.XuatThongTin()}, So Cho Ngoi: {SoChoNgoi}, Kieu Dong Co: {KieuDongCo}]";
            return s;
        }
    }
}
