using System.ComponentModel.DataAnnotations;

namespace AdoPrac.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}x
