using FinanciasWeb.Domain.Dto;
using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Service
{
    public interface ICategoryAplicationService
    {
        List<Category> GET();
        Category GET(int Id);
        void Created(CategoryDto category);
        void Delete(CategoryDto category);
        void Update(CategoryDto category);
    }
}
