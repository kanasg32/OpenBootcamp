using System.ComponentModel.DataAnnotations;

namespace OpenBootCamp.KanaSG.Models.Entities
{
    public class Category: BaseEntity
    {

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Curso> Cursos { get; set; } =new List<Curso>();
    }
}
