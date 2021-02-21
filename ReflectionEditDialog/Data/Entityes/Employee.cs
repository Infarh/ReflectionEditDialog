﻿using System;
using ReflectionEditDialog.Data.Entityes.Base;

namespace ReflectionEditDialog.Data.Entityes
{
    public class Employee : NamedEntity
    {
        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
