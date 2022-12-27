using System.ComponentModel.DataAnnotations;

namespace OpenBootCamp.KanaSG.Models.Entities
{
    public class Curso:BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        public string TargetAudience { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public Level Levels { get; set; } = Level.Basico;

        [Required]
        public Chapter Chapters { get; set; } = new Chapter();
        public ICollection<Category> Categories { get; set; } = new List<Category>();       
        public ICollection<Student> Students { get; set; } = new List<Student>();       
    }
}
