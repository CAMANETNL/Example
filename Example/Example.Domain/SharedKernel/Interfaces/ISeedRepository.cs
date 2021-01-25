using System.Threading.Tasks;

namespace Example.Domain.SharedKernel
{
    public interface ISeedRepository
    {
        Task<string> PopulateTestDataAsync();
    }
}
