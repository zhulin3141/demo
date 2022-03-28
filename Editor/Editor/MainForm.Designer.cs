/*
 * Created by SharpDevelop.
 * User: zhulin
 * Date: 2022/3/28
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Editor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel sidebar;
		private System.Windows.Forms.Button btnExplorer;
		private System.Windows.Forms.Panel filePanel;
		private System.Windows.Forms.TreeView tvFiles;
		private System.Windows.Forms.TextBox tbEditor;
		private System.Windows.Forms.WebBrowser wbContent;
		private System.Windows.Forms.ContextMenuStrip cmsFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiTop;
		private System.Windows.Forms.ToolStripMenuItem tsmiStar;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnSetting;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		{
			this.components = new System.ComponentModel.Container();
			this.sidebar = new System.Windows.Forms.Panel();
			this.btnExplorer = new System.Windows.Forms.Button();
			this.filePanel = new System.Windows.Forms.Panel();
			this.tvFiles = new System.Windows.Forms.TreeView();
			this.tbEditor = new System.Windows.Forms.TextBox();
			this.wbContent = new System.Windows.Forms.WebBrowser();
			this.cmsFile = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTop = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiStar = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSetting = new System.Windows.Forms.Button();
			this.sidebar.SuspendLayout();
			this.filePanel.SuspendLayout();
			this.cmsFile.SuspendLayout();
			this.SuspendLayout();
			// 
			// sidebar
			// 
			this.sidebar.Controls.Add(this.btnSetting);
			this.sidebar.Controls.Add(this.btnExplorer);
			this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar.Location = new System.Drawing.Point(0, 0);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(63, 489);
			this.sidebar.TabIndex = 0;
			// 
			// btnExplorer
			// 
			this.btnExplorer.Location = new System.Drawing.Point(0, 0);
			this.btnExplorer.Name = "btnExplorer";
			this.btnExplorer.Size = new System.Drawing.Size(63, 42);
			this.btnExplorer.TabIndex = 0;
			this.btnExplorer.Text = "Explorer";
			this.btnExplorer.UseVisualStyleBackColor = true;
			this.btnExplorer.Click += new System.EventHandler(this.BtnExplorerClick);
			// 
			// filePanel
			// 
			this.filePanel.Controls.Add(this.tvFiles);
			this.filePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.filePanel.Location = new System.Drawing.Point(63, 0);
			this.filePanel.Name = "filePanel";
			this.filePanel.Size = new System.Drawing.Size(200, 489);
			this.filePanel.TabIndex = 1;
			// 
			// tvFiles
			// 
			this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvFiles.Location = new System.Drawing.Point(0, 0);
			this.tvFiles.Name = "tvFiles";
			this.tvFiles.Size = new System.Drawing.Size(200, 489);
			this.tvFiles.TabIndex = 0;
			this.tvFiles.DoubleClick += new System.EventHandler(this.TvFilesDoubleClick);
			this.tvFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TvFilesMouseDown);
			// 
			// tbEditor
			// 
			this.tbEditor.Location = new System.Drawing.Point(269, 0);
			this.tbEditor.Multiline = true;
			this.tbEditor.Name = "tbEditor";
			this.tbEditor.Size = new System.Drawing.Size(291, 489);
			this.tbEditor.TabIndex = 2;
			this.tbEditor.TextChanged += new System.EventHandler(this.TbEditorTextChanged);
			// 
			// wbContent
			// 
			this.wbContent.Location = new System.Drawing.Point(566, 0);
			this.wbContent.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbContent.Name = "wbContent";
			this.wbContent.Size = new System.Drawing.Size(304, 489);
			this.wbContent.TabIndex = 3;
			// 
			// cmsFile
			// 
			this.cmsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiTop,
			this.tsmiStar});
			this.cmsFile.Name = "cmsFile";
			this.cmsFile.Size = new System.Drawing.Size(101, 48);
			// 
			// tsmiTop
			// 
			this.tsmiTop.Name = "tsmiTop";
			this.tsmiTop.Size = new System.Drawing.Size(100, 22);
			this.tsmiTop.Text = "置顶";
			this.tsmiTop.Click += new System.EventHandler(this.TsmiTopClick);
			// 
			// tsmiStar
			// 
			this.tsmiStar.Name = "tsmiStar";
			this.tsmiStar.Size = new System.Drawing.Size(100, 22);
			this.tsmiStar.Text = "加星";
			this.tsmiStar.Click += new System.EventHandler(this.TsmiStarClick);
			// 
			// btnSetting
			// 
			this.btnSetting.Location = new System.Drawing.Point(0, 450);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(63, 39);
			this.btnSetting.TabIndex = 1;
			this.btnSetting.Text = "setting";
			this.btnSetting.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(871, 489);
			this.Controls.Add(this.wbContent);
			this.Controls.Add(this.tbEditor);
			this.Controls.Add(this.filePanel);
			this.Controls.Add(this.sidebar);
			this.Name = "MainForm";
			this.Text = "Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.sidebar.ResumeLayout(false);
			this.filePanel.ResumeLayout(false);
			this.cmsFile.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}this.Controls.Add(this.wbContent);
			this.Controls.Add(this.tbEditor);
			this.Controls.Add(this.filePanel);
			this.Controls.Add(this.sidebar);
			this.Name = "MainForm";
			this.Text = "Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.sidebar.ResumeLayout(false);
			this.filePanel.ResumeLayout(false);
			this.cmsFile.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
