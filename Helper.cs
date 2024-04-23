using System;
namespace csharp_calcolatrice
{
	public static class Helper
	{
		public static int Somma(int n1, int n2)
		{
			return n1 + n2;
		}

		public static double Somma(double n1, double n2)
		{
			return n1 + n2;
		}

		public static int Differenza(int n1, int n2)
		{
			return n1 - n2;
		}

		public static double Differenza(double n1, double n2)
		{
			return n1 - n2;
		}

		public static int Moltiplicazione(int n1, int n2)
		{
			return n1 * n2;
		}

		public static double Moltiplicazione(double n1, double n2)
		{
			return n1 * n2;
		}

		public static int ValoreAssoluto(int num)
		{
			if (num > 0)
				return num;
			else
				return -num;
		}

		public static double ValoreAssoluto(double num)
		{
			if (num > 0)
				return num;
			else
				return -num;
		}

		public static int Minimo(int n1, int n2)
		{
			if (n1 > n2)
				return n2;
			else
				return n1;
		}

		public static double Minimo(double n1, double n2)
		{
			if (n1 > n2)
				return n2;
			else
				return n1;
		}

		public static int Massimo(int n1, int n2)
		{
			if (n1 > n2)
				return n1;
			else
				return n2;
		}

		public static double Massimo(double n1, double n2)
		{
			if (n1 > n2)
				return n1;
			else
				return n2;
		}

		public static double Potenza(int nBase, int nEsponente)
		{
			if (nBase == 0 && nEsponente == 0)
				return 1;
			if (nBase == 0)
				return 0;
			if (nEsponente == 0)
				return 1;

			double risultato = 1.0;
            bool isNegativeExponent = nEsponente < 0;
            if (isNegativeExponent)
            {
                nEsponente = -nEsponente;
            }
            for (int i = 0; i < nEsponente; i++)
			{
				risultato *= nBase;
			}
            if (isNegativeExponent)
            {
                risultato = 1.0 / risultato;
            }
            return risultato;
		}
	}
}

