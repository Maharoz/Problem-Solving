using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasyProblem
{
	public class SumOfNaturalNumber
	{
		public int naturalNumberAdd(int naturalNumber)
		{
			if (naturalNumber == 1)
			{
				return naturalNumber;
			}
		int x= naturalNumberAdd(naturalNumber - 1);
			return naturalNumber + x;
		}
	}
}
