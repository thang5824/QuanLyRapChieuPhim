using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhimv2.DTO
{
    public class Database
    {
        private string connectionString = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

        public string GetDatabase()
        {
            return connectionString;
        }
    }
}
