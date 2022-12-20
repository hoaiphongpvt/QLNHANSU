using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChucVu
    {
        HRMEntities db = new HRMEntities();

        public List<CHUCVU> getList()
        {
            return db.CHUCVUs.ToList();
        }

        public CHUCVU getItem(int id)
        {
            return db.CHUCVUs.FirstOrDefault(x => x.MaCV == id); ;
        }

        public CHUCVU Add(CHUCVU cv)
        {
            try
            {
                db.CHUCVUs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public CHUCVU Update(CHUCVU cv)
        {
            try
            {
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.MaCV == cv.MaCV);
                _cv.TenCV = cv.TenCV;
                db.SaveChanges();
                return cv;
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
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.MaCV == id);
                db.CHUCVUs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}