using System.Collections.Generic;

namespace PlanetaTest.Models
{
    public class ClientsList
    {
        private List<Client> Clients;
        public void SetClients(List<Client> _Clients)
        {
            Clients = _Clients;
        }
        public List<Client> GetClients() => Clients;
        public ClientsList(List<Client> clients)
        {
            SetClients(clients);
        }
    }
}