using System;
using TaxCalculatorConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxCalculatorConsoleApp.UnitTest
{
    [TestClass]
    public class TaxesFor2018_UnitTest
    {
        [TestMethod]
        public void TaxesFor2018_GrossIncomeLessThan24000_Returns24000()
        {
            var taxTrial = new TaxesFor2018(65000, 50);

            double r = taxTrial.Taxes_owed_at_10_percent();
            double a = r;

            Assert.Equals(r, a);

        }
    }
}
