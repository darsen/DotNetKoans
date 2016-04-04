namespace DotNetKoans.CSharp
{
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class AboutExtensionMethods : Koan
    {
        private readonly int __ = 0;
        private readonly string ___ = "";

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
            Assert.Equal(all, new List<string> {___, ___, ___, ___});
        }

        [Koan(3)]
        public void Map()
        {
            var books = new List<string> {"1984", "Animal Farm", "Homage to Catalonia", "Burmese Days"};
            var title_length = books.Select(t => t.Length);
            Assert.Equal(title_length, new[] {__, __, __, __});
        }

        [Koan(4)]
        public void Intersect()
        {
            var Orwells = new List<string> {"1984", "Animal Farm", "Homage to Catalonia", "Burmese Days"};
            var great_novels = new List<string> {"Hear of Darkness", "1984", "Animal Farm", "Ulysses"};
            var Orwells_great_novels = great_novels.Intersect(Orwells).ToArray();
            Assert.Equal(Orwells_great_novels, new[] { ___, ___ });
        }
    }
}