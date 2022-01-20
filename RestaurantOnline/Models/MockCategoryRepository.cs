using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId=1, CategoryName="Burgeri", Description="",},
                    new Category {CategoryId=2, CategoryName="Bauturi", Description=""},
                    new Category {CategoryId=3, CategoryName="Meniuri", Description=""}
                };
            }
        }
    }
}
