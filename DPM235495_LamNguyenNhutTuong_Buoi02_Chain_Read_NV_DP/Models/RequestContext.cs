using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235495_LamNguyenNhutTuong_Buoi02_Chain_Read_NV_DP.Models
{
    public class RequestContext
    {
        public int NhanVienId { get; set; }
        public string UserRole { get; set; } // Quyền của người đang thực hiện yêu cầu (vd: "Admin", "Staff")
    }
}
