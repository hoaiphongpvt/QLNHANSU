using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BoPhan
    {
        HRMEntities db = new HRMEntities();

        public List<BOPHAN> getList()
        {
            return db.BOPHANs.ToList();
        }

        public BOPHAN getItem(int id)
        {
            return db.BOPHANs.FirstOrDefault(x => x.MaBP == id); ;
        }

        public BOPHAN Add(BOPHAN bp)
        {
            try
            {
                db.BOPHANs.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public BOPHAN Update(BOPHAN bp)
        {
            try
            {
                var _bp = db.BOPHANs.FirstOrDefault(x => x.MaBP == bp.MaBP);
                _bp.TenBP = bp.TenBP;
                db.SaveChanges();
                return bp;
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
                var _bp = db.BOPHANs.FirstOrDefault(x => x.MaBP == id);
                db.BOPHANs.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
