using FinanciasWeb.Domain.Dto;
using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Service
{
    public interface IProductAplicationService
    {
        List<Product> GET();
        List<Product> GET(int Id);
        void Created(ProductDto product);
        void Delete(ProductDto product);
        void Update(ProductDto product);

    }
}
