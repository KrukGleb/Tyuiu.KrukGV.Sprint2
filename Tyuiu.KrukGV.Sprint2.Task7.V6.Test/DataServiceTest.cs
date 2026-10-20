using Tyuiu.KrukGV.Sprint2.Task7.V6.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.CheckDotInShadedArea(0.3, 1.4);
            Assert.AreEqual(true, res);
        }
    }
}
