using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5dbaitapnangcao
{
    public partial class FormNhapHocVien : Form
    {
        private FormBaiNangCao formChinh;
        public FormNhapHocVien(FormBaiNangCao frm)
        {
            InitializeComponent();

            formChinh = frm;
        }

        private void FormNhapHocVien_Load(
            object sender,
            EventArgs e)
        {
            comboBox_Lop.Items.Add("Lớp A");
            comboBox_Lop.Items.Add("Lớp B");

            comboBox_Lop.SelectedIndex = 0;

            Inputhoten.Focus();
        }

        private void button_capnhat_Click(
            object sender,
            EventArgs e)
        {
            string hoTen =
                Inputhoten.Text.Trim();

            if (hoTen == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputhoten.Focus();
                return;
            }

            string lop =
                comboBox_Lop.Text;

            formChinh.ThemHocVien(
                hoTen,
                lop
            );

            MessageBox.Show(
                "Thêm học viên thành công!"
            );

            Inputhoten.Clear();
            Inputhoten.Focus();
        }

        private void button_trove_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}
