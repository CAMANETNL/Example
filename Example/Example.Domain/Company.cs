
using Example.Domain.SharedKernel;

namespace Example.Domain

{
    public class Company : Entity
    {
        public string Name { get; private set; }

        public Company(string name) : base()
        {
            Name = name;
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}