using System.ComponentModel.DataAnnotations;

namespace AdoPrac.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
    }
}
