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
    public partial class HeaManage : Form
    {
        public HeaManage()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            string sql = "select * from HeaInfo";
            DataSet ds = DBHelper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void HeaManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            string apartment = comboBox1.Text;
            string roomNumber = textBox1.Text;
            string heaSituation = comboBox2.Text;
            string note = textBox2.Text;
            int result;

            sql = "update HeaInfo set Apartment='" + apartment + "',RoomNumber='" + roomNumber + "',HeaSituation='" + heaSituation + "',Note='" + note + "'";
            if(comboBox1.Text!=""&&comboBox2.Text!=""&&textBox1.Text!=""&&textBox2.Text!="")
            {
                result = DBHelper.ExecuteSql(sql);
                if(result==1)
                {
                    MessageBox.Show("卫生情况修改成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                }
                else
                {
                    MessageBox.Show("卫生情况修改失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请检查数据输入的正确性！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string Apartment = comboBox1.Text;
            sql = "delete HeaInfo where Apartment='" + Apartment + "'";
            int result = DBHelper.ExecuteSql(sql);
            if(result==1)
            {
                MessageBox.Show("卫生情况删除成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind();
            }
            else
            {
                MessageBox.Show("卫生情况删除失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
