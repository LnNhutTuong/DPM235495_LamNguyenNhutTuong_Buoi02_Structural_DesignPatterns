using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235495_LamNguyenNhutTuong_Buoi02_Mediator_DP.Interfaces
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
