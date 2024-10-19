namespace PhuongTienGiaoThong
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhuongTien ql_pt = new QuanLyPhuongTien();
            ql_pt.NhapDanhSach();
            Console.WriteLine("-----THONG TIN CAC PHUONG TIEN-----");
            ql_pt.XuatDanhSach();
            ql_pt.SearchColor();
            ql_pt.SearchByYear();
        }
    }
}