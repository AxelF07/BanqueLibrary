using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class Compte
	{
		private int identifiant;
		private string libelle;
		private DateTime dateOuverture;
		private double solde;
		private int typeCompte;


		public int Crediter(int montant)
		{
			solde += montant;
		}

		public virtual int Debiter(int montant)
		{
			solde -= montant;
		}

		public int Id
		{
			get{ return Id; }
		}

		public string Libelle
		{
			get { return this.libelle; }
			set { this.libelle = value; }
		}

		public DateTime DateOuverture
		{
			get { return dateOuverture; }
			set { dateOuverture = value; }
		}

		public double Solde
		{
			get { return solde; }
		}

		public int TypeCompte
		{
			get { return typeCompte; }
		}

	}
}

