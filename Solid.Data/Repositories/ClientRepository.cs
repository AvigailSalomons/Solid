using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ClientRepository:IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context) {
            _context = context;
        }
        public IEnumerable<Client> GetClients() { 
            return _context.clients;
        }

      public  Client GetById(int id) {
            return _context.clients.Find(id);
        }

       public async Task<Client> AddClientAsync(Client client) {
            _context.clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

       public async Task<Client> UpdateClientAsync(int id, Client client) {
            var temp = _context.clients.Find(id);
            temp = client;
            await _context.SaveChangesAsync();
            return temp;
        }

       public async Task DeleteClientAsync(int id) {
            var temp = _context.clients.Find(id);
            _context.clients.Remove(temp);
            await _context.SaveChangesAsync();
        }
    }
}
