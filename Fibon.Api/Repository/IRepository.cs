using System;
using System.Collections.Generic;

namespace Fibon.Api.Repository
{
    public interface IRepository
    {
         void Add(int number, int result);
         int? Get(int number);
    }

    public class InMemoryRepository : IRepository
    {
        private readonly Dictionary<int, int> _storage = new Dictionary<int, int>();

        public void Add(int number, int result)
        {
            _storage[number] = result;
        }

        public int? Get(int number)
        {
            if(_storage.TryGetValue(number, out int result)){
                return result;
            }

            return null;
        }
    }
}