using System;

namespace ProjetBanque
{
	public class read
	{
		/*  Création de readInt et readDouble:  */

		public static int readInt()
		{
			int val = -1;
			bool erreurSaisie = false;
			do
			{
				try
				{
					val = int.Parse(Console.ReadLine());
					erreurSaisie = false;
				}
				catch (Exception)
				{
					Console.WriteLine("Veuillez saisir une valeur entière");
					erreurSaisie = true;
				}
			} while (erreurSaisie);

			return val;
		}

		public static double readDouble()
		{
			double val = -1;
			bool erreurSaisie = false;
			do
			{
				try
				{
					val = double.Parse(Console.ReadLine());
					erreurSaisie = false;
				}
				catch (Exception)
				{
					Console.WriteLine("Veuillez saisir une valeur double");
					erreurSaisie = true;
				}
			} while (erreurSaisie);

			return val;
		}
		private string readString()
		{
			return Console.ReadLine();
		}
	}
}

