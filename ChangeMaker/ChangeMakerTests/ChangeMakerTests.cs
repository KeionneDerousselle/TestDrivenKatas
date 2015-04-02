using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChangeMaker;
using NUnit.Framework;

namespace ChangeMakerTests
{
    [TestFixture]
    public class ChangeMakerTests
    {
        private static ChangeMakerController changeMaker;

        [SetUp]
        public void Init()
        {
            changeMaker = new ChangeMakerController();
        }

        [Test]
        public void TestMakeChange()
        {
            decimal amount = new decimal(427.57);
            string change = "100's: 4, 50's: 0, 20's: 1, 10's: 0, 5's: 1, 1's: 2, .25's: 2, .10's: 0, .05's: 1, .01's: 2, ";
            string value = changeMaker.MakeChange(amount);
            Console.WriteLine(value);
            Assert.AreEqual(change, value);
        }
    }
}
