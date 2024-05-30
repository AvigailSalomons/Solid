using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClients();

        Client GetById(int id);

        Task<Client> AddClientAsync(Client client);

        Task<Client> UpdateClientAsync(int id, Client client);

        Task DeleteClientAsync(int id);
    }
}
