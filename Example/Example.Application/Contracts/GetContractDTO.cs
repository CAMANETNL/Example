
namespace Example.Application.Contracts
{
    public class GetContractDTO
    {
        // TODO: remove when seedData is not needed anymore
        public int Id { get; set; }

        public string Text { get; set; }
        public double Price { get; set; }
        public bool Signed { get; set; }
        public string Name { get; set; }
    }

   
}