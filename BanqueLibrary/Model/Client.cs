using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class Client
	{
		private int Id;
        private string Nom;
        private string Prenom;
        private string Adresse;
        private string Cp;
        private string Tel;

        public Client(int Id, string Nom, string Prenom, string Adresse, string Cp, string Tel)
        {
            Id = this.Id;
            Nom = this.Nom;
            Prenom = this.Prenom;
            Adresse = this.Adresse;
            Cp = this.Cp;
            Tel = this.Tel;
        }

        public int AccesId()
        {
            return this.Id;
        }

        public string AccesNom()
        {
            return this.Nom;
        }

        public string AccesPrenom()
        {
            return this.Prenom;
        }

        public string AccesAdresse()
        {
            return this.Adresse;
        }

        public string AccesCp()
        {
            return this.Cp;
        }

        public string AccesTel()
        {
            return this.Tel;
        }
	}
}

