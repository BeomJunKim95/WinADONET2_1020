namespace WinADONET2_1020
{
	partial class Form2
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
			this.dgvMember = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMember
			// 
			this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMember.Location = new System.Drawing.Point(12, 12);
			this.dgvMember.Name = "dgvMember";
			this.dgvMember.RowTemplate.Height = 23;
			this.dgvMember.Size = new System.Drawing.Size(498, 527);
			this.dgvMember.TabIndex = 7;
			this.dgvMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(516, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(429, 269);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "회원정보";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "회원ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "회원명";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "비밀번호";
			// 
			// txtID
			// 
			this.txtID.BackColor = System.Drawing.SystemColors.Info;
			this.txtID.Location = new System.Drawing.Point(146, 66);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(186, 26);
			this.txtID.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(146, 128);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(186, 26);
			this.txtName.TabIndex = 1;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(146, 190);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(186, 26);
			this.txtPwd.TabIndex = 2;
			// 
			// btnInsert
			// 
			this.btnInsert.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnInsert.Location = new System.Drawing.Point(580, 340);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(137, 66);
			this.btnInsert.TabIndex = 4;
			this.btnInsert.Text = "등록";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSearch.Location = new System.Drawing.Point(758, 340);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(137, 66);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "조회";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnUpdate.Location = new System.Drawing.Point(580, 438);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(137, 66);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDelete.Location = new System.Drawing.Point(758, 438);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(137, 66);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "삭제";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 555);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvMember);
			this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form2";
			this.Text = "회원관리";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMember;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
	}
}