using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;   
        }
        public IEnumerable<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            await _clientRepository.AddClientAsync(client);
            return client;
        }

        public async Task<Client> UpdateClientAsync(int id, Client client)
        {
            await _clientRepository.UpdateClientAsync(id, client);
            return client;

        }
            public async Task DeleteClientAsync(int id)
        {
           await _clientRepository.DeleteClientAsync(id);
        }
    }
}
