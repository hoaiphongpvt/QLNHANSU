using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;
using DevExpress.Utils.Behaviors.Common;
using BusinessLayer.DataObject;

namespace BusinessLayer
{
    public class KhenThuong_KiLuat
    {
        HRMEntities db = new HRMEntities();

        public KHENTHUONGKILUAT getItem(int id)
        {
            return db.KHENTHUONGKILUATs.FirstOrDefault(x => x.MaKTKL == id);
        }

        public List<KHENTHUONGKILUAT> getList(int loai)
        {
            return db.KHENTHUONGKILUATs.Where(x => x.Loai == loai).ToList();
        }

        public List<KhenThuong_KiLuatDTO> getListFull(int loai)
        {
            List<KHENTHUONGKILUAT> lstKT = db.KHENTHUONGKILUATs.Where(x => x.Loai == loai).ToList();
            List<KhenThuong_KiLuatDTO> lstKTDTO = new List<KhenThuong_KiLuatDTO>();
            KhenThuong_KiLuatDTO kt;

            foreach(var item in lstKT)
            {
                kt = new KhenThuong_KiLuatDTO();
                kt.Loai = item.Loai;
                kt.MaKTKL = item.MaKTKL;
                kt.LyDo = item.LyDo;
                kt.Ngay = item.Ngay;
                kt.TuNgay = item.TuNgay;
                kt.DenNgay = item.DenNgay;
                kt.NoiDung = item.NoiDung;
                kt.MaNV = item.MaNV;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MaNV == item.MaNV);
                kt.HoTen = nv.HoTen;
                lstKTDTO.Add(kt);
            }

            return lstKTDTO;
        }

        public KHENTHUONGKILUAT Add(KHENTHUONGKILUAT ktkl)
        {
            try
            {
                db.KHENTHUONGKILUATs.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public KHENTHUONGKILUAT Update(KHENTHUONGKILUAT ktkl)
        {
            try
            {
                KHENTHUONGKILUAT _ktkl = db.KHENTHUONGKILUATs.FirstOrDefault(x => x.MaKTKL == ktkl.MaKTKL);
                _ktkl.Ngay = ktkl.Ngay;
                _ktkl.TuNgay = ktkl.TuNgay;
                _ktkl.DenNgay = ktkl.DenNgay;
                _ktkl.LyDo = ktkl.LyDo;
                _ktkl.Loai = ktkl.Loai;
                _ktkl.MaNV = ktkl.MaNV;
                _ktkl.NoiDung = ktkl.NoiDung;
                db.SaveChanges();
                return ktkl;
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
                KHENTHUONGKILUAT ktkl = db.KHENTHUONGKILUATs.FirstOrDefault(x => x.MaKTKL == id);
                db.KHENTHUONGKILUATs.Remove(ktkl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
