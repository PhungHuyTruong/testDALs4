using DALs4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs4
{
    public class Repo4
    {
        private readonly Sof205FinalTestContext _context;

        public Repo4()
        {
            _context = new Sof205FinalTestContext();
        }

        //nhan vien + cong ty 

        public List<Nhanvien> AllNhanVien()
        {
            return _context.Nhanviens.ToList();
        }
        public bool AddNhanVien(Nhanvien nv)
        {
            try
            {
                _context.Nhanviens.Add(nv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateNhanVien(Nhanvien nv)
        {
            try
            {
                var nhanviensua = _context.Nhanviens.Find(nv.Id);
                nhanviensua.Ten = nv.Ten;
                nhanviensua.Diachi = nv.Diachi;
                nhanviensua.Sodienthoai = nv.Sodienthoai;
                nhanviensua.Ngaytuyendung = nv.Ngaytuyendung;
                nhanviensua.IdCn = nv.IdCn;

                _context.Nhanviens.Update(nhanviensua);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteNhanVien(int id)
        {
            try
            {
                var nhanvienxoa = _context.Nhanviens.Find(id);
                _context.Nhanviens.Remove(nhanvienxoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public List<Nhanvien> TimNhanVien(string ten)
        {
            return _context.Nhanviens.Where(a => a.Ten.Contains(ten)).ToList();
        }
        public List<Congty> AllCongTy()
        {
            return _context.Congties.ToList();
        }
    }
}
