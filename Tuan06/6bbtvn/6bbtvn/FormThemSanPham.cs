using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _6bbtvn
{
    public class FormThemSanPham : Form
    {
        private TextBox txtTenSP = new TextBox();
        public FormThemSanPham()
        {
            Text = "Thêm sản phẩm mới";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(430, 180);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            Label lblTenSP = new Label();
            lblTenSP.Text = "Tên sản phẩm";
            lblTenSP.Location = new Point(30, 43);
            lblTenSP.AutoSize = true;
            Controls.Add(lblTenSP);

            txtTenSP.SetBounds(145, 38, 250, 27);
            Controls.Add(txtTenSP);

            Button btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Bounds = new Rectangle(90, 95, 100, 34);

            Button btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Bounds = new Rectangle(235, 95, 100, 34);

            btnThem.Click += (s, e) => ThemSanPham();
            btnThoat.Click += (s, e) => Close();

            Controls.Add(btnThem);
            Controls.Add(btnThoat);

            AcceptButton = btnThem;
        }

        // thêm sp và tồn kho ban đầu
        private void ThemSanPham()
        {
            string ten = txtTenSP.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sản phẩm!"
                );
                txtTenSP.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Db.Open())
                using (SqlTransaction tran =
                    conn.BeginTransaction())
                {
                    try
                    {
                        string sql = @"
                            INSERT INTO SANPHAM(TenSP)
                            OUTPUT INSERTED.MaSP
                            VALUES (@TenSP)";

                        int maSP;

                        using (SqlCommand cmd =
                            new SqlCommand(sql, conn, tran))
                        {
                            cmd.Parameters.Add(
                                "@TenSP", SqlDbType.NVarChar, 100
                            ).Value = ten;

                            maSP = Convert.ToInt32(
                                cmd.ExecuteScalar()
                            );
                        }

                        string sqlTon = @"
                            INSERT INTO TONKHO
                                (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                            VALUES (@MaSP, @Today, 0, 0, 0)";

                        using (SqlCommand cmdTon =
                            new SqlCommand(sqlTon, conn, tran))
                        {
                            cmdTon.Parameters.Add(
                                "@MaSP", SqlDbType.Int
                            ).Value = maSP;

                            cmdTon.Parameters.Add(
                                "@Today", SqlDbType.Date
                            ).Value = DateTime.Today;

                            cmdTon.ExecuteNonQuery();
                        }

                        tran.Commit();

                        MessageBox.Show(
                            "Thêm sản phẩm thành công!\n" +
                            "Mã sản phẩm: " + maSP
                        );

                        txtTenSP.Clear();
                        txtTenSP.Focus();
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
                    "Lỗi thêm sản phẩm: " + ex.Message
                );
            }
        }
    }
}
