using System;
using PP.CLI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace PP.CLI.Services
{
    public class ClientService
    {

        public List<Client> Clients
        {
            get
            {
                return clients;
            }
        }
        private List<Client> clients;
        private static ClientService? instance;
        public static ClientService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientService();
                }
                return instance;
            }
        }

        private ClientService()
        {
            clients = new List<Client> {
                new Client{Id = 1, Name = "Client 1"},
                new Client{Id = 2, Name = "Client 2"},
                new Client{Id = 3, Name = "Client 3"},

                new Client{Id = 4, Name = "Client 4"},
                new Client{Id = 5, Name = "Client 5"},
                new Client{Id = 6, Name = "Client 6"}



            };




        }




        /*
		public List<Client> Search(string query) {
			return Clients.Where(s => s.Name.ToUpper().Contains(query.ToUpper())).ToList();
		}
        */
        /*
		public Client? Get(int id) {
			return clients.FirstOrDefault(e => e.Id == id);
		}


		public void Add(Client? client) {
			if (client != null) {
				clients.Add(client);
			}
		}
        */

        public void Delete(int id)
        {


            Console.WriteLine(id);


            var clientToDelete = Clients.FirstOrDefault(c => c.Id == id);
            Console.WriteLine("This is for client services: ");
            Console.WriteLine(clientToDelete);
            if (clientToDelete != null)
            {
                Console.WriteLine("went through");
                Clients.Remove(clientToDelete);
                //Read();

            }
        }

        /*
        public void Delete(Client s)

        {
            //Console.WriteLine(s);
            Delete(s.Id);
        }


		*/

        /*
        public void Read()
        {
            clients.ForEach(Console.WriteLine);
        }



        */

    }
}