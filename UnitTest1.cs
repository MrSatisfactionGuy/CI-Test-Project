using CI_Test_Project.Classes;
using System.ComponentModel;

namespace TestSum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_Result_Are_Equal_True()
        {
            //Arrange
            Add addClass = new Add();
            int one = 1;
            int two = 5;
            int res = 6;

            //Act
            int result = addClass.Sum(one, two);

            //Assert
            Assert.AreEqual(result, res);
        }

        [TestMethod]
        public void Sum_Result_Are_Not_Equal_True()
        {
            //Arrange
            Add addClass = new Add();
            int one = 1;
            int two = 5;
            //int res = 6;

            //Act
            int result = addClass.Sum(one, two);

            //Assert
            Assert.AreNotEqual(result, one);
            Assert.AreNotEqual(result, two);
        }
    }
}