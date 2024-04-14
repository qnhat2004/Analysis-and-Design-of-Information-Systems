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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
	public partial class Form_dangnhap : Form
	{
		public Form_dangnhap()
		{
			InitializeComponent();
		}

		string cnnString = @"Data Source=SUNSHINE;Initial Catalog=users;Integrated Security=True";
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form_dangky f8 = new Form_dangky();
			f8.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			string sql = "select * from account where tk = @tk and mk = @mk";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@tk", textBox1.Text);
			cmd.Parameters.AddWithValue("@mk", textBox2.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Form_nhapdiemrl f1 = new Form_nhapdiemrl();
				f1.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			cnn.Close();
		}

		private void Form9_Load(object sender, EventArgs e)
		{
			textBox2.PasswordChar = '*';
		}
		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(sender, e);
			}
		}
	}
}
