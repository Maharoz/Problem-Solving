using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasyProblem
{
	public class MeanOfArrayUsingRecursion
	{
		public float findMean(int[] A, int N)
		{
			if (N == 1)
				return (float)A[N - 1];
			else
				return ((float)(findMean(A, N - 1) *
							   (N - 1) + A[N - 1]) / N);
		}
	}
}
