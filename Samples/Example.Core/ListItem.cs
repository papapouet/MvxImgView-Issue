using System;
using System.Collections.Generic;

namespace Example.Core
{
    public class ListItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual string ImageUrl
        {
            get
            {
                var random = new Random();
                var i = random.Next(1, 24);
                return string.Format("res:sport_sport_list_icon{0}", i);
            }
        }


        public static List<ListItem> Generate(int number)
        {
            var items = new List<ListItem>();
            for (var i = 0; i < number; i++)
            {
                

                var sport = new ListItem()
                {
                    Id = i,
                    Title = string.Format("Sport{0}", i)
                };

                items.Add(sport);
            }

            return items;
        } 
    }
}