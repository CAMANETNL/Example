using Example.Domain.SharedKernel;

namespace Example.Domain
{
    public class Contract : Entity
    {
        public double Price { get; private set; }
        public bool Signed { get; private set; }

        // Navigation Props
        public int TemplateId { get; private set; }
        public ContractTemplate Template { get; private set; }

        // Navigation Props
        public int TenantId { get; private set; }
        public Company Tenant { get; private set; }

        private Contract(double price, int tenantId, int templateId)
        {
            // Needed by EF COre
            Price = price;
            TenantId = tenantId;
            TemplateId = templateId;
            Signed = false;
        }

        public Contract(double price, Company tenant, ContractTemplate template)
        {
            Price = price;
            Tenant = tenant;
            Template = template;
            Signed = false;
        }

        public void MarkAsSigned()
        {
            Signed = true;
        }
    }
}