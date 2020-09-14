namespace DataCollect
{
    partial class F_DeviceManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tV_设备管理 = new System.Windows.Forms.TreeView();
            this.cMS_添加设备 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_添加设备 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_添加设备.SuspendLayout();
            this.SuspendLayout();
            // 
            // tV_设备管理
            // 
            this.tV_设备管理.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_设备管理.Location = new System.Drawing.Point(0, 0);
            this.tV_设备管理.Name = "tV_设备管理";
            this.tV_设备管理.Size = new System.Drawing.Size(263, 704);
            this.tV_设备管理.TabIndex = 0;
            this.tV_设备管理.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tV_设备管理_MouseDown);
            // 
            // cMS_添加设备
            // 
            this.cMS_添加设备.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_添加设备});
            this.cMS_添加设备.Name = "cMS_添加设备";
            this.cMS_添加设备.Size = new System.Drawing.Size(125, 26);
            // 
            // TSMI_添加设备
            // 
            this.TSMI_添加设备.Name = "TSMI_添加设备";
            this.TSMI_添加设备.Size = new System.Drawing.Size(180, 22);
            this.TSMI_添加设备.Text = "添加设备";
            // 
            // F_DeviceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 704);
            this.Controls.Add(this.tV_设备管理);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Name = "F_DeviceManage";
            this.Text = "设备管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_DeviceManage_FormClosing_1);
            this.cMS_添加设备.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tV_设备管理;
        private System.Windows.Forms.ContextMenuStrip cMS_添加设备;
        private System.Windows.Forms.ToolStripMenuItem TSMI_添加设备;
    }
}