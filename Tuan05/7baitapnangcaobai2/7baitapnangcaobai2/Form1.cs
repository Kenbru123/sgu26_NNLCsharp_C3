using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace _7baitapnangcaobai2
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
            if (Inputmasv.Text.Trim() == "" ||
                Inputmamh.Text.Trim() == "" ||
                Inputdiem.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Mã sinh viên, mã môn học và điểm không được để trống!"
                );

                return;
            }

            if (!double.TryParse(Inputdiem.Text, out double diem))
            {
                MessageBox.Show(
                    "Điểm phải là số!"
                );

                Inputdiem.Focus();
                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "INSERT INTO Diem(MaSinhVien, MaMonHoc, Diem) " +
                    "VALUES(@MaSV, @MaMH, @Diem)";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputmamh.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@Diem",
                    diem
                );

                cmd.ExecuteNonQuery();

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
            finally
            {
                DongKetNoi();
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (Inputmasv.Text.Trim() == "" ||
                Inputmamh.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Phải nhập Mã sinh viên và Mã môn học!"
                );

                return;
            }

            // Theo đề: khi xóa, ô điểm không nhập
            if (Inputdiem.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa không được nhập Điểm!"
                );

                Inputdiem.Clear();
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa điểm này không?",
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
                    "DELETE FROM Diem " +
                    "WHERE MaSinhVien = @MaSV " +
                    "AND MaMonHoc = @MaMH";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputmamh.Text.Trim()
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Xóa điểm thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy dữ liệu cần xóa!"
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
            if (Inputmasv.Text.Trim() == "" ||
                Inputmamh.Text.Trim() == "" ||
                Inputdiem.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Mã SV, Mã môn học và Điểm!"
                );

                return;
            }

            if (!double.TryParse(Inputdiem.Text, out double diem))
            {
                MessageBox.Show(
                    "Điểm phải là số!"
                );

                Inputdiem.Focus();
                return;
            }

            try
            {
                MoKetNoi();

                string sql =
                    "UPDATE Diem " +
                    "SET Diem = @Diem " +
                    "WHERE MaSinhVien = @MaSV " +
                    "AND MaMonHoc = @MaMH";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaSV",
                    Inputmasv.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@MaMH",
                    Inputmamh.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@Diem",
                    diem
                );

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Sửa điểm thành công!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy sinh viên và môn học tương ứng!"
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

        private void Inputdiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, phím điều khiển và dấu thập phân
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void XoaDuLieu()
        {
            Inputmasv.Clear();
            Inputmamh.Clear();
            Inputdiem.Clear();

            Inputmasv.Focus();
        }
    }
}
