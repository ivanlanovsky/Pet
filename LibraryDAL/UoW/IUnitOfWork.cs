using System;
using System.Collections.Generic;
using System.Text;
using LibraryDAL.Repository;
using LibraryDAL.Model;

namespace LibraryDAL.UoW
{
    public interface IUnitOfWork: IDisposable
    {
        public void Save();
        public IRepository<User> Users { get; }
        public IRepository<Title> Titles { get; }

    }
}
