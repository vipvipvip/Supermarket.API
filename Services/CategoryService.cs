using Supermarket.API.Domain.IRepositories;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRespository;
    private readonly IUnitOfWork _unitofWork;
    public CategoryService(ICategoryRepository categoryRespository, IUnitOfWork unitOfWork)
    {
        _categoryRespository = categoryRespository;
        _unitofWork = unitOfWork;
    }
    public Task<IEnumerable<Category>> ListAsync()
    {
        return _categoryRespository.ListAsync();
    }
    public async Task<SaveCategoryResponse> SaveAsync(Category category)
    {
        try
        {
            await _categoryRespository.AddAsync(category);
            await _unitofWork.CompleteAsync();

            return new SaveCategoryResponse(category);

        }
        catch (Exception ex)
        {
            return new SaveCategoryResponse($"An error occurred when saving the category: {ex.Message}");
        }
    }
}
