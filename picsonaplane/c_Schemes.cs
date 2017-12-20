using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picsonaplane
{
	public class c_Schemes
	{
		

		public Bitmap drawSchemePreview(int w, int h, Schemes scheme)
		{
			Bitmap b = new Bitmap(w, h);

			int padding = 2;
			int margin = 4;

			Size sqr_1 = new Size((w - ((margin * 2))),						(((h - ((2 * margin) + (2 * padding))) / 4) * 2	));
			Size sqr_2 = new Size((w - ((margin * 2) + padding)) / 2,		(((h - ((2 * margin) + (2 * padding))) / 4		)));
			Size sqr_3 = new Size((w - ((2 * padding) + (2 * margin))) / 3, (((h - ((2 * margin) + (2 * padding))) / 4		)));
			Size sqr_4 = new Size((w - ((3 * padding) + (2 * margin))) / 4, (((h - ((2 * margin) + (2 * padding))) / 4		)));
			int hp3 = (((h - ((2 * margin) + (2 * padding))) / 3));

			using (Graphics g = Graphics.FromImage(b))
			{
				switch (scheme)
				{
					case Schemes.s133:
						
						g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin, margin), sqr_1));
						
						for(int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + padding + sqr_1.Height), sqr_3));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding * 2) + sqr_3.Height + sqr_1.Height), sqr_3));
						}

						break;

					case Schemes.s134:
						g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin, margin), sqr_1));
						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + padding + sqr_1.Height), sqr_3));
						}
							
						for(int i = 0; i < 4; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + 1 + (i * (sqr_4.Width + padding)), margin + (padding * 2) + sqr_3.Height + sqr_1.Height), sqr_4));
						}
						break;

					case Schemes.s212:

						for (int i = 0; i < 2; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_2.Width + padding)), margin), sqr_2));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_2.Width + padding)), margin + (padding * 2) + sqr_1.Height + sqr_2.Height), sqr_2));
						}

						g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin, margin + padding + sqr_2.Height), sqr_1));

						break;

					case Schemes.s232:
						for (int i = 0; i < 2; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_2.Width + padding)), margin), new Size(sqr_2.Width, hp3)));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_2.Width + padding)), margin + (padding * 2) + hp3 + hp3), new Size(sqr_2.Width, hp3)));
						}
						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + padding + hp3), new Size(sqr_3.Width, hp3)));
						}

						break;

					case Schemes.s313:
						g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin, margin + padding + sqr_3.Height), sqr_1));

						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin), sqr_3));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding * 2) + sqr_3.Height + sqr_1.Height), sqr_3));
						}
						break;

					case Schemes.s323:
						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin), new Size(sqr_3.Width,hp3)));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding * 2) + hp3 + hp3), new Size(sqr_3.Width, hp3)));
						}
						for (int i = 0; i < 2; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_2.Width + padding)), margin + padding + hp3), new Size(sqr_2.Width,hp3)));
						}
						break;

					case Schemes.s333:
						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin), new Size(sqr_3.Width, hp3)));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding) + hp3), new Size(sqr_3.Width, hp3)));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding * 2) + hp3 + hp3), new Size(sqr_3.Width, hp3)));
						}
						break;

					case Schemes.s434:
						for (int i = 0; i < 3; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin), new Size(sqr_3.Width, hp3)));
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + (i * (sqr_3.Width + padding)), margin + (padding * 2) + hp3 + hp3), new Size(sqr_3.Width, hp3)));
						}
						for (int i = 0; i < 4; i++)
						{
							g.DrawRectangle(Pens.Red, new Rectangle(new Point(margin + 1 + (i * (sqr_4.Width + padding)), margin + padding + hp3), new Size(sqr_4.Width, hp3)));
						}
						break;
				}
			}

			return b;
		}
	}
}
