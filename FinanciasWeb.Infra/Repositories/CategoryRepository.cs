using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.Domain.Repositories;
using FinanciasWeb.Infra.Persistence.DataContexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinanciasWeb.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private StoreDataContext _context;

        public CategoryRepository(StoreDataContext context)
        {
            this._context = context;
        }
        public void Created(Category category)
        {
            this._context.Category.Add(category);
        }

        public void Delete(Category category)
        {
            this._context.Category.Remove(category);
        }

        public List<Category> GET()
        {
            return this._context.Category.ToList();
        }

        public Category GET(int Id)
        {
            return _context.Category.Find(Id);
        }

        public void Update(Category category)
        {
            _context
                .Entry<Category>(category)
                .State = EntityState.Modified;
        }
    }
}