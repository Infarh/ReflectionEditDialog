using System;

namespace ReflectionEditDialog.Models
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public Department Department { get; set; }
    }
}
