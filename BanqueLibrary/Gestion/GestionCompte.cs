using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class GestionCompte
	{

		private List<Compte> ListeComptes = new List<Compte>();

		public void Ajouter(int Id, string libelle, DateTime dateOuverture, double solde, int typeCompte)
		{
			ListeComptes.Add (Id, libelle, dateOuverture, solde, typeCompte);
		}

		public void Supprimer (Compte compte)
		{
			ListeComptes.Remove (compte);
		}

		public Compte Obtenir (int numero)
		{
			return null;
		}

		public int Afficher ()
		{
			foreach(int compte in ListeComptes)
			{
				Console.WriteLine (compte);
			}
		}

		public int Virement (int montant)
		{

		}
	}
}

