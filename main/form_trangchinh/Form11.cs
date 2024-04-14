using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form_hocphi : Form
	{
		public Form_hocphi()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult dr =  MessageBox.Show("Bạn có chắc chắn muốn khóa tài khoản những sinh viên chưa đóng học phí không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				MessageBox.Show("Đã khóa tài khoản tất cả sinh viên chưa đóng học phí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}	
		}
	}
}
