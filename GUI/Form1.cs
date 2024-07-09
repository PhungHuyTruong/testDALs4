using BUI;
using DALs4.Models;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly Service4 ser;
        int IdChon = -1;
        public Form1(Service4 ser4)
        {
            ser = ser4;
            InitializeComponent();
            Loadcombobox();
        }
        public void Loaddata(List<Nhanvien> nv, List<Congty> congty)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "ten";
            dataGridView1.Columns[2].Name = "dia chi";
            dataGridView1.Columns[3].Name = "sdt";
            dataGridView1.Columns[4].Name = "ngay tuyen dung";
            dataGridView1.Columns[5].Name = "idcn";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Name = "id";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Name = "Ten cong ty";

            foreach (Nhanvien nhanvien in nv)
            {
                Congty ct = congty.FirstOrDefault(x => x.Id == nhanvien.IdCn);
                var tenct = ct != null ? ct.Ten : "ko co";
                dataGridView1.Rows.Add(stt++, nhanvien.Ten, nhanvien.Diachi, nhanvien.Sodienthoai, nhanvien.Ngaytuyendung, nhanvien.IdCn, nhanvien.Id, tenct);
            }
        }
        public void Loadcombobox()
        {
            var cmbx = ser.GetAllCongTy();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Ten";
            comboBox1.DataSource = cmbx.ToList();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Loaddata(ser.GetAllNhanVien(), ser.GetAllCongTy());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var click = dataGridView1.Rows[index];
            ten.Text = click.Cells[1].Value.ToString();
            diachi.Text = click.Cells[2].Value.ToString();
            sdt.Text = click.Cells[3].Value.ToString();
            ngaytuyendung.Text = click.Cells[4].Value.ToString();
            comboBox1.SelectedValue = click.Cells[5].Value;
            IdChon = Convert.ToInt32(click.Cells[6].Value.ToString());
        }

        private void them_Click(object sender, EventArgs e)
        {
            var nhanvien = new Nhanvien
            {
                Ten = ten.Text,
                Diachi = diachi.Text,
                Sodienthoai = sdt.Text,
                Ngaytuyendung = DateOnly.Parse(ngaytuyendung.Text),
                IdCn = Convert.ToInt32(comboBox1.SelectedValue),
            };
            ser.ThemNhanVien(nhanvien);
            Loaddata(ser.GetAllNhanVien(), ser.GetAllCongTy());

        }

        private void sua_Click(object sender, EventArgs e)
        {
            var nhanviens = new Nhanvien
            {
                Id = IdChon,
                Ten = ten.Text,
                Diachi = diachi.Text,
                Sodienthoai = sdt.Text,
                Ngaytuyendung = DateOnly.Parse(ngaytuyendung.Text),
                IdCn = Convert.ToInt32(comboBox1.SelectedIndex),
            };
            ser.UpdateNhanVien(nhanviens);
            Loaddata(ser.GetAllNhanVien(), ser.GetAllCongTy());
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            ser.XoaNhanVien(IdChon);
            Loaddata(ser.GetAllNhanVien(), ser.GetAllCongTy());
        }
        public void Load()
        {
            MessageBox.Show("FASdfs");
        }
        public void Lo()
        {
            MessageBox.Show("Dsdad");
        }
    }
}
