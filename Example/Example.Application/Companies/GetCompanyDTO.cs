using System;
using System.ComponentModel.DataAnnotations;

namespace Example.Application.Companies
   
{
    public class GetCompanyDTO
    {
        public string Name { get; set; }
        // TODO: remove when done manually testing
        public int Id { get; set; }
    }

   
}