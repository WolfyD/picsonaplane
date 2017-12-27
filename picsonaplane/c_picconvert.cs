using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picsonaplane
{
	public static class c_picconvert
	{
		public static string pic2b64(Bitmap img)
		{
			string str = "";

			byte[] imageBytes;

			using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
			{
				img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
				imageBytes = stream.ToArray();
			}

			str = Convert.ToBase64String(imageBytes);

			return str;
		}
	}
}
