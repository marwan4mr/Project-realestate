﻿using realestate_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL
{ 
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly RealstateContext _context;

        public GenericRepo(RealstateContext context)
        {
            _context = context;
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
             _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {    
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}