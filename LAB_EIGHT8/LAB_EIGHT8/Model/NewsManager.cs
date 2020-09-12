using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_EIGHT8.Model
{
    class NewsManager
    {
        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem1" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Lorem2" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Lorem3" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Lorem4" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Lorem5" });
            
            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Lorem6" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Lorem7" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "Lorem8" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Lorem9" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Lorem10" });

            return items;
        }
    }
}
