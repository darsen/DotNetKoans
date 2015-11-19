namespace DotNetKoans.CSharp
{
    using System;
    using Xunit;

    public class AboutOperators : Koan
    {
        [Koan(1)]
        public void Elvis()
        {
            string guitar = new Random().Next(1) > 2 ? "is alien and " : null;
            string Elvis;
            try
            {
                Elvis = guitar?.ToLower();
                Elvis += "is alive";
            }
            catch (NullReferenceException)
            {
                Elvis = "is dead";
            }
            Assert.Equal(Elvis, FILL_ME_IN);            
        }

    }
}