using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _02_樊佳兴崔仲达董鑫
{
    public partial class StuInfo : Form
    {
        public StuInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            string sex = comboBox1.Text;
            string idNumber = textBox2.Text;
            string phoneNumber = textBox3.Text;
            string id = textBox4.Text;
            int result;

            sql = "insert into StuInfo(StudentName,Sex,IDNumber,PhoneNumber,ID) values('" + studentName + "','" + sex + "'," + idNumber + ",'" + phoneNumber + "','"+id+"')";
            if(textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!=""&&comboBox1.Text!=""&&textBox4.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("学生信息添加成功！","成功提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("学生信息添加失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
