﻿using System;

namespace GoGo_Tester
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tIpConfig = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIpRange = new System.Windows.Forms.TextBox();
            this.bAddIpRange = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nTestCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.cbPools = new System.Windows.Forms.ComboBox();
            this.cmsIpData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mImportIpsInClipbord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mExportSelectedIps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mExportAllIps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mExportSelectedIpAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mExportAllIpsAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemoveSelectedIps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mRemoveAllIps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mRemoveIpsInClipbord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mRemoveInvalidIps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mApply = new System.Windows.Forms.ToolStripMenuItem();
            this.mApplySelectedIpsToUserConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mRndTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mStdTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mBandTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mStopTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mClearRndCache = new System.Windows.Forms.ToolStripMenuItem();
            this.mLoadIpPool = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIpData = new System.Windows.Forms.DataGridView();
            this.lTip = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lProgress = new System.Windows.Forms.Label();
            this.tIpConfig.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPingTimeout)).BeginInit();
            this.cmsIpData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpData)).BeginInit();
            this.SuspendLayout();
            // 
            // tIpConfig
            // 
            this.tIpConfig.AutoSize = true;
            this.tIpConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tIpConfig.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tIpConfig, 2);
            this.tIpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tIpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tIpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tIpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tIpConfig.Controls.Add(this.label5, 0, 0);
            this.tIpConfig.Controls.Add(this.tbIpRange, 1, 0);
            this.tIpConfig.Controls.Add(this.bAddIpRange, 2, 0);
            this.tIpConfig.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tIpConfig.Controls.Add(this.cbPools, 3, 0);
            this.tIpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tIpConfig.Location = new System.Drawing.Point(4, 701);
            this.tIpConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tIpConfig.Name = "tIpConfig";
            this.tIpConfig.RowCount = 2;
            this.tIpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tIpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tIpConfig.Size = new System.Drawing.Size(1406, 87);
            this.tIpConfig.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "导入IP段：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIpRange
            // 
            this.tbIpRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbIpRange.Location = new System.Drawing.Point(94, 5);
            this.tbIpRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIpRange.Name = "tbIpRange";
            this.tbIpRange.Size = new System.Drawing.Size(1041, 27);
            this.tbIpRange.TabIndex = 1;
            this.tbIpRange.Tag = "允许添加IP段，格式0-255,左边或者右边留空代表采用其最值。173.0-255.0-255.0-255代表173段所有IP。173.128.128.0/24与" +
    "173.128.128.0-255等价，173.128.128.0/18与173.128.128-255.0-255。";
            this.tbIpRange.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // bAddIpRange
            // 
            this.bAddIpRange.AutoSize = true;
            this.bAddIpRange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAddIpRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddIpRange.Location = new System.Drawing.Point(1143, 5);
            this.bAddIpRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddIpRange.Name = "bAddIpRange";
            this.bAddIpRange.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.bAddIpRange.Size = new System.Drawing.Size(79, 30);
            this.bAddIpRange.TabIndex = 2;
            this.bAddIpRange.Text = "导入";
            this.bAddIpRange.UseVisualStyleBackColor = true;
            this.bAddIpRange.Click += new System.EventHandler(this.bAddIpRange_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tIpConfig.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.nTestCount, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.nMaxThreads, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nPingTimeout, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 45);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1398, 37);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // nTestCount
            // 
            this.nTestCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.nTestCount.Location = new System.Drawing.Point(1003, 5);
            this.nTestCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nTestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTestCount.Name = "nTestCount";
            this.nTestCount.Size = new System.Drawing.Size(391, 27);
            this.nTestCount.TabIndex = 32;
            this.nTestCount.Tag = "";
            this.nTestCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nTestCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTestCount.ValueChanged += new System.EventHandler(this.nTestCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(926, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 37);
            this.label2.TabIndex = 31;
            this.label2.Tag = "对每个IP的测试次数，与IP的稳定性有关。";
            this.label2.Text = "测试次数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // nMaxThreads
            // 
            this.nMaxThreads.Dock = System.Windows.Forms.DockStyle.Top;
            this.nMaxThreads.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMaxThreads.Location = new System.Drawing.Point(51, 5);
            this.nMaxThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nMaxThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxThreads.Name = "nMaxThreads";
            this.nMaxThreads.Size = new System.Drawing.Size(391, 27);
            this.nMaxThreads.TabIndex = 27;
            this.nMaxThreads.Tag = "随机测试和标准测试的最大线程数";
            this.nMaxThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nMaxThreads.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nMaxThreads.ValueChanged += new System.EventHandler(this.nMaxTest_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 37);
            this.label3.TabIndex = 8;
            this.label3.Tag = "随机测试和标准测试的最大线程数";
            this.label3.Text = "线程";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(450, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 37);
            this.label1.TabIndex = 29;
            this.label1.Tag = "";
            this.label1.Text = "连接超时";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // nPingTimeout
            // 
            this.nPingTimeout.Dock = System.Windows.Forms.DockStyle.Top;
            this.nPingTimeout.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nPingTimeout.Location = new System.Drawing.Point(527, 5);
            this.nPingTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nPingTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPingTimeout.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nPingTimeout.Name = "nPingTimeout";
            this.nPingTimeout.Size = new System.Drawing.Size(391, 27);
            this.nPingTimeout.TabIndex = 30;
            this.nPingTimeout.Tag = "Ping的延时。";
            this.nPingTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nPingTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nPingTimeout.ValueChanged += new System.EventHandler(this.nPingTimeout_ValueChanged);
            // 
            // cbPools
            // 
            this.cbPools.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbPools.FormattingEnabled = true;
            this.cbPools.Location = new System.Drawing.Point(1230, 5);
            this.cbPools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPools.Name = "cbPools";
            this.cbPools.Size = new System.Drawing.Size(169, 28);
            this.cbPools.TabIndex = 28;
            this.cbPools.Tag = "选择IP池，启动时加载个人IP池，命名格式为 name.ip.txt，必须以 .ip.txt 结尾。内容允许为 192.168.0-255.0-55 或 192." +
    "168.0.0/16 或 www.google.com 。默认查询 google.com 的 spf 记录，可以新建 spf.txt 并写入域名更改查询的域名，" +
    "域名间以空格分隔。";
            this.cbPools.SelectedIndexChanged += new System.EventHandler(this.cbPools_SelectedIndexChanged);
            this.cbPools.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // cmsIpData
            // 
            this.cmsIpData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsIpData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mImport,
            this.toolStripSeparator1,
            this.mExport,
            this.toolStripSeparator2,
            this.mRemove,
            this.toolStripSeparator3,
            this.mApply});
            this.cmsIpData.Name = "cmsIpData";
            this.cmsIpData.Size = new System.Drawing.Size(130, 118);
            // 
            // mImport
            // 
            this.mImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mImportIpsInClipbord});
            this.mImport.Name = "mImport";
            this.mImport.Size = new System.Drawing.Size(129, 24);
            this.mImport.Text = "导入(&I)";
            // 
            // mImportIpsInClipbord
            // 
            this.mImportIpsInClipbord.Name = "mImportIpsInClipbord";
            this.mImportIpsInClipbord.Size = new System.Drawing.Size(200, 26);
            this.mImportIpsInClipbord.Text = "剪切板中的IP(&C)";
            this.mImportIpsInClipbord.Click += new System.EventHandler(this.mImportIpsInClipbord_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // mExport
            // 
            this.mExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExportSelectedIps,
            this.toolStripSeparator6,
            this.mExportAllIps,
            this.toolStripSeparator7,
            this.mExportSelectedIpAsJson,
            this.toolStripSeparator9,
            this.mExportAllIpsAsJson});
            this.mExport.Name = "mExport";
            this.mExport.Size = new System.Drawing.Size(129, 24);
            this.mExport.Text = "导出(&E)";
            // 
            // mExportSelectedIps
            // 
            this.mExportSelectedIps.Name = "mExportSelectedIps";
            this.mExportSelectedIps.Size = new System.Drawing.Size(203, 26);
            this.mExportSelectedIps.Text = "选中的IP (INI)";
            this.mExportSelectedIps.Click += new System.EventHandler(this.mExportSelectedIps_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(200, 6);
            // 
            // mExportAllIps
            // 
            this.mExportAllIps.Name = "mExportAllIps";
            this.mExportAllIps.Size = new System.Drawing.Size(203, 26);
            this.mExportAllIps.Text = "全部IP (INI)";
            this.mExportAllIps.Click += new System.EventHandler(this.mExportAllIps_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(200, 6);
            // 
            // mExportSelectedIpAsJson
            // 
            this.mExportSelectedIpAsJson.Name = "mExportSelectedIpAsJson";
            this.mExportSelectedIpAsJson.Size = new System.Drawing.Size(203, 26);
            this.mExportSelectedIpAsJson.Text = "选中的IP (JSON)";
            this.mExportSelectedIpAsJson.Click += new System.EventHandler(this.mExportSelectedIp_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(200, 6);
            // 
            // mExportAllIpsAsJson
            // 
            this.mExportAllIpsAsJson.Name = "mExportAllIpsAsJson";
            this.mExportAllIpsAsJson.Size = new System.Drawing.Size(203, 26);
            this.mExportAllIpsAsJson.Text = "全部IP (JSON)";
            this.mExportAllIpsAsJson.Click += new System.EventHandler(this.mExportAllIpsAsJson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // mRemove
            // 
            this.mRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRemoveSelectedIps,
            this.toolStripSeparator4,
            this.mRemoveAllIps,
            this.toolStripSeparator8,
            this.mRemoveIpsInClipbord,
            this.toolStripSeparator5,
            this.mRemoveInvalidIps});
            this.mRemove.Name = "mRemove";
            this.mRemove.Size = new System.Drawing.Size(129, 24);
            this.mRemove.Text = "移除(&R)";
            // 
            // mRemoveSelectedIps
            // 
            this.mRemoveSelectedIps.Name = "mRemoveSelectedIps";
            this.mRemoveSelectedIps.Size = new System.Drawing.Size(230, 26);
            this.mRemoveSelectedIps.Text = "选中的IP(&S)";
            this.mRemoveSelectedIps.Click += new System.EventHandler(this.mRemoveSelectedIps_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // mRemoveAllIps
            // 
            this.mRemoveAllIps.Name = "mRemoveAllIps";
            this.mRemoveAllIps.Size = new System.Drawing.Size(230, 26);
            this.mRemoveAllIps.Text = "全部IP(&A)";
            this.mRemoveAllIps.Click += new System.EventHandler(this.mRemoveAllIps_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(227, 6);
            // 
            // mRemoveIpsInClipbord
            // 
            this.mRemoveIpsInClipbord.Name = "mRemoveIpsInClipbord";
            this.mRemoveIpsInClipbord.Size = new System.Drawing.Size(230, 26);
            this.mRemoveIpsInClipbord.Text = "剪切板中存在的IP(&C)";
            this.mRemoveIpsInClipbord.Click += new System.EventHandler(this.mRemoveIpsInClipbord_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(227, 6);
            // 
            // mRemoveInvalidIps
            // 
            this.mRemoveInvalidIps.Name = "mRemoveInvalidIps";
            this.mRemoveInvalidIps.Size = new System.Drawing.Size(230, 26);
            this.mRemoveInvalidIps.Text = "无效的IP(&I)";
            this.mRemoveInvalidIps.Click += new System.EventHandler(this.mRemoveInvalidIps_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // mApply
            // 
            this.mApply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApplySelectedIpsToUserConfig});
            this.mApply.Name = "mApply";
            this.mApply.Size = new System.Drawing.Size(129, 24);
            this.mApply.Text = "应用(&A)";
            // 
            // mApplySelectedIpsToUserConfig
            // 
            this.mApplySelectedIpsToUserConfig.Name = "mApplySelectedIpsToUserConfig";
            this.mApplySelectedIpsToUserConfig.Size = new System.Drawing.Size(274, 26);
            this.mApplySelectedIpsToUserConfig.Tag = "只支持IPv4。";
            this.mApplySelectedIpsToUserConfig.Text = "选中的IP到用户配置文件(&S)";
            this.mApplySelectedIpsToUserConfig.Click += new System.EventHandler(this.mApplySelectedIpsToUserConfig_Click);
            this.mApplySelectedIpsToUserConfig.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.msMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvIpData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lTip, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tIpConfig, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbProgress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lProgress, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 843);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // msMain
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.msMain, 2);
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRndTest,
            this.mStdTest,
            this.mBandTest,
            this.mStopTest,
            this.mClearRndCache,
            this.mLoadIpPool});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msMain.Size = new System.Drawing.Size(1414, 30);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // mRndTest
            // 
            this.mRndTest.Name = "mRndTest";
            this.mRndTest.Size = new System.Drawing.Size(103, 24);
            this.mRndTest.Tag = "随机从IP池中获取指定数量的可用IP。如果指定的数目过于庞大，可能会花费很长时间进行测试。";
            this.mRndTest.Text = "随机测试(&R)";
            this.mRndTest.Click += new System.EventHandler(this.mRndTest_Click);
            this.mRndTest.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // mStdTest
            // 
            this.mStdTest.Name = "mStdTest";
            this.mStdTest.Size = new System.Drawing.Size(102, 24);
            this.mStdTest.Tag = "测试IP是否可用。";
            this.mStdTest.Text = "标准测试(&S)";
            this.mStdTest.Click += new System.EventHandler(this.mStdTest_Click);
            this.mStdTest.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // mBandTest
            // 
            this.mBandTest.Name = "mBandTest";
            this.mBandTest.Size = new System.Drawing.Size(102, 24);
            this.mBandTest.Tag = "测试IP的连接带宽。";
            this.mBandTest.Text = "带宽测试(&B)";
            this.mBandTest.Click += new System.EventHandler(this.mBandTest_Click);
            this.mBandTest.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // mStopTest
            // 
            this.mStopTest.Name = "mStopTest";
            this.mStopTest.Size = new System.Drawing.Size(102, 24);
            this.mStopTest.Tag = "停止所有测试。";
            this.mStopTest.Text = "停止测试(&T)";
            this.mStopTest.Click += new System.EventHandler(this.mStopTest_Click);
            this.mStopTest.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // mClearRndCache
            // 
            this.mClearRndCache.Name = "mClearRndCache";
            this.mClearRndCache.Size = new System.Drawing.Size(133, 24);
            this.mClearRndCache.Text = "清除测试缓存(&C)";
            this.mClearRndCache.Click += new System.EventHandler(this.mClearRndCache_Click);
            // 
            // mLoadIpPool
            // 
            this.mLoadIpPool.Name = "mLoadIpPool";
            this.mLoadIpPool.Size = new System.Drawing.Size(99, 24);
            this.mLoadIpPool.Tag = "加载随机测试IP池";
            this.mLoadIpPool.Text = "加载IP池(&L)";
            this.mLoadIpPool.Click += new System.EventHandler(this.mLoadIpPool_Click);
            this.mLoadIpPool.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // dgvIpData
            // 
            this.dgvIpData.AllowUserToAddRows = false;
            this.dgvIpData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvIpData, 2);
            this.dgvIpData.ContextMenuStrip = this.cmsIpData;
            this.dgvIpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIpData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIpData.Location = new System.Drawing.Point(4, 61);
            this.dgvIpData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIpData.Name = "dgvIpData";
            this.dgvIpData.ReadOnly = true;
            this.dgvIpData.RowHeadersWidth = 50;
            this.dgvIpData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvIpData.RowTemplate.DefaultCellStyle.NullValue = "N/A";
            this.dgvIpData.RowTemplate.Height = 30;
            this.dgvIpData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIpData.Size = new System.Drawing.Size(1406, 630);
            this.dgvIpData.TabIndex = 25;
            this.dgvIpData.Tag = "右键导入支持 IPv4 和 IPv6。G：可直连Google；A：可连接AppSpot，即GAE；NN：无效IP。地理位置数据由 IP2Location™ 提供：" +
    "https://lite.ip2location.com/database/ip-country。";
            this.dgvIpData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvIpData_RowPostPaint);
            this.dgvIpData.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // lTip
            // 
            this.lTip.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lTip, 2);
            this.lTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTip.ForeColor = System.Drawing.Color.DarkRed;
            this.lTip.Location = new System.Drawing.Point(4, 793);
            this.lTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTip.MinimumSize = new System.Drawing.Size(0, 50);
            this.lTip.Name = "lTip";
            this.lTip.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lTip.Size = new System.Drawing.Size(1406, 50);
            this.lTip.TabIndex = 12;
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgress.Location = new System.Drawing.Point(4, 35);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1196, 16);
            this.pbProgress.Step = 1;
            this.pbProgress.TabIndex = 23;
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProgress.Location = new System.Drawing.Point(1208, 30);
            this.lProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(202, 20);
            this.lProgress.TabIndex = 24;
            this.lProgress.Tag = "随机测试 线程数 / 完成数 / 已测试数；标准测试：线程数 / 剩余数";
            this.lProgress.Text = "0 / 0";
            this.lProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lProgress.MouseEnter += new System.EventHandler(this.Tip_MouseEnter);
            // 
            // Form1
            // 
            this.AcceptButton = this.bAddIpRange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(711, 635);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "GoGo Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tIpConfig.ResumeLayout(false);
            this.tIpConfig.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPingTimeout)).EndInit();
            this.cmsIpData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIpData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel tIpConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIpRange;
        private System.Windows.Forms.Button bAddIpRange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsIpData;
        private System.Windows.Forms.ToolStripMenuItem mImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mExport;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mStdTest;
        private System.Windows.Forms.ToolStripMenuItem mImportIpsInClipbord;
        private System.Windows.Forms.ToolStripMenuItem mExportSelectedIps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mRemove;
        private System.Windows.Forms.ToolStripMenuItem mRemoveSelectedIps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ToolStripMenuItem mExportAllIps;
        private System.Windows.Forms.ToolStripMenuItem mRemoveAllIps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mRemoveIpsInClipbord;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.NumericUpDown nMaxThreads;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem mStopTest;
        private System.Windows.Forms.ToolStripMenuItem mRndTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mApply;
        private System.Windows.Forms.NumericUpDown nPingTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mApplySelectedIpsToUserConfig;
        private System.Windows.Forms.ToolStripMenuItem mClearRndCache;
        private System.Windows.Forms.NumericUpDown nTestCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mBandTest;
        private System.Windows.Forms.ComboBox cbPools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mRemoveInvalidIps;
        private System.Windows.Forms.ToolStripMenuItem mLoadIpPool;
        private System.Windows.Forms.ToolStripMenuItem mExportSelectedIpAsJson;
        private System.Windows.Forms.ToolStripMenuItem mExportAllIpsAsJson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridView dgvIpData;
        private System.Windows.Forms.Label lTip;
    }
}

