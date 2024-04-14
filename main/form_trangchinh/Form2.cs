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
	public partial class Form_baocao : Form
	{
		public Form_baocao()
		{
			InitializeComponent();
		}
		string cnnString = @"Data Source=SUNSHINE;Initial Catalog=qlbaocao;Integrated Security=True";

		private void Form2_Load(object sender, EventArgs e)
		{
			string sql = "select * from baocao";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgv.DataSource = dt;
			dtgv.Columns[0].Visible = false;
			dtgv.Columns[1].HeaderText = "Tên báo cáo";
			dtgv.Columns[2].HeaderText = "Ghi chú";
			dtgv.Columns[3].HeaderText = "Ngày thêm";
			dtgv.Columns[4].HeaderText = "Kiểm định chất lượng";
			cnn.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = "insert into baocao values (@ten, @ghichu, @ngaythem, @kiemdinh)";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@ten", ten.Text);
			cmd.Parameters.AddWithValue("@ghichu", ghichu.Text);
			cmd.Parameters.AddWithValue("@ngaythem", ngay.Value.ToString("yyyy-MM-dd"));
			cmd.Parameters.AddWithValue("@kiemdinh", kiemdinh.Text);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgv.DataSource = dt;
			Form2_Load(sender, e);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int idx = dtgv.CurrentRow.Index;
			if (idx >= 0)
			{
				string sql = "update baocao set ten = @ten, ghichu = @ghichu, ngaythem = @ngaythem, kiemdinh = @kiemdinh where id = @id";
				SqlConnection cnn = new SqlConnection(cnnString);
				cnn.Open();
				SqlCommand cmd = new SqlCommand(sql, cnn);
				string ngaythem = dtgv.Rows[idx].Cells[3].Value.ToString();
				cmd.Parameters.AddWithValue("@ten", ten.Text);
				cmd.Parameters.AddWithValue("@ghichu", ghichu.Text);
				cmd.Parameters.AddWithValue("@ngaythem", ngay.Value.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@kiemdinh", kiemdinh.Text);
				cmd.Parameters.AddWithValue("@id", dtgv.Rows[idx].Cells[0].Value.ToString());
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dtgv.DataSource = dt;
				Form2_Load(sender, e);
			}
			else
				MessageBox.Show("Chọn dòng cần sửa");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int idx = dtgv.CurrentRow.Index;
			if (idx >= 0)
			{
				string sql = "delete from baocao where id = @id";
				SqlConnection cnn = new SqlConnection(cnnString);
				cnn.Open();
				SqlCommand cmd = new SqlCommand(sql, cnn);
				cmd.Parameters.AddWithValue("@id", dtgv.Rows[idx].Cells[0].Value.ToString());
				cmd.ExecuteNonQuery();
				Form2_Load(sender, e);
			}
			else
				MessageBox.Show("Chọn dòng cần xóa");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form2_Load(sender, e);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int idx = dtgv.CurrentRow.Index;
			if (idx >= 0)
			{
				ten.Text = dtgv.Rows[idx].Cells[1].Value.ToString();
				ghichu.Text = dtgv.Rows[idx].Cells[2].Value.ToString();
				ngay.Value = DateTime.Parse(dtgv.Rows[idx].Cells[3].Value.ToString());
				kiemdinh.Text = dtgv.Rows[idx].Cells[4].Value.ToString();
			}
		}

		private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int idx = dtgv.CurrentRow.Index;
			if (idx >= 0)
			{
				ten.Text = dtgv.Rows[idx].Cells[1].Value.ToString();
				ghichu.Text = dtgv.Rows[idx].Cells[2].Value.ToString();
				ngay.Value = DateTime.Parse(dtgv.Rows[idx].Cells[3].Value.ToString());
				kiemdinh.Text = dtgv.Rows[idx].Cells[4].Value.ToString();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string sql = "select * from baocao where ten like @ten";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@ten", search.Text);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dtgv.DataSource = dt;
			dtgv.Columns[0].Visible = false;
			dtgv.Columns[1].HeaderText = "Tên báo cáo";
			dtgv.Columns[2].HeaderText = "Ghi chú";
			dtgv.Columns[3].HeaderText = "Ngày thêm";
			dtgv.Columns[4].HeaderText = "Kiểm định chất lượng";
			cnn.Close();
		}

		private void kiemdinh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
