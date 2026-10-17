using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace _6bbaitaptailop2
{
    public partial class Form1 : Form
    {
        string chuoiKetNoi =
            @"Data Source=THANHDAI;
              Initial Catalog=QLSinhVien;
              Integrated Security=True;
              TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
            LoadMonHoc();
        }

        // load sinh viên
        private void LoadSinhVien()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaSinhVien FROM SinhVien";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        comboBox_sv.Items.Clear();

                        while (rd.Read())
                        {
                            comboBox_sv.Items.Add(
                                rd["MaSinhVien"].ToString()
                            );
                        }
                    }
                }

                comboBox_sv.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải sinh viên: " + ex.Message
                );
            }
        }

        //load môn học
        private void LoadMonHoc()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaMonHoc FROM MonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        comboBox_mh.Items.Clear();

                        while (rd.Read())
                        {
                            comboBox_mh.Items.Add(
                                rd["MaMonHoc"].ToString()
                            );
                        }
                    }
                }

                comboBox_mh.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải môn học: " + ex.Message
                );
            }
        }

        // kiểm tra xem sinh viên tồn tại
        private bool KiemTraSinhVien(string maSV)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql =
                    "SELECT COUNT(*) FROM SinhVien " +
                    "WHERE MaSinhVien = @MaSV";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // kiểm tra môn học tồn tại
        private bool KiemTraMonHoc(string maMH)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql =
                    "SELECT COUNT(*) FROM MonHoc " +
                    "WHERE MaMonHoc = @MaMH";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMH", maMH);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // kiểm tra điểm tồn tại
        private bool KiemTraDiem(string maSV, string maMH)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql =
                    "SELECT COUNT(*) FROM Diem " +
                    "WHERE MaSinhVien = @MaSV " +
                    "AND MaMonHoc = @MaMH";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@MaMH", maMH);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // kiểm tra dữ liệu
        private bool KiemTraDuLieu(out decimal diem)
        {
            diem = 0;

            if (comboBox_sv.SelectedIndex == -1 ||
                comboBox_mh.SelectedIndex == -1 ||
                Inputdiem.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!"
                );
                return false;
            }

            string chuoiDiem = Inputdiem.Text.Trim()
                .Replace(',', '.');

            if (!decimal.TryParse(
                chuoiDiem,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out diem))
            {
                MessageBox.Show(
                    "Điểm phải là số!"
                );
                Inputdiem.Focus();
                return false;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show(
                    "Điểm phải từ 0 đến 10!"
                );
                Inputdiem.Focus();
                return false;
            }

            return true;
        }

        //button thêm
        private void button_them_Click(object sender, EventArgs e)
        {
            decimal diem;

            if (!KiemTraDuLieu(out diem))
                return;

            string maSV = comboBox_sv.Text;
            string maMH = comboBox_mh.Text;

            try
            {
                if (!KiemTraSinhVien(maSV))
                {
                    MessageBox.Show(
                        "Mã sinh viên không tồn tại!"
                    );
                    return;
                }

                if (!KiemTraMonHoc(maMH))
                {
                    MessageBox.Show(
                        "Mã môn học không tồn tại!"
                    );
                    return;
                }

                if (KiemTraDiem(maSV, maMH))
                {
                    MessageBox.Show(
                        "Sinh viên đã có điểm môn học này!"
                    );
                    return;
                }

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "INSERT INTO Diem " +
                        "(MaSinhVien, MaMonHoc, Diem) " +
                        "VALUES (@MaSV, @MaMH, @Diem)";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm điểm thành công!"
                );

                XoaDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm thất bại!\n" + ex.Message
                );
            }
        }

        //button xóa
        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_sv.SelectedIndex == -1 ||
                comboBox_mh.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên và môn học!"
                );
                return;
            }

            string maSV = comboBox_sv.Text;
            string maMH = comboBox_mh.Text;

            try
            {
                if (!KiemTraSinhVien(maSV) ||
                    !KiemTraMonHoc(maMH))
                {
                    MessageBox.Show(
                        "Sinh viên hoặc môn học không tồn tại!"
                    );
                    return;
                }

                if (!KiemTraDiem(maSV, maMH))
                {
                    MessageBox.Show(
                        "Không tìm thấy điểm cần xóa!"
                    );
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "Bạn có chắc muốn xóa điểm này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (r == DialogResult.No)
                    return;

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "DELETE FROM Diem " +
                        "WHERE MaSinhVien = @MaSV " +
                        "AND MaMonHoc = @MaMH";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show(
                                "Xóa điểm thành công!"
                            );
                            XoaDuLieu();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy điểm!"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Xóa thất bại!\n" + ex.Message
                );
            }
        }

        //button sửa
        private void button_sua_Click(object sender, EventArgs e)
        {
            decimal diem;

            if (!KiemTraDuLieu(out diem))
                return;

            string maSV = comboBox_sv.Text;
            string maMH = comboBox_mh.Text;

            try
            {
                if (!KiemTraSinhVien(maSV) ||
                    !KiemTraMonHoc(maMH))
                {
                    MessageBox.Show(
                        "Sinh viên hoặc môn học không tồn tại!"
                    );
                    return;
                }

                if (!KiemTraDiem(maSV, maMH))
                {
                    MessageBox.Show(
                        "Không tìm thấy điểm cần sửa!"
                    );
                    return;
                }

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "UPDATE Diem SET Diem = @Diem " +
                        "WHERE MaSinhVien = @MaSV " +
                        "AND MaMonHoc = @MaMH";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show(
                                "Sửa điểm thành công!"
                            );
                            XoaDuLieu();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy điểm!"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Sửa thất bại!\n" + ex.Message
                );
            }
        }

        private void XoaDuLieu()
        {
            comboBox_sv.SelectedIndex = -1;
            comboBox_mh.SelectedIndex = -1;
            Inputdiem.Clear();
        }
    }
}
