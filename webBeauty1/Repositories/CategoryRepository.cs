using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using webBeauty1.Models;

namespace webBeauty1.Repositories
{
    public class CategoryRepository
    {
        public  List<CategoryModel> GetAllListAsync()
        {
             var list = new List<CategoryModel>();
             list.Add(new CategoryModel { Id = 1, Name = "Массаж", });
             list.Add(new CategoryModel { Id = 2, Name = "Манік'юр" });
             list.Add(new CategoryModel { Id = 3, Name = "Космитологія" });
             return list;
        }
    }
}
