namespace Magazine.DAL.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Magazine.DAL.Context.MagazineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Magazine.DAL.Context.MagazineContext context)
        {
            var store = new List<Store>
            {
                new Store { Name = "LightPoint", Address = "220113, Belarus, Minsk city,  5-1 Melezha str., Apt. 306", StartWorkTime = "11.00 A.M.", EndWorkTime = "00.00 A.M." },
                new Store { Name = "EPAM", Address = "1/1 Academician Kuprevich Street, Suite 110, 220141 Minsk Belarus", StartWorkTime = "8.30 A.M.", EndWorkTime = "20.00 P.M." },
                new Store { Name = "HTP", Address = "Kuprevicha, 1/1, 220141, Minsk, Belarus.", StartWorkTime = "9.30 A.M.", EndWorkTime = "22.30 P.M." },
                new Store { Name = "Itransition", Address = "Street Kuĺman 1, Minsk 220013, Belarus", StartWorkTime = "10.00 A.M.", EndWorkTime = "21.00 P.M." },
                new Store { Name = "Wargaming", Address = "Partizansky Ave. 178/2, Minsk", StartWorkTime = "7.00 A.M.", EndWorkTime = "23.00 P.M." },
                new Store { Name = "Scand Ltd.", Address = "8b/1-520 Fabritsiusa str., 220007 Minsk, Belarus", StartWorkTime = "8.00 A.M.", EndWorkTime = "18.00 P.M." },
                new Store { Name = "exp(capital)", Address = "36 Internacyjanalnaya str. 6th floor, Minsk 220022, Belarus", StartWorkTime = "6.00 A.M.", EndWorkTime = "17.00 P.M." },
                new Store { Name = "WorkFusion", Address = "48 Wall Street, 7th floor New York NY 10005 ", StartWorkTime = "7.30 A.M.", EndWorkTime = "20.30 P.M." }
            };
            store.ForEach(s => context.Stores.Add(s));
            context.SaveChanges();

            for (int j = 1; j <= store.Count; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    var item = new Item
                    {
                        Name = $"Item{i}",
                        Description = $"Description{i}",
                        StoreId = j
                    };
                    context.Items.Add(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
