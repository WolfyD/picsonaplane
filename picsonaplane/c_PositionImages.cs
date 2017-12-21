using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picsonaplane
{
	class c_PositionImages
	{
		public void addImageToList(string path, int wid, int hei, ref List<imagePositioning> impl)
		{
			impl.Add(new imagePositioning() {
				path = path,
				imgName = path.Substring(path.LastIndexOf("\\") + 1),
				originalH = hei,
				originalW = wid }
			);
		}

		public int[] getPicData(int pic_num, pagestructs sch, a4size a, out int cw, out int ch)
		{
			int[] possize = new int[4];
			int picnum = pic_num;
			int col = 0;
			int row = 0;

			cw = 0;
			ch = 0;

			int top = a.margin;
			int left = a.margin;

			int wid = 0;
			int hei = 0;

			foreach(int i in sch.picsPerCol)
			{
				if (picnum - i >= 0)
				{
					picnum -= i;
					int h = i == 1 ? a.halfheight : (sch.picsPerCol.Contains(1) ? a.fourthheight : a.thirdheight);
					top += h;
					top += a.padding;
				}
				else
				{
					col = picnum;

					int l = 0;

					wid = i == 1 ? a.fullwidth : (i == 2 ? a.halfwidth : (i == 3 ? a.thirdwidth : a.fourthwidth));
					hei = i == 1 ? a.halfheight : (sch.picsPerCol.Contains(1) ? a.fourthheight : a.thirdheight);

					cw = wid;
					ch = hei;

					switch (i)
					{
						case 1:
							l = 0;
							break;
						case 2:
							l = a.halfwidth;
							break;
						case 3:
							l = a.thirdwidth;
							break;
						case 4:
							l = a.fourthwidth;
							break;
					}

					for (int ii = 0; ii < col; ii++)
					{
						left += l + a.padding;
					}

					picnum = i;
					break;
				}

				row++;
			}

			possize[0] = left;  //LEFT
			possize[1] = top;   //TOP
			possize[2] = wid;   //WIDTH
			possize[3] = hei;   //HEIGHT

			return possize;
		}

		public Size getSize(int owid, int ohei, int newhei, int newwid)
		{
			Size s = new Size();

			float newwid1 = 0.0f;
			newwid1 = (owid * 1.0f) / (ohei * 1.0f) * newhei;
			float newhei1 = 0.0f;
			newhei1 = (ohei * 1.0f) / (owid * 1.0f) * newwid;


			s = new Size((int)newwid1, (int)newhei1);

			return s;
		}

		public List<Bitmap> createPositions(pagestructs p, List<string> pics, a4size a)
		{
			List<Bitmap> bmps = new List<Bitmap>();

			int numofPics = pics.Count;

			int picspp = p.pics;

			int numOfPages = (numofPics / picspp) + (numofPics % picspp == 0 ? 0 : 1);

			int i = 0;

			Bitmap b = new Bitmap(a.width, a.height);
			using (Graphics g = Graphics.FromImage(b))
			{
				g.Clear(Properties.Settings.Default.s_BlackBG ? Color.Black : Color.White);
			}

				foreach (String s in pics)
			{
				using (Graphics g = Graphics.FromImage(b))
				{
					int cw = 0;
					int ch = 0;
					int[] r = getPicData(i, p, a, out cw, out ch);
					int[] r2 = new int[4];
					for(int ii = 0; ii < 4; ii++) { r2[ii] = r[ii]; }
					Bitmap bmp = new Bitmap(s);
					Size res = getSize(bmp.Width, bmp.Height, r[3], r[2]);
					Size res2 = new Size();


					if (res.Width > cw) { res2 = new Size(r[2], res.Height); r[1] = r[1] + (r[3] / 2) - (res2.Height / 2); }
					else { res2 = new Size(res.Width, r[3]); r[0] += (r[2] - res2.Width) / 2; }

					g.DrawImage(bmp, new Rectangle(r[0], r[1], res2.Width, res2.Height));
					if (Properties.Settings.Default.s_Borders)
					{
						if(Properties.Settings.Default.s_BlackBG)
							g.DrawRectangle(Pens.White, new Rectangle(r2[0], r2[1], r2[2], r2[3]));
						else
							g.DrawRectangle(Pens.Black, new Rectangle(r2[0], r2[1], r2[2], r2[3]));
					}
				}

				if(i == picspp - 1)
				{
					bmps.Add(b);
					
					i = -1;
					b = new Bitmap(a.width, a.height);
					using (Graphics g = Graphics.FromImage(b))
					{
						g.Clear(Properties.Settings.Default.s_BlackBG ? Color.Black : Color.White);
					}
				}
				else if(s == pics.Last())
				{
					bmps.Add(b);
				}
				
				i++;
			}
			
			return bmps;
		}

		public void createPositionsHTML()
		{

		}
	}

	public struct pagestructs
	{
		public Schemes sch { get; set; }
		public int[] positions { get; set; }
		public int pics { get; set; }
		public int[] picsPerCol { get; set; }
	}
}
