using UserRegistrationProblemMSTest;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            string expected = "Roanak";

            UCOnePattern UCOne = new UCOnePattern("Roanak");
            string actual = UCOne.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }

        [TestMethod]
        public void TestLastName()
        {
            string expected = "Sharma";

            UCTwoPattern UCTwo = new UCTwoPattern("Sharma");
            string actual= UCTwo.ValidateLastName();

            Assert.AreEqual(expected , actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestEmail()
        {
            string expected = "roanak.sharma@gmail.com";

            UCThreePattern UCThree = new UCThreePattern("roanak.sharma@gmail.com");
            string actual = UCThree.ValidateEmail();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            string expected = "+91 7895361455";

            UCFourPattern UCFour = new UCFourPattern("+91 7895361455");
            string actual = UCFour.ValideMobileNumber();

            Assert.AreEqual (expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestPasswordRuleOne()
        {
            string expected = "roanaksharma";

            UCFivePattern UCFive = new UCFivePattern("roanaksharma");
            string actual = UCFive.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]

        public void TestPasswordRuleTwo()
        {
            string expected = "RoanakSharma";

            UCSixPattern UCSix = new UCSixPattern("RoanakSharma");
            string actual = UCSix.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestPasswordRuleThree()
        {
            string expected = "RoanakSharma12";

            UCSevenPattern UCSeven = new UCSevenPattern("RoanakSharma12");
            string actual = UCSeven.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }


        [TestMethod]
        public void TestPasswordRuleFour()
        {
            string expected = "RoanakSharma#12";

            UCEightPattern UCEight = new UCEightPattern("RoanakSharma#12");
            string actual = UCEight.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestEmailSamples()
        {
            string expected1 = "abc.100@abc.com.au";
            string expected2 = "abc@.com.my";

            UCNinePattern UCNine1 = new UCNinePattern("abc.100@abc.com.au");
            string actual1 = UCNine1.ValidateEmail();

            UCNinePattern UCNine2 = new UCNinePattern("abc@.com.my");
            string actual2 = UCNine2.ValidateEmail();

            Assert.AreEqual(expected1, actual1);
            Assert.AreNotEqual(expected2, actual2);
            Console.WriteLine(actual1);
            Console.WriteLine(actual2);
        }
    }
}
            