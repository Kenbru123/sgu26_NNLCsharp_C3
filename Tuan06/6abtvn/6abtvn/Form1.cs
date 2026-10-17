using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace _6abtvn
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
            {
                conn.Open();
            }
        }

        private void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (Inputmakhoa.Text.Trim() == "" ||
                Inputmalop.Text.Trim() == "" ||
                Inputtenlop.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã khoa, mã lớp và tên lớp không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "INSERT INTO Lop(MaLop, TenLop, MaKhoa) " +
                    "VALUES(@MaLop, @TenLop, @MaKhoa)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaLop",
                    Inputmalop.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@TenLop",
                    Inputtenlop.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@MaKhoa",
                    Inputmakhoa.Text.Trim()
                );

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Thêm lớp thành công!"
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
            if (Inputmalop.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã lớp cần xóa!"
                );

                Inputmalop.Focus();
                return;
            }

            // Theo đề: khi xóa chỉ nhập Mã lớp
            if (Inputmakhoa.Text.Trim() != "" ||
                Inputtenlop.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa chỉ nhập Mã lớp!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp này không?",
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
                    "DELETE FROM Lop " +
                    "WHERE MaLop = @MaLop";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaLop",
                    Inputmalop.Text.Trim()
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Xóa lớp thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy mã lớp!"
                    );
                }

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
            if (Inputmalop.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã lớp không được để trống!"
                );

                Inputmalop.Focus();
                return;
            }

            if (Inputmakhoa.Text.Trim() == "" &&
                Inputtenlop.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Phải nhập ít nhất Mã khoa hoặc Tên lớp cần sửa!"
                );

                return;
            }

            try
            {
                MoKetNoi();

                string sql = "UPDATE Lop SET ";

                bool daCoCot = false;

                if (Inputmakhoa.Text.Trim() != "")
                {
                    sql += "MaKhoa = @MaKhoa";
                    daCoCot = true;
                }

                if (Inputtenlop.Text.Trim() != "")
                {
                    if (daCoCot)
                    {
                        sql += ", ";
                    }

                    sql += "TenLop = @TenLop";
                }

                sql += " WHERE MaLop = @MaLop";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaLop",
                    Inputmalop.Text.Trim()
                );

                if (Inputmakhoa.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@MaKhoa",
                        Inputmakhoa.Text.Trim()
                    );
                }

                if (Inputtenlop.Text.Trim() != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@TenLop",
                        Inputtenlop.Text.Trim()
                    );
                }

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Sửa lớp thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy mã lớp!"
                    );
                }

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
            Inputmakhoa.Clear();
            Inputmalop.Clear();
            Inputtenlop.Clear();

            Inputmakhoa.Focus();
        }
    }
}
