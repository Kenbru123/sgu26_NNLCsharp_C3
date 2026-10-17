using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace _6abaitapnangcao1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(
                @"Data Source=THANHDAI;
                  Initial Catalog=QLSinhVien;
                  Integrated Security=True;
                  TrustServerCertificate=True"
            );
        }

        private void MoKetNoi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (Inputmalop.Text.Trim() == "" ||
                Inputmasv.Text.Trim() == "" ||
                Inputhoten.Text.Trim() == "" ||
                Inputngaysinh.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!"
                );
                return;
            }

            if (!DateTime.TryParse(
                Inputngaysinh.Text,
                out DateTime ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ!"
                );

                Inputngaysinh.Focus();
                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "INSERT INTO SinhVien " +
                    "(MaSinhVien, HoTen, NgaySinh, MaLop) " +
                    "VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@HoTen",
                    Inputhoten.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@NgaySinh",
                    ngaySinh
                );

                cmd.Parameters.AddWithValue(
                    "@MaLop",
                    Inputmalop.Text.Trim()
                );

                cmd.ExecuteNonQuery();

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
            finally
            {
                DongKetNoi();
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (Inputmasv.Text.Trim() == "" ||
                Inputhoten.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Khi xóa phải nhập Mã SV và Họ tên!"
                );
                return;
            }

            if (Inputmalop.Text.Trim() != "" ||
                Inputngaysinh.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa chỉ nhập Mã SV và Họ tên!"
                );
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
                return;

            try
            {
                MoKetNoi();

                string sql =
                    "DELETE FROM SinhVien " +
                    "WHERE MaSinhVien = @MaSV " +
                    "AND HoTen = @HoTen";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@HoTen",
                    Inputhoten.Text.Trim()
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show(
                        "Không tìm thấy sinh viên!"
                    );

                XoaDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Xóa thất bại!\n" + ex.Message
                );
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (Inputmasv.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã sinh viên không được để trống!"
                );

                Inputmasv.Focus();
                return;
            }

            if (Inputmalop.Text.Trim() == "" &&
                Inputhoten.Text.Trim() == "" &&
                Inputngaysinh.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Phải nhập ít nhất một thông tin cần sửa!"
                );

                return;
            }

            try
            {
                MoKetNoi();

                // Tạo câu UPDATE theo những ô có nhập
                string sql = "UPDATE SinhVien SET ";

                bool daCoCot = false;

                if (Inputmasv.Text.Trim() != "")
                {
                    sql += "MaLop = @MaLop";
                    daCoCot = true;
                }

                if (Inputhoten.Text.Trim() != "")
                {
                    if (daCoCot)
                        sql += ", ";

                    sql += "HoTen = @HoTen";
                    daCoCot = true;
                }

                DateTime ngaySinh = DateTime.MinValue;

                if (Inputngaysinh.Text.Trim() != "")
                {
                    if (!DateTime.TryParse(
                        Inputngaysinh.Text,
                        out ngaySinh))
                    {
                        MessageBox.Show(
                            "Ngày sinh không hợp lệ!"
                        );

                        return;
                    }

                    if (daCoCot)
                        sql += ", ";

                    sql += "NgaySinh = @NgaySinh";
                }

                sql += " WHERE MaSinhVien = @MaSV";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                if (Inputmalop.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@MaLop",
                        Inputmalop.Text.Trim()
                    );
                }

                if (Inputhoten.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@HoTen",
                        Inputhoten.Text.Trim()
                    );
                }

                if (Inputngaysinh.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@NgaySinh",
                        ngaySinh
                    );
                }

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show(
                        "Không tìm thấy mã sinh viên!"
                    );

                XoaDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Sửa thất bại!\n" + ex.Message
                );
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void XoaDuLieu()
        {
            Inputmalop.Clear();
            Inputmasv.Clear();
            Inputhoten.Clear();
            Inputngaysinh.Clear();

            Inputmalop.Focus();
        }
    }
}
