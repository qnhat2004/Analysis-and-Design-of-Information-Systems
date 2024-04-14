using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form_nhapdiemrl : Form
	{
		public Form_nhapdiemrl()
		{
			InitializeComponent();
			string sql = "select stt, madd, hoten, ngaysinh, gioitinh, diemrl from sv";
			string cnnString = @"Data Source=SUNSHINE;Initial Catalog=sinhvien;Integrated Security=True";

			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgv.DataSource = dt;
			dtgv.Columns[0].HeaderText = "STT";
			dtgv.Columns[1].HeaderText = "Mã định danh";
			dtgv.Columns[2].HeaderText = "Họ tên";
			dtgv.Columns[3].HeaderText = "Ngày sinh";
			dtgv.Columns[4].HeaderText = "Giới tính";
			dtgv.Columns[5].HeaderText = "Điểm rèn luyện";
			cnn.Close();
		}

		private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_hososv f3 = new Form_hososv();
			f3.Show();
		}

		private void nhậpĐiểmTrungBìnhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_nhapdiemtb f4 = new Form_nhapdiemtb();
			f4.Show();
		}

		private void nhậpĐiểmRènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_nhapdiemrl f1 = new Form_nhapdiemrl();
			f1.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void báoCáoĐịnhKìToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void hiểnThịDanhSáchBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_baocao f2 = new Form_baocao();
			f2.Show();
		}

		private void saoLưuHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_saoluu f6 = new Form_saoluu();
			f6.Show();
		}

		private void khôiPhụcHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_khoiphuc f7 = new Form_khoiphuc();
			f7.Show();
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất khỏi hệ thống", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				List<Form> formsToClose = new List<Form>();
				foreach (Form form in Application.OpenForms)
				{
					if (form.Name != "Form_dangnhap")
					{
						formsToClose.Add(form);
					}
				}

				foreach (Form form in formsToClose)
				{
					form.Close();
				}

				Form_dangnhap f9 = new Form_dangnhap();
				f9.Show();
				this.Close();
			}
		}


		private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_doimatkhau f12 = new Form_doimatkhau();
			f12.Show();
		}

		private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_hocphi f11 = new Form_hocphi();
			f11.Show();
		}
	}
}
