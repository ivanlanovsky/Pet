using System;
using System.Collections.Generic;
using System.Text;
using LibraryDAL.Repository;
using LibraryDAL.Context;
using LibraryDAL.Model;

namespace LibraryDAL.UoW
{
    public sealed class UnitOfWork : IUnitOfWork
    {

        private readonly LibraryContext db;
        private IRepository<User> userRepo;
        private IRepository<Title> titleRepo;

        public UnitOfWork(LibraryContext context)
        {
            this.db = context;
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepo == null)
                    userRepo = new UserRepository(db);
                return userRepo;
            }
        }

        public IRepository<Title> Titles
        {
            get
            {
                if (titleRepo == null)
                    titleRepo = new TitleRepository(db);
                return titleRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
