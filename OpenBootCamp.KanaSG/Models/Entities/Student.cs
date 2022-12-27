using System.ComponentModel.DataAnnotations;

namespace OpenBootCamp.KanaSG.Models.Entities
{
    public class Student:BaseEntity
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateTime Bob { get; set; }

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>(); 


    }
}
