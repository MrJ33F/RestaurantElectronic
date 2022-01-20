using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item { Name = "Luger Burger", Price = 12.95M, shortDescription = "Iti va lasa apa-n gura.", LongDescription = "Lorem Ipsum", Category = Categories["Burgeri"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Milkshake Vanilla", Price = 18.95M, shortDescription = "Bautura racoritoare", LongDescription = "Lorem Ipsum", Category = Categories["Bauturi"], ImageUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg", AllergyInformation = "" },
                    new Item { Name = "Milkshace Ciocolata", Price = 18.95M, shortDescription = "Bautura racoritoare", LongDescription = "Lorem Ipsum", Category = Categories["Bauturi"], ImageUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg", AllergyInformation = "" },
                    new Item { Name = "Burger + Cartofi Prajiti", Price = 15.95M, shortDescription = "Meniu ca sa iti pui pofta-n cui.!", LongDescription = "Lorem Ipsum", Category = Categories["Meniuri"], ImageUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg", AllergyInformation = "" },
                    new Item { Name = "Porumbelu' Burger", Price = 13.95M, shortDescription = "Iti va lasa apa-n gura.", LongDescription = "Lorem Ipsum", Category = Categories["Burgeri"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Burger Stil Dublu Animalic", Price = 17.95M, shortDescription = "Iti va lasa apa-n gura.", LongDescription = "Lorem Ipsum", Category = Categories["Burgeri"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Originalu'", Price = 15.95M, shortDescription = "Iti va lasa apa-n gura.", LongDescription = "Lorem Ipsum", Category = Categories["Burgeri"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Capi de Mango", Price = 12.95M, shortDescription = "Bautura racoritoare", LongDescription = "Lorem Ipsum", Category = Categories["Bauturi"], ImageUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg", AllergyInformation = "" },
                    new Item { Name = "Burger + Cartofi Prajiti + Bautura", Price = 15.95M, shortDescription = "Meniu ca sa iti pui pofta-n cui.!", LongDescription = "Lorem Ipsum", Category = Categories["Meniuri"], ImageUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg", AllergyInformation = "" },
                    new Item { Name = "Rodia de Dimineata", Price = 15.95M, shortDescription = "Bautura racoritoare", LongDescription = "Lorem Ipsum", Category = Categories["Bauturi"], ImageUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg", AllergyInformation = "" },
                    new Item { Name = "Mac cel Victorios", Price = 18.95M, shortDescription = "Iti va lasa apa-n gura.", LongDescription = "Lorem Ipsum", Category = Categories["Burgeri"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Burgeri" },
                        new Category { CategoryName = "Meniuri" },
                        new Category { CategoryName = "Bauturi" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
