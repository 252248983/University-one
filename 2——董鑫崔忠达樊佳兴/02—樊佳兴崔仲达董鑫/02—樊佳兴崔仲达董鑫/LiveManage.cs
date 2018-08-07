using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_樊佳兴崔仲达董鑫
{
    public partial class LiveManage : Form
    {
        public LiveManage()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            string sql = "select * from LiveInfo";
            DataSet ds = DBHelper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void LiveManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            string apartment = comboBox3.Text;
            string roomNumber = textBox2.Text;
            string roomType = comboBox1.Text;
            string beds = comboBox2.Text;
            int result;

            sql = "update LiveInfo set StudentName='" + studentName + "',Apartment='" + apartment + "',RoomNumber='" + roomNumber + "',RoomType='" + roomType + "',Beds='" + beds + "'";
            if (textBox1.Text != "" && comboBox3.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("住宿信息修改成功！", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DataBind();
                }
                else
                {
                    MessageBox.Show("住宿信息修改失败！", "错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string StudentName = textBox1.Text;
            sql="delete LiveInfo where StudentName='"+StudentName+"'";
            int result = DBHelper.ExecuteSql(sql);
            if(result==1)
            {
                MessageBox.Show("住宿信息删除成功！", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("住宿信息删除失败！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
