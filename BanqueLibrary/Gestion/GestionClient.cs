using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class GestionClient
	{
		List<Client> ListeClients = new List<Client>();

		public int Ajouter()
		{
			ListeClients.Add (new Client ());
		}

		public int Supprimer ()
		{
			ListeClients.Remove (new Client ());
		}

		public int Obtenir ()
		{

		}

		public int Afficher ()
		{

		}
	}
}

