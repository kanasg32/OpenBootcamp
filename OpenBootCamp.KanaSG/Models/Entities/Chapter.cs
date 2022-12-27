using System.ComponentModel.DataAnnotations;

namespace OpenBootCamp.KanaSG.Models.Entities
{
    public class Chapter:BaseEntity
    {
        public int CursoId { get; set; }    
        public virtual Curso Cursos { get; set; } = new Curso();  

        [Required]
        public string List = string.Empty; 
    }
}
