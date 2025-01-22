using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhimv2.DTO
{
    public class ve_ban
    {
        public string Id { get; set; } 
        public DateTime NgayBan { get; set; } 
        public int TongTien { get; set; } 
        public string SuatChieuId { get; set; } 
        public int GiaVeId { get; set; } 
        public int GheId { get; set; } 
        public string NhanVienId { get; set; } 
    }
}
