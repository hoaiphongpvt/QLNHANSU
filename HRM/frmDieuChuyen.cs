using BusinessLayer;
using DataLayer;
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

namespace HRM
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }

        DieuChuyen dieuchuyen;
        NhanVien nhanvien;
        PhongBan phongban;
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
            txtGhichu.Text = string.Empty;
        }

        void loadData()
        {
            gcDanhSach.DataSource = dieuchuyen.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = nhanvien.getList();
            slkNhanvien.Properties.ValueMember = "MaNV";
            slkNhanvien.Properties.DisplayMember = "HoTen";
        }

        void loadDonViDen()
        {
            cboPB2.DataSource = phongban.getList();
            cboPB2.DisplayMember = "TenPB";
            cboPB2.ValueMember = "MaPB";
        }

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            dieuchuyen = new DieuChuyen();
            nhanvien = new NhanVien();
            phongban = new PhongBan();
            show(true);
            loadData();
            loadNhanvien();
            loadDonViDen();
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
                dieuchuyen.Delete(id);
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
                DIEUCHUYEN dc = new DIEUCHUYEN();
                dc.GhiChu = txtGhichu.Text;
                dc.LyDo = txtLydo.Text;
                dc.Ngay = dtNgay.Value;
                dc.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                dc.MaPB = nhanvien.getItem(int.Parse(slkNhanvien.EditValue.ToString())).MaBP;
                dc.MaPB2 = int.Parse(cboPB2.SelectedValue.ToString());
                dieuchuyen.Add(dc);

            }
            else //ngược lại thì Update
            {
                var dc = dieuchuyen.getItem(id);
                dc.GhiChu = txtGhichu.Text;
                dc.LyDo = txtLydo.Text;
                dc.Ngay = dtNgay.Value;
                dc.MaNV = int.Parse(slkNhanvien.EditValue.ToString());
                dc.MaPB = nhanvien.getItem(int.Parse(slkNhanvien.EditValue.ToString())).MaBP;
                dc.MaPB2 = int.Parse(cboPB2.SelectedValue.ToString());
                dieuchuyen.Update(dc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaDC").ToString());
                var _dc = dieuchuyen.getItem(id);
                slkNhanvien.EditValue = _dc.MaNV;
                txtGhichu.Text = _dc.GhiChu;
                txtLydo.Text = _dc.LyDo;
                dtNgay.Value = _dc.Ngay.Value;
                cboPB2.SelectedValue = _dc.MaPB2;
            }
        }
    }
}