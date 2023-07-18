using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOneToNWithoutLoop
{
	public class PrintNToOneWithoutLoop
	{
		public void printNos(int n)
		{
			if (n > 0)
			{
				Console.Write(n + " ");
				printNos(n - 1);
			}
			return;
		}
	}
}
