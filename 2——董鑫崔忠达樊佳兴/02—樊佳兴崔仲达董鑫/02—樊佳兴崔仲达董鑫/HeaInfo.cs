using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace _02_樊佳兴崔仲达董鑫
{
    public partial class HeaInfo : Form
    {
        public HeaInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string apartment = comboBox1.Text;
            string roomNumber = textBox1.Text;
            string heaSituation = comboBox2.Text;
            string note = textBox2.Text;
            int result;
            sql = "insert into HeaInfo(Apartment,RoomNumber,HeaSituation,Note) values('" + apartment + "','" + roomNumber + "','" + heaSituation + "','" + note + "')";
            if(comboBox1.Text!=""&&comboBox2.Text!=""&&textBox1.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("卫生信息添加成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("卫生信息添加失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
