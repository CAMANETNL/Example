using System.ComponentModel.DataAnnotations;

namespace Example.Application.Contracts
{
    public class AddContractDTO
    {
        [Required]
        public double Price { get; set; }
        [Required]
        public int ContractId { get; set; }
        [Required]
        public int TemplateId { get; set; }
    }
}
