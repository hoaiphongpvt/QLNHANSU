using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;
using DevExpress.Utils.Serializing.Helpers;

namespace BusinessLayer
{
    public class DieuChuyen
    {
        HRMEntities db = new HRMEntities();

        public DIEUCHUYEN getItem(int ma)
        {
            return db.DIEUCHUYENs.FirstOrDefault(x => x.MaDC == ma);
        }

        public List<DIEUCHUYEN> getList()
        {
            return db.DIEUCHUYENs.ToList();
        }

        public List<DieuChuyenDTO> getListFull()
        {
            var lstDC = db.DIEUCHUYENs.ToList();
            List<DieuChuyenDTO> lstDTO = new List<DieuChuyenDTO>();
            DieuChuyenDTO dcdto;
            foreach (var item in lstDC)
            {
                dcdto = new DieuChuyenDTO();
                dcdto.MaDC = item.MaDC;
                dcdto.MaNV = item.MaNV;
                dcdto.Ngay = item.Ngay;
                dcdto.LyDo = item.LyDo;
                dcdto.GhiChu = item.GhiChu;
                dcdto.MaPB = item.MaPB;
                dcdto.MaPB2 = item.MaPB2;
                var _nv = db.NHANVIENs.FirstOrDefault(n => n.MaNV == item.MaNV);
                dcdto.HoTen = _nv.HoTen;
                var _pb = db.PHONGBANs.FirstOrDefault(p => p.MaPB == item.MaPB);
                dcdto.TenPB = _pb.TenPB;
                var _pb2 = db.PHONGBANs.FirstOrDefault(p2 => p2.MaPB == item.MaPB);
                dcdto.TenBP2 = _pb2.TenPB;
                lstDTO.Add(dcdto);
            }
            return lstDTO;
        }

        public DIEUCHUYEN Add(DIEUCHUYEN dc)
        {
            try
            {
                db.DIEUCHUYENs.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public DIEUCHUYEN Update(DIEUCHUYEN dc)
        {
            try
            {
                var _dc = db.DIEUCHUYENs.FirstOrDefault(x => x.MaDC == dc.MaDC);
                _dc.MaPB2 = dc.MaPB2;
                _dc.Ngay = dc.Ngay;
                _dc.MaNV = dc.MaNV;
                _dc.LyDo = dc.LyDo;
                _dc.GhiChu = dc.GhiChu;
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _dc = db.DIEUCHUYENs.FirstOrDefault(x => x.MaDC == id);
                db.DIEUCHUYENs.Remove(_dc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
