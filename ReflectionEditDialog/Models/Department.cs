using System;
using System.Collections.Generic;

namespace ReflectionEditDialog.Models
{
    class Department : IEquatable<Department>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public bool Equals(Department other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Department) obj);
        }

        public override int GetHashCode() => Id;

        public static bool operator ==(Department left, Department right) => Equals(left, right);
        public static bool operator !=(Department left, Department right) => !Equals(left, right);
    }
}
