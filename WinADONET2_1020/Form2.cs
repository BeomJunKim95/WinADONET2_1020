using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WinADONET2_1020
{
	public partial class Form2 : Form
	{
		string strConn = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			//데이터 그리드뷰 설정(컬럼설정)
			CommonUtil.SetInitGridView(dgvMember);

			CommonUtil.AddGridTextColumn(dgvMember, "회원ID", "userID");
			CommonUtil.AddGridTextColumn(dgvMember, "회원명", "userName", 200);
			CommonUtil.AddGridTextColumn(dgvMember, "비밀번호", "userPwd");

			//등록된 데이터 목록 조회
			DataRetrieve();
		}
		private void DataRetrieve()//이벤트가 끝나면 자동으로 데이터뷰에 바뀐 정보를 띄워주는 메서드
		{
			MySqlConnection conn = new MySqlConnection(strConn);
			string sql = @"select userID, userPwd, userName 
							 from members; ";
			MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
			DataSet ds = new DataSet();
			conn.Open();
			da.Fill(ds, "member");
			conn.Close();

			dgvMember.DataSource = ds.Tables["member"];

			txtID.Text = txtName.Text = txtPwd.Text = "";//텍스트박스에 작성한 내용들을 이벤트가 끝나면 초기화
			txtID.Enabled = true; //밑에서 잠긴 텍스트 박스를 다시 열어줌 
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			//유효성 체크
			if (txtID.Text.Trim().Length < 1)
			{
				MessageBox.Show("회원ID를 입력하여 주십시오.");
				return;
			}

			//DB저장
			MySqlConnection conn = new MySqlConnection(strConn);
			string sql = $@"insert into members (userID, userPwd, userName)
  values('{ txtID.Text}', '{ txtPwd.Text}', '{ txtName.Text}' ); ";
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			conn.Open();
			cmd.ExecuteNonQuery(); // 인서트니까 논쿼리
			conn.Close();


			//저장완료 메세지
			//MessageBox.Show("회원이 등록되었습니다.");

			DataRetrieve();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DataRetrieve();
		}

		private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtID.Text = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtName.Text = dgvMember.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtPwd.Text = dgvMember.Rows[e.RowIndex].Cells[2].Value.ToString();

			txtID.Enabled = false; //셀을 더블클릭했을때 텍스트박스에 정보가 뜨게 해주는데 기본키는 바뀌면 안되니 아예 잠궈버림

			#region 다른방법
			//데이터그리드뷰에 컬럼은 적은데 보여줘야하는 상세내용이 많을때 사용하는 방식
			//string userid = dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString();
			//MySqlConnection conn = new MySqlConnection(strConn);
			//MySqlCommand cmd = new MySqlCommand("select * from members where userID =' " + userid + "'", conn);
			//conn.Open();
			//MySqlDataReader reader = cmd.ExecuteReader();
			//if(reader.Read())
			//{
			//	txtID.Text = reader["userID"].ToString();
			//	txtName.Text = reader["userName"].ToString();
			//	txtPwd.Text = reader["userPwd"].ToString();
			//}
			//conn.Close();
			#endregion
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if(txtID.Enabled)
			{
				MessageBox.Show("수정할 회원을 선택하여 주십시오.");
				return;
			}

			MySqlConnection conn = new MySqlConnection(strConn);
			string sql = $@"update members
							   set userPwd = '{ txtPwd.Text}',
								   userName = '{ txtName.Text}'
						     where userID = '{ txtID.Text}'; ";
			MySqlCommand cmd = new MySqlCommand(sql, conn);
			conn.Open();
			cmd.ExecuteNonQuery(); // 업데이트니까 논쿼리
			conn.Close();

			DataRetrieve();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (txtID.Enabled)
			{
				MessageBox.Show("삭제할 회원을 선택하여 주십시오.");
				return;
			}

			if (MessageBox.Show($"{txtName.Text}님의 정보를 정말로 삭제하시겠습니까?", "삭제확인", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MySqlConnection conn = new MySqlConnection(strConn);
				string sql = $@"Delete 
							  from members 
						     where userID = '{ txtID.Text}'; ";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				conn.Open();
				cmd.ExecuteNonQuery(); // 딜리트니까 논쿼리
				conn.Close();

				DataRetrieve();
			}
		}
	}
}
