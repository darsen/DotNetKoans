namespace DotNetKoans.CSharp
{
    using System;
    using System.Collections;
    using Xunit;

    public class AboutOperators : Koan
    {
        [Koan(1)]
        public void SafeNavigation()
        {
            string marthonMan = new Random().Next(1) > 2 ? "Is it safe? " : null;
            string safe;
            try
            {
                safe = marthonMan?.ToLower();
                safe += "Yes, it's safe, it's very safe, it's so safe you wouldn't believe it.";
            }
            catch (NullReferenceException)
            {
                safe = "No, it's not safe. It's very dangerous. Be careful.";
            }
            Assert.Equal(safe, FILL_ME_IN);
        }

        [Koan(2)]
        public void NullCoalescing()
        {
            string morpheus = "".Length > 5 ? "Red or blue? " : null;
            string neo;
            try
            {
                neo = morpheus?.ToUpper() ?? "Red pill";
            }
            catch (NullReferenceException)
            {
                neo = "Blue pill";
            }
            Assert.Equal(neo, FILL_ME_IN);
        }

        [Koan(3)]
        public void SafetyCast()
        {
            ICollection mrRipley;
            if (new Random().Next(1) > 2)
            {
                mrRipley = new ArrayList();
            }
            else
            {
                mrRipley = new Hashtable();
            }
            var dickie = mrRipley as ArrayList;
            Assert.Equal(dickie, FILL_ME_IN);
        }

    }
}