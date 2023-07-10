namespace people_api_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string empty = "";

            Assert.Throws<EmptyCpfException>(() =>
            {
                Cpf.makeCpf(empty);
            });
        }

        [Test]
        public void Test2()
        {
            string lessThenElevenDigits = "123";
            Assert.Throws<InvalidLengthCpfException>(() =>
            {
                Cpf.makeCpf(lessThenElevenDigits);
            });
        }

        [Test]
        public void Test3()
        {
            string greaterThenElevenDigits = "123456789101112";
            Assert.Throws<InvalidLengthCpfException>(() =>
            {
                Cpf.makeCpf(greaterThenElevenDigits);
            });
        }

        [Test]
        public void Test4()
        {
            string invalidCharacterCpf = "123456789 2";
            Assert.Throws<InvalidCharacterCpfException>(() =>
            {
                Cpf.makeCpf(invalidCharacterCpf);
            });
        }

        [Test]
        public void Test5()
        {
            string exempleCorrectCpfOne = "16912963099";
            Assert.DoesNotThrow(() =>
            {
                Cpf.makeCpf(exempleCorrectCpfOne);
            });
        }
        
        [Test]
        public void Test6()
        {
            string exempleCorrectCpfTwo = "45088273061";
            Assert.DoesNotThrow(() =>
            {
                Cpf.makeCpf(exempleCorrectCpfTwo);
            });
        }

        [Test]
        public void Test7()
        {
            string exempleCorrectCpfThree = "89507632069";
            Assert.DoesNotThrow(() =>
            {
                Cpf.makeCpf(exempleCorrectCpfThree);
            });
        }

        [Test]
        public void Test8()
        {
            string exempleCorrectCpfFour = "72350516040";
            Assert.DoesNotThrow(() =>
            {
                Cpf.makeCpf(exempleCorrectCpfFour);
            });
        }
        
        [Test]
        public void Test9()
        {
            string exempleInvalidCpfOne = "16912963097";
            Assert.Throws<InvalidCpfException>(() =>
            {
                Cpf.makeCpf(exempleInvalidCpfOne);
            });
        }

        [Test]
        public void Test10()
        {
            string exempleInvalidCpfTwo = "45088273041";
            Assert.Throws<InvalidCpfException>(() =>
            {
                Cpf.makeCpf(exempleInvalidCpfTwo);
            });
        }

        [Test]
        public void Test11()
        {
            string exempleInvalidCpfThree = "89507732069";
            Assert.Throws<InvalidCpfException>(() =>
            {
                Cpf.makeCpf(exempleInvalidCpfThree);
            });
        }

        [Test]
        public void Test12()
        {
            string exempleInvalidCpfFour = "72356516040";
            Assert.Throws<InvalidCpfException>(() =>
            {
                Cpf.makeCpf(exempleInvalidCpfFour);
            });
        }
    }
}