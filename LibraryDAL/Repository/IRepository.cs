using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Repository
{
    public interface IRepository<T> where T: class
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public bool Add(T obj);
        public bool Update(T obj);
        public bool Delete(int id);
    }
}
