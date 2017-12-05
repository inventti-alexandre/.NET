using FinanciasWeb.Domain.Enum;
using System;
using FinanciasWeb.Domain.Scopes;

namespace FinanciasWeb.Domain.Entitys
{
    public class Product
    {
        public Product(Product product)
        {
            this.GenerationDate = DateTime.Now;
            this.Status = EOrderStatus.Em_Dias;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime? GenerationDate { get; set; }
        public decimal Value { get; set; }
        public DateTime DueDate { get; set; }
        public EOrderStatus Status { get; set; }

        public void Register()
        {
            this.CreatedProductScopesValid();
        }
    }

}
