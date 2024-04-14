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
	public partial class Form_xacnhankhoataikhoan : Form
	{
		public Form_xacnhankhoataikhoan()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đã khóa tài khoản tất cả sinh viên chưa đóng học phí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
