using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;
using DevExpress.Utils.NonclientArea;

namespace BusinessLayer
{
    public class NhanVien
    {
        HRMEntities db = new HRMEntities();

        public List<NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();
        }

        public List<NhanVienDTO> getListFull()
        {
            var lstNV = db.NHANVIENs.ToList();
            List<NhanVienDTO> lstNVDTO = new List<NhanVienDTO>();
            NhanVienDTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVienDTO();
                nvDTO.MaNV = item.MaNV;
                nvDTO.HoTen = item.HoTen;
                nvDTO.GioiTinh = item.GioiTinh;
                nvDTO.NgaySinh = item.NgaySinh;
                nvDTO.DiaChi = item.DiaChi;
                nvDTO.DienThoai = item.DienThoai;
                nvDTO.HinhAnh = item.HinhAnh;
                nvDTO.MaBP = item.MaBP;
                var bp = db.BOPHANs.FirstOrDefault(b => b.MaBP == item.MaBP);
                nvDTO.TenBP = bp.TenBP;
                nvDTO.MaCV = item.MaCV;
                var cv = db.CHUCVUs.FirstOrDefault(c => c.MaCV == item.MaCV);
                nvDTO.TenCV = cv.TenCV;
                nvDTO.MaPB = item.MaPB;
                var pb = db.PHONGBANs.FirstOrDefault(p => p.MaPB == item.MaPB);
                nvDTO.TenPB = pb.TenPB;
                nvDTO.MaTD = item.MaTD;
                var td = db.TRINHDOes.FirstOrDefault(t => t.MaTD == item.MaTD);
                nvDTO.TenTD = td.TenTD;

                lstNVDTO.Add(nvDTO);
            }

            return lstNVDTO;
        }

        public NHANVIEN getItem(int id)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.MaNV == id); ;
        }

        public NHANVIEN Add(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public NHANVIEN Update(NHANVIEN nv)
        {
            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MaNV == nv.MaNV);
                _nv.HoTen = nv.HoTen;
                _nv.GioiTinh = nv.GioiTinh;
                _nv.NgaySinh = nv.NgaySinh;
                _nv.DiaChi = nv.DiaChi;
                _nv.DienThoai = nv.DienThoai;
                _nv.HinhAnh = nv.HinhAnh;
                _nv.MaBP = nv.MaBP;
                _nv.MaPB = nv.MaPB;
                _nv.MaCV = nv.MaCV;
                _nv.MaTD = nv.MaTD;
                db.SaveChanges();
                return nv;
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
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MaNV == id);
                db.NHANVIENs.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
