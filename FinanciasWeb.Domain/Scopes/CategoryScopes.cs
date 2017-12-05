using FinanciasWeb.Domain.Entitys;
using FinanciasWeb.SharedKernel.Validation.DomainNotificationHelper.Validation;

namespace FinanciasWeb.Domain.Scopes
{
    public static class CategoryScopes
    {
        public static bool CreatedCategoryScopesIsValid(this Category category)
        {
            return Validation.IsSatisfiedBy
            (
                Validation.AssertNotEmpty(category.Title, "O Titulo não pode ser Vazio"),
                Validation.AssertLength(category.Title,3,15,"Tamanha Caracteries Invalido")
            );
        }

        public static bool UpdatedCategoryScopesValid(this Category category, string title)
        {
            return Validation.IsSatisfiedBy
            (
                Validation.AssertNotEmpty(title, "O Titulo não pode ser Vazio"),
                Validation.AssertLength(title, 3, 15, "Tamanha Caracteries Invalido")
            );
        }

        public static bool DeleteCategoryScopesValid(this Category category)
        {
            return false;
        }
    }
}
