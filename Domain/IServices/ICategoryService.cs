using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services.Communication;

public interface ICategoryService
{
    Task<IEnumerable<Category>> ListAsync();
    Task<SaveCategoryResponse> SaveAsync(Category category);
}
