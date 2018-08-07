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
    public partial class VisInfo : Form
    {
        public VisInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string visName = textBox1.Text;
            string sex = comboBox1.Text;
            string idNumber = textBox2.Text;
            string apartment = comboBox2.Text;
            string checkInTime = comboBox3.Text + "年" + comboBox4.Text + "月" + comboBox5.Text + "日";
            int result;

            sql = "insert into VisInfo (VisName,Sex,IDNumber,Apartment,CheckInTime) values('" + visName + "','" + sex + "','" + idNumber + "','" + apartment + "','" + checkInTime + "')";
            if(textBox1.Text!=""&&comboBox1.Text!=""&&textBox2.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!=""&&comboBox4.Text!=""&comboBox5.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("访客信息添加成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("访客信息添加失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}