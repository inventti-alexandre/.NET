using FinanciasWeb.Infra.Persistence;
using FinanciasWeb.Infra.Persistence.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private StoreDataContext _context;
        public UnitOfWork(StoreDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
