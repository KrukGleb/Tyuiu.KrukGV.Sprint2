

using Tyuiu.KrukGV.Sprint2.Task3.V13.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.Calculate(1);
            Assert.AreEqual(11, res);

        }
    }
}
