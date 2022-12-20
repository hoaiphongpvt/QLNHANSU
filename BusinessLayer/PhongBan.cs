using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PhongBan
    {
        HRMEntities db = new HRMEntities();

        public List<PHONGBAN> getList()
        {
            return db.PHONGBANs.ToList();
        }

        public PHONGBAN getItem(int id)
        {
            return db.PHONGBANs.FirstOrDefault(x => x.MaPB == id); ;
        }

        public PHONGBAN Add(PHONGBAN td)
        {
            try
            {
                db.PHONGBANs.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public PHONGBAN Update(PHONGBAN pb)
        {
            try
            {
                var _td = db.PHONGBANs.FirstOrDefault(x => x.MaPB == pb.MaPB);
                _td.TenPB = pb.TenPB;
                db.SaveChanges();
                return pb;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _td = db.PHONGBANs.FirstOrDefault(x => x.MaPB == id);
                db.PHONGBANs.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
