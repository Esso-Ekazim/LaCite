using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSom3
{
    internal class Client
    {
        private String nom, prenom, courriel, carteDeCredit;
        private int numeroDeChambre;

        //Getters & Setters
        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public String Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public String Courriel
        {
            get { return this.courriel; }
            set { this.courriel = value; }
        }
        
        public String CarteDeCredit
        {
            get { return this.carteDeCredit; }
            set { this.carteDeCredit = value; }
        }

        public int NumerCatoDeChambre
        {
            get { return this.numeroDeChambre; }
            set { this.numeroDeChambre = value; }
        }

        //Constructeur initialisant tous les attributs 
        public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroDeChambre)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.courriel = courriel;
            this.carteDeCredit = carteDeCredit;
            this.numeroDeChambre = numeroDeChambre;
        }

        /*
          * Argument    : Object
          * Type retour : Booléen
          * Rôle        : Tester l'égalité d'un client
          */
        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   nom == client.nom &&
                   prenom == client.prenom &&
                   courriel == client.courriel &&
                   carteDeCredit == client.carteDeCredit &&
                   numeroDeChambre == client.numeroDeChambre;
        }

        /*
         * Argument    : Aucun
         * Type retour : String
         * Rôle        : Renvoyer la description textuelle
         */
        public override string ToString()
        {
            return "------------ Informations sur le client ------------" + "\n" +
                   " Nom : " + nom + "\n" +
                   " Prenom : " + prenom + "\n" +
                   " Courriel : " + courriel + "\n" +
                   " Carte de crédit : " + carteDeCredit + "\n" +
                   " Numéro de chambre : " + numeroDeChambre + "\n" +
                   "----------------------------------------------------" + "\n"; 
        }
    }
}
