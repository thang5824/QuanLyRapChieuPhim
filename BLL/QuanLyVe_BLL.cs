using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyVe_BLL
    {
        private QuanLyVe_DAL quanLyveDAL;

        public QuanLyVe_BLL(string Dbconnection)
        {
            quanLyveDAL = new QuanLyVe_DAL(Dbconnection);
        }
        public DataTable LoadListVe()
        {
            return quanLyveDAL.LoadDataVe();    
        }

        public DataTable LoadLisstHoaDon()
        {
            return quanLyveDAL.LoadDataHoaDon();
        }
        public DataTable LoadGiaVePhim()
        {
            return quanLyveDAL.LoadDataGiaVePhim();
        }
        public bool AddHoaDon(int mave ,int tongtien)
        {
          return quanLyveDAL.AddHoaDon(mave , tongtien);  
        }
        public bool AddNewVeBan(int maveBan , DateTime ngayBan, int tongTien, string suatChieu, int giaVe, int ghe, string maNhanVien)
        {
            return quanLyveDAL.AddVeMua( maveBan,ngayBan, tongTien, suatChieu, giaVe, ghe, maNhanVien);
        }
        public bool UpdateVeBan(int maveBan, DateTime ngayBan, int tongTien, string suatChieu, int giaVe, int ghe, string maNhanVien)
        {
            return quanLyveDAL.UpdateVeBanInDb(maveBan, ngayBan, tongTien, suatChieu, giaVe, ghe, maNhanVien);
        }
        public bool DeleteVeBan(string maVe)
        {
            return quanLyveDAL.DeleteVeMua(maVe);
        }
      


    }
}
