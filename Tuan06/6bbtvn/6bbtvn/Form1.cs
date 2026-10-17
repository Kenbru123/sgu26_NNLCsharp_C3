using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace _6bbtvn
{
    public partial class Form1 : Form
    {
        private MenuStrip menu = new MenuStrip();
        public Form1()
        {
            Text = "Quản lý cửa hàng - Thực hành 06b";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(680, 350);

            ToolStripMenuItem mnuTon =
                new ToolStripMenuItem("Tạo tồn kho");

            ToolStripMenuItem mnuSP =
                new ToolStripMenuItem("Thêm sản phẩm mới");

            ToolStripMenuItem mnuBan =
                new ToolStripMenuItem("Bán hàng");

            ToolStripMenuItem mnuThoat =
                new ToolStripMenuItem("Thoát");

            mnuTon.Click += (s, e) => TaoTonKho();

            mnuSP.Click += (s, e) =>
                new FormThemSanPham().ShowDialog(this);

            mnuBan.Click += (s, e) =>
                new FormBanHang().ShowDialog(this);

            mnuThoat.Click += (s, e) => Close();

            menu.Items.AddRange(new ToolStripItem[]
            {
                mnuTon, mnuSP, mnuBan, mnuThoat
            });

            MainMenuStrip = menu;
            Controls.Add(menu);

            Label lblTitle = new Label();
            lblTitle.Text = "QUẢN LÝ CỬA HÀNG";
            lblTitle.Font =
                new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Bounds = new Rectangle(45, 82, 590, 50);
            Controls.Add(lblTitle);
        }

        // chức năng tạo tồn kho
        private void TaoTonKho()
        {
            try
            {
                using (SqlConnection conn = Db.Open())
                using (SqlTransaction tran =
                    conn.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        string sql = @"
                            DECLARE @Ngay DATE = @Today;

                            INSERT INTO TONKHO
                                (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                            SELECT
                                sp.MaSP,
                                @Ngay,
                                ISNULL(
                                    t.SLDau + t.SLNhap - t.SLBan, 0
                                ),
                                0,
                                0
                            FROM SANPHAM sp
                            LEFT JOIN TONKHO t
                                ON t.MaSP = sp.MaSP
                                AND t.NgayTon =
                                    DATEADD(DAY, -1, @Ngay)
                            WHERE NOT EXISTS
                            (
                                SELECT 1
                                FROM TONKHO x
                                    WITH (UPDLOCK, HOLDLOCK)
                                WHERE x.MaSP = sp.MaSP
                                  AND x.NgayTon = @Ngay
                            )";

                        using (SqlCommand cmd =
                            new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.Add(
                                "@Today", SqlDbType.Date
                            ).Value = DateTime.Today;

                            int count = cmd.ExecuteNonQuery();

                            tran.Commit();

                            MessageBox.Show(
                                count == 0
                                ? "Tồn kho hôm nay đã được tạo!"
                                : "Đã tạo tồn kho cho " +
                                  count + " sản phẩm!"
                            );
                        }
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tạo tồn kho: " + ex.Message
                );
            }
        }
    }
}
