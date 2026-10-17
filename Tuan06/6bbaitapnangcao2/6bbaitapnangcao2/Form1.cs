using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace _6bbaitapnangcao2
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
            Outputdiem.ReadOnly = true;

            LoadMonHoc();

            // Hiển thị tất cả điểm ban đầu
            LoadDiem("");
        }

        //load môn học
        private void LoadMonHoc()
        {
            try
            {
                comboBox_monhoc.Items.Clear();

                // Mục trống = tất cả môn học
                comboBox_monhoc.Items.Add("");

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "SELECT MaMonHoc FROM MonHoc " +
                        "ORDER BY MaMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    using (SqlDataReader rd =
                        cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            comboBox_monhoc.Items.Add(
                                rd["MaMonHoc"].ToString()
                            );
                        }
                    }
                }

                comboBox_monhoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải môn học!\n" + ex.Message
                );
            }
        }

        // hiển thị danh sách điểm
        private void LoadDiem(string maMH)
        {
            try
            {
                listView_danhsach.Items.Clear();
                Outputdiem.Text = "0";

                decimal tongDiem = 0;
                int stt = 1;

                using (SqlConnection conn =
                    new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql =
                        "SELECT sv.HoTen, sv.NgaySinh, " +
                        "mh.TenMonHoc, d.Diem " +
                        "FROM Diem d " +
                        "INNER JOIN SinhVien sv " +
                        "ON d.MaSinhVien = sv.MaSinhVien " +
                        "INNER JOIN MonHoc mh " +
                        "ON d.MaMonHoc = mh.MaMonHoc ";

                    // Nếu chọn mã môn học thì lọc
                    if (maMH != "")
                    {
                        sql += "WHERE d.MaMonHoc = @MaMH ";
                    }

                    sql += "ORDER BY sv.HoTen, mh.TenMonHoc";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        if (maMH != "")
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaMH", maMH
                            );
                        }

                        using (SqlDataReader rd =
                            cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string hoTen =
                                    rd["HoTen"].ToString();

                                string ngaySinh =
                                    Convert.ToDateTime(
                                        rd["NgaySinh"]
                                    ).ToString("dd/MM/yyyy");

                                string tenMonHoc =
                                    rd["TenMonHoc"].ToString();

                                decimal diem =
                                    Convert.ToDecimal(rd["Diem"]);

                                // Tạo dòng ListView
                                ListViewItem item =
                                    new ListViewItem(
                                        stt.ToString()
                                    );

                                item.SubItems.Add(hoTen);
                                item.SubItems.Add(ngaySinh);
                                item.SubItems.Add(tenMonHoc);
                                item.SubItems.Add(
                                    diem.ToString("0.##")
                                );

                                listView_danhsach.Items.Add(item);

                                // Cộng dồn tổng điểm
                                tongDiem += diem;

                                stt++;
                            }
                        }
                    }
                }

                // Hiển thị tổng điểm
                Outputdiem.Text =
                    tongDiem.ToString("0.##");
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

        //button lọc dữ liệu
        private void button_loc_Click(object sender, EventArgs e)
        {
            string maMH = comboBox_monhoc.Text.Trim();

            LoadDiem(maMH);
        }
    }
}
