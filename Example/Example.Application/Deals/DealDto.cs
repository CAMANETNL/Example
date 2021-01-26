using Example.Application.Contracts;
using Example.Domain.Deals;
using System.ComponentModel.DataAnnotations;

namespace Example.Application.Deals

{
    public class GetDealDTO
    {
        public DealStatus Status { get; set; }
        public GetContractDTO Buy { get; set; }
        public GetContractDTO Sell { get; set; }
    }

    public class AddDealDTO
    {
        [Required]
        public AddContractDTO Buy { get; set; } = new AddContractDTO() { };
        [Required]
        public AddContractDTO Sell { get; set; } = new AddContractDTO() { };
    }
}