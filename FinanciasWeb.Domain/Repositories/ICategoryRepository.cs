using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GET();
        Category GET(int Id);
        void Created(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
