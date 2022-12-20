namespace HRM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTrinhdo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongban = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopdong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenthuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiviec = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaica = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaicong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangca = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngluong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangcong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangluong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoidulieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnBophan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucvu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKiluat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTrinhdo,
            this.btnNhanvien,
            this.btnPhongban,
            this.btnHopdong,
            this.btnKhenthuong,
            this.btnThoiviec,
            this.btnLoaica,
            this.btnLoaicong,
            this.btnPhucap,
            this.btnTangca,
            this.btnUngluong,
            this.btnBangcong,
            this.btnBangluong,
            this.btnDoimatkhau,
            this.btnPhuchoidulieu,
            this.btnSaoluu,
            this.btnThoat,
            this.btnBophan,
            this.btnChucvu,
            this.btnKiluat,
            this.btnDieuChuyen});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1194, 193);
            // 
            // btnTrinhdo
            // 
            this.btnTrinhdo.Caption = "Trình độ";
            this.btnTrinhdo.Id = 1;
            this.btnTrinhdo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrinhdo.ImageOptions.Image")));
            this.btnTrinhdo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrinhdo.ImageOptions.LargeImage")));
            this.btnTrinhdo.Name = "btnTrinhdo";
            this.btnTrinhdo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhdo_ItemClick);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Nhân viên";
            this.btnNhanvien.Id = 2;
            this.btnNhanvien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanvien.ImageOptions.SvgImage")));
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanvien_ItemClick);
            // 
            // btnPhongban
            // 
            this.btnPhongban.Caption = "Phòng ban";
            this.btnPhongban.Id = 3;
            this.btnPhongban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongban.ImageOptions.Image")));
            this.btnPhongban.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhongban.ImageOptions.LargeImage")));
            this.btnPhongban.Name = "btnPhongban";
            this.btnPhongban.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongban_ItemClick);
            // 
            // btnHopdong
            // 
            this.btnHopdong.Caption = "Hợp đồng";
            this.btnHopdong.Id = 4;
            this.btnHopdong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHopdong.ImageOptions.Image")));
            this.btnHopdong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHopdong.ImageOptions.LargeImage")));
            this.btnHopdong.Name = "btnHopdong";
            this.btnHopdong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHopdong_ItemClick);
            // 
            // btnKhenthuong
            // 
            this.btnKhenthuong.Caption = "Khen thưởng";
            this.btnKhenthuong.Id = 5;
            this.btnKhenthuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhenthuong.ImageOptions.Image")));
            this.btnKhenthuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhenthuong.ImageOptions.LargeImage")));
            this.btnKhenthuong.Name = "btnKhenthuong";
            this.btnKhenthuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenthuong_ItemClick);
            // 
            // btnThoiviec
            // 
            this.btnThoiviec.Caption = "Thôi việc";
            this.btnThoiviec.Id = 6;
            this.btnThoiviec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoiviec.ImageOptions.Image")));
            this.btnThoiviec.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoiviec.ImageOptions.LargeImage")));
            this.btnThoiviec.Name = "btnThoiviec";
            // 
            // btnLoaica
            // 
            this.btnLoaica.Caption = "Loại ca";
            this.btnLoaica.Id = 7;
            this.btnLoaica.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaica.ImageOptions.SvgImage")));
            this.btnLoaica.Name = "btnLoaica";
            // 
            // btnLoaicong
            // 
            this.btnLoaicong.Caption = "Loại công";
            this.btnLoaicong.Id = 8;
            this.btnLoaicong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaicong.ImageOptions.SvgImage")));
            this.btnLoaicong.Name = "btnLoaicong";
            // 
            // btnPhucap
            // 
            this.btnPhucap.Caption = "Phụ cấp";
            this.btnPhucap.Id = 9;
            this.btnPhucap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucap.ImageOptions.Image")));
            this.btnPhucap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucap.ImageOptions.LargeImage")));
            this.btnPhucap.Name = "btnPhucap";
            // 
            // btnTangca
            // 
            this.btnTangca.Caption = "Tăng ca";
            this.btnTangca.Id = 10;
            this.btnTangca.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTangca.ImageOptions.Image")));
            this.btnTangca.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTangca.ImageOptions.LargeImage")));
            this.btnTangca.Name = "btnTangca";
            // 
            // btnUngluong
            // 
            this.btnUngluong.Caption = "Ứng lương";
            this.btnUngluong.Id = 11;
            this.btnUngluong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUngluong.ImageOptions.Image")));
            this.btnUngluong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUngluong.ImageOptions.LargeImage")));
            this.btnUngluong.Name = "btnUngluong";
            // 
            // btnBangcong
            // 
            this.btnBangcong.Caption = "Bảng công";
            this.btnBangcong.Id = 12;
            this.btnBangcong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangcong.ImageOptions.Image")));
            this.btnBangcong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangcong.ImageOptions.LargeImage")));
            this.btnBangcong.Name = "btnBangcong";
            // 
            // btnBangluong
            // 
            this.btnBangluong.Caption = "Bảng lương";
            this.btnBangluong.Id = 13;
            this.btnBangluong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangluong.ImageOptions.Image")));
            this.btnBangluong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangluong.ImageOptions.LargeImage")));
            this.btnBangluong.Name = "btnBangluong";
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Caption = "Đổi mật khẩu";
            this.btnDoimatkhau.Id = 14;
            this.btnDoimatkhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoimatkhau.ImageOptions.SvgImage")));
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            // 
            // btnPhuchoidulieu
            // 
            this.btnPhuchoidulieu.Caption = "Phục hồi dữ liệu";
            this.btnPhuchoidulieu.Id = 15;
            this.btnPhuchoidulieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuchoidulieu.ImageOptions.SvgImage")));
            this.btnPhuchoidulieu.Name = "btnPhuchoidulieu";
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.Caption = "Sao lưu dữ liệu";
            this.btnSaoluu.Id = 16;
            this.btnSaoluu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoluu.ImageOptions.SvgImage")));
            this.btnSaoluu.Name = "btnSaoluu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 17;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // btnBophan
            // 
            this.btnBophan.Caption = "Bộ phận";
            this.btnBophan.Id = 18;
            this.btnBophan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBophan.ImageOptions.SvgImage")));
            this.btnBophan.Name = "btnBophan";
            this.btnBophan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBophan_ItemClick);
            // 
            // btnChucvu
            // 
            this.btnChucvu.Caption = "Chức vụ";
            this.btnChucvu.Id = 19;
            this.btnChucvu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucvu.ImageOptions.SvgImage")));
            this.btnChucvu.Name = "btnChucvu";
            this.btnChucvu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucvu_ItemClick);
            // 
            // btnKiluat
            // 
            this.btnKiluat.Caption = "Kỉ luật";
            this.btnKiluat.Id = 20;
            this.btnKiluat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKiluat.ImageOptions.Image")));
            this.btnKiluat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKiluat.ImageOptions.LargeImage")));
            this.btnKiluat.Name = "btnKiluat";
            this.btnKiluat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKiluat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoimatkhau, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhuchoidulieu, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaoluu, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhdo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanvien, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongban, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBophan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucvu, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHopdong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhenthuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKiluat, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoiviec, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDieuChuyen, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp vụ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm công";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaica, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaicong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhucap, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTangca, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUngluong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangcong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangluong, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý chấm công";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều chuyển";
            this.btnDieuChuyen.Id = 21;
            this.btnDieuChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuChuyen.ImageOptions.Image")));
            this.btnDieuChuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDieuChuyen.ImageOptions.LargeImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDieuChuyen_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 733);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phầm mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTrinhdo;
        private DevExpress.XtraBars.BarButtonItem btnNhanvien;
        private DevExpress.XtraBars.BarButtonItem btnPhongban;
        private DevExpress.XtraBars.BarButtonItem btnHopdong;
        private DevExpress.XtraBars.BarButtonItem btnKhenthuong;
        private DevExpress.XtraBars.BarButtonItem btnThoiviec;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnLoaica;
        private DevExpress.XtraBars.BarButtonItem btnLoaicong;
        private DevExpress.XtraBars.BarButtonItem btnPhucap;
        private DevExpress.XtraBars.BarButtonItem btnTangca;
        private DevExpress.XtraBars.BarButtonItem btnUngluong;
        private DevExpress.XtraBars.BarButtonItem btnBangcong;
        private DevExpress.XtraBars.BarButtonItem btnBangluong;
        private DevExpress.XtraBars.BarButtonItem btnDoimatkhau;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoidulieu;
        private DevExpress.XtraBars.BarButtonItem btnSaoluu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnBophan;
        private DevExpress.XtraBars.BarButtonItem btnChucvu;
        private DevExpress.XtraBars.BarButtonItem btnKiluat;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
    }
}

