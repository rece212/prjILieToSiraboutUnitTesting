using prjILieToSiraboutUnitTesting;

namespace TestIWantANewProgLect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestEmail()
        {

        }
        [TestMethod]
        public void TestAge()
        {

        }
    }
}