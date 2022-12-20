using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class HopDong
    {
        HRMEntities db = new HRMEntities();

        public HOPDONG getItem(int id)
        {
            return db.HOPDONGs.FirstOrDefault(x => x.MaHD == id);
        }

        public List<HOPDONG> getList()
        {
            return db.HOPDONGs.ToList();
        }

        public HOPDONG Add(HOPDONG hd)
        {
            try
            {
                db.HOPDONGs.Add(hd);
                db.SaveChanges();
                return hd;
            }
            
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }

        public HOPDONG Update(HOPDONG hd)
        {
            try
            {
                var _hd = db.HOPDONGs.FirstOrDefault(x => x.MaHD == hd.MaHD);
                _hd.MaHD = hd.MaHD;
                _hd.NgayBD = hd.NgayBD;
                _hd.NgayKT = hd.NgayKT;
                _hd.NgayKi = hd.NgayKi;
                _hd.MaNV = hd.MaNV;
                _hd.HeSoLuong = hd.HeSoLuong;
                _hd.NoiDung = hd.NoiDung;
                _hd.ThoiHan = hd.ThoiHan;
                db.SaveChanges();
                return hd;
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            var _hd = db.HOPDONGs.FirstOrDefault(x => x.MaHD == id);
            db.SaveChanges();
        }
    }
}
