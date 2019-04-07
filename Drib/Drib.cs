using System;

namespace Drib
{
	class Drib
	{
		int P { get; set; }
		int Q { get; set; }
		Drib(int N = 1, int M = 1)
		{
			int D = GCD(N, M);
			P = N / D;
			Q = M / D;
			if (P < 0)
			{
				P *= -1;
				Q *= -1;
			}
		}
		int GCD(int A, int B)
		{
			A = Math.Abs(A);
			B = Math.Abs(B);
			if (A == 0) return B;
			return GCD(B % A, A);
		}
		static public Drib operator +(Drib a, Drib b)
		{
			return new Drib(a.P * b.Q + a.Q * b.P, a.Q * b.Q);
		}
		static public Drib operator -(Drib a, Drib b)
		{
			return new Drib(a.P * b.Q - a.Q * b.P, a.Q * b.Q);
		}
		static public Drib operator *(Drib a, Drib b)
		{
			return new Drib(a.P * b.P, a.Q * b.Q);
		}
		static public Drib operator /(Drib a, Drib b)
		{
			//assert b == 0
			return new Drib(a.P * b.Q, a.Q * b.P);
		}
		public Drib POW(int n)
		{
			int Up = 1;
			int Down = 1;
			for (int i = 0; i < n; i++)
			{
				Up *= P;
				Down *= Q;
			}
			return new Drib(Up, Down);
		}
	}
}
