using Tyuiu.KhudiNA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.KhudiNA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidStr()
        {
            DataService ds = new DataService();

            string s = "?????";

            bool wait = true;
            bool res = ds.CheckeFirstLetterRepetition(s);
            Assert.AreEqual(wait, res);
        }
    }
}