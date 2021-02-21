using System.Collections.Generic;
using ReflectionEditDialog.Data.Entityes.Base;

namespace ReflectionEditDialog.Data.Entityes
{
    public class Department : NamedEntity
    {
        public ICollection<Employee> Employees { get; set; }
    }
}
