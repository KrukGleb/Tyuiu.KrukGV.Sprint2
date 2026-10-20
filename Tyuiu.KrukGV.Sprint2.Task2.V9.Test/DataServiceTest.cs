
using Tyuiu.KrukGV.Sprint2.Task2.V9.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.CheckDotInShadedArea(4,7);
            Assert.AreEqual(true, res);

            res = ds.CheckDotInShadedArea(1, 7);
            Assert.AreEqual(false, res);

            res = ds.CheckDotInShadedArea(10, 9);
            Assert.AreEqual(true, res);

            res = ds.CheckDotInShadedArea(7, 12);
            Assert.AreEqual(true, res);
        }
    }
}
