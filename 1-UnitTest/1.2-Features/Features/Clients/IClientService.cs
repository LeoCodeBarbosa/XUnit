using System;
using System.Collections.Generic;

namespace Features.Clients
{
    public interface IClientService : IDisposable
    {
        IEnumerable<Client> GetAllActives();
        void Add(Client cliente);
        void Update(Client cliente);
        void Remove(Client cliente);
        void Inactivate(Client cliente);
    }
}