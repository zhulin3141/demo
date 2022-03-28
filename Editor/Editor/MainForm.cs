using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Editor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// TODO: 写注册表
		String selectedPath = "";
		
		public MainForm()
		{
			InitializeComponent();	
			this.wbContent.ScriptErrorsSuppressed = true;
			this.wbContent.IsWebBrowserContextMenuEnabled = true;
			this.wbContent.WebBrowserShortcutsEnabled = true;
			
		}
		
		void BtnExplorerClick(object sender, EventArgs e)
		{
			var dialog = new FolderBrowserDialog ();
			if(  this.selectedPath != String.Empty )  {
				dialog.SelectedPath = this.selectedPath;
			}
			
			if( dialog.ShowDialog() == DialogResult.OK ){
				var folder = dialog.SelectedPath.ToString();

				this.OpenFolder(folder);
			}
		}
		
		void OpenFolder(String path)
		{
			if( Directory.Exists(path) ){
				this.selectedPath = path;
				
				string[] files = Directory.GetFileSystemEntries(path);
			
				this.tvFiles.Nodes.Clear();			
				foreach(var file in files){
					var node = new TreeNode();
					node.Text = file.Replace(path + "\\", "");
					node.Name = file;
	
					this.tvFiles.Nodes.Add(node);
				}
			}
		}
		
		void TvFilesDoubleClick(object sender, EventArgs e)
		{
			TreeView treeView = (TreeView)sender;
			this.OpenFolder(treeView.SelectedNode.Name);
		}
		
		void TvFilesMouseDown(object sender, MouseEventArgs e)
		{
			if( e.Button == MouseButtons.Right ){
				TreeNode tn = tvFiles.GetNodeAt(e.X,e.Y);
				if ( tn!=null )
                {
                    this.tvFiles.SelectedNode = tn;
                }
				
				this.cmsFile.Show(PointToScreen(e.Location));
			}
		}
		
		/// <summary>
		/// 右键菜单 置顶
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TsmiTopClick(object sender, EventArgs e)
		{
			String filePath = this.tvFiles.SelectedNode.Name;
			var shellFile = ShellObject.FromParsingName(filePath);
			
//			shell32.dll
//			shellFile.Properties.System.Author.Value = new string[] { "Author #1", "Author #2" };
//			shellFile.Properties.System.Title.Value = "Example Title";
			
			
//			ShellPropertyWriter propertyWriter = shellFile.Properties.GetPropertyWriter();
//            propertyWriter.WriteProperty(SystemProperties.System.Comment, "cccb");
//            propertyWriter.Close();
		}
		
		/// <summary>
		/// 右键菜单 加星
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TsmiStarClick(object sender, EventArgs e)
		{
	
		}
		
		void TbEditorTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
