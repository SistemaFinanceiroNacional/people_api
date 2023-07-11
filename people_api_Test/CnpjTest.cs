namespace people_api_Test
{
    public class CnpjTest
    {

        [Test]
        public void Test1()
        {
            string empty = "";

            Assert.Throws<EmptyCnpjException>(() =>
            {
                Cnpj.makeCnpj(empty);
            });
        }

        [Test]
        public void Test2()
        {
            string lessThenFourteenDigits = "123";
            Assert.Throws<InvalidLengthCnpjException>(() =>
            {
                Cnpj.makeCnpj(lessThenFourteenDigits);
            });
        }

        [Test]
        public void Test3()
        {
            string greaterThenFourteenDigits = "123456789101112131415";
            Assert.Throws<InvalidLengthCnpjException>(() =>
            {
                Cnpj.makeCnpj(greaterThenFourteenDigits);
            });
        }

        [Test]
        public void Test4()
        {
            string invalidCharacterCnpj = "1111111111111 ";

            Assert.Throws<InvalidCharacterCnpjException>(() =>
            {
                Cnpj.makeCnpj(invalidCharacterCnpj);
            });
        }

        [Test]
        public void Test5()
        {
            string exempleCorrectCnpjOne = "79592112000139";
            Assert.DoesNotThrow(() =>
            {
                Cnpj.makeCnpj(exempleCorrectCnpjOne);
            });

        }

        [Test]
        public void Test6()
        {
            string exempleCorrectCnpjTwo = "54607642000182";
            Assert.DoesNotThrow(() =>
            {
                Cnpj.makeCnpj(exempleCorrectCnpjTwo);
            });

        }

        [Test]
        public void Test7()
        {
            string exempleCorrectCnpjThree = "17065292000143";
            Assert.DoesNotThrow(() =>
            {
                Cnpj.makeCnpj(exempleCorrectCnpjThree);
            });

        }

        [Test]
        public void Test8()
        {
            string exempleCorrectCnpjFour = "95544857000189";
            Assert.DoesNotThrow(() =>
            {
                Cnpj.makeCnpj(exempleCorrectCnpjFour);
            });

        }

        [Test]
        public void Test9()
        {
            string exempleIncorrectCnpjOne = "79592002000139";
            Assert.Throws<InvalidCnpjException>(() =>
            {
                Cnpj.makeCnpj(exempleIncorrectCnpjOne);
            });
        }

        [Test]
        public void Test10()
        {
            string exempleIncorrectCnpjTwo = "54377642000182";
            Assert.Throws<InvalidCnpjException>(() =>
            {
                Cnpj.makeCnpj(exempleIncorrectCnpjTwo);
            });
        }

        [Test]
        public void Test11()
        {
            string exempleIncorrectCnpjThree = "17065122000143";
            Assert.Throws<InvalidCnpjException>(() =>
            {
                Cnpj.makeCnpj(exempleIncorrectCnpjThree);
            });
        }

        [Test]
        public void Test12()
        {
            string exempleIncorrectCnpjFour = "95544857009989";
            Assert.Throws<InvalidCnpjException>(() =>
            {
                Cnpj.makeCnpj(exempleIncorrectCnpjFour);
            });
        }


    }
}
