namespace DotNetKoans.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class AboutOperators : Koan
    {
        [Koan(1)]
        public void Elvis()
        {
            string guitar = null;
            string Elvis = "dead or alive?";
            try
            {
                Elvis = guitar?.ToLower();
                Elvis = "is_alive";
            }
            catch (NullReferenceException ex)
            {
                Elvis = "is_dead";
            }
            Assert.Equal(Elvis, FILL_ME_IN);            
        }

    }
}