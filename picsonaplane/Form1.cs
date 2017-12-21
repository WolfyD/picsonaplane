using PdfSharp.Drawing;
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

		void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
		{
			XImage image = XImage.FromFile(jpegSamplePath);
			gfx.DrawImage(image, x, y, width, height);
			
		}

		private void btn_GenFiles_Click(object sender, EventArgs e)
		{
			c_PositionImages cp = new c_PositionImages();
			List<Bitmap> bmplst = cp.createPositions(psl[cb_Scheme.SelectedIndex], picList, selectedDPI);

			if (rb_PDF.Checked)
			{
				PdfSharp.Pdf.PdfDocument pdoc = new PdfSharp.Pdf.PdfDocument();
				pdoc.PageLayout = PdfSharp.Pdf.PdfPageLayout.SinglePage;
				if (!Directory.Exists(@"F:\poop"))
				{
					Directory.CreateDirectory(@"F:\poop");
				}
				if (!Directory.Exists(@"F:\poop\tmp"))
				{
					Directory.CreateDirectory(@"F:\poop\tmp");
				}
				foreach (Bitmap b in bmplst)
				{
					b.Save(@"F:\poop\tmp\bmp_tmp_" + bmplst.IndexOf(b) + ".bmp");
					PdfSharp.Pdf.PdfPage pag = pdoc.AddPage();

					pag.Width = selectedDPI.width;
					pag.Height = selectedDPI.height;
					XGraphics gfx = XGraphics.FromPdfPage(pag);
					DrawImage(gfx, @"F:\poop\tmp\bmp_tmp_" + bmplst.IndexOf(b) + ".bmp", 0, 0, (int)pag.Width, (int)pag.Height);
					b.Dispose();
					gfx.Dispose();
					pag.Close();
				}

				pdoc.Save(@"F:\poop\testpdf.pdf");
				pdoc.Dispose();
				//Directory.Delete(@"C:\poop\tmp", true);
			}
			else
			{
				foreach (Bitmap b in bmplst)
				{
					b.Save("F:\\poop\\bmp_" + bmplst.IndexOf(b) + ".bmp");
				}
			}

			
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
			Bitmap bmplst = cp.createPositions(psl[cb_Scheme.SelectedIndex], smallpl, a4sizes[0])[0];
			pb_Scheme.SizeMode = PictureBoxSizeMode.StretchImage;
			pb_Scheme.Image = bmplst;
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
		d_200,
		d_300,
		d_400,
		d_600,
		d_1200
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
