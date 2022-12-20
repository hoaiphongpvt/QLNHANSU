using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace HRM
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        HopDong hopdong;
        NhanVien nhanvien;
        int id;

        private void show(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
        }

        private void reset()
        {
            dtNgaybatdau.Value = DateTime.Now;
            dtNgayketthuc.Value = dtNgaybatdau.Value.AddMonths(6); //them 6 thang
            dtNgayki.Value = DateTime.Now;
            spHesoluong.Text = "1";
            
        }

        private void loadData()
        {
            gcDanhSach.DataSource = hopdong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = nhanvien.getList();
            slkNhanvien.Properties.ValueMember = "MaNV";
            slkNhanvien.Properties.DisplayMember = "HoTen";
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            hopdong = new HopDong();
            nhanvien = new NhanVien();
            loadData();
            loadNhanvien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnThem.Enabled = true;
            reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnSua.Enabled = true;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                hopdong.Delete(id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            show(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {

            

            if (btnThem.Enabled) //nếu btnThem bật thì thêm
            {
                HOPDONG hd = new HOPDONG();
                hd.HeSoLuong = float.Parse(spHesoluong.EditValue.ToString());
                hd.NgayBD = dtNgaybatdau.Value;
                hd.NgayKT = dtNgayketthuc.Value;
                hd.NgayKi = dtNgayki.Value;
                hd.ThoiHan = cboThoihan.Text;
                hd.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                hd.NoiDung = txtNoidung.RtfText;
                hopdong.Add(hd);
            }
            else //ngược lại thì Update
            {
                var hd = hopdong.getItem(id);
                hd.HeSoLuong = float.Parse(spHesoluong.EditValue.ToString());
                hd.NgayBD = dtNgaybatdau.Value;
                hd.NgayKT = dtNgayketthuc.Value;
                hd.NgayKi = dtNgayki.Value;
                hd.ThoiHan = cboThoihan.Text;
                hd.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                hd.NoiDung = txtNoidung.RtfText;
                hopdong.Update(hd);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                splitContainer1.Panel1Collapsed = false;
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaHD").ToString());
                var hd = hopdong.getItem(id);
                spHesoluong.Text = hd.HeSoLuong.ToString();
                dtNgaybatdau.Value = hd.NgayBD.Value;
                dtNgayketthuc.Value =  hd.NgayKT.Value;
                dtNgayki.Value = hd.NgayKi.Value;
                cboThoihan.Text = hd.ThoiHan;
                txtNoidung.RtfText = hd.NoiDung;
                slkNhanvien.EditValue = hd.MaNV;

            }
        }
    }
}