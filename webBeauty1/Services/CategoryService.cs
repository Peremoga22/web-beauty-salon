using System.Collections.Generic;
using System.Threading.Tasks;
using webBeauty1.Models;
using webBeauty1.Repositories;

namespace webBeauty1.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }
       public List<CategoryModel> GetAllListAsync()
        {
            
            var result =  _categoryRepository.GetAllListAsync();
            return result;
        }
    }
}
