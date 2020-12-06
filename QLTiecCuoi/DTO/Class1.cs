using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DICHVU
    {
        string id;
        Nullable<double> donGia;

        public DICHVU()
        {
        }

        public DICHVU(string id, double donGia)
        {
            this.id = id;
            this.donGia = donGia;
        }

        public Nullable<double> DonGia { get => donGia; set => donGia = value; }
        public string Id { get => id; set => id = value; }
    }
    public class KHACHHANG
    {
        string id;
        string tenCR;
        string tenCD;
        int dienThoai;

        public string Id { get => id; set => id = value; }
        public string TenCR { get => tenCR; set => tenCR = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
        public int DienThoai { get => dienThoai; set => dienThoai = value; }
    }
    public class HOADON
    {
        DateTime ngayHD;
        string id_KhachHang;
        int soluong;
        float dongiaban;
        string id_HoaDon;

        public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
        public string Id_KhachHang { get => id_KhachHang; set => id_KhachHang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongiaban { get => dongiaban; set => dongiaban = value; }
        public string Id_HoaDon { get => id_HoaDon; set => id_HoaDon = value; }
    }
    public class Sanh
    {
        string tenSanh;
        string id_LoaiSanh;
        string id_Sanh;
        Nullable<int> soluongTD;
        Nullable<double> dongia;
        Nullable<bool> tinhTrang;
        string ghiChu;

        public string TenSanh { get => tenSanh; set => tenSanh = value; }
        public string Id_LoaiSanh { get => id_LoaiSanh; set => id_LoaiSanh = value; }
        public string Id_Sanh { get => id_Sanh; set => id_Sanh = value; }
        public Nullable<int> SoluongTD { get => soluongTD; set => soluongTD = value; }
        public Nullable<double> Dongia { get => dongia; set => dongia = value; }
        public Nullable<bool> TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public Sanh()
        {
        }
    }
    public class CTTIECCUOI
    {
        public string ID_TiecCuoi { get; set; }
        public string ID_MonAn { get; set; }
        public string ID_DichVu { get; set; }
        public string GhiChuMA { get; set; }
        public Nullable<int> SoLuongDV { get; set; }

        public virtual DICHVU DichVu { get; set; }
        public virtual MONAN MonAn { get; set; }
        public virtual TiecCuoi TIECCUOI { get; set; }
    }
    public class MONAN
    {
        public string ID_MonAn { get; set; }
        public Nullable<double> DonGia { get; set; }
    }
    public class TiecCuoi
    {
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> Ca { get; set; }
        public string ID_Sanh { get; set; }
        public Nullable<double> TienDatCoc { get; set; }
        public Nullable<int> SobanDuTru { get; set; }
        public string ID_KhachHang { get; set; }
        public string ID_TiecCuoi { get; set; }
    }
}
