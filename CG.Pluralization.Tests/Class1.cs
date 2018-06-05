using CG.Pluralization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QA.CG.Pluralization
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void T()
        {
            var foo = PluralizationService.CreateService().Pluralize("chip");
            Assert.IsTrue(foo == "chips");
        }
    }
}
