using System;
using HRLibrary;
using NUnit.Framework;
namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class MedicineUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var regulon = CreateTestMedicine();
            Assert.AreEqual("Regulon", regulon.Name);
            Assert.AreEqual("4638234", regulon.Code);
            Assert.AreEqual(Omitting.NoPerscription, regulon.Omit);
            Assert.AreEqual("Gedeon Richter", regulon.Company);
        }
        [Test]
        public void ToString_Person_NameSpaceCode()
        {
            var regulon = CreateTestMedicine();
            Assert.AreEqual("Regulon 4638234", regulon.ToString());
        }
        private Medicine CreateTestMedicine()
        {
            return new Medicine("Regulon", "4638234", Omitting.NoPerscription, "Gedeon Richter");
        }
    }
}
