using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TrinhDo
    {
        HRMEntities db = new HRMEntities();

        public List<TRINHDO> getList()
        {
            return db.TRINHDOes.ToList();
        }

        public TRINHDO getItem(int id)
        {
            return db.TRINHDOes.FirstOrDefault(x => x.MaTD == id); ;
        }

        public TRINHDO Add (TRINHDO td)
        {
            try
            {
                db.TRINHDOes.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TRINHDO Update(TRINHDO td)
        {
            try
            {
                var _td = db.TRINHDOes.FirstOrDefault(x => x.MaTD == td.MaTD);
                _td.TenTD = td.TenTD;
                db.SaveChanges();
                return td;
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
                var _td = db.TRINHDOes.FirstOrDefault(x => x.MaTD == id);
                db.TRINHDOes.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
