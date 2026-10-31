using Lab09_DataReaderSearch.DAL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;



namespace Lab09_DataReaderSearch.GUI
{

    public partial class frmLab9 : Form
    {
        private int trangHienTai = 1;
        private int soDongMoiTrang = 10;
        private void TaiDanhSachSinhVien()
        {
            try
            {
                DataTable dt = sinhVienDAL.LayDanhSachSinhVien();

                dgvSinhVien.DataSource = dt;

                // Đặt tên các cột hiển thị
                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã sinh viên";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa";
                dgvSinhVien.Columns["DiemTB"].HeaderText = "Điểm trung bình";
                dgvSinhVien.Columns["Email"].HeaderText = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách sinh viên: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private SinhVienDAL sinhVienDAL = new SinhVienDAL();
        public frmLab9()
        {
            InitializeComponent();

            TaiDanhSachSinhVien();
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Tất cả");
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            cboGioiTinh.SelectedIndex = 0;
            TaiDanhSachKhoa();

        }
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.Create())
                {
                    conn.Open();

                    MessageBox.Show(
                        "Kết nối SQL Server thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {
            // Khong xu ly gi
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            trangHienTai = 1;
            TaiDuLieuTheoDieuKien();
        }
        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangHienTai = 1;

            if (cboGioiTinh.SelectedIndex >= 0)
                TaiDuLieuTheoDieuKien();
        }
        private void TaiDanhSachKhoa()
        {
            DataTable dt = sinhVienDAL.LayDanhSachKhoa();

            DataRow row = dt.NewRow();
            row["MaKhoa"] = "TatCa";
            row["TenKhoa"] = "Tất cả khoa";
            dt.Rows.InsertAt(row, 0);

            cboKhoa.DataSource = dt;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = 0;
        }
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null ||
                cboKhoa.SelectedValue is DataRowView)
                return;

            trangHienTai = 1;
            TaiDuLieuTheoDieuKien();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa từ khóa tìm kiếm
                txtTuKhoa.Clear();

                // Đưa giới tính về Tất cả
                cboGioiTinh.SelectedIndex = 0;

                // Đưa khoa về Tất cả
                cboKhoa.SelectedIndex = 0;

                // Đưa điểm về khoảng 0 đến 10
                txtDiemTu.Text = "0";
                txtDiemDen.Text = "10";

                // Quay về trang đầu
                trangHienTai = 1;

                // Tải lại danh sách
                TaiDuLieuTheoDieuKien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message);
            }
        }
        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null ||
                dgvSinhVien.CurrentRow.IsNewRow)
                return;

            try
            {
                txtMaSV.Text = dgvSinhVien.CurrentRow.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = dgvSinhVien.CurrentRow.Cells["HoTen"].Value?.ToString();
                txtGioiTinh.Text = dgvSinhVien.CurrentRow.Cells["GioiTinh"].Value?.ToString();
                txtDiemTB.Text = dgvSinhVien.CurrentRow.Cells["DiemTB"].Value?.ToString();
                txtEmail.Text = dgvSinhVien.CurrentRow.Cells["Email"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message);
            }
        }
        private void TaiDuLieuPhanTrang()
        {
            dgvSinhVien.DataSource =
                sinhVienDAL.LaySinhVienPhanTrang(trangHienTai, soDongMoiTrang);

            lblTrang.Text = "Trang " + trangHienTai;
        }
        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            trangHienTai++;
            TaiDuLieuTheoDieuKien();
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                TaiDuLieuTheoDieuKien();
            }
        }
        private void txtDiemTu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaiDuLieuTheoDieuKien()
        {
            try
            {
                string tuKhoa = txtTuKhoa.Text.Trim();

                string gioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Tất cả";

                if (gioiTinh == "Tất cả")
                    gioiTinh = "TatCa";

                string maKhoa = cboKhoa.SelectedValue?.ToString() ?? "TatCa";

                decimal diemMin = 0;
                decimal diemMax = 10;

                if (!decimal.TryParse(txtDiemTu.Text, out diemMin) ||
                    !decimal.TryParse(txtDiemDen.Text, out diemMax))
                {
                    MessageBox.Show("Điểm phải là số hợp lệ!");
                    return;
                }

                if (diemMin < 0 || diemMax > 10 || diemMin > diemMax)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10 và điểm từ không được lớn hơn điểm đến!");
                    return;
                }

                int tongSoDong;

                DataTable dt = sinhVienDAL.TimKiemLocPhanTrang(
                    tuKhoa,
                    gioiTinh,
                    maKhoa,
                    diemMin,
                    diemMax,
                    trangHienTai,
                    soDongMoiTrang,
                    out tongSoDong
                );

                int tongSoTrang = Math.Max(
                    1,
                    (int)Math.Ceiling((double)tongSoDong / soDongMoiTrang)
                );

                // Nếu trang hiện tại vượt quá trang cuối thì quay về trang cuối
                if (trangHienTai > tongSoTrang)
                {
                    trangHienTai = tongSoTrang;

                    dt = sinhVienDAL.TimKiemLocPhanTrang(
                        tuKhoa,
                        gioiTinh,
                        maKhoa,
                        diemMin,
                        diemMax,
                        trangHienTai,
                        soDongMoiTrang,
                        out tongSoDong
                    );
                }

                dgvSinhVien.DataSource = dt;

                lblTrang.Text = "Trang " + trangHienTai + " / " + tongSoTrang;

                if (dt.Rows.Count > 0)
                    dgvSinhVien_SelectionChanged(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message);
            }
        }

    }
}