using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient; //전용 데이터 프로바이더 
using System.Configuration;   //App.config 사용준비

namespace WinADONET2_1020
{
	public partial class Form1 : Form
	{
		string strConn = ConfigurationManager.ConnectionStrings["goodie"].ConnectionString;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MySqlConnection conn = new MySqlConnection(strConn);

			StringBuilder sb = new StringBuilder();
			sb.Append("select E.emp_no,");
			sb.Append("		  concat(first_name, ' ', last_name) emp_name, ");
			sb.Append("		  E.dept_no, ");
			sb.Append("		  D.dept_name");
			sb.Append("  from vw_current_emp E join departments D");
			sb.Append("	   on E.dept_no = D.dept_no");
			sb.Append(" where E.dept_no = 'd009';");
			// 이렇게 스트링빌더로 줄맞춰서 쓸수도 있다
			// 연결 문자열 줄때 앞뒤에 공백을 주는 습관을 들이면 좋다 없으면 오류남, 그리고 가독성도 늘어난다

			//			string sql = @"select E.emp_no, concat(first_name, ' ', last_name) emp_name, E.dept_no, D.dept_name 
			//from vw_current_emp E join departments D on E.dept_no = D.dept_no; ";
			MySqlDataAdapter da = new MySqlDataAdapter(sb.ToString(), conn);
			DataSet ds = new DataSet();

			conn.Open(); //Fill직전에만 해주면 된다
			da.Fill(ds);
			conn.Close();

			dataGridView1.DataSource = ds.Tables[0];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MySqlConnection conn = new MySqlConnection();
			conn.ConnectionString = strConn;

			StringBuilder sb = new StringBuilder();
			sb.Append("select E.emp_no, ");
			sb.Append("		  concat(first_name, ' ', last_name) emp_name, ");
			sb.Append("		  E.dept_no, ");
			sb.Append("		  D.dept_name");
			sb.Append("  from vw_current_emp E join departments D");
			sb.Append("	   on E.dept_no = D.dept_no");
			sb.Append(" where E.dept_no = 'd009';");

			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandText = sb.ToString();
			cmd.Connection = conn;
			conn.Open(); // Execute전에 오픈
			MySqlDataReader reader = cmd.ExecuteReader();

			//dataGridView1.DataSource = reader;
			//데이터 소스에 reader 바로 못줌 실행해보면 타입이 맞지 않다고 뜸
			DataTable dt = new DataTable();
			dt.Load(reader);
			conn.Close();

			dataGridView1.DataSource = dt;
			//빈 데이터 테이블을 하나 만들어 datareader를  data테이블로 만들고 줘야한다, Load메서드
			// 이래서 데이터그리드뷰에 무언가를 보여줄거면 DataAdapter를 쓰는게 그냥 좋다
		}

		private void Form1_Load(object sender, EventArgs e)// 폼을 실행시켰을때 한번만 실행되게 하려면 로드에 코딩
		{
			//폼이 실행되면 초기값을 설정해줌
			dataGridView1.AutoGenerateColumns = false; //열을 자동으로 생성시켜주는 코드 기본값 true
			dataGridView1.AllowUserToAddRows = false; // 맨 밑에 추가하는 열 없애주는 코드

			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //클릭하면 열전체를 선택해주는것
			dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//셀의 글자위치
			dataGridView1.ColumnHeadersHeight = 30; //행의 높이
			
			//메서드추출
			//DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			//col1.HeaderText = "사원번호";
			//col1.DataPropertyName = "emp_no";
			//col1.Width = 100;
			//col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			//dataGridView1.Columns.Add(col1);
			

			CommonUtil.AddGridTextColumn(dataGridView1, "사번", "emp_no", 100, true, DataGridViewContentAlignment.MiddleCenter);
			CommonUtil.AddGridTextColumn(dataGridView1, "사원명", "emp_name", 250);
			CommonUtil.AddGridTextColumn(dataGridView1, "부서", "dept_no", 100, false, DataGridViewContentAlignment.MiddleCenter);
			CommonUtil.AddGridTextColumn(dataGridView1, "부서명", "dept_name", 200);

		}

		// 클래스 화 CommonUtil
		// colWidth값에 디폴트값 100을 줘서 안쓰면 100들어가게 함
		//private void AddGridTextColumn(string headerText, 
		//							   string dataPropertyName, 
		//							   int colWidth = 100, 
		//							   bool visibility = true, 
		//							   DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
		//{
		//	DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
		//	col.HeaderText = headerText;
		//	col.DataPropertyName = dataPropertyName;
		//	col.Width = colWidth;
		//	col.DefaultCellStyle.Alignment = textAlign;
		//	col.Visible = false;

		//	dataGridView1.Columns.Add(col);
		//}
	}
}
