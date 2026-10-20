using Tyuiu.KrukGV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.FindDayName(1, 3);
            Assert.AreEqual("среда", res);
        }
    }
}
