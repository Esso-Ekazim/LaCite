using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalSom3
{
    internal class Hotel
    {
        private String nomHotel, adresse;
        private int nombreDeChambre;
        private long numDeTel;
        private List<Client> Clients = new List<Client>();

        //Getters & Setters
        public String Nom
        {
            get { return this.nomHotel; }
            set { this.nomHotel = value; }
        }

        public String Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public int NombreDeChambre
        {
            get { return this.nombreDeChambre; }
            set { this.nombreDeChambre = value; }
        }

        public long NumeroDeTelephone
        {
            get { return this.numDeTel; }
            set { this.numDeTel = value; }
        }


        //Constructeur initialisant tous les attributs 
        public Hotel(string nomHotel, string adresse, int nombreDeChambre, long numDeTel)
        {
            this.nomHotel = nomHotel;
            this.adresse = adresse;
            this.nombreDeChambre = nombreDeChambre;
            this.numDeTel = numDeTel;
        }


        /*
        * Argument    : nouveauClient 
        * Type retour : Aucun
        * Rôle        : Ajouter un client à l'Hotel
        */
        public void AjouterClient(Client nouveauClient)
        {
            Clients.Add(nouveauClient);
        }

        /*
         * Argument    : nouveauClient
         * Type retour : bool
         * Rôle        : Tester l'égalité d'un hôtel 
         */
        public override bool Equals(object? obj)
        {
            return obj is Hotel hotel &&
                   nomHotel == hotel.nomHotel &&
                   adresse == hotel.adresse &&
                   nombreDeChambre == hotel.nombreDeChambre &&
                   numDeTel == hotel.numDeTel;
        }

        public override string ToString()
        {
            String listeDeClients = "";
            Console.WriteLine("------------ Liste des clients de l'hôtel "+ nomHotel + "------------" + "\n");
            foreach (Client client in Clients)
            {
                //listeDeClients += client.ToString() + "\n";
                Console.WriteLine(client.ToString());
            }
            return "------------ Informations sur le l'hôtel ------------" + "\n" +
                   " Nom : " + nomHotel + "\n" +
                   " Adresse : " + adresse + "\n" +
                   " Nombre de chambres : " + nombreDeChambre + "\n" +
                   " Numéro de Téléphone : " + numDeTel + "\n" +
                   "----------------------------------------------------" + "\n";
        }
    }
}
