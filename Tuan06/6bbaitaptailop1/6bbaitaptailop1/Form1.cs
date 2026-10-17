using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace _6bbaitaptailop1
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
            LoadLop();

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            Inputmasv.Focus();
        }

        private void LoadLop()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql = "SELECT MaLop FROM Lop";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        comboBox_Lop.Items.Clear();

                        while (rd.Read())
                        {
                            comboBox_Lop.Items.Add(
                                rd["MaLop"].ToString()
                            );
                        }
                    }
                }

                if (comboBox_Lop.Items.Count > 0)
                    comboBox_Lop.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải lớp: " + ex.Message
                );
            }
        }

        // Kiểm tra mã sinh viên
        private bool KiemTraMaSV(string maSV)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql =
                    "SELECT MaSinhVien FROM SinhVien " +
                    "WHERE MaSinhVien = @MaSV";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);

                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        return rd.HasRows;
                    }
                }
            }
        }

        // Kiểm tra mã lớp
        private bool KiemTraMaLop(string maLop)
        {
            using (SqlConnection conn =
                new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                string sql =
                    "SELECT MaLop FROM Lop " +
                    "WHERE MaLop = @MaLop";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        return rd.HasRows;
                    }
                }
            }
        }

        // button thêm
        private void button_them_Click(object sender, EventArgs e)
        {
            string maSV = Inputmasv.Text.Trim();
            string hoTen = Inputhoten.Text.Trim();
            string maLop = comboBox_Lop.Text;
            DateTime ngaySinh = dtpNgaySinh.Value.Date;

            if (maSV == "" || hoTen == "" || maLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!"
                );
                return;
            }

            // Tuổi chỉ tính theo năm sinh
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (tuoi < 17)
            {
                MessageBox.Show(
                    "Sinh viên phải từ 17 tuổi trở lên!"
                );
                return;
            }

            try
            {
                if (KiemTraMaSV(maSV))
                {
                    MessageBox.Show(
                        "Mã sinh viên đã tồn tại!"
                    );
                    Inputmasv.Focus();
                    return;
                }

                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show(
                        "Mã lớp không tồn tại!"
                    );
                    return;
                }

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "INSERT INTO SinhVien " +
                        "(MaSinhVien, HoTen, NgaySinh, MaLop) " +
                        "VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Thêm sinh viên thành công!"
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

        // button xóa
        private void button_xoa_Click(object sender, EventArgs e)
        {
            string maSV = Inputmasv.Text.Trim();

            if (maSV == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên cần xóa!"
                );
                Inputmasv.Focus();
                return;
            }

            try
            {
                if (!KiemTraMaSV(maSV))
                {
                    MessageBox.Show(
                        "Mã sinh viên không tồn tại!"
                    );
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên này?",
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
                        "DELETE FROM SinhVien " +
                        "WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show(
                                "Xóa sinh viên thành công!"
                            );
                            XoaDuLieu();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên!"
                            );
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể xóa vì sinh viên đang " +
                    "được tham chiếu ở bảng khác!"
                );
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
            string maSV = Inputmasv.Text.Trim();
            string hoTen = Inputhoten.Text.Trim();
            string maLop = comboBox_Lop.Text;
            DateTime ngaySinh = dtpNgaySinh.Value.Date;

            if (maSV == "" || hoTen == "" || maLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!"
                );
                return;
            }

            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (tuoi < 17)
            {
                MessageBox.Show(
                    "Sinh viên phải từ 17 tuổi trở lên!"
                );
                return;
            }

            try
            {
                if (!KiemTraMaSV(maSV))
                {
                    MessageBox.Show(
                        "Mã sinh viên không tồn tại!"
                    );
                    return;
                }

                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show(
                        "Mã lớp không tồn tại!"
                    );
                    return;
                }

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "UPDATE SinhVien SET " +
                        "HoTen = @HoTen, " +
                        "NgaySinh = @NgaySinh, " +
                        "MaLop = @MaLop " +
                        "WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show(
                                "Sửa sinh viên thành công!"
                            );
                            XoaDuLieu();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên!"
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

        // xóa dữ liệu trên form
        private void XoaDuLieu()
        {
            Inputmasv.Clear();
            Inputhoten.Clear();

            dtpNgaySinh.Value = DateTime.Today;

            if (comboBox_Lop.Items.Count > 0)
                comboBox_Lop.SelectedIndex = 0;

            Inputmasv.Focus();
        }
    }
}
