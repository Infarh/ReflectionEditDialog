using System;

namespace ReflectionEditDialog.Models
{
    class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public Department Department { get; set; }

        public bool Equals(Employee other) => 
            other is not null 
            && (ReferenceEquals(this, other) || Id == other.Id);

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Employee) obj);
        }

        public override int GetHashCode() => Id;

        public static bool operator ==(Employee left, Employee right) => Equals(left, right);
        public static bool operator !=(Employee left, Employee right) => !Equals(left, right);
    }
}
