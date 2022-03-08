using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.IRepositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> ListAsync();
    Task AddAsync(Category category);
}
