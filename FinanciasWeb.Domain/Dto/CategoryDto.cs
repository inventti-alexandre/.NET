using FinanciasWeb.Domain.Scopes;
namespace FinanciasWeb.Domain.Dto
{
    public class CategoryDto
    {
        public CategoryDto(string Title)
        {
            this.Title = Title;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        //public void RegisterCategory()
        //{
        //    if (!this.CreatedCategoryScopesIsValid())
        //        return;

        //}

        //public void RegisterCategory(string Title)
        //{
        //    if (!this.UpdatedCategoryScopesValid(Title))
        //        return;

        //    this.Title = Title;
        //}

    }

}
