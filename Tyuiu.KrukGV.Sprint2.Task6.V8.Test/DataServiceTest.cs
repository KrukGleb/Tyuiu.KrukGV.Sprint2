using Tyuiu.KrukGV.Sprint2.Task6.V8.Lib;

namespace Tyuiu.KrukGV.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfPreviousDay(1, 2);
            Assert.AreEqual("31.01", res);
        }
    }
}
