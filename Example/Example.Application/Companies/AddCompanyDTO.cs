using System.ComponentModel.DataAnnotations;

namespace Example.Application.Companies
{
    public class AddCompanyDTO
    {
        [Required]
        public string Name { get; set; }
    }
}