using DALs4;
using DALs4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUI
{
    public class Service4
    {
        private readonly Repo4 repo;
        public Service4(Repo4 rp4)
        {
            repo = rp4;
        }
        public List<Nhanvien> GetAllNhanVien()
        {
            return repo.AllNhanVien();
        }
        public bool ThemNhanVien(Nhanvien nhanvien)
        {
            return repo.AddNhanVien(nhanvien);
        }
        public bool UpdateNhanVien(Nhanvien nhanvien)
        {
            return repo.UpdateNhanVien(nhanvien) ;
        }
        public bool XoaNhanVien(int id)
        {
            return repo.DeleteNhanVien(id) ;
        }
        public List<Nhanvien> TimNhanVien(string ten)
        {
            return repo.TimNhanVien(ten) ;
        }
        public List<Congty> GetAllCongTy()
        {
            return repo.AllCongTy();
        }
    }
}
