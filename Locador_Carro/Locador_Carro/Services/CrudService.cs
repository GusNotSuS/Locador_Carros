using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarros.Services
{
    public class CrudService<T> where T : class
    {
        private readonly List<T> _data = new();
        private int _nextId = 1;

        public void Add(T item)
        {
            ((dynamic)item).Id = _nextId++;
            _data.Add(item);
        }

        public List<T> GetAll() => _data;

        public T GetById(int id) => _data.FirstOrDefault(i => ((dynamic)i).Id == id);

        public void Delete(int id) => _data.RemoveAll(i => ((dynamic)i).Id == id);
    }
}

