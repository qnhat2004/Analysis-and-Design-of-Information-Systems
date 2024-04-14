namespace test
{
	partial class Form_xacnhanthongbaohocphi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(1, 107);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(708, 57);
			this.panel2.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(396, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(77, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "No";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(302, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "Yes";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::test.Properties.Resources.Screenshot_2024_04_12_100116;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(470, 68);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form_xacnhanthongbaohocphi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(500, 165);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Name = "Form_xacnhanthongbaohocphi";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}