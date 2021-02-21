﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReflectionEditDialog.Data.Context;
using ReflectionEditDialog.Data.Entityes;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class EmployeesRepository : DbRepository<Employee>
    {
        public override IQueryable<Employee> Items => Set.Include(e => e.Department);

        public EmployeesRepository(IDbContextFactory<EmployeesDB> db) : base(db) { }
    }
}