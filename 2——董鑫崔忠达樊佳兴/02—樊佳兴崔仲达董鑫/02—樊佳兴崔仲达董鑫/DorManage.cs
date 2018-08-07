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
    public partial class DorManage : Form
    {
        public DorManage()
        {
            InitializeComponent();
        }

        private void 确认退出AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuInfo frmStuInfo = new StuInfo();
            frmStuInfo.MdiParent = this;
            frmStuInfo.Show();

        }

        private void 管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuManage frmStuManage = new StuManage();
            frmStuManage.MdiParent = this;
            frmStuManage.Show();
        }

        private void 登记PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveInfo frmLiveInfo = new LiveInfo();
            frmLiveInfo.MdiParent = this;
            frmLiveInfo.Show();
        }

        private void 管理FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiveManage frmLiveManage = new LiveManage();
            frmLiveManage.MdiParent = this;
            frmLiveManage.Show();
        }

        private void 卫生情况AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeaInfo frmHeaInfo = new HeaInfo();
            frmHeaInfo.MdiParent = this;
            frmHeaInfo.Show();
        }

        private void 卫生情况管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeaManage frmHeaManage = new HeaManage();
            frmHeaManage.MdiParent = this;
            frmHeaManage.Show();
        }

        private void 来访人员登记AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisInfo frmVisInfo = new VisInfo();
            frmVisInfo.MdiParent = this;
            frmVisInfo.Show();
        }

        private void 来访人员管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisManage frmVisManage = new VisManage();
            frmVisManage.MdiParent = this;
            frmVisManage.Show();

        }

        private void 贵重物品登记AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreInfo frmPreInfo = new PreInfo();
            frmPreInfo.MdiParent = this;
            frmPreInfo.Show();
        }

        private void 贵重物品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreManage frmPreManage = new PreManage();
            frmPreManage.MdiParent = this;
            frmPreManage.Show();
        }
    }
}
