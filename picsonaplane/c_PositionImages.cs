using System;
using System.Collections.Generic;
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

		public void createPositions()
		{

		}
	}

	public struct pagestructs
	{
		public Schemes sch { get; set; }
		public int[][] positions { get; set; }
	}
}
