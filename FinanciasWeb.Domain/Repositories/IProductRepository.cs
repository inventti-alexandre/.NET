using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Repositories
{
    public interface IProductRepository
    {
        List<Product> GET();
        List<Product> GET(int Id);
        void Created(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
