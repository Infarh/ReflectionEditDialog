using System;
using ReflectionEditDialog.Data.Entityes.Base;

namespace ReflectionEditDialog.Data.Entityes
{
    public class Employee : NamedEntity
    {
        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public Departament Departament { get; set; }
    }
}
