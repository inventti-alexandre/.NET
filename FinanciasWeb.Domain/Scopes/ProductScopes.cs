using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.SharedKernel.Validation.DomainNotificationHelper.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Domain.Scopes
{
    public static class ProductScopes
    {
        public static bool CreatedProductScopesValid(this Product product)
        {
            return Validation.IsSatisfiedBy
                (
                    Validation.AssertNotEmpty(product.Title, "Nome não pode Ser Embranco"),
                    Validation.AssertLength(product.Title,10,80,"Quantidade de Caracteries Invalidos")
                );
        }

        public static bool UpdatedProductScopesValid()
        {
            return false;
        }

        public static bool DeleteProductScopeValid()
        {
            return false;
        }
    }
}
