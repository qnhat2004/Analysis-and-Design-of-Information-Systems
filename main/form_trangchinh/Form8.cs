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
	public partial class Form_dangky : Form
	{
		public Form_dangky()
		{
			InitializeComponent();
		}

		string cnnString = @"Data Source=SUNSHINE;Initial Catalog=users;Integrated Security=True";

		private void textBox1_Leave(object sender, EventArgs e)
		{
			System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
			if (tb.Text == "")
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
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
			string sql = "select * from account where tk = @tk";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@tk", textBox1.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				dr.Close();
				MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				string sql1 = "insert into account values(@tk, @mk)";
				cmd = new SqlCommand(sql1, cnn);
				cmd.Parameters.AddWithValue("@tk", textBox1.Text);
				cmd.Parameters.AddWithValue("@mk", textBox2.Text);
				cmd.ExecuteNonQuery();
				this.Close();
			}
			cnn.Close();
		}
	}
}
