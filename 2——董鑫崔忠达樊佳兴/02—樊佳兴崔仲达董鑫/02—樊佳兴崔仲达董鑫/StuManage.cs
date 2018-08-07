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
    public partial class StuManage : Form
    {
        public StuManage()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            string sql = "select * from StuInfo";
            DataSet ds = DBHelper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void StuManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            string sex = comboBox1.Text;
            string idNumber = textBox2.Text;
            string phoneNumber = textBox3.Text;
            string id = textBox4.Text;
            int result;

            sql = "update StuInfo set StudentName = '" + studentName + "',Sex = '" + sex + "',IDNumber = '" + idNumber + "',PhoneNumber = '" + phoneNumber + "',ID = '" + id + "'";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox4.Text != "")
            {
                result = DBHelper.ExecuteSql(sql);
                if (result == 1)
                {
                    MessageBox.Show("学生信息修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                }
                else
                {
                    MessageBox.Show("学生信息修改失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql;
            string ID = textBox4.Text;
            sql = "delete StuInfo where ID='" + ID + "'";
            int result = DBHelper.ExecuteSql(sql);
            if (result == 1)
            {
                MessageBox.Show("学生删除成功！", "，成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("学生删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

