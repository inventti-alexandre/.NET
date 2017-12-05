using FinanciasWeb.Domain.Scopes;
namespace FinanciasWeb.Domain.Entitys
{
    public class Category
    {
        public Category(Category category)
        {
            this.Title = category.Title;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public void RegisterCategory()
        {
            if (!this.CreatedCategoryScopesIsValid())
                return;

        }

        public void RegisterCategory(string Title)
        {
            if (!this.UpdatedCategoryScopesValid(Title))
                return;
            this.Title = Title;
        }

    }

}
