using BlogAPI.Models.Domain;

namespace BlogAPI.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
