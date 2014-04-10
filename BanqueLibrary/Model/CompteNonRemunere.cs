using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class CompteNonRemunere : Compte
	{
		private bool autorisationDecouvert;
		private double montantDecouvert;

		public double CalculAgios()
		{
            if(Solde < 0)
            {
                double agio = ((20/100) * this.Solde);
                return agio;
            }else
            {
                return 0;
            }
		}

		public override int Debiter ()
		{

		}
	}
}

