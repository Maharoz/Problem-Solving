using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOneToNWithoutLoop
{
	public class PrintOneToNWithOutLoop
	{
		public void printNos(int n)
		{
			if (n > 0)
			{
				printNos(n - 1);
				Console.Write(n + " ");
			}
			return;
		}
	}
}
