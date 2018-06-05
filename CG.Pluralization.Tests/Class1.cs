using System.Data.Entity.Design.PluralizationServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QA.CG.Pluralization
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void T()
        {
            var foo = PluralizationService.CreateService(new System.Globalization.CultureInfo("en")).Pluralize("chip");
            Assert.IsTrue(foo == "chips");
        }
    }
}
