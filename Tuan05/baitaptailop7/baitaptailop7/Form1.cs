using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace baitaptailop7
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
            if (Inputma.Text.Trim() == "" ||
                Inputten.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã môn học và tên môn học không được để trống!"
                );

                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "INSERT INTO MonHoc(MaMonHoc, TenMonHoc) " +
                    "VALUES(@MaMH, @TenMH)";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputma.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@TenMH",
                    Inputten.Text.Trim()
                );

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Thêm môn học thành công!"
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
            if (Inputma.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã môn học cần xóa!"
                );

                Inputma.Focus();
                return;
            }

            // Theo đề: khi xóa không nhập tên môn học
            if (Inputten.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa chỉ nhập mã môn học!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa môn học này không?",
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
                    "DELETE FROM MonHoc " +
                    "WHERE MaMonHoc = @MaMH";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputma.Text.Trim()
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Xóa môn học thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy mã môn học!"
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
            if (Inputma.Text.Trim() == "" ||
                Inputten.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã môn học và tên môn học không được để trống!"
                );

                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "UPDATE MonHoc " +
                    "SET TenMonHoc = @TenMH " +
                    "WHERE MaMonHoc = @MaMH";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputma.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@TenMH",
                    Inputten.Text.Trim()
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Sửa môn học thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy mã môn học!"
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
            Inputma.Clear();
            Inputten.Clear();

            Inputma.Focus();
        }
    }
}
