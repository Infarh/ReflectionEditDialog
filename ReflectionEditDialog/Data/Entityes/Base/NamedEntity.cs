using System.ComponentModel.DataAnnotations;

namespace ReflectionEditDialog.Data.Entityes.Base
{
    public abstract class NamedEntity : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
