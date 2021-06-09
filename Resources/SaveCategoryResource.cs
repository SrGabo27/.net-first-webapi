using System.ComponentModel.DataAnnotations;

namespace first_app.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
