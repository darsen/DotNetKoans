namespace DotNetKoans.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class AboutOperators : Koan
    {
        [Koan(1)]
        public void ElvisOperator()
        {
            string foo = null;
            try
            {
                foo = foo?.ToLower();
            }
            catch (NullReferenceException ex)
            {
                foo = "exception";
            }
            Assert.Equal(FILL_ME_IN, foo);            
        }
    }
}