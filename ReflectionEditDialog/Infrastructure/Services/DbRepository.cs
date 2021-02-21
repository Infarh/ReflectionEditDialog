using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReflectionEditDialog.Data.Context;
using ReflectionEditDialog.Data.Entityes.Base;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class DbRepository<T> : IRepository<T>, IDisposable where T : Entity, new()
    {
        private readonly EmployeesDB _db;

        protected DbSet<T> Set { get; }

        public virtual IQueryable<T> Items => Set;

        public bool AutoSaveChanges { get; set; } = true;

        public DbRepository(IDbContextFactory<EmployeesDB> db)
        {
            _db = db.CreateDbContext();
            Set = _db.Set<T>();
        }

        public T Get(int id) => Items is DbSet<T> set ? set.Find(id) : Items.FirstOrDefault(e => e.Id == id);

        public T Add(T item)
        {
            Set.Add(item);
            if (AutoSaveChanges)
                _db.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges)
                _db.SaveChanges();
            return item;
        }

        public bool Remove(int id)
        {
            var item = Set.Local.FirstOrDefault(i => i.Id == id) 
                ?? Set.Select(i => new T {Id = i.Id}).FirstOrDefault(i => i.Id == id);
            if (item is null) return false;
            _db.Entry(item).State = EntityState.Deleted;
            if (AutoSaveChanges)
                _db.SaveChanges();
            return true;
        }

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            _db?.Dispose();
        }
    }
}
