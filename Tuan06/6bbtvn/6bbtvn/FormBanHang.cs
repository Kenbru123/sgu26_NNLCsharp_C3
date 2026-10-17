using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _6bbtvn
{
    public class FormBanHang : Form
    {
        TextBox txtMaHD = new TextBox();
        ComboBox cboMaSP = new ComboBox();
        TextBox txtSoLuong = new TextBox();

        Button btnTao = new Button();
        Button btnThem = new Button();
        Button btnHuy = new Button();
        Button btnThanhToan = new Button();

        int? maHD = null;

        private class SanPhamItem
        {
            public int MaSP { get; }
            public string TenSP { get; }

            public SanPhamItem(int ma, string ten)
            {
                MaSP = ma;
                TenSP = ten;
            }

            public override string ToString()
            {
                return MaSP + " - " + TenSP;
            }
        }

        public FormBanHang()
        {
            Text = "Bán hàng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(500, 370);

            btnTao.Text = "Tạo hóa đơn mới";
            btnTao.SetBounds(293, 16, 170, 36);
            Controls.Add(btnTao);

            GroupBox group = new GroupBox();
            group.Text = "Chi tiết hóa đơn";
            group.Bounds = new Rectangle(36, 73, 427, 220);
            Controls.Add(group);

            group.Controls.Add(new Label
            {
                Text = "Mã hóa đơn",
                Bounds = new Rectangle(28, 38, 110, 24)
            });

            group.Controls.Add(new Label
            {
                Text = "Mã sản phẩm",
                Bounds = new Rectangle(28, 88, 110, 24)
            });

            group.Controls.Add(new Label
            {
                Text = "Số lượng",
                Bounds = new Rectangle(28, 136, 110, 24)
            });

            txtMaHD.SetBounds(155, 32, 226, 27);
            cboMaSP.SetBounds(155, 82, 226, 27);
            txtSoLuong.SetBounds(155, 130, 226, 27);

            txtMaHD.ReadOnly = true;
            cboMaSP.DropDownStyle =
                ComboBoxStyle.DropDownList;

            group.Controls.Add(txtMaHD);
            group.Controls.Add(cboMaSP);
            group.Controls.Add(txtSoLuong);

            btnThem.Text = "Thêm";
            btnThem.SetBounds(156, 172, 100, 34);

            btnHuy.Text = "Hủy";
            btnHuy.SetBounds(281, 172, 100, 34);

            group.Controls.Add(btnThem);
            group.Controls.Add(btnHuy);

            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.SetBounds(308, 311, 155, 35);
            Controls.Add(btnThanhToan);

            btnTao.Click += (s, e) => TaoHoaDon();
            btnThem.Click += (s, e) => ThemChiTiet();
            btnHuy.Click += (s, e) => HuyHoaDon();
            btnThanhToan.Click += (s, e) => ThanhToan();

            txtSoLuong.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            SetTrangThai(false);
            LoadSanPham();
        }

        private void SetTrangThai(bool dangTao)
        {
            btnTao.Enabled = !dangTao;
            cboMaSP.Enabled = dangTao;
            txtSoLuong.Enabled = dangTao;
            btnThem.Enabled = dangTao;
            btnHuy.Enabled = dangTao;
            btnThanhToan.Enabled = dangTao;

            if (!dangTao)
            {
                maHD = null;
                txtMaHD.Clear();
                txtSoLuong.Clear();
                cboMaSP.SelectedIndex = -1;
            }
        }

        protected override void OnFormClosing(
            FormClosingEventArgs e)
        {
            if (maHD.HasValue)
            {
                MessageBox.Show(
                    "Hãy thanh toán hoặc hủy hóa đơn trước!"
                );
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }
        // tải danh sách sp
        private void LoadSanPham()
        {
            try
            {
                cboMaSP.Items.Clear();

                using (SqlConnection conn = Db.Open())
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT MaSP, TenSP FROM SANPHAM ORDER BY MaSP",
                    conn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cboMaSP.Items.Add(
                            new SanPhamItem(
                                Convert.ToInt32(rd["MaSP"]),
                                rd["TenSP"].ToString()
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải sản phẩm: " + ex.Message
                );
            }
        }

        // tạo hóa đơn mới
        private void TaoHoaDon()
        {
            try
            {
                using (SqlConnection conn = Db.Open())
                {
                    string sqlCheck = @"
                        SELECT COUNT(*)
                        FROM SANPHAM sp
                        WHERE NOT EXISTS
                        (
                            SELECT 1 FROM TONKHO tk
                            WHERE tk.MaSP = sp.MaSP
                            AND tk.NgayTon = @Today
                        )";

                    using (SqlCommand check =
                        new SqlCommand(sqlCheck, conn))
                    {
                        check.Parameters.Add(
                            "@Today", SqlDbType.Date
                        ).Value = DateTime.Today;

                        int missing = Convert.ToInt32(
                            check.ExecuteScalar()
                        );

                        if (missing > 0)
                        {
                            MessageBox.Show(
                                "Bạn phải tạo tồn kho hôm nay trước!"
                            );
                            return;
                        }
                    }

                    string sql = @"
                        INSERT INTO HOADON
                            (NgayTao, TinhTrangThanhToan)
                        OUTPUT INSERTED.MaHD
                        VALUES (@Now, 0)";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@Now", SqlDbType.DateTime2
                        ).Value = DateTime.Now;

                        maHD = Convert.ToInt32(
                            cmd.ExecuteScalar()
                        );
                    }

                    txtMaHD.Text = maHD.Value.ToString();
                    SetTrangThai(true);
                    cboMaSP.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tạo hóa đơn: " + ex.Message
                );
            }
        }

        // thêm sp vào hóa đơn
        private void ThemChiTiet()
        {
            if (!maHD.HasValue) return;

            SanPhamItem sp =
                cboMaSP.SelectedItem as SanPhamItem;

            if (sp == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm!");
                return;
            }

            int soLuong;

            if (!int.TryParse(txtSoLuong.Text, out soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên lớn hơn 0!"
                );
                return;
            }

            try
            {
                using (SqlConnection conn = Db.Open())
                using (SqlTransaction tran =
                    conn.BeginTransaction(
                        IsolationLevel.Serializable))
                {
                    try
                    {
                        // Kiểm tra hóa đơn chưa thanh toán
                        string sqlHD = @"
                            SELECT NgayTao FROM HOADON
                                WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaHD = @MaHD
                            AND TinhTrangThanhToan = 0";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlHD, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );

                            object ngay = cmd.ExecuteScalar();

                            if (ngay == null ||
                                Convert.ToDateTime(ngay).Date
                                != DateTime.Today)
                            {
                                throw new Exception(
                                    "Hóa đơn không hợp lệ!"
                                );
                            }
                        }

                        // Kiểm tra số lượng tồn
                        string sqlTon = @"
                            SELECT SLDau + SLNhap - SLBan
                            FROM TONKHO WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaSP = @MaSP
                            AND NgayTon = @Today";

                        int tonCon;

                        using (SqlCommand cmd =
                            new SqlCommand(sqlTon, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaSP", sp.MaSP
                            );
                            cmd.Parameters.Add(
                                "@Today", SqlDbType.Date
                            ).Value = DateTime.Today;

                            object result = cmd.ExecuteScalar();

                            if (result == null)
                                throw new Exception(
                                    "Chưa có tồn kho hôm nay!"
                                );

                            tonCon = Convert.ToInt32(result);
                        }

                        // Theo đề: số lượng bán nhỏ hơn tồn
                        if (soLuong >= tonCon)
                        {
                            throw new Exception(
                                "Số lượng bán phải nhỏ hơn " +
                                "tồn kho hiện tại: " + tonCon
                            );
                        }

                        // Kiểm tra sản phẩm đã có trong hóa đơn
                        string sqlTrung = @"
                            SELECT COUNT(*)
                            FROM CHITIET_HOADON
                            WHERE MaHD = @MaHD
                            AND MaSP = @MaSP";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlTrung, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );
                            cmd.Parameters.AddWithValue(
                                "@MaSP", sp.MaSP
                            );

                            if (Convert.ToInt32(
                                cmd.ExecuteScalar()) > 0)
                            {
                                throw new Exception(
                                    "Sản phẩm đã có trong hóa đơn!"
                                );
                            }
                        }

                        // Thêm chi tiết hóa đơn
                        string sqlThem = @"
                            INSERT INTO CHITIET_HOADON
                                (MaHD, MaSP, SoLuong)
                            VALUES (@MaHD, @MaSP, @SoLuong)";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlThem, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );
                            cmd.Parameters.AddWithValue(
                                "@MaSP", sp.MaSP
                            );
                            cmd.Parameters.AddWithValue(
                                "@SoLuong", soLuong
                            );
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật số lượng đã bán
                        string sqlUpdate = @"
                            UPDATE TONKHO
                            SET SLBan = SLBan + @SoLuong
                            WHERE MaSP = @MaSP
                            AND NgayTon = @Today";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlUpdate, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaSP", sp.MaSP
                            );
                            cmd.Parameters.AddWithValue(
                                "@SoLuong", soLuong
                            );
                            cmd.Parameters.Add(
                                "@Today", SqlDbType.Date
                            ).Value = DateTime.Today;

                            if (cmd.ExecuteNonQuery() != 1)
                                throw new Exception(
                                    "Không cập nhật được tồn kho!"
                                );
                        }

                        tran.Commit();

                        MessageBox.Show(
                            "Đã thêm sản phẩm vào hóa đơn!"
                        );

                        cboMaSP.SelectedIndex = -1;
                        txtSoLuong.Clear();
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
                    "Lỗi thêm chi tiết: " + ex.Message
                );
            }
        }

        // hủy hóa đơn ch thanh toán
        private void HuyHoaDon()
        {
            if (!maHD.HasValue) return;

            if (MessageBox.Show(
                "Bạn có muốn hủy hóa đơn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = Db.Open())
                using (SqlTransaction tran =
                    conn.BeginTransaction(
                        IsolationLevel.Serializable))
                {
                    try
                    {
                        string sqlNgay = @"
                            SELECT NgayTao
                            FROM HOADON WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaHD = @MaHD
                            AND TinhTrangThanhToan = 0";

                        DateTime ngayHD;

                        using (SqlCommand cmd =
                            new SqlCommand(sqlNgay, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );

                            object result = cmd.ExecuteScalar();

                            if (result == null)
                                throw new Exception(
                                    "Hóa đơn không còn hợp lệ!"
                                );

                            ngayHD =
                                Convert.ToDateTime(result).Date;
                        }

                        // Hoàn lại số lượng đã bán
                        string sqlHoan = @"
                            UPDATE tk
                            SET tk.SLBan =
                                tk.SLBan - ct.SoLuong
                            FROM TONKHO tk
                            INNER JOIN CHITIET_HOADON ct
                                ON tk.MaSP = ct.MaSP
                            WHERE ct.MaHD = @MaHD
                            AND tk.NgayTon = @Ngay";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlHoan, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );
                            cmd.Parameters.Add(
                                "@Ngay", SqlDbType.Date
                            ).Value = ngayHD;
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd =
                            new SqlCommand(
                                "DELETE FROM CHITIET_HOADON " +
                                "WHERE MaHD = @MaHD",
                                conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd =
                            new SqlCommand(
                                "DELETE FROM HOADON " +
                                "WHERE MaHD = @MaHD " +
                                "AND TinhTrangThanhToan = 0",
                                conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );

                            if (cmd.ExecuteNonQuery() != 1)
                                throw new Exception(
                                    "Không hủy được hóa đơn!"
                                );
                        }

                        tran.Commit();
                        MessageBox.Show(
                            "Đã hủy hóa đơn và hoàn tồn kho!"
                        );
                        SetTrangThai(false);
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
                    "Lỗi hủy hóa đơn: " + ex.Message
                );
            }
        }

        // thanh toán hóa đơn
        private void ThanhToan()
        {
            if (!maHD.HasValue) return;

            try
            {
                using (SqlConnection conn = Db.Open())
                using (SqlTransaction tran =
                    conn.BeginTransaction())
                {
                    try
                    {
                        string sqlCheck = @"
                            SELECT COUNT(*)
                            FROM CHITIET_HOADON
                            WHERE MaHD = @MaHD";

                        using (SqlCommand cmd =
                            new SqlCommand(sqlCheck, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );

                            if (Convert.ToInt32(
                                cmd.ExecuteScalar()) == 0)
                            {
                                MessageBox.Show(
                                    "Hóa đơn chưa có sản phẩm!"
                                );
                                tran.Rollback();
                                return;
                            }
                        }

                        string sql = @"
                            UPDATE HOADON
                            SET TinhTrangThanhToan = 1
                            WHERE MaHD = @MaHD
                            AND TinhTrangThanhToan = 0";

                        using (SqlCommand cmd =
                            new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaHD", maHD.Value
                            );

                            if (cmd.ExecuteNonQuery() != 1)
                                throw new Exception(
                                    "Không thanh toán được!"
                                );
                        }

                        tran.Commit();

                        MessageBox.Show(
                            "Thanh toán thành công!"
                        );

                        SetTrangThai(false);
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
                    "Lỗi thanh toán: " + ex.Message
                );
            }
        }
    }
}
