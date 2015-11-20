namespace DotNetKoans.CSharp
{
    using System;
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

    }
}