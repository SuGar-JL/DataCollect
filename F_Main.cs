using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCollect
{
    public partial class F_Main : Form
    {
        public F_DeviceManage f_DeviceManage;
        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            f_DeviceManage = F_DeviceManage.GetInstance();
            f_DeviceManage.Show(dockPanel1);
            f_DeviceManage.DockTo(dockPanel1, DockStyle.Left);//左边停靠
        }

        private void tSBtn_设备管理_Click(object sender, EventArgs e)
        {
            //若设备管理窗口没有实例化或已经被释放（关闭了）
            if (f_DeviceManage == null || f_DeviceManage.IsDisposed == true)
            {
                f_DeviceManage = F_DeviceManage.GetInstance();
                f_DeviceManage.Show(dockPanel1);
                f_DeviceManage.DockTo(dockPanel1, DockStyle.Left);//左边停靠
            }
        }

    }
}
