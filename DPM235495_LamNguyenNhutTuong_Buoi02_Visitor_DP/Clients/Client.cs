using DPM235495_LamNguyenNhutTuong_Buoi02_Visitor_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235495_LamNguyenNhutTuong_Buoi02_Visitor_DP.Clients
{
    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
