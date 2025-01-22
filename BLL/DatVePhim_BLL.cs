using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatVePhim_BLL
    {
        public DatVePhim_DAL datVeDAL;

        public DatVePhim_BLL(string Dbconnection)
        {
            datVeDAL = new DatVePhim_DAL(Dbconnection);
        }
        public DataTable LoadDatVe()
        {
            return datVeDAL.LoadDataDatVe();
        }
        public bool AddDatVe(string phimId, int gheNgoiId, DateTime thoiGianDat, int giaVeId, string trangThai)
        {
            return datVeDAL.InsertDatVe(phimId, gheNgoiId, thoiGianDat, giaVeId, trangThai);
        }

        public bool EditDatVe(int id, string phimId, int gheNgoiId, DateTime thoiGianDat, int giaVeId, string trangThai)
        {
            return datVeDAL.UpdateDatVe(id, phimId, gheNgoiId, thoiGianDat, giaVeId, trangThai);
        }

        public bool RemoveDatVe(int id)
        {
            return datVeDAL.DeleteDatVe(id);
        }

    }
}
