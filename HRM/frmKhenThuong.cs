using BusinessLayer;
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

namespace HRM
{
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        KhenThuong_KiLuat ktkl;
        NhanVien nhanvien;
        int id;

        void show(bool kt)
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
            dtNgay.Value = DateTime.Now;
            txtLydo.Text = string.Empty;
            txtNoidung.Text = string.Empty;

        }

        void loadData()
        {
            gcDanhSach.DataSource = ktkl.getListFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = nhanvien.getList();
            slkNhanvien.Properties.ValueMember = "MaNV";
            slkNhanvien.Properties.DisplayMember = "HoTen";
        }

        private void KhenThuong_Load(object sender, EventArgs e)
        {
            ktkl = new KhenThuong_KiLuat();
            nhanvien = new NhanVien();
            show(true);
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
                ktkl.Delete(id);
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
                KHENTHUONGKILUAT kt = new KHENTHUONGKILUAT();
                kt.NoiDung = txtNoidung.Text;
                kt.LyDo = txtLydo.Text;
                kt.Ngay = dtNgay.Value;
                kt.Loai = 1;
                kt.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                ktkl.Add(kt);

            }
            else //ngược lại thì Update
            {
                var kt = ktkl.getItem(id);
                kt.NoiDung = txtNoidung.Text;
                kt.LyDo = txtLydo.Text;
                kt.Ngay = dtNgay.Value;
                kt.Loai = 1;
                kt.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                ktkl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaKTKL").ToString());
                var kt = ktkl.getItem(id);
                slkNhanvien.EditValue = kt.MaNV;
                txtMaktkl.Text = kt.MaKTKL.ToString();
                txtNoidung.Text = kt.NoiDung;
                txtLydo.Text = kt.LyDo;
                dtNgay.Value = kt.Ngay.Value;
            }
        }

    }
}