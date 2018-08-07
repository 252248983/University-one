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
    public partial class VisManage : Form
    {
        public VisManage()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            string sql = "select * from VisInfo";
            DataSet ds = DBHelper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void VisManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string i = comboBox3.Text +"年"+ comboBox4.Text +"月" + comboBox5.Text+"日";
            string visName = textBox1.Text;
            string sex = comboBox1.Text;
            string idNumber = textBox2.Text;
            string apartment = comboBox2.Text;
            string checkInTime = i;
            int result;

            sql = "update VisInfo set VisName='" + visName + "',Sex='" + sex + "',IDNumber='" + idNumber + "',Apartment='" + apartment + "',CheckInTime='" + checkInTime + "'";
            if(textBox1.Text!=""&&comboBox1.Text!=""&&textBox2.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!=""&&comboBox4.Text!=""&&comboBox5.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("访客信息修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                }
                else
                {
                    MessageBox.Show("访客信息修改失败！", "错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string VisName = textBox1.Text;
            sql = "delete VisInfo where VisName='" + VisName + "'";
            int result = DBHelper.ExecuteSql(sql);
            if(result==1)
            {
                MessageBox.Show("访客信息删除成功！", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("访客信息删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
            string nian = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
            string nian1 = nian.Substring(0, 4);
            comboBox3.Text = nian1;
            string yue = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
            string yue1 = yue.Substring(5, 2);
            comboBox4.Text = yue1;
            string ri = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
            string ri1 = yue.Substring(8, 2);
            comboBox5.Text = ri1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
