namespace EvalSom3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des clients
            Client client1 = new Client("David", "Ramos", "david@ramos.com", "7849-4814-7148-1210", 1); Client client2 = new Client("Jessica", "Brest", "Jessica@brest.com", "6687-2290-8853-2592", 4);
            Client client3 = new Client("Maria", "Miller", "maria@miler.com", "6504-0218-3134-3509", 4); Client client4 = new Client("Troy", "Anderson", "troy@anderson.com", "7465-6762-1922-6873", 11);
            Client client5 = new Client("Shawn", "Klein", "shawn@klein.com", "7255-1424-8773-8246", 8); Client client6 = new Client("Dustin", "Archer", "dustin@archer.com", "7849-4814-7148-1210", 2);
            Client client7 = new Client("Mary", "Pollard", "mary@pollard.com", "9876-5522-3426-7779", 1); Client client8 = new Client("Monica", "Morgan", "monica@morgan.com", "2580-3737-7477-7756", 12);
            Client client9 = new Client("Nancy", "Cook", "nancy@cook.com", "1883-8765-4711-6332", 5); Client client10 = new Client("Michael", "Campbell", "michael@campbell.com", "9016-1009-3444-1802", 6);

            //Création des hôtels;
            Hotel hotel1 = new Hotel("Hilton", "1100 boul. René-Lévesque Est, G1R 5V2, Québec City", 200,4186472411);
            Hotel hotel2 = new Hotel("Ramada Plaza", "75 rue d'Edmonton, Hull, J8Y 6W9, Gatineau", 110, 8197777538);

            //Création d'une liste de clients de l'hôtel 1
            hotel1.AjouterClient(client1);
            hotel1.AjouterClient(client3);
            hotel1.AjouterClient(client5);
            hotel1.AjouterClient(client7);
            hotel1.AjouterClient(client9);

            //Création d'une liste de clients de l'hôtel 2
            hotel2.AjouterClient(client2);
            hotel2.AjouterClient(client4);
            hotel2.AjouterClient(client6);
            hotel2.AjouterClient(client8);
            hotel2.AjouterClient(client10);

            //Affichage d'un client
            //Console.WriteLine(client1);
            Console.WriteLine();

            //Affichage d'un hôtel
            Console.WriteLine(hotel1);
            Console.WriteLine();
            Console.WriteLine(hotel2);
        }
    }
}