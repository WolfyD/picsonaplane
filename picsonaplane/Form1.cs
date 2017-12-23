using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picsonaplane
{
	public partial class Form1 : Form
	{
		public List<imagePositioning> imposlist = new List<imagePositioning>();
		public c_Schemes schemes = new c_Schemes();
		public Schemes _s = new Schemes();
		public List<string> picList = new List<string>();
		public List<a4size> a4sizes = new List<a4size>();
		public List<pagestructs> psl = new List<pagestructs>();

		public a4size selectedDPI =  new a4size();

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (dpi d in Enum.GetValues(typeof(dpi)))
			{
				a4size a = new a4size();

				switch (d)
				{
					case dpi.d_72:
						a._dpi = dpi.d_72;
						a.width = 595;
						a.height = 842;
						a.margin = 15;
						a.padding = 8;
						break;

					case dpi.d_100:
						a._dpi = dpi.d_100;
						a.width = 827;
						a.height = 1169;
						a.margin = 20;
						a.padding = 10;
						break;

					case dpi.d_140:
						a._dpi = dpi.d_140;
						a.width = 1157;
						a.height = 1637;
						a.margin = 27;
						a.padding = 14;
						break;

					case dpi.d_200:
						a._dpi = dpi.d_200;
						a.width = 1654;
						a.height = 2339;
						a.margin = 41;
						a.padding = 22;
						break;

					case dpi.d_300:
						a._dpi = dpi.d_300;
						a.width = 2480;
						a.height = 3508;
						a.margin = 61;
						a.padding = 32;
						break;

					case dpi.d_400:
						a._dpi = dpi.d_400;
						a.width = 3307;
						a.height = 4677;
						a.margin = 81;
						a.padding = 42;
						break;

					case dpi.d_600:
						a._dpi = dpi.d_600;
						a.width = 4961;
						a.height = 7016;
						a.margin = 121;
						a.padding = 63;
						break;

					case dpi.d_1200:
						a._dpi = dpi.d_1200;
						a.width = 9921;
						a.height = 14031;
						a.margin = 241;
						a.padding = 125;
						break;

					case dpi.dd_30:
						a._dpi = dpi.dd_30;
						a.width = 248;
						a.height = 351;
						a.margin = 5;
						a.padding = 3;
						break;

				}

				a.fullheight = a.height - (2 * a.margin);
				a.halfheight = (a.height - ((2 * a.margin) + a.padding)) / 2;
				a.thirdheight = (a.height - ((2 * a.margin) + (2 * a.padding))) / 3;
				a.fourthheight = (a.height - ((2 * a.margin) + (3 * a.padding))) / 4;
				a.fullwidth = a.width - (2 * a.margin);
				a.halfwidth = (a.width - ((2 * a.margin) + a.padding)) / 2;
				a.thirdwidth = (a.width - ((2 * a.margin) + (2 * a.padding))) / 3;
				a.fourthwidth = (a.width - ((2 * a.margin) + (3 * a.padding))) / 4;

				a4sizes.Add(a);

				cb_BlackBG.Checked = Properties.Settings.Default.s_BlackBG;
				cb_Borders.Checked = Properties.Settings.Default.s_Borders;
			}

			foreach(Schemes v in Enum.GetValues(typeof(Schemes)))
			{
				pagestructs ps = new pagestructs();

				switch (v)
				{
					case Schemes.s133:
						ps.sch = Schemes.s133;
						ps.positions = new int[] { 1, 3, 3, 3, 3, 3, 3 };
						ps.pics = 7;
						ps.picsPerCol = new int[] { 1, 3, 3 };
						break;

					case Schemes.s134:
						ps.sch = Schemes.s134;
						ps.positions = new int[] { 1, 3, 3, 3, 4, 4, 4, 4 };
						ps.pics = 8;
						ps.picsPerCol = new int[] { 1, 3, 4 };
						break;

					case Schemes.s212:
						ps.sch = Schemes.s212;
						ps.positions = new int[] { 2, 2, 1, 2, 2 };
						ps.pics = 5;
						ps.picsPerCol = new int[] { 2, 1, 2 };
						break;

					case Schemes.s232:
						ps.sch = Schemes.s232;
						ps.positions = new int[] { 2, 2, 3, 3, 3, 2, 2 };
						ps.pics = 7;
						ps.picsPerCol = new int[] { 2, 3, 2 };
						break;

					case Schemes.s313:
						ps.sch = Schemes.s313;
						ps.positions = new int[] { 3, 3, 3, 1, 3, 3, 3 };
						ps.pics = 7;
						ps.picsPerCol = new int[] { 3, 1, 3 };
						break;

					case Schemes.s323:
						ps.sch = Schemes.s323;
						ps.positions = new int[] { 3, 3, 3, 2, 2, 3, 3, 3 };
						ps.pics = 8;
						ps.picsPerCol = new int[] { 3, 2, 3 };
						break;

					case Schemes.s333:
						ps.sch = Schemes.s333;
						ps.positions = new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
						ps.pics = 9;
						ps.picsPerCol = new int[] { 3, 3, 3 };
						break;

					case Schemes.s434:
						ps.sch = Schemes.s434;
						ps.positions = new int[] { 4, 4, 4, 4, 3, 3, 3, 4, 4, 4, 4 };
						ps.pics = 11;
						ps.picsPerCol = new int[] { 4, 3, 4 };
						break;


				}

				psl.Add(ps);

			}

			cb_Scheme.SelectedIndex = Properties.Settings.Default.s_Layout;
			cb_DPI.SelectedIndex = Properties.Settings.Default.s_DPI;
			switch (Properties.Settings.Default.s_Output)
			{
				case 0:
					rb_PDF.Checked = true;
					break;

				case 1:
					rb_IMG.Checked = true;
					break;

				case 2:
					rb_HTML.Checked = true;
					break;

				default: rb_PDF.Checked = true; break;
			}
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

		public bool getSizes = false;

		public void updateList()
		{
			lv_PicList.Items.Clear();

			int i = 1;
			foreach (string s in picList)
			{
				if (getSizes)
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
				else
				{
					ListViewItem lvi = new ListViewItem();
					lvi.SubItems[0].Text = i + "";
					lvi.SubItems.Add(s.Substring(s.LastIndexOf("\\") + 1));
					lvi.Tag = s;
					lvi.SubItems.Add(" -- ");

					lvi.BackColor = i % 2 == 0 ? Color.LightYellow : Color.WhiteSmoke;

					lv_PicList.Items.Add(lvi);
					i++;
				}
			}

			if (picList.Count == 0) { btn_Preview.Enabled = false; btn_GenFiles.Enabled = false; }
			else { btn_Preview.Enabled = true; btn_GenFiles.Enabled = true; }
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

		private void cb_Scheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_Scheme.SelectedIndex == 0) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s323); _s = Schemes.s323; }
			else if (cb_Scheme.SelectedIndex == 1) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s232); _s = Schemes.s232; }
			else if (cb_Scheme.SelectedIndex == 2) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s333); _s = Schemes.s333; }
			else if (cb_Scheme.SelectedIndex == 3) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s434); _s = Schemes.s434; }
			else if (cb_Scheme.SelectedIndex == 4) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s212); _s = Schemes.s212; }
			else if (cb_Scheme.SelectedIndex == 5) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s313); _s = Schemes.s313; }
			else if (cb_Scheme.SelectedIndex == 6) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s133); _s = Schemes.s133; }
			else if (cb_Scheme.SelectedIndex == 7) { pb_Scheme.Image = schemes.drawSchemePreview(pb_Scheme.Width, pb_Scheme.Height, Schemes.s134); _s = Schemes.s134; }

			Properties.Settings.Default.s_Layout = cb_Scheme.SelectedIndex;
			Properties.Settings.Default.Save();
		}

		private void rb_PDF_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_PDF.Checked)
			{
				Properties.Settings.Default.s_Output = 0;
			}
			else if (rb_IMG.Checked)
			{
				Properties.Settings.Default.s_Output = 1;
			}
			else
			{
				Properties.Settings.Default.s_Output = 2;
			}

			Properties.Settings.Default.Save();
		}

		private void cb_DPI_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedDPI = a4sizes[cb_DPI.SelectedIndex];
			Properties.Settings.Default.s_DPI = cb_DPI.SelectedIndex;
			Properties.Settings.Default.Save();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_GenFiles_Click(object sender, EventArgs e)
		{
			c_PositionImages cp = new c_PositionImages();
			List<Bitmap> bmplst = cp.createPositions(psl[cb_Scheme.SelectedIndex], picList, selectedDPI);

			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if(Properties.Settings.Default.s_LastDir != "" && Directory.Exists(Properties.Settings.Default.s_LastDir))
			{
				fbd.SelectedPath = Properties.Settings.Default.s_LastDir;
			}

			fbd.ShowNewFolderButton = true;

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.s_LastDir = fbd.SelectedPath;
				Properties.Settings.Default.Save();

				string path = fbd.SelectedPath;
				DateTime d = DateTime.Now;
				if (rb_PDF.Checked)
				{
					string fn = "pic_collage_pdf_" + d.Year + d.Month + d.Day + "_" + d.Hour + d.Minute + ".pdf";

					using (PdfSharp.Pdf.PdfDocument pdoc = new PdfSharp.Pdf.PdfDocument())
					{
						pdoc.PageLayout = PdfSharp.Pdf.PdfPageLayout.SinglePage;
						if (!Directory.Exists(fbd.SelectedPath))
						{
							Directory.CreateDirectory(fbd.SelectedPath);
						}
						if (!Directory.Exists(fbd.SelectedPath + "\\tmp"))
						{
							Directory.CreateDirectory(fbd.SelectedPath + "\\tmp");
						}
						foreach (Bitmap b in bmplst)
						{
							b.Save(fbd.SelectedPath + "\\tmp\\bmp_tmp_" + bmplst.IndexOf(b) + ".bmp");
							PdfSharp.Pdf.PdfPage pag = pdoc.AddPage();

							pag.Width = selectedDPI.width;
							pag.Height = selectedDPI.height;
							XGraphics gfx = XGraphics.FromPdfPage(pag);
							XImage image = XImage.FromFile(fbd.SelectedPath + "\\tmp\\bmp_tmp_" + bmplst.IndexOf(b) + ".bmp");
							gfx.DrawImage(image, 0, 0, (int)pag.Width, (int)pag.Height);

							image.Dispose();
							b.Dispose();
							gfx.Dispose();
							pag.Close();
						}
						
						pdoc.Save(fbd.SelectedPath + "\\" + fn);
					}
					Directory.Delete(fbd.SelectedPath + "\\tmp", true);
					System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + fbd.SelectedPath + "\\" + fn + "\"");
				}
				else
				{
					string fn = "bmp_" + d.Year + d.Month + d.Day + "_" + d.Hour + d.Minute + "_";
					foreach (Bitmap b in bmplst)
					{

						b.Save(fbd.SelectedPath + "\\" + fn + bmplst.IndexOf(b) + ".bmp");
					}

					System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + fbd.SelectedPath + "\\" + fn + "0.bmp\"");
				}

				

			}

			GC.Collect();

		}

		private void cb_BlackBG_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_BlackBG = cb_BlackBG.Checked;
			Properties.Settings.Default.Save();
		}

		private void btn_Preview_Click(object sender, EventArgs e)
		{
			c_PositionImages cp = new c_PositionImages();
			List<string> smallpl = new List<string>();
			for(int i = 0; i < psl[cb_Scheme.SelectedIndex].pics; i++)
			{
				try
				{
					smallpl.Add(picList[i]);
				}
				catch { }
			}
			Bitmap bmplst = cp.createPositions(psl[cb_Scheme.SelectedIndex], smallpl, a4sizes[8])[0];
			pb_Scheme.SizeMode = PictureBoxSizeMode.StretchImage;
			pb_Scheme.Image = bmplst;

			//bmplst.Dispose();
			GC.Collect();
		}

		private void p_Preview_SizeChanged(object sender, EventArgs e)
		{
			doResize();
		}

		public void doResize()
		{
				p_Preview.Width = (int)(p_Preview.Height / 1.4142f);
		}

		private void pb_Scheme_MouseDown(object sender, MouseEventArgs e)
		{
			p_Preview.Visible = true;
			p_Preview.BackgroundImage = pb_Scheme.Image;
			p_Preview.Width = (int)(p_Preview.Height / 1.4142f);
			p_Preview.Left = Width - p_Preview.Width;
		}

		private void pb_Scheme_MouseUp(object sender, MouseEventArgs e)
		{
			p_Preview.Visible = false;
		}

		private void cb_Borders_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_Borders = cb_Borders.Checked;
			Properties.Settings.Default.Save();
		}

		private void btn_OpenPics_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif;*.bmp;*.exim;*.exif;*.tiff;*.tif;*.jfif|All Files|*.*";
			ofd.Title = "Open File(s)";
			ofd.Multiselect = true;

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				foreach(String s in ofd.FileNames)
				{
					addFileToList(s);
				}

				updateList();
			}
		}

		public void removeFromList()
		{
			if(lv_PicList.SelectedItems != null && lv_PicList.SelectedItems.Count > 0)
			{
				foreach (ListViewItem lvi in lv_PicList.SelectedItems)
				{
					if (lvi.Tag != null && picList.Contains(lvi.Tag.ToString()))
					{
						picList.Remove(lvi.Tag.ToString());
					}
				}
				
				updateList();
			}
		}

		private void btn_DELETE_Click(object sender, EventArgs e)
		{
			removeFromList();
		}

		public bool ctrldown = false;

		private void lv_PicList_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete) { removeFromList(); }
			else if(e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.LControlKey || e.Control)
			{
				ctrldown = true;
			}
			if(e.KeyCode == Keys.A && ctrldown)
			{
				foreach(var v in lv_PicList.Items)
				{
					((ListViewItem)v).Selected = true;
				}
			}
		}

		private void btn_UP_Click(object sender, EventArgs e)
		{
			List<int> newindexes = new List<int>();

			if (lv_PicList.SelectedItems != null && lv_PicList.SelectedItems.Count > 0)
			{
				if(lv_PicList.SelectedItems[0].Index > 0)
				{
					foreach (ListViewItem lvi in lv_PicList.SelectedItems)
					{
						if (lvi.Tag != null && picList.Contains(lvi.Tag.ToString()))
						{
							int ind = picList.IndexOf(lvi.Tag.ToString());
							picList.Remove(lvi.Tag.ToString());
							picList.Insert(ind - 1, lvi.Tag.ToString());
							newindexes.Add(ind - 1);
						}
					}
				}
					

				updateList();

				foreach(int i in newindexes)
				{
					lv_PicList.Items[i].Selected = true;
				}
			}
		}

		private void btn_DOWN_Click(object sender, EventArgs e)
		{
			List<int> newindexes = new List<int>();

			if (lv_PicList.SelectedItems != null && lv_PicList.SelectedItems.Count > 0)
			{
				if (lv_PicList.SelectedItems[lv_PicList.SelectedItems.Count - 1].Index < lv_PicList.Items.Count - 1)
				{
					for(int i = lv_PicList.Items.Count; i > 0; i--)
					{
						ListViewItem lvi = lv_PicList.Items[i - 1];

						if (lvi.Selected && lvi.Tag != null && picList.Contains(lvi.Tag.ToString()))
						{
							int ind = picList.IndexOf(lvi.Tag.ToString());
							picList.Remove(lvi.Tag.ToString());
							picList.Insert(ind + 1, lvi.Tag.ToString());
							newindexes.Add(ind + 1);
						}
					}
					
				}


				updateList();

				foreach (int i in newindexes)
				{
					lv_PicList.Items[i].Selected = true;
				}
			}
		}

		private void btn_Rand_Click(object sender, EventArgs e)
		{
			int len = 0;
			Dictionary<int, string> indexes = new Dictionary<int, string>();
			List<int> newindexes = new List<int>();
			List<int> origindexes = new List<int>();

			for(int i = 0; i < lv_PicList.Items.Count; i++)
			{
				origindexes.Add(i);
			}

			int current = 0;

			if (lv_PicList.Items != null && lv_PicList.Items.Count > 0)
			{
				len = lv_PicList.Items.Count - 1;

				while(newindexes.Count - 1 < len)
				{
					Thread.Sleep(1);
					int selindex = new Random(Environment.TickCount + 1).Next(0, origindexes.Count);
					int i = origindexes[selindex];
					
					if (!newindexes.Contains(i))
					{
						newindexes.Add(i);
						indexes.Add(i, picList[current]);
						current++;
					}

					origindexes.RemoveAt(selindex);
				}

				picList.Clear();

				indexes.OrderBy(x => x.Key < x.Key);

				for(int i = 0; i < indexes.Count; i++)
				{
					picList.Add(indexes[i]);
				}

				updateList();
				
			}
		}

		private void lv_PicList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			foreach (ListViewItem lvi in lv_PicList.Items)
			{
				lvi.Font = new Font(lvi.Font.FontFamily, lvi.Font.Size, FontStyle.Regular);
				lvi.BackColor = lvi.Index % 2 == 1 ? Color.LightYellow : Color.WhiteSmoke;
				lvi.ForeColor = Color.Black;
			}

			foreach (ListViewItem lvi2 in lv_PicList.SelectedItems)
			{
				lvi2.Font = new Font(lvi2.Font.FontFamily, lvi2.Font.Size, FontStyle.Underline);
				lvi2.BackColor = Color.LightBlue;
				lvi2.ForeColor = Color.Red;
			}


		}

		private void lv_PicList_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.LControlKey || e.Control)
			{
				ctrldown = false;
			}
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

	public struct a4size
	{
		public dpi _dpi { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public int margin { get; set; }
		public int padding { get; set; }
		public int fullheight { get; set; }
		public int halfheight { get; set; }
		public int thirdheight { get; set; }
		public int fourthheight { get; set; }
		public int fullwidth { get; set; }
		public int halfwidth { get; set; }
		public int thirdwidth { get; set; }
		public int fourthwidth { get; set; }
	}

	public enum dpi
	{
		d_72,
		d_100,
		d_140,
		d_200,
		d_300,
		d_400,
		d_600,
		d_1200,
		dd_30
	}

	public enum Schemes
	{
		s323,
		s232,
		s333,
		s434,
		s212,
		s313,
		s133,
		s134
	}

}
