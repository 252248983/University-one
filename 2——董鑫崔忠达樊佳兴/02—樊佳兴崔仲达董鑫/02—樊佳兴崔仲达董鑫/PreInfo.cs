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
    public partial class PreInfo : Form
    {
        public PreInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            string res = textBox2.Text;
            string checkInTime = comboBox1.Text + "年" + comboBox2.Text + "月" + comboBox3.Text + "日";
            string phoneNumber = textBox3.Text;
            int result;

            sql = "insert into PreInfo (StudentName,Res,CheckInTime,PhoneNumber) values('" + studentName + "','" + res + "','" + checkInTime + "','" + phoneNumber + "')";
            if(textBox1.Text!=""&&textBox2.Text!=""&&comboBox1.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!=""&&textBox3.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("贵重物品登记成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("贵重物品登记失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性", "成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
