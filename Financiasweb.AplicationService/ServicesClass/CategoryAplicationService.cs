using FinanciasWeb.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Domain.Repositories;
using FinanciasWeb.Infra.Persistence;
using FinanciasWeb.Domain.Dto;

namespace FinanciasWeb.AplicationService.ServicesClass
{
    public class CategoryAplicationService : AplicationService, ICategoryAplicationService
    {
        private ICategoryRepository _repository;
        public CategoryAplicationService(
            ICategoryRepository repository, 
            IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }
        public void Created(CategoryDto category)
        {
            throw new NotImplementedException();
        }

        public void Delete(CategoryDto category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GET()
        {
            throw new NotImplementedException();
        }

        public Category GET(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDto category)
        {
            throw new NotImplementedException();
        }
    }
}
