using Tyuiu.KrukGV.Sprint2.Task4.V26.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.Calculate(1, 3);
            Assert.AreEqual(1728, res);

        }
    }
}
