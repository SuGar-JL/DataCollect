using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DataCollect;

namespace DataCollect
{
    /// <summary>
    /// 设备管理页面只有一个，采用单例模式
    /// </summary>
    public partial class F_DeviceManage : DockContent
    {
        private static F_DeviceManage Instance;
        public F_DeviceManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取设备管理的实例
        /// </summary>
        /// <returns></returns>
        public static F_DeviceManage GetInstance()
        {
            if (Instance == null)
            {
                Instance = new F_DeviceManage();
            }
            return Instance;
        }
        private void F_DeviceManage_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //关闭时清空了实例
            Instance = null;  // 否则下次打开时报错，提示“无法访问已释放对象”
        }

        private void tV_设备管理_MouseDown(object sender, MouseEventArgs e)
        {
            //右击节点弹出菜单，根节点与子节点不同
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = tV_设备管理.GetNodeAt(ClickPoint);
                //点击的是节点，且是节点所在区域
                if (CurrentNode != null && CurrentNode.Bounds.Contains(e.X, e.Y))
                {
                    //如果不是子节点，即是根节点
                    if (CurrentNode.FirstNode != null)
                    {
                        //currRightDownDevice = CurrentNode.Text;
                        //treeView1.ContextMenuStrip = contextMenuStrip_setDevice;
                    }
                    //是子节点
                    else if (CurrentNode.Parent != null)
                    {
                        //currRightDownChennal = CurrentNode.Text;
                        //treeView1.ContextMenuStrip = contextMenuStrip_setChennalAndSensor;
                    }

                }
                //点击的不是节点（空白处）
                else
                {
                    tV_设备管理.ContextMenuStrip = cMS_添加设备;
                }
            }
            //为了我不让双击时展开节点，而是做其他操作，winform默认双击左键会展开节点
            //左键点击
            else if (e.Button == MouseButtons.Left)
            {
                //num_MouseClicks = e.Clicks;//记录左键按下次数
            }
        }
    }
}
