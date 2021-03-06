using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item GetItemById(int itemId);
    }
}
