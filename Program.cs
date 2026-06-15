using System;
namespace QuanLyHocSinh
{
    class HocSinh
    {
        // Thuộc tính riêng tư(Private Fields)
        private string _ten;
        private double _diemToan;
        private double _diemLy;
        private double _diemHoa;
        public  String Ten
        {
             get { return _ten;}
             set { _ten = value;}
        }
        public double DiemToan
        {
            get { return _diemToan;}
            set
            {
                if ( value >= 0 && value <= 10)
                _diemToan = value;
                else
                {
                    Console.WriteLine("Điểm Toán không hợp lệ! Vui lòng nhập lại");
                    _diemToan = 0;
                }
            }
        }
        public double DiemLy
        {
            get { return _diemLy; }
            set
            {
                if (value >= 0 && value <= 10)
                    _diemLy = value;
                else
                {
                    Console.WriteLine("Điểm Lý không hợp lệ! Vui lòng nhập lại");
                    _diemLy = 0;
                }
            }
        }
        public double DiemHoa
        {
            get { return _diemHoa; }
            set
            {
                if (value >= 0 && value <= 10)
                    _diemHoa = value;
                else
                {
                    Console.WriteLine("Điểm Hóa không hợp lệ! Vui lòng nhập lại");
                    _diemHoa = 0;
                }
            }
        }
        public HocSinh()
        {
            _ten = "";
            _diemToan = 0;
            _diemLy = 0;
            _diemHoa = 0;
        }
        public void NhapThongTin()
        {
            Console.Write("Nhập tên học sinh: ");
            Ten = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhập điểm Toán: ");
            DiemToan = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("Nhập điểm Lý: ");
            DiemLy = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("Nhập điểm Hóa: ");
            DiemHoa = Convert.ToDouble(Console.ReadLine() ?? "0");
        }
        public double TinhDiemTrungBinh()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }
        public void HienThi()
        {
            Console.WriteLine("\n===== THÔNG TIN HỌC SINH =====");
            Console.WriteLine($"Tên: {Ten}");
            Console.WriteLine($"Điểm Toán: {DiemToan}");
            Console.WriteLine($"Điểm Lý: {DiemLy}");
            Console.WriteLine($"Điểm Hóa: {DiemHoa}");
            Console.WriteLine($"Điểm trung bình: {TinhDiemTrungBinh():F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.NhapThongTin();
            hs.HienThi();
        }
    }
}