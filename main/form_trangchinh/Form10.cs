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
	public partial class Form_doimatkhau : Form
	{
		public Form_doimatkhau()
		{
			InitializeComponent();
		}
		string cnnString = @"Data Source=SUNSHINE;Initial Catalog=users;Integrated Security=True";

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = "select * from account where tk = @tk";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@tk", textBox1.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				sql = "update account set mk = @mk where tk = @tk";
				SqlCommand cmd1 = new SqlCommand(sql, cnn);
				cmd1.Parameters.AddWithValue("@tk", textBox1.Text);
				cmd1.Parameters.AddWithValue("@mk", textBox2.Text);
				dr.Close();
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
	}
}
