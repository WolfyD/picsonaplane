using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picsonaplane
{
	public partial class Form1 : Form
	{
		public List<imagePositioning> imposlist = new List<imagePositioning>();
		List<string> picList = new List<string>();


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
				p_Drop.Dock = DockStyle.Fill;
		}

		private void Form1_DragLeave(object sender, EventArgs e)
		{
			p_Drop.Dock = DockStyle.None;
		}

		private void p_Drop_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.StringFormat))
			{
				p_Drop.Dock = DockStyle.Fill;
				e.Effect = DragDropEffects.All;
			}
		}

		public bool ew(string f, string e)
		{
			bool ret = f.ToLower().EndsWith(e);
			return ret;
		}

		public void addFileToList(string FileName)
		{
			bool add = false;
			string extensions = "jpg;png;jpeg;gif;bmp;exim;exif;tiff;tif;jfif";

			foreach(String s in extensions.Split(';'))
			{
				if(ew(FileName, s)) { add = true; break; }
			}

			if (add && picList.Contains(FileName) == false)
			{
				picList.Add(FileName);
			}
		}

		public void updateList()
		{
			lv_PicList.Items.Clear();

			int i = 1;
			foreach (string s in picList)
			{
				using (Bitmap b = new Bitmap(s))
				{
					ListViewItem lvi = new ListViewItem();
					lvi.SubItems[0].Text = i + "";
					lvi.SubItems.Add(s.Substring(s.LastIndexOf("\\") + 1));
					lvi.Tag = s;
					lvi.SubItems.Add(b.Width + "x" + b.Height);

					lvi.BackColor = i % 2 == 0 ? Color.LightYellow : Color.WhiteSmoke;

					lv_PicList.Items.Add(lvi);
					i++;
				}
			}
		}

		private void p_Drop_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				foreach (String s in e.Data.GetData(DataFormats.FileDrop) as string[])
				{
					if (File.Exists(s))
					{
						addFileToList(s);
					}else if (Directory.Exists(s))
					{
						foreach(string ss in Directory.GetFiles(s, "*.*", SearchOption.AllDirectories))
						{
							addFileToList(ss);
						}
					}
				}
			}
			else if (e.Data.GetDataPresent(DataFormats.StringFormat))
			{
				string s = e.Data.GetData(DataFormats.StringFormat).ToString();
				MessageBox.Show(s);
				s = s.Replace("\r", "");
				string[] ss = s.Split('\n');
				foreach(String sss in ss)
				{
					if(sss != "" && File.Exists(sss))
					{
						addFileToList(sss);
					}else if(sss != "" && Directory.Exists(sss))
					{
						foreach (string sssss in Directory.GetFiles(sss, "*.*", SearchOption.AllDirectories))
						{
							addFileToList(sssss);
						}
					}
				}
			}

			updateList();
			p_Drop.Dock = DockStyle.None;
		}
	}

	public class imagePositioning
	{
		public string imgName { get; set; }
		public string path { get; set; }
		public int originalW { get; set; }
		public int originalH { get; set; }
		public int resizedW { get; set; }
		public int resizedH { get; set; }
		public int left { get; set; }
		public int top { get; set; }
	}

}
