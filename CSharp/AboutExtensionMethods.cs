namespace DotNetKoans.CSharp
{
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class AboutExtensionMethods : Koan
    {
        [Koan(1)]
        public void Filter()
        {
            int title;
            var books = new List<string> {"1984", "Animal Farm", "Homage to Catalonia", "Burmese Days"};
            var number_as_title = books.Where(t => int.TryParse(t, out title)).First();
            Assert.Equal(number_as_title, FILL_ME_IN);
        }

        [Koan(2)]
        public void Flatten()
        {
            var fiction_and_nonfiction = new List<List<string>>
            {
                new List<string> {"1984", "Animal Farm"},
                new List<string> {"Homage to Catalonia", "Burmese Days"}
            };
            var all = fiction_and_nonfiction.SelectMany(b => b).ToList();
            Assert.Equal(all, FILL_ME_IN);
        }

        [Koan(3)]
        public void Map()
        {
            var books = new List<string> {"1984", "Animal Farm", "Homage to Catalonia", "Burmese Days"};
            var title_length = books.Select(t => t.Length);
            Assert.Equal(title_length, FILL_ME_IN);
        }

        [Koan(4)]
        public void Intersect()
        {
            var Orwells = new List<string> {"1984", "Animal Farm", "Homage to Catalonia", "Burmese Days"};
            var great_novels = new List<string> {"Hear of Darkness", "1984", "Animal Farm", "Ulysses"};
            var Orwells_great_novels = great_novels.Intersect(Orwells).ToArray();
            Assert.Equal(Orwells_great_novels, FILL_ME_IN);
        }

        [Koan(5)]
        public void Union()
        {
            var Orwells = new List<string> { "1984", "Animal Farm", "Homage to Catalonia", "Burmese Days" };
            var great_novels = new List<string> { "Hear of Darkness", "1984", "Animal Farm", "Ulysses" };
            var all = great_novels.Union(Orwells).ToArray();
            Assert.Equal(all, FILL_ME_IN);
        }

        [Koan(6)]
        public void Aggregate()
        {
            var books = new List<string> { "1984", "Animal Farm", "Homage to Catalonia", "Burmese Days" };
            var more_books = books.Aggregate("Orwell's novels are: ", (a, b) => a + b + ", ") + "A Clergyman's daughter";
            Assert.Equal(more_books, FILL_ME_IN);
        }

    }
}