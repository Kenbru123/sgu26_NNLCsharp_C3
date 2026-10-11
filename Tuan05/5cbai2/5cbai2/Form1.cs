namespace _5cbai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dsLop =
            {
                "05DHTH1",
                "05DHTH2",
                "05DHTH3",
                "05DHTH4"
            };

            foreach (string lop in dsLop)
            {
                treeView_danhsach.Nodes.Add(lop);
                Outputlop.Items.Add(lop);
            }

            if (Outputlop.Items.Count > 0)
            {
                Outputlop.SelectedIndex = 0;
            }

            checkBox_themlop.Checked = false;
            grpThemLop.Visible = false;
        }

        private void checkbox_themlop_CheckedChanged(object sender, EventArgs e)
        {
            grpThemLop.Visible = checkBox_themlop.Checked;
        }

        private bool LopDaTonTai(string tenLop)
        {
            foreach (TreeNode node in treeView_danhsach.Nodes)
            {
                if (string.Compare(
                    node.Text,
                    tenLop,
                    true) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void button_themlop_Click(object sender, EventArgs e)
        {
            string tenLop = inputlop.Text.Trim();

            if (tenLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                inputlop.Focus();
                return;
            }

            if (LopDaTonTai(tenLop))
            {
                MessageBox.Show(
                    "Tên lớp đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                inputlop.SelectAll();
                inputlop.Focus();
                return;
            }

            treeView_danhsach.Nodes.Add(tenLop);
            Outputlop.Items.Add(tenLop);

            inputlop.Clear();
            inputlop.Focus();
        }

        private bool MaSVDaTonTai(string maSV)
        {
            foreach (TreeNode lopNode in treeView_danhsach.Nodes)
            {
                foreach (TreeNode svNode in lopNode.Nodes)
                {
                    if (svNode.Tag is string tagMaSV)
                    {
                        if (string.Compare(
                            tagMaSV,
                            maSV,
                            true) == 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private TreeNode TimNodeLop(string tenLop)
        {
            foreach (TreeNode node in treeView_danhsach.Nodes)
            {
                if (node.Text == tenLop)
                {
                    return node;
                }
            }

            return null;
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            string maSV = Inputmasv.Text.Trim();
            string hoTen = Inputhoten.Text.Trim();
            string diaChi = Inputdiachi.Text.Trim();

            if (maSV == "" ||
                hoTen == "" ||
                diaChi == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (Outputlop.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn lớp!"
                );

                return;
            }

            if (MaSVDaTonTai(maSV))
            {
                MessageBox.Show(
                    "Mã sinh viên đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Inputmasv.SelectAll();
                Inputmasv.Focus();
                return;
            }

            string tenLop = Outputlop.Text;

            TreeNode lopNode = TimNodeLop(tenLop);

            if (lopNode == null)
                return;

            TreeNode svNode =
                new TreeNode(maSV + ", " + hoTen);

            svNode.Tag = maSV;

            TreeNode diaChiNode =
                new TreeNode(diaChi);

            svNode.Nodes.Add(diaChiNode);

            lopNode.Nodes.Add(svNode);

            lopNode.Expand();

            Inputmasv.Clear();
            Inputhoten.Clear();
            Inputdiachi.Clear();

            Inputmasv.Focus();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (treeView_danhsach.SelectedNode == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!"
                );

                return;
            }

            TreeNode node = treeView_danhsach.SelectedNode;

            // Node sinh viên có Parent là node lớp
            if (node.Parent == null)
            {
                MessageBox.Show(
                    "Chỉ được xóa sinh viên!"
                );

                return;
            }

            // Nếu chọn node địa chỉ thì cũng không cho xóa
            if (node.Parent.Parent != null)
            {
                MessageBox.Show(
                    "Vui lòng chọn node sinh viên!"
                );

                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                node.Remove();

                Inputmasv.Clear();
                Inputhoten.Clear();
                Inputdiachi.Clear();
            }
        }

        private void treeView_danhsach_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            // Phải là node sinh viên
            if (node.Parent == null)
                return;

            if (node.Parent.Parent != null)
                return;

            string noiDung = node.Text;

            int viTriPhay = noiDung.IndexOf(',');

            if (viTriPhay == -1)
                return;

            string maSV =
                noiDung.Substring(
                    0,
                    viTriPhay
                ).Trim();

            string hoTen =
                noiDung.Substring(
                    viTriPhay + 1
                ).Trim();

            Inputmasv.Text = maSV;
            Inputhoten.Text = hoTen;

            if (node.Nodes.Count > 0)
            {
                Inputdiachi.Text =
                    node.Nodes[0].Text;
            }

            Outputlop.Text =
                node.Parent.Text;
        }
    }
}
