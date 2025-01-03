using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.BLL
{
    internal class BLL_CoVanHocTap
    {
        public class DAL_CoVanHocTap
        {
            private static DAL_CoVanHocTap instance;
            public static DAL_CoVanHocTap Instance
            {
                get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
                private set => instance = value;
            }
            private DAL_CoVanHocTap() { }

            public DataTable DanhSach()
            {
                return DAL_CoVanHocTap.Instance.DanhSach();
            }

            public bool Them(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop)
            {
                return DAL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop);
            }

            public bool Sua(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string id)
            {
                return DAL_CoVanHocTap.Instance.Sua((macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id)
            }

            public bool Xoa(int id)
            {
                return DAL_CoVanHocTap.Instance.Xoa(id);
            }
        }
    }
}
