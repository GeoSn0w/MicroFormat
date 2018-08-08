namespace MicroFormat
{
    partial class Form1
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
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            iTalk.ControlRenderer controlRenderer2 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable2 = new iTalk.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topbar = new System.Windows.Forms.Panel();
            this.hwite = new System.Windows.Forms.Panel();
            this.icn = new System.Windows.Forms.PictureBox();
            this.yeeFormatThis = new System.ComponentModel.BackgroundWorker();
            this.info_about_btn = new System.Windows.Forms.PictureBox();
            this.vanity_link = new iTalk.iTalk_HeaderLabel();
            this.doFormatNow = new iTalk.iTalk_Button_2();
            this.VolumeName = new iTalk.iTalk_TextBox_Small();
            this.iTalk_HeaderLabel4 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_HeaderLabel3 = new iTalk.iTalk_HeaderLabel();
            this.drives_list_cbox = new iTalk.iTalk_ComboBox();
            this.iTalk_HeaderLabel2 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.evLog = new System.Windows.Forms.RichTextBox();
            this.FS_CBOX = new iTalk.iTalk_ComboBox();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_ContextMenuStrip1 = new iTalk.iTalk_ContextMenuStrip();
            this.logs_cmenu = new iTalk.iTalk_ContextMenuStrip();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topbar.SuspendLayout();
            this.hwite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_about_btn)).BeginInit();
            this.iTalk_GroupBox1.SuspendLayout();
            this.logs_cmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.topbar.Controls.Add(this.iTalk_ControlBox1);
            this.topbar.Controls.Add(this.iTalk_HeaderLabel1);
            this.topbar.Location = new System.Drawing.Point(29, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(527, 27);
            this.topbar.TabIndex = 0;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            // 
            // hwite
            // 
            this.hwite.BackColor = System.Drawing.Color.White;
            this.hwite.Controls.Add(this.icn);
            this.hwite.Location = new System.Drawing.Point(0, 0);
            this.hwite.Name = "hwite";
            this.hwite.Size = new System.Drawing.Size(30, 27);
            this.hwite.TabIndex = 1;
            // 
            // icn
            // 
            this.icn.Image = global::MicroFormat.Properties.Resources.hard_disk__1_;
            this.icn.Location = new System.Drawing.Point(2, 2);
            this.icn.Name = "icn";
            this.icn.Size = new System.Drawing.Size(24, 22);
            this.icn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icn.TabIndex = 4;
            this.icn.TabStop = false;
            // 
            // yeeFormatThis
            // 
            this.yeeFormatThis.WorkerReportsProgress = true;
            this.yeeFormatThis.WorkerSupportsCancellation = true;
            this.yeeFormatThis.DoWork += new System.ComponentModel.DoWorkEventHandler(this.yeeFormatThis_DoWork);
            this.yeeFormatThis.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.yeeFormatThis_RunWorkerCompleted);
            // 
            // info_about_btn
            // 
            this.info_about_btn.Image = global::MicroFormat.Properties.Resources.info;
            this.info_about_btn.Location = new System.Drawing.Point(529, 562);
            this.info_about_btn.Name = "info_about_btn";
            this.info_about_btn.Size = new System.Drawing.Size(24, 21);
            this.info_about_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_about_btn.TabIndex = 4;
            this.info_about_btn.TabStop = false;
            this.info_about_btn.Click += new System.EventHandler(this.info_about_btn_Click);
            // 
            // vanity_link
            // 
            this.vanity_link.AutoSize = true;
            this.vanity_link.BackColor = System.Drawing.Color.Transparent;
            this.vanity_link.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanity_link.ForeColor = System.Drawing.Color.Gray;
            this.vanity_link.Location = new System.Drawing.Point(3, 560);
            this.vanity_link.Name = "vanity_link";
            this.vanity_link.Size = new System.Drawing.Size(180, 21);
            this.vanity_link.TabIndex = 11;
            this.vanity_link.Text = "by GeoSn0w (@FCE365)";
            this.vanity_link.Click += new System.EventHandler(this.vanity_link_Click);
            // 
            // doFormatNow
            // 
            this.doFormatNow.BackColor = System.Drawing.Color.Transparent;
            this.doFormatNow.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.doFormatNow.ForeColor = System.Drawing.Color.White;
            this.doFormatNow.Image = null;
            this.doFormatNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doFormatNow.Location = new System.Drawing.Point(141, 192);
            this.doFormatNow.Name = "doFormatNow";
            this.doFormatNow.Size = new System.Drawing.Size(274, 40);
            this.doFormatNow.TabIndex = 10;
            this.doFormatNow.Text = "Format Drive";
            this.doFormatNow.TextAlignment = System.Drawing.StringAlignment.Center;
            this.doFormatNow.Click += new System.EventHandler(this.doFormatNow_Click);
            // 
            // VolumeName
            // 
            this.VolumeName.BackColor = System.Drawing.Color.Transparent;
            this.VolumeName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.VolumeName.ForeColor = System.Drawing.Color.DimGray;
            this.VolumeName.Location = new System.Drawing.Point(217, 140);
            this.VolumeName.MaxLength = 32;
            this.VolumeName.Multiline = false;
            this.VolumeName.Name = "VolumeName";
            this.VolumeName.ReadOnly = false;
            this.VolumeName.Size = new System.Drawing.Size(305, 28);
            this.VolumeName.TabIndex = 9;
            this.VolumeName.Text = "New Volume";
            this.VolumeName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.VolumeName.UseSystemPasswordChar = false;
            this.VolumeName.TextChanged += new System.EventHandler(this.VolumeName_TextChanged);
            // 
            // iTalk_HeaderLabel4
            // 
            this.iTalk_HeaderLabel4.AutoSize = true;
            this.iTalk_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.iTalk_HeaderLabel4.Location = new System.Drawing.Point(30, 136);
            this.iTalk_HeaderLabel4.Name = "iTalk_HeaderLabel4";
            this.iTalk_HeaderLabel4.Size = new System.Drawing.Size(169, 30);
            this.iTalk_HeaderLabel4.TabIndex = 8;
            this.iTalk_HeaderLabel4.Text = "New Drive Label:";
            // 
            // iTalk_HeaderLabel3
            // 
            this.iTalk_HeaderLabel3.AutoSize = true;
            this.iTalk_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.iTalk_HeaderLabel3.Location = new System.Drawing.Point(30, 94);
            this.iTalk_HeaderLabel3.Name = "iTalk_HeaderLabel3";
            this.iTalk_HeaderLabel3.Size = new System.Drawing.Size(166, 30);
            this.iTalk_HeaderLabel3.TabIndex = 7;
            this.iTalk_HeaderLabel3.Text = "Drive To Format:";
            // 
            // drives_list_cbox
            // 
            this.drives_list_cbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drives_list_cbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drives_list_cbox.DropDownHeight = 100;
            this.drives_list_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drives_list_cbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.drives_list_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.drives_list_cbox.FormattingEnabled = true;
            this.drives_list_cbox.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.drives_list_cbox.IntegralHeight = false;
            this.drives_list_cbox.ItemHeight = 20;
            this.drives_list_cbox.Location = new System.Drawing.Point(217, 98);
            this.drives_list_cbox.Name = "drives_list_cbox";
            this.drives_list_cbox.Size = new System.Drawing.Size(305, 26);
            this.drives_list_cbox.StartIndex = 0;
            this.drives_list_cbox.TabIndex = 6;
            this.drives_list_cbox.SelectedIndexChanged += new System.EventHandler(this.drives_list_cbox_SelectedIndexChanged);
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(30, 52);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(169, 30);
            this.iTalk_HeaderLabel2.TabIndex = 5;
            this.iTalk_HeaderLabel2.Text = "New File System:";
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.evLog);
            this.iTalk_GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(35, 250);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(487, 293);
            this.iTalk_GroupBox1.TabIndex = 4;
            this.iTalk_GroupBox1.Text = "Event Logs";
            // 
            // evLog
            // 
            this.evLog.BackColor = System.Drawing.Color.White;
            this.evLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.evLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.evLog.DetectUrls = false;
            this.evLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evLog.Location = new System.Drawing.Point(5, 28);
            this.evLog.Name = "evLog";
            this.evLog.ReadOnly = true;
            this.evLog.ShortcutsEnabled = false;
            this.evLog.Size = new System.Drawing.Size(477, 260);
            this.evLog.TabIndex = 0;
            this.evLog.Text = "";
            // 
            // FS_CBOX
            // 
            this.FS_CBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FS_CBOX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FS_CBOX.DropDownHeight = 100;
            this.FS_CBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FS_CBOX.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FS_CBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.FS_CBOX.FormattingEnabled = true;
            this.FS_CBOX.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FS_CBOX.IntegralHeight = false;
            this.FS_CBOX.ItemHeight = 20;
            this.FS_CBOX.Items.AddRange(new object[] {
            "NTFS\t (Quick)",
            "FAT32\t (Quick)",
            "NTFS\t",
            "FAT32"});
            this.FS_CBOX.Location = new System.Drawing.Point(217, 55);
            this.FS_CBOX.Name = "FS_CBOX";
            this.FS_CBOX.Size = new System.Drawing.Size(305, 26);
            this.FS_CBOX.StartIndex = 0;
            this.FS_CBOX.TabIndex = 3;
            this.FS_CBOX.SelectedIndexChanged += new System.EventHandler(this.FS_CBOX_SelectedIndexChanged);
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(447, -1);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 12;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.White;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(172, 1);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(167, 25);
            this.iTalk_HeaderLabel1.TabIndex = 2;
            this.iTalk_HeaderLabel1.Text = "Micro Format Tool";
            // 
            // iTalk_ContextMenuStrip1
            // 
            this.iTalk_ContextMenuStrip1.Name = "iTalk_ContextMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_ContextMenuStrip1.Renderer = controlRenderer1;
            this.iTalk_ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logs_cmenu
            // 
            this.logs_cmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem});
            this.logs_cmenu.Name = "logs_cmenu";
            controlRenderer2.ColorTable = msColorTable2;
            controlRenderer2.RoundedEdges = true;
            this.logs_cmenu.Renderer = controlRenderer2;
            this.logs_cmenu.Size = new System.Drawing.Size(130, 26);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(556, 586);
            this.Controls.Add(this.info_about_btn);
            this.Controls.Add(this.vanity_link);
            this.Controls.Add(this.doFormatNow);
            this.Controls.Add(this.VolumeName);
            this.Controls.Add(this.iTalk_HeaderLabel4);
            this.Controls.Add(this.iTalk_HeaderLabel3);
            this.Controls.Add(this.drives_list_cbox);
            this.Controls.Add(this.iTalk_HeaderLabel2);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.FS_CBOX);
            this.Controls.Add(this.hwite);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MicroFormat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.hwite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_about_btn)).EndInit();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.logs_cmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel hwite;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox icn;
        private iTalk.iTalk_ComboBox FS_CBOX;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel2;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel3;
        private iTalk.iTalk_ComboBox drives_list_cbox;
        private System.Windows.Forms.RichTextBox evLog;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel4;
        private iTalk.iTalk_TextBox_Small VolumeName;
        private iTalk.iTalk_Button_2 doFormatNow;
        private System.ComponentModel.BackgroundWorker yeeFormatThis;
        private iTalk.iTalk_HeaderLabel vanity_link;
        private System.Windows.Forms.PictureBox info_about_btn;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
        private iTalk.iTalk_ContextMenuStrip iTalk_ContextMenuStrip1;
        private iTalk.iTalk_ContextMenuStrip logs_cmenu;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
    }
}

