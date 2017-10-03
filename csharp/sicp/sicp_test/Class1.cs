using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sicp;

namespace sicp_test
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        void test_q_1_3()
        {
            questions obj = new questions();
            double actual = obj.question_1_3(2, 3, 4);
            double expected = 25;
            Assert.AreEqual(expected, actual, 10E-5);
        }
    }
}
