using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.DAL;
using DTO;

namespace DAO
{
    public class Class1
    {

    }
    public class DichVu_DAO
    {
        private static DichVu_DAO instance;
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();

        public static DichVu_DAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new DichVu_DAO();
                return instance; 
            } 
        }

        //public List<DICHVU> Bingding()
        //{
        //    var dsDichVu = from dv in database.DichVus select new DICHVU{ Id = dv.ID_DichVu, DonGia =dv.DonGia};
        //    return dsDichVu.ToList();
        //}
        public object Binding()
        {
            var dsDichVu = from dv in database.DichVus select new DICHVU { Id = dv.ID_DichVu, DonGia = dv.DonGia };
            return dsDichVu.ToList();
        }
        public object Load()
        {
            var dsChiTiet = from ct in database.CTTiecCuois select ct;
            return dsChiTiet.ToList();
        }
        public bool Add(DICHVU dv)
        {
            string ID_DichVu= dv.Id;
            double DonGia = dv.DonGia;
            dv = new DICHVU(ID_DichVu, DonGia);
            
            return false;
        }
    }
    public class DSSanh_DAO
    {
        private static DSSanh_DAO instance;
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();

        public static DSSanh_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DSSanh_DAO();
                return instance;
            }
        }

        //public List<DICHVU> Bingding()
        //{
        //    var dsDichVu = from dv in database.DichVus select new DICHVU{ Id = dv.ID_DichVu, DonGia =dv.DonGia};
        //    return dsDichVu.ToList();
        //}
        public object Binding()
        {
            var dsDichVu = from dv in database.DichVus select new DICHVU { Id = dv.ID_DichVu, DonGia = dv.DonGia };
            return dsDichVu.ToList();
        }
        public object Load()
        {
            var dsSanh = from sanh in database.SANHs select new Sanh { Dongia = sanh.DonGiaBanTT,
                                                                       TenSanh = sanh.TenSanh,
                                                                       Id_LoaiSanh=sanh.ID_LoaiSanh,
                                                                       Id_Sanh=sanh.ID_Sanh,
                                                                       SoluongTD=sanh.SoLuonBanTD,
                                                                       TinhTrang=sanh.TinhTrang,
                                                                       GhiChu=sanh.GhiChu,  
                                                                      };
            return dsSanh.ToList();
        }
        public bool Add(Sanh sa)
        {
            SANH sanh = database.SANHs.Where(s => s.ID_Sanh == sa.Id_Sanh).SingleOrDefault();
            return false;
        }
    }
}
