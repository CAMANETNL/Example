using Example.Domain.SharedKernel;
using Example.Domain.Companies;

namespace Example.Domain.Contracts
{
    public class Contract : Entity
    {
        public double Price { get; private set; }
        public bool Signed { get; private set; }

        // Navigation Props
        public int TemplateId { get; private set; }
        public ContractTemplate Template { get; private set; }

        // Navigation Props
        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        private Contract(double price, int tenantId, int templateId)
        {
            // Needed by EF COre
            Price = price;
            CompanyId = tenantId;
            TemplateId = templateId;
            Signed = false;
        }

        public Contract(double price, Company company, ContractTemplate template)
        {
            Price = price;
            Company = company;
            Template = template;
            Signed = false;
        }

        public void MarkAsSigned()
        {
            Signed = true;
        }
    }
}