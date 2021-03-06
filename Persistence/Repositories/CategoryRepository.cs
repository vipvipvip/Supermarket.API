using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.IRepositories;
using Supermarket.API.Domain.Models;
using Supermarket.API.Persistence.Contexts;
using Supermarket.API.Persistence.Repositories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<IEnumerable<Category>> ListAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task AddAsync(Category category)
    {
        await _context.Categories.AddAsync(category);
    }
}
