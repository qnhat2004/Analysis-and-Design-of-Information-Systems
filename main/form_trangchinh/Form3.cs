using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
	public partial class Form_hososv : Form
	{
		public Form_hososv()
		{
			InitializeComponent();
		}

		string cnnString = @"Data Source=SUNSHINE;Initial Catalog=sinhvien;Integrated Security=True";
		private void Form3_Load(object sender, EventArgs e)
		{
			string sql = "select masv, hoten, malop, ngaysinh, quequan, gioitinh from sv";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			this.dtgv1.DataSource = dt;
			dtgv1.Columns[0].HeaderText = "Mã sinh viên";
			dtgv1.Columns[1].HeaderText = "Tên sinh viên";
			dtgv1.Columns[2].HeaderText = "Mã lớp";
			dtgv1.Columns[3].HeaderText = "Ngày sinh";
			dtgv1.Columns[4].HeaderText = "Quê quán";
			dtgv1.Columns[5].HeaderText = "Giới tính";
			cnn.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = "insert into sv (masv, hoten, malop, ngaysinh, quequan, gioitinh) values ( @masv, @hoten, @malop, @ngaysinh, @quequan, @gioitinh)";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@masv", masv.Text);
			cmd.Parameters.AddWithValue("@hoten", tensv.Text);
			cmd.Parameters.AddWithValue("@malop", malop.Text);
			cmd.Parameters.AddWithValue("@ngaysinh", dtp.Value.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@quequan", quequan.Text);
			cmd.Parameters.AddWithValue("@gioitinh", nam.Checked ? "Nam" : "Nữ");
			cmd.ExecuteNonQuery();
			Form3_Load(sender, e);
			cnn.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string sql = "select masv, hoten, malop, ngaysinh, quequan, gioitinh from sv";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			this.dtgv1.DataSource = dt;
			dtgv1.Columns[0].HeaderText = "Mã sinh viên";
			dtgv1	.Columns[1].HeaderText = "Tên sinh viên";
			dtgv1.Columns[2].HeaderText = "Mã lớp";
			dtgv1.Columns[3].HeaderText = "Ngày sinh";
			dtgv1.Columns[4].HeaderText = "Quê quán";
			dtgv1.Columns[5].HeaderText = "Giới tính";
			cnn.Close();
		}

		// sửa
		private void button2_Click(object sender, EventArgs e)
		{
			string sql = "update sv set hoten = @hoten, malop = @malop, ngaysinh = @ngaysinh, quequan = @quequan, gioitinh = @gioitinh where masv = @masv";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@masv", masv.Text);
			cmd.Parameters.AddWithValue("@hoten", tensv.Text);
			cmd.Parameters.AddWithValue("@malop", malop.Text);
			cmd.Parameters.AddWithValue("@ngaysinh", dtp.Value.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@quequan", quequan.Text);
			cmd.Parameters.AddWithValue("@gioitinh", nam.Checked ? "Nam" : "Nữ");
			cmd.ExecuteNonQuery();
			cnn.Close();
			Form3_Load(sender, e);
		}

		// xóa
		private void button3_Click(object sender, EventArgs e)
		{
			string sql = "delete from sv where masv = @masv";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@masv", masv.Text);
			cmd.ExecuteNonQuery();
			cnn.Close();
			Form3_Load(sender, e);
		}

		private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv1.Rows[e.RowIndex];
				masv.Text = row.Cells[0].Value.ToString();
				tensv.Text = row.Cells[1].Value.ToString();
				malop.Text = row.Cells[2].Value.ToString();
				dtp.Value = DateTime.Parse(row.Cells[3].Value.ToString());
				quequan.Text = row.Cells[4].Value.ToString();
				if (row.Cells[5].Value.ToString() == "Nam")
				{
					nam.Checked = true;
				}
				else
				{
					nu.Checked = true;
				}
			}
		}

		private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dtgv1.Rows[e.RowIndex];
				masv.Text = row.Cells[0].Value.ToString();
				tensv.Text = row.Cells[1].Value.ToString();
				malop.Text = row.Cells[2].Value.ToString();
				dtp.Value = DateTime.Parse(row.Cells[3].Value.ToString());
				quequan.Text = row.Cells[4].Value.ToString();
				if (row.Cells[5].Value.ToString() == "Nam")
				{
					nam.Checked = true;
				}
				else
				{
					nu.Checked = true;
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (search.Text != "")
			{
				string sql = "select masv, hoten, malop, ngaysinh, quequan, gioitinh from sv where masv = @masv";
				SqlConnection cnn = new SqlConnection(cnnString);
				cnn.Open();
				SqlCommand cmd = new SqlCommand(sql, cnn);
				cmd.Parameters.AddWithValue("@masv", search.Text);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				this.dtgv1.DataSource = dt;
				cnn.Close();
			}	
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void comboBox1_DropDown(object sender, EventArgs e)
		{
			//String sql = "select malop from sv";
			//SqlConnection cnn = new SqlConnection(sql);
			//cnn.Open();
			comboBox1.DisplayMember = "malop";
		}
	}
}
