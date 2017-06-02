﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseRepository<TEntity> where TEntity: class
    {
        protected MyTicketContext _context;
        public BaseRepository(MyTicketContext context)
        {
            _context = context;
        }
        public void Add(TEntity item)
        {
          _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }
        public void Update(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(TEntity item) {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }
        public TEntity Get(int id) {
            return _context.Set<TEntity>().Find(id);

        }
        public List<TEntity> GetAll() {
            return _context.Set<TEntity>().ToList();
        }





    }
}
