
using System;
using System.Data;
using System.Data.SqlClient;

namespace Lab09_DataReaderSearch.DAL
{
    public class SinhVienDAL
    {
        // Đọc danh sách sinh viên và tên khoa
        public DataTable LayDanhSachSinhVien()
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT 
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh,
                    CASE 
                        WHEN sv.GioiTinh = 1 THEN N'Nam'
                        ELSE N'Nữ'
                    END AS GioiTinh,
                    k.TenKhoa,
                    sv.DiemTB,
                    sv.Email
                FROM SinhVien sv
                INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
                ORDER BY sv.MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
        public DataTable TimKiemSinhVien(string tuKhoa)
        {
            DataTable dt = new DataTable();

            string sql = @"
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            CASE
                WHEN sv.GioiTinh = 1 THEN N'Nam'
                ELSE N'Nữ'
            END AS GioiTinh,
            k.TenKhoa,
            sv.DiemTB,
            sv.Email
        FROM SinhVien sv
        INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
        WHERE sv.MaSV LIKE @TuKhoa
           OR sv.HoTen LIKE @TuKhoa
        ORDER BY sv.MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value =
                    "%" + tuKhoa + "%";

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public DataTable LocTheoGioiTinh(string gioiTinh)
        {
            DataTable dt = new DataTable();

            string sql = @"
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            CASE
                WHEN sv.GioiTinh = 1 THEN N'Nam'
                ELSE N'Nữ'
            END AS GioiTinh,
            k.TenKhoa,
            sv.DiemTB,
            sv.Email
        FROM SinhVien sv
        INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
        WHERE (@GioiTinh = 'TatCa')
           OR (sv.GioiTinh = CASE
                WHEN @GioiTinh = 'Nam' THEN 1
                ELSE 0
              END)
        ORDER BY sv.MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = gioiTinh;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public DataTable LocTheoKhoa(string maKhoa)
        {
            DataTable dt = new DataTable();

            string sql = @"
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            CASE
                WHEN sv.GioiTinh = 1 THEN N'Nam'
                ELSE N'Nữ'
            END AS GioiTinh,
            k.TenKhoa,
            sv.DiemTB,
            sv.Email
        FROM SinhVien sv
        INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
        WHERE (@MaKhoa = 'TatCa' OR sv.MaKhoa = @MaKhoa)
        ORDER BY sv.MaSV";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = maKhoa;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public DataTable LayDanhSachKhoa()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public DataTable LaySinhVienPhanTrang(int trang, int soDong)
        {
            DataTable dt = new DataTable();

            string sql = @"
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            CASE
                WHEN sv.GioiTinh = 1 THEN N'Nam'
                ELSE N'Nữ'
            END AS GioiTinh,
            k.TenKhoa,
            sv.DiemTB,
            sv.Email
        FROM SinhVien sv
        INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
        ORDER BY sv.MaSV
        OFFSET @Offset ROWS
        FETCH NEXT @PageSize ROWS ONLY";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Offset", SqlDbType.Int).Value =
                    (trang - 1) * soDong;

                cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = soDong;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public int DemTongSoSinhVien()
        {
            string sql = "SELECT COUNT(*) FROM SinhVien";

            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable TimKiemLocPhanTrang(
            string tuKhoa,
            string gioiTinh,
            string maKhoa,
            decimal diemMin,
            decimal diemMax,
            int trang,
            int soDong,
            out int tongSoDong)
        {
            DataTable dt = new DataTable();
            tongSoDong = 0;

            string dieuKien = @"
        WHERE (sv.MaSV LIKE @TuKhoa OR sv.HoTen LIKE @TuKhoa)
          AND (@GioiTinh = 'TatCa'
               OR sv.GioiTinh = CASE
                    WHEN @GioiTinh = 'Nam' THEN 1
                    ELSE 0
               END)
          AND (@MaKhoa = 'TatCa' OR sv.MaKhoa = @MaKhoa)
          AND sv.DiemTB BETWEEN @DiemMin AND @DiemMax";

            string sqlDem = "SELECT COUNT(*) FROM SinhVien sv " +
                            dieuKien;

            string sql = @"
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            CASE
                WHEN sv.GioiTinh = 1 THEN N'Nam'
                ELSE N'Nữ'
            END AS GioiTinh,
            k.TenKhoa,
            sv.DiemTB,
            sv.Email
        FROM SinhVien sv
        INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa "
                + dieuKien + @"
        ORDER BY sv.MaSV
        OFFSET @Offset ROWS
        FETCH NEXT @PageSize ROWS ONLY";

            using (SqlConnection conn = DbConnectionFactory.Create())
            {
                conn.Open();

                using (SqlCommand cmdDem = new SqlCommand(sqlDem, conn))
                {
                    cmdDem.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value =
                        "%" + tuKhoa + "%";

                    cmdDem.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value =
                        gioiTinh;

                    cmdDem.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value =
                        maKhoa;

                    cmdDem.Parameters.Add("@DiemMin", SqlDbType.Decimal).Value =
                        diemMin;

                    cmdDem.Parameters.Add("@DiemMax", SqlDbType.Decimal).Value =
                        diemMax;

                    tongSoDong = (int)cmdDem.ExecuteScalar();
                }

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value =
                        "%" + tuKhoa + "%";

                    cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value =
                        gioiTinh;

                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value =
                        maKhoa;

                    cmd.Parameters.Add("@DiemMin", SqlDbType.Decimal).Value =
                        diemMin;

                    cmd.Parameters.Add("@DiemMax", SqlDbType.Decimal).Value =
                        diemMax;

                    cmd.Parameters.Add("@Offset", SqlDbType.Int).Value =
                        (trang - 1) * soDong;

                    cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value =
                        soDong;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

    }
}
