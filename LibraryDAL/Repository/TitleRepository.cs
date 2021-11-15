using System;
using System.Collections.Generic;
using System.Text;
using LibraryDAL.Model;
using LibraryDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LibraryDAL.Repository
{
    class TitleRepository : IRepository<Title>
    {
        private readonly LibraryContext db;

        public TitleRepository(LibraryContext context)
        {
            this.db = context;
        }

        public IEnumerable<Title> GetAll()
        {
            return db.Titles;
        }
        public bool Add(Title obj)
        {
            db.Titles.Add(obj);
            return true;
        }

        public bool Delete(int id)
        {
            bool res = false;
            Title u = this.GetById(id);
            if (u != null)
            {
                res = true;
                if (db.Entry(u).State == EntityState.Detached)
                    db.Titles.Attach(u);
                db.Titles.Remove(u);
            }
            return res;
        }

        public Title GetById(int id)
        {
            return db.Titles.Find(id);
        }

        public bool Update(Title obj)
        {
            db.Titles.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            return true;
        }
    }
}
