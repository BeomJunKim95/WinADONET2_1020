using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinADONET2_1020
{
	//많이쓰는 걸 빼서 클래스로 따로 만듦
	class CommonUtil
	{
		//데이터 그리드뷰 설정
		public static void SetInitGridView(DataGridView dgv)
		{
			dgv.AutoGenerateColumns = false;
			dgv.AllowUserToAddRows = false;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		public static void AddGridTextColumn(
									  DataGridView dgv,
									  string headerText,
									  string dataPropertyName,
									  int colWidth = 100,
									  bool visibility = true,
									  DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
		{
			DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
			col.HeaderText = headerText;
			col.DataPropertyName = dataPropertyName;
			col.Width = colWidth;
			col.DefaultCellStyle.Alignment = textAlign;
			col.Visible = visibility;
			col.ReadOnly = false; //수정못하게 읽기만 하게 하려할때

			dgv.Columns.Add(col);
		}
	}
}
