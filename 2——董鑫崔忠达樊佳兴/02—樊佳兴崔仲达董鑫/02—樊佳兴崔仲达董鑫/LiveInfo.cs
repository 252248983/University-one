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
    public partial class LiveInfo : Form
    {
        public LiveInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string studentName = textBox1.Text;
            string roomNumber = textBox2.Text;
            string roomType = comboBox1.Text;
            string beds = comboBox2.Text;
            string apartment = comboBox3.Text;
            int result;
            sql = "insert into LiveInfo(StudentName,Apartment,RoomNumber,RoomType,Beds) values('" + studentName + "','"+apartment+"','" + roomNumber + "','" + roomType + "','" + beds + "')";
            if(textBox1.Text!=""&& textBox2.Text!=""&& comboBox1.Text!=""&& comboBox2.Text!=""&&comboBox3.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("住宿信息添加成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("住宿信息添加失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
