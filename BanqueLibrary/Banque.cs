using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class Banque
	{
		private string nom;

		void afficherCompte()
		{
			Console.WriteLine ("Choisissez un compte à afficher: ");
			int libelle = read.readInt ();
			GestionCompte.Afficher;
		}
		void choisirTypeCompte()
		{
			int choix = 0;
			do
			{
				Console.WriteLine("0 Compte rémunéré");
				Console.WriteLine("1 Compte non-rémunéré");
				Console.WriteLine("Indiquez le type de compte à ajouter: ");
				choix = read.readInt();
			}while(choix != 0);
		}

		void ajouterCompte()
		{
			int Id;
			string libelle;
			DateTime date = System.DateTime.Now;
			double solde;
			int typeCompte;
			GestionCompte.Ajouter(Id, libelle, date, solde, typeCompte );
		}

		void afficherMenu ()
		{
			int choixUtilisateur = 0;
			do
			{
				Console.WriteLine("0 Ajouter un compte");
				Console.WriteLine("1 Supprimer un compte");
				Console.WriteLine("2 Obtenir un compte");
				Console.WriteLine("3 Afficher un compte");
				Console.WriteLine("4 Effectuer un virement");
				Console.WriteLine("5 Quitter");
				do
				{
					choixUtilisateur = read.readInt();
				}while(0 < choixUtilisateur || choixUtilisateur > 0 );

				switch(choixUtilisateur)
				{
				case 0:
					afficherCompte();
					choisirTypeCompte();
					ajouterCompte();
				break;
				case 0:

				break;
				case 1:
				break;
				case 2:
				break;
				case 3:

				break;
				case 4:
				break;
				case 5:
				break;
				default:
					Console.WriteLine("Valeur inconnue");
				break;
				}
			}while(choixUtilisateur != 0);
				
		}
	}
}

