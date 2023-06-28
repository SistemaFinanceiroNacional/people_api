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

        }
    }
}