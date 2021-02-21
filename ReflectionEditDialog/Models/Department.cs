﻿using System.Collections.Generic;

namespace ReflectionEditDialog.Models
{
    class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
