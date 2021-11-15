using System;
using System.Collections.Generic;
using System.Text;
using LibraryDAL.Model;
using LibraryDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LibraryDAL.Repository
{
    class UserRepository : IRepository<User>
    {
        private readonly LibraryContext db;

        public UserRepository(LibraryContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }
        public bool Add(User obj)
        {
            db.Users.Add(obj);
            return true;
        }

        public bool Delete(int id)
        {
            bool res = false;
            User u = this.GetById(id);
            if (u != null)
            {
                res = true;
                if (db.Entry(u).State == EntityState.Detached)
                    db.Users.Attach(u);
                db.Users.Remove(u);
            }
            return res;
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            db.Users.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            return true;
        }
    }
}
