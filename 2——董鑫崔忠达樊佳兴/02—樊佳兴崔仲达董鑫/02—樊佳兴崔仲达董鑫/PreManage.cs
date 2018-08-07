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
    public partial class PreManage : Form
    {
        public PreManage()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            string sql = "select * from PreInfo";
            DataSet ds = DBHelper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PreManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string i = comboBox1.Text + "年" + comboBox2.Text + "月" + comboBox3.Text + "日";
            string studentName = textBox1.Text;
            string res = textBox2.Text;
            string checkInTime = i;
            string phoneNumber = textBox3.Text;
            int result;

            sql = "update PreInfo set StudentName='" + studentName + "',Res='" + res + "',CheckInTime='" + checkInTime + "',PhoneNumber='" + phoneNumber + "'";
            result = DBHelper.ExecuteSql(sql);
            if(result==1)
            {
                MessageBox.Show("贵重物品登记修改成功！", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("贵重物品登记失败！", "错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            sql = "delete PreInfo where StudentName='" + studentName + "'";
            int result = DBHelper.ExecuteSql(sql);
            if (result == 1)
            {
                MessageBox.Show("贵重物品修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("贵重物品修改失败！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            string nian = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string nian1 = nian.Substring(0, 4);
            comboBox1.Text = nian1;
            string yue = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string yue1 = yue.Substring(5, 2);
            comboBox2.Text = yue1;
            string ri = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string ri1 = yue.Substring(8, 2);
            comboBox3.Text = ri1;
            textBox3.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
