
using Example.Domain.SharedKernel;

namespace Example.Domain.Contracts
{
    public class ContractTemplate : Entity
    {
        public string Text { get; private set; }

        private ContractTemplate() { }

        public ContractTemplate(string text) : base()
        {
            Text = text;
        }

        public void UpdateText(string text)
        {
            Text = text;
        }
    }
}