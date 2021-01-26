using System.ComponentModel.DataAnnotations;

namespace Example.Application.Companies
{
    public class AddCompanyDto
    {
        [Required]
        public string Name { get; set; }
    }
}