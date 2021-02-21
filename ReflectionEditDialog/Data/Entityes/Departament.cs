using System.Collections.Generic;
using ReflectionEditDialog.Data.Entityes.Base;

namespace ReflectionEditDialog.Data.Entityes
{
    public class Departament : NamedEntity
    {
        public ICollection<Employee> Employees { get; set; }
    }
}
