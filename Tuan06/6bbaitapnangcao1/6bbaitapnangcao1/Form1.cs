using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _6bbaitapnangcao1
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

        //button hiển thị
        private void button_hienthi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu cũ trên ListView
                listView_danhsach.Items.Clear();

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    // Lấy danh sách lớp từ SQL
                    string sql =
                        "SELECT MaLop, TenLop, MaKhoa " +
                        "FROM Lop ORDER BY MaLop";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        int stt = 1;

                        while (rd.Read())
                        {
                            // Cột STT
                            ListViewItem item =
                                new ListViewItem(stt.ToString());

                            // Cột Mã lớp
                            item.SubItems.Add(
                                rd["MaLop"].ToString()
                            );

                            // Cột Tên lớp
                            item.SubItems.Add(
                                rd["TenLop"].ToString()
                            );

                            // Cột Mã khoa
                            item.SubItems.Add(
                                rd["MaKhoa"].ToString()
                            );

                            // Thêm dòng vào ListView
                            listView_danhsach.Items.Add(item);

                            stt++;
                        }
                    }
                }

                if (listView_danhsach.Items.Count == 0)
                {
                    MessageBox.Show(
                        "Chưa có dữ liệu lớp!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi hiển thị dữ liệu!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //button thoát
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
