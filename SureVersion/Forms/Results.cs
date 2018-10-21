using SureVersion.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureVersion.Forms
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            InitDataGridResult();
        }

        public Results(List<TestQuery> ListTestQuery)
        {
            InitializeComponent();
            InitDataGridResult();

            UpdateGrid(ListTestQuery);
        }

        private void InitDataGridResult()
        {
            DataGridResult.ColumnCount = 8;
            DataGridResult.Columns[0].Name = "Name";
            DataGridResult.Columns[1].Name = "Url";
            DataGridResult.Columns[2].Name = "Method";
            DataGridResult.Columns[3].Name = "Enverioment";
            DataGridResult.Columns[4].Name = "ResultExecute";
            DataGridResult.Columns[5].Name = "IsVersion";
            DataGridResult.Columns[5].Visible = false;
            DataGridResult.Columns[6].Name = "StatusCode";
            DataGridResult.Columns[7].Name = "Status";
        }

        public void UpdateGrid(List<TestQuery> QueryResult)
        {
            DataGridResult.Rows.Clear();

            foreach (var Result in QueryResult)
            {
                DataGridResult.Rows.Add(Result.ToArrayObject());
            }

            for (int i = 0; i < DataGridResult.Rows.Count; i++)
            {
                int StatusCode = QueryResult[i].HttpResult.StatusCode.GetHashCode();
                if (StatusCode >= 200 && StatusCode <= 399)
                {
                    DataGridResult.Rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.Green,
                        ForeColor = Color.White,
                        SelectionForeColor = Color.White
                    };
                }
                else if (StatusCode >= 400 && StatusCode <= 499)
                {
                    DataGridResult.Rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.Orange,
                        ForeColor = Color.White,
                        SelectionForeColor = Color.White
                    };
                }
                else
                {
                    DataGridResult.Rows[i].DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        SelectionForeColor = Color.White
                    };
                }
            }
        }
    }
}
